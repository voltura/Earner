#region Using statements

using Earner.Properties;
using Earner.Records;
using Earner.Settings;
using System.Diagnostics;
using System.Media;
using Application = System.Windows.Forms.Application;

#endregion Using statements

namespace Earner.Forms
{
    public partial class EarnerForm : Form
    {
        #region Private variables

        private TimeSpan _ElapsedTime;

        private DateTime _ActiveDay;

        private string _ActiveTask = string.Empty;

        private readonly EarnerRecords _EarnerRecords;

        private readonly Stopwatch _Stopwatch = new();

        private readonly EarnerSettings _Settings = EarnerSettings.Instance;

        private bool _DoNotChangeFontSize = false;

        private int _UnfocusCount = 0;

        private bool _PlayedOvertimeTuneToday = false;

        private string _InternetVersion = string.Empty;

        private readonly NotifyIcon _NotifyIcon;

        #endregion Private variables

        #region Constructor

        public EarnerForm()
        {
            Log.Init();
            Log.LogCaller();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            _EarnerRecords = EarnerRecords.Instance;
            InitializeComponent();
            _lblEarnerHeader.Text = $"{Application.ProductName} {Application.ProductVersion}";
            _NotifyIcon = new()
            {
                Icon = Resources.dollar,
                Visible = _Settings.MinimizeToSystemTray
            };
            _NotifyIcon.Click += NotifyIconClick;
            _NotifyIcon.MouseClick += NotifyIconClick;
            LoadAppSettings();
            ShowInTaskbar = !_Settings.MinimizeToSystemTray;
            StartEarning();
        }

        #endregion Constructor

        #region Private methods

        private void LoadAppSettings()
        {
            _Settings.Load();
            SetTooltips();
            _ActiveTask = _Settings.Tasks.FirstOrDefault("Default Task");
            _lblActiveTask.Text = $"Working with {_ActiveTask}";
            _pbWorkProgress.Visible = _Settings.ShowProgressbar;
            TopMost = _Settings.StayOnTop;
            _NotifyIcon.Visible = _Settings.MinimizeToSystemTray;
        }

        private void SetTooltips()
        {
            if (_Settings.ShowTooltips)
            {
                _toolTip.SetToolTip(_lblEarned, "Earnings");
                _toolTip.SetToolTip(_btnOptions, "Show settings");
                _toolTip.SetToolTip(_btnStart, "Start/Stop/Change task");
                _toolTip.SetToolTip(_lblWorkTime, "Time worked today");
                _toolTip.SetToolTip(_pbWorkProgress, "Work progress (% of billable hours)");
                _toolTip.SetToolTip(_btnHide, "Minimize app");
                _toolTip.SetToolTip(_btnClose, "Close app");
                _toolTip.SetToolTip(_btnRestart, "Reset todays earnings");
                _toolTip.SetToolTip(_btnShowRecords, "Show earnings and work log");
                _toolTip.SetToolTip(_lblActiveTask, "Active task");
                _toolTip.SetToolTip(_lblEarnerHeader, $"{Application.ProductName} {Application.ProductVersion} by Voltura AB");
            }
            else
            {
                _toolTip.Hide(this);
                _toolTip.SetToolTip(_lblEarnerHeader, null);
                _toolTip.SetToolTip(_lblActiveTask, null);
                _toolTip.SetToolTip(_pbWorkProgress, null);
                _toolTip.SetToolTip(_lblEarned, null);
                _toolTip.SetToolTip(_btnOptions, null);
                _toolTip.SetToolTip(_btnStart, null);
                _toolTip.SetToolTip(_lblWorkTime, null);
                _toolTip.SetToolTip(_btnHide, null);
                _toolTip.SetToolTip(_btnClose, null);
                _toolTip.SetToolTip(_btnRestart, null);
                _toolTip.SetToolTip(_btnShowRecords, null);
            }
        }

        private void StartEarning()
        {
            EarnerCommon.SetProgressbarActive(_pbWorkProgress.Handle);
            if (_Settings.ShowSettingsOnStartup)
            {
                try
                {
                    Visible = false;
                    using SettingsForm sf = new();
                    _ = sf.ShowDialog(this);
                    _Settings.ShowSettingsOnStartup = false;
                    _Settings.Save();
                }
                finally
                {
                    ShowInTaskbar = !_Settings.MinimizeToSystemTray;
                    Visible = true;
                }
            }

            bool visibleState = Visible;
            try
            {
                Visible = false;
                using TasksForm tasksForm = new();
                DialogResult tasksFormResult;
                tasksFormResult = tasksForm.ShowDialog(this);
            }
            finally
            {
                Visible = visibleState || WindowState != FormWindowState.Minimized;
            }

            LoadAppSettings();
            int workedPercentageToday = Convert.ToInt32(Math.Round(_EarnerRecords.TotalSecondsWorkedToday / (_Settings.MaxBillableDailyHours * 3600) * 100, 0));
            _pbWorkProgress.Value = workedPercentageToday > 100 ? 100 : workedPercentageToday;
            _pbWorkProgress.Visible = _Settings.ShowProgressbar;
            _ActiveDay = DateTime.Today;
            _Stopwatch.Start();
            _earnerTimer.Start();
            _btnStart.Tag = "Stop";
            _btnStart.BackgroundImage = Properties.Resources.pause_48x48;
            Tick(this, new EventArgs());
        }

        private void StopEarning()
        {
            EarnerCommon.SetProgressbarPaused(_pbWorkProgress.Handle);
            int progress = Convert.ToInt32(Math.Round(_EarnerRecords.TotalSecondsWorkedToday / (_Settings.MaxBillableDailyHours * 3600) * 100, 0));
            _pbWorkProgress.Value = progress > 100 ? 100 : progress;
            _pbWorkProgress.Visible = _Settings.ShowProgressbar;
            _Stopwatch.Stop();
            _earnerTimer.Stop();
            _btnStart.Tag = "Start";
            _btnStart.BackgroundImage = Properties.Resources.play_48x48;
        }

        private void UpdateEarnings()
        {
            _ElapsedTime = _Stopwatch.Elapsed;
            _Stopwatch.Restart();
            double activeTaskEarningsToday = _EarnerRecords.TotalEarningsTodayForTask(_ActiveTask) + (_ElapsedTime.TotalSeconds * (_Settings.HourlyRate / 3600.00d));
            if (_EarnerRecords.TotalSecondsWorkedToday + _ElapsedTime.TotalSeconds <= _Settings.MaxBillableDailyHours * 3600)
            {
                int progress = Convert.ToInt32(Math.Round((_EarnerRecords.TotalSecondsWorkedToday + _ElapsedTime.TotalSeconds) / (_Settings.MaxBillableDailyHours * 3600) * 100, 0));
                _pbWorkProgress.Value = progress > 100 ? 100 : progress;
                _pbWorkProgress.Visible = _Settings.ShowProgressbar;
                _EarnerRecords.UpdateRecord(
                    _ActiveTask,
                    activeTaskEarningsToday,
                    _ElapsedTime.TotalSeconds + _EarnerRecords.TotalSecondsTodayForTask(_ActiveTask),
                    _Settings.CurrencySymbol,
                    _Settings.HourlyRate);
            }
            else
            {
                _pbWorkProgress.Value = 100;
                EarnerCommon.SetProgressbarErrorState(_pbWorkProgress.Handle);
                _pbWorkProgress.Visible = _Settings.ShowProgressbar;
                PlayOvertimeTune();
                Log.Info = "Working overtime";
                _NotifyIcon.ShowBalloonTip(30000, "Earner", "Working overtime", ToolTipIcon.Warning);
            }
        }

        private void PlayOvertimeTune()
        {
            if (_Settings.PlaySounds && _PlayedOvertimeTuneToday == false)
            {
                SystemSounds.Exclamation.Play();
                _PlayedOvertimeTuneToday = true;
            }
        }

        private void UpdateEarningsUI()
        {
            double weightedEarnings = _EarnerRecords.TotalEarningsToday - _Settings.FixedDailyCost;
            _lblEarned.Text = $"{weightedEarnings:00000}{_Settings.CurrencySymbol}";
            _NotifyIcon.Text = $"{Application.ProductName} {Application.ProductVersion}\nTodays earnings:\n{_lblEarned.Text}";
            TimeSpan totalToday = TimeSpan.FromSeconds(_EarnerRecords.TotalSecondsWorkedToday);
            _lblWorkTime.Text = $"{totalToday:c}"[..8];
            _lblWorkTime.ForeColor = totalToday.TotalHours <= _Settings.MaxBillableDailyHours ? Color.White : Color.Red;
            UnfocusForm();
        }

        private void UnfocusForm()
        {
            if (ActiveControl is null)
            {
                _UnfocusCount = 0;
                return;
            }

            _UnfocusCount++;
            if (_UnfocusCount > 10)
            {
                ActiveControl = null;
                _UnfocusCount = 0;
            }
        }

        private void ResetUnfocusFormCounter()
        {
            _UnfocusCount = 0;
        }

        private void UpdateCheckCallbackFunction(string internetVersion)
        {
            if (string.IsNullOrWhiteSpace(internetVersion))
            {
                return;
            }

            _InternetVersion = internetVersion;
            if (UpdateHandler.IsNewerVersion(Application.ProductVersion, _InternetVersion))
            {
                WriteTextSafe($"{Application.ProductName} {_InternetVersion} available!", Color.White);
                ChangeHideToUpdate();
            }
            else
            {
                WriteTextSafe($"{Application.ProductName} {Application.ProductVersion}", Color.FromArgb(64, 64, 64));
            }
        }

        public void WriteTextSafe(string text, Color color)
        {
            if (_lblEarnerHeader.InvokeRequired)
            {
                void safeWrite()
                {
                    WriteTextSafe(text, color);
                }
                _lblEarnerHeader.Invoke(safeWrite);
            }
            else
            {
                _lblEarnerHeader.Text = text;
                _lblEarnerHeader.ForeColor = color;
            }
        }

        public void ChangeHideToUpdate()
        {
            if (_btnHide.InvokeRequired)
            {
                void safeChangeHideToUpdate()
                {
                    ChangeHideToUpdate();
                }
                _lblEarnerHeader.Invoke(safeChangeHideToUpdate);
            }
            else
            {
                _btnHide.Tag = "Update";
                _btnHide.BackgroundImage = Resources.info_48x48;
            }
        }

        private void GetAndDisplayUpdateInfoInHeader()
        {
            if (_Settings.UpdateChecks)
            {
                _ = Task.Run(() => UpdateHandler.Instance.GetAsyncVersionInfoWithCallback(UpdateCheckCallbackFunction));
            }
        }

        private void NewVersionGoToWebPage()
        {
            bool visibleState = Visible;
            if (_Settings.UpdateChecks == false ||
                string.IsNullOrWhiteSpace(_InternetVersion) ||
                UpdateHandler.IsNewerVersion(Application.ProductVersion, _InternetVersion) == false)
            {
                return;
            }
            try
            {
                using ConfirmForm confirmForm = new();
                confirmForm.LblQuestion.Text = $"Earner {_InternetVersion} available, open web page?";
                if (confirmForm.ShowDialog() == DialogResult.Yes)
                {
                    Visible = false;
                    EarnerCommon.OpenUrl(@"https://voltura.github.io/Earner/");
                }
            }
            finally
            {
                Visible = visibleState;
            }
        }

        #endregion Private methods

        #region Private events

        private void StartStopClick(object sender, EventArgs e)
        {
            Log.LogCaller();
            if (_btnStart.Tag is not null && _btnStart.Tag.ToString() == "Start")
            {
                StartEarning();
            }
            else
            {
                StopEarning();
            }
        }

        private void OptionsClick(object sender, EventArgs e)
        {
            Log.LogCaller();
            StopEarning();
            DialogResult sfDialogResult = DialogResult.None;
            try
            {
                Visible = false;
                using SettingsForm sf = new();
                sfDialogResult = sf.ShowDialog(this);
            }
            finally
            {
                ShowInTaskbar = !_Settings.MinimizeToSystemTray;
                Visible = true;
            }
            if (sfDialogResult == DialogResult.OK)
            {
                StartEarning();
            }
            else if (sfDialogResult == DialogResult.TryAgain)
            {
                EarnerRecords.EraseLog();
                _EarnerRecords.RemoveAllEarningRecords();
                _Stopwatch.Reset();
                StartEarning();
            }
        }

        private void Tick(object sender, EventArgs e)
        {
            UpdateEarnings();
            UpdateEarningsUI();

            if (_ActiveDay != DateTime.Today)
            {
                _earnerTimer.Stop();
                _EarnerRecords.LogRecords();
                DialogResult confirmResult = DialogResult.None;
                bool visibleState = Visible;
                try
                {
                    _PlayedOvertimeTuneToday = false;
                    Visible = false;
                    using ConfirmForm confirmForm = new();
                    confirmForm.LblQuestion.Text = "New day, new earnings!\nStart earnings for today?";
                    confirmResult = confirmForm.ShowDialog(this);
                }
                finally
                {
                    Visible = visibleState;
                }
                if (DialogResult.Yes != confirmResult)
                {
                    StopEarning();
                    return;
                }

                _Stopwatch.Reset();
                StartEarning();
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= EarnerCommon.WS_EX_COMPOSITED;
                cp.ClassStyle |= EarnerCommon.CS_DROPSHADOW;
                return cp;
            }
        }

        private void HideClick(object sender, EventArgs e)
        {
            if (_btnHide.Tag != null && _btnHide.Tag.ToString() == "Update")
            {
                NewVersionGoToWebPage();
                _btnHide.Tag = null;
                _btnHide.BackgroundImage = Resources.minimize_48x48;
                return;
            }

            _DoNotChangeFontSize = true;
            WindowState = FormWindowState.Minimized;
        }

        private void TopPanelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _ = NativeMethods.ReleaseCapture();
                _ = NativeMethods.SendMessage(Handle, NativeMethods.WM_NCLBUTTONDOWN, NativeMethods.HT_CAPTION, 0);
            }
        }

        private void CloseClick(object sender, EventArgs e)
        {
            if (_Settings.UseConfirmations)
            {
                DialogResult cfdr = DialogResult.None;
                try
                {
                    Visible = false;
                    using ConfirmForm confirmForm = new();
                    confirmForm.LblQuestion.Text = "Close application?";
                    cfdr = confirmForm.ShowDialog(this);
                }
                finally
                {
                    Visible = true;
                }
                if (DialogResult.Yes != cfdr)
                {
                    return;
                }
            }

            Close();
        }

        private void RestartClick(object sender, EventArgs e)
        {
            DialogResult confirmResult = DialogResult.None;
            try
            {
                Visible = false;
                using ConfirmForm confirmForm = new();
                confirmForm.LblQuestion.Text = "Restart todays earnings?\nIt will erase todays work log.";
                confirmResult = confirmForm.ShowDialog(this);
            }
            finally
            {
                Visible = true;
            }
            if (DialogResult.Yes != confirmResult)
            {
                return;
            }

            _EarnerRecords.LogRecords();
            _EarnerRecords.RemoveTodaysEarningRecords();
            _Stopwatch.Reset();
            StartEarning();
        }

        private void ShowRecordsClick(object sender, EventArgs e)
        {
            try
            {
                Visible = false;
                using LogPeriodForm logPeriodForm = new();
                if (DialogResult.OK == logPeriodForm.ShowDialog(this))
                {
                    _EarnerRecords.LogRecords(true, logPeriodForm.ReportPeriod);
                }

            }
            finally
            {
                Visible = true;
            }
        }

        private void EarnerFormClosing(object sender, FormClosingEventArgs e)
        {
            _EarnerRecords.LogRecords();
        }

        private void ScaleTextChanged(object sender, EventArgs e)
        {
            if (_DoNotChangeFontSize)
            {
                return;
            }
            Label label = (Label)sender;
            EarnerCommon.ScaleFont(label, label.Tag is null ? 52 : 10);
        }

        private void EarnerFormResize(object sender, EventArgs e)
        {
            _DoNotChangeFontSize = WindowState == FormWindowState.Minimized;
            if (WindowState == FormWindowState.Minimized)
            {
                if (_Settings.MinimizeToSystemTray == true)
                {
                    Hide();
                    _NotifyIcon.Visible = true;
                }
            }
        }

        private void EarnerFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult dialogResult = DialogResult.None;
                try
                {
                    Visible = false;
                    using ConfirmForm confirmForm = new();
                    confirmForm.LblQuestion.Text = "Close application?";
                    dialogResult = confirmForm.ShowDialog(this);
                }
                finally
                {
                    Visible = true;
                }
                if (_Settings.UseConfirmations || dialogResult == DialogResult.Yes)
                {
                    CloseClick(sender, e);
                }
            }
        }

        private void ShowRecordsFocusEnter(object sender, EventArgs e)
        {
            ResetUnfocusFormCounter();
        }

        private void OptionsFocusEnter(object sender, EventArgs e)
        {
            ResetUnfocusFormCounter();
        }

        private void RestartFocusEnter(object sender, EventArgs e)
        {
            ResetUnfocusFormCounter();
        }

        private void StartFocusEnter(object sender, EventArgs e)
        {
            ResetUnfocusFormCounter();
        }

        private void EarnerFormLoad(object sender, EventArgs e)
        {
            GetAndDisplayUpdateInfoInHeader();
        }

        private void EarnerFormShown(object sender, EventArgs e)
        {
            GetAndDisplayUpdateInfoInHeader();
        }

        private void NotifyIconClick(object? sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            _NotifyIcon.Visible = false;
            _ = Focus();
        }

        #endregion Private events
    }
}
