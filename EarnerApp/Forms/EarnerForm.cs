#region Using statements

using Earner.Records;
using Earner.Settings;
using System.Diagnostics;

#endregion Using statements

namespace Earner.Forms
{
    public partial class EarnerForm : Form
    {
        #region Private variables

        private double _TotalSecondsWorkedTodayWhenAppStarted;

        private TimeSpan _ElapsedTime;

        private DateTime _ActiveDay;

        private string _ActiveTask = string.Empty;

        private readonly EarnerRecords _EarnerRecords;

        private readonly Stopwatch _stopwatch = new();

        private readonly EarnerSettings _Settings = EarnerSettings.Instance;

        private bool _DoNotChangeFontSize = false;

        private int _unfocusCount = 0;

        #endregion Private variables

        #region Constructor

        public EarnerForm()
        {
            Log.Init();
            Log.LogCaller();
            _EarnerRecords = new EarnerRecords();
            _TotalSecondsWorkedTodayWhenAppStarted = _EarnerRecords.TotalSecondsWorkedToday;
            InitializeComponent();
            LoadAppSettings();
            _ = StartEarning();
        }

        #endregion Constructor

        #region Private methods

        private void LoadAppSettings()
        {
            _Settings.Load();
            SetTooltips();
            _ActiveTask = _Settings.EarnerTasks.FirstOrDefault("Default Task");
            _lblActiveTask.Text = $"Working with {_ActiveTask}";
            _lblEarnerHeader.Text = $"{Application.ProductName} {Application.ProductVersion}";
            _pbWorkProgress.Visible = _Settings.ShowProgressbar;
        }

        private void SetTooltips()
        {
            if (_Settings.ShowTooltips)
            {
                _toolTip.SetToolTip(_lblEarned, "Earnings");
                _toolTip.SetToolTip(_btnOptions, "Show settings");
                _toolTip.SetToolTip(_btnStart, "Start/Stop task");
                _toolTip.SetToolTip(_lblWorkTime, "Time elapsed");
                _toolTip.SetToolTip(_btnHide, "Minimize app");
                _toolTip.SetToolTip(_btnClose, "Close app");
                _toolTip.SetToolTip(_btnRestart, "Reset todays earnings");
                _toolTip.SetToolTip(_btnShowRecords, "Show earnings");
            }
            else
            {
                _toolTip.Hide(this);
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

        private bool StartEarning()
        {
            EarnerCommon.MakeProgressbarGreen(_pbWorkProgress.Handle);
            if (_Settings.ShowSettingsOnStartup)
            {
                using SettingsForm sf = new();
                sf.ShowDialog(this);
                _Settings.ShowSettingsOnStartup = false;
                _Settings.Save();
            }

            using TasksForm tasksForm = new();
            DialogResult tasksFormResult;
            tasksFormResult = tasksForm.ShowDialog(this);
            if (tasksFormResult != DialogResult.OK)
            {
                return false;
            }

            LoadAppSettings();
            _pbWorkProgress.Value = Convert.ToInt32(Math.Round(_EarnerRecords.TotalSecondsWorkedToday / (_Settings.MaxBillableDailyHours * 3600) * 100, 0));
            _pbWorkProgress.Visible = _Settings.ShowProgressbar;
            _ActiveDay = DateTime.Today;
            _stopwatch.Start();
            _earnerTimer.Start();
            _btnStart.Tag = "Stop";
            _btnStart.BackgroundImage = Properties.Resources.pause_48x48;
            Tick(this, new EventArgs());
            return true;
        }

        private bool StopEarning()
        {
            EarnerCommon.MakeProgressbarPaused(_pbWorkProgress.Handle);
            _pbWorkProgress.Value = Convert.ToInt32(Math.Round(_EarnerRecords.TotalSecondsWorkedToday / (_Settings.MaxBillableDailyHours * 3600) * 100, 0));
            _pbWorkProgress.Visible = _Settings.ShowProgressbar;
            _stopwatch.Stop();
            _earnerTimer.Stop();
            _btnStart.Tag = "Start";
            _btnStart.BackgroundImage = Properties.Resources.play_48x48;
            return true;
        }

        private void UpdateEarnings()
        {
            _ElapsedTime = _stopwatch.Elapsed;
            _stopwatch.Restart();
            double activeTaskEarningsToday = _EarnerRecords.TotalEarningsTodayForTask(_ActiveTask) + (_ElapsedTime.TotalSeconds * (_Settings.HourlyRate / 3600.00d));
            if (_TotalSecondsWorkedTodayWhenAppStarted + _ElapsedTime.TotalSeconds <= _Settings.MaxBillableDailyHours * 3600)
            {
                _pbWorkProgress.Value = Convert.ToInt32(Math.Round((_TotalSecondsWorkedTodayWhenAppStarted + _ElapsedTime.TotalSeconds) / (_Settings.MaxBillableDailyHours * 3600) * 100, 0));
                _pbWorkProgress.Visible = _Settings.ShowProgressbar;
                _EarnerRecords.UpdateRecord(
                    _ActiveTask,
                    activeTaskEarningsToday,
                    _ElapsedTime.TotalSeconds + _EarnerRecords.TotalSecondsTodayForTask(_ActiveTask),
                    _Settings.CurrencySymbol);
            }
            else
            {
                _pbWorkProgress.Value = 100;
                EarnerCommon.MakeProgressbarError(_pbWorkProgress.Handle);
                _pbWorkProgress.Visible = _Settings.ShowProgressbar;
                Log.Info = "Working overtime";
            }
        }

        private void UpdateEarningsUI()
        {
            double weightedEarnings = _EarnerRecords.TotalEarningsToday - _Settings.FixedDailyCost;
            _lblEarned.Text = $"{weightedEarnings:00000}{_Settings.CurrencySymbol}";
            TimeSpan totalToday = TimeSpan.FromSeconds(_EarnerRecords.TotalSecondsWorkedToday);
            _lblWorkTime.Text = $"{totalToday:c}"[..8];
            _lblWorkTime.ForeColor = totalToday.TotalHours <= _Settings.MaxBillableDailyHours ? Color.White : Color.Red;
            UnfocusForm();
        }

        private void UnfocusForm()
        {
            if (ActiveControl is null)
            {
                _unfocusCount = 0;
                return;
            }

            _unfocusCount++;
            if (_unfocusCount > 10)
            {
                ActiveControl = null;
                _unfocusCount = 0;
            }
        }

        private void ResetUnfocusFormCounter()
        {
            _unfocusCount = 0;
        }

        #endregion Private methods

        #region Private events

        private void StartStopClick(object sender, EventArgs e)
        {
            Log.LogCaller();
            _ = (_btnStart.Tag.ToString() == "Start") ? StartEarning() : StopEarning();
        }

        private void OptionsClick(object sender, EventArgs e)
        {
            Log.LogCaller();
            using SettingsForm sf = new();
            sf.ShowDialog(this);
            if (sf.DialogResult == DialogResult.OK)
            {
                LoadAppSettings();
                Tick(this, new EventArgs());
            }
            else if (sf.DialogResult == DialogResult.TryAgain)
            {
                EarnerRecords.EraseLog();
                _EarnerRecords.RemoveAllEarningRecords();
                _TotalSecondsWorkedTodayWhenAppStarted = 0;
                _stopwatch.Reset();
                _ = StartEarning();
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
                using ConfirmForm confirmForm = new();
                confirmForm.LblQuestion.Text = "New day, new earnings!\nStart earnings for today?";
                if (DialogResult.Yes != confirmForm.ShowDialog(this))
                {
                    StopEarning();
                    return;
                }

                _stopwatch.Reset();
                _TotalSecondsWorkedTodayWhenAppStarted = 0;
                _ = StartEarning();
            }
        }

        private void HideClick(object sender, EventArgs e)
        {
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
            if (_Settings.ConfirmBeforeClose)
            {
                using ConfirmForm confirmForm = new();
                confirmForm.LblQuestion.Text = "Close application?";
                if (DialogResult.Yes != confirmForm.ShowDialog(this))
                {
                    return;
                }

            }

            Close();
        }

        private void RestartClick(object sender, EventArgs e)
        {
            using ConfirmForm confirmForm = new();
            confirmForm.LblQuestion.Text = "Restart todays earnings?\nIt will erase todays work log.";
            if (DialogResult.Yes != confirmForm.ShowDialog(this))
            {
                return;
            }

            _EarnerRecords.LogRecords();
            _EarnerRecords.RemoveTodaysEarningRecords();
            _TotalSecondsWorkedTodayWhenAppStarted = 0;
            _stopwatch.Reset();
            _ = StartEarning();
        }

        private void ShowRecordsClick(object sender, EventArgs e)
        {

            using LogPeriodForm logPeriodForm = new();
            logPeriodForm.ShowDialog(this);
            _EarnerRecords.LogRecords(true, (EarnerRecords.REPORT_PERIOD)logPeriodForm.DialogResult);
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
            EarnerCommon.ScaleFont(label, label.Tag is null ? 62 : 10);
        }

        private void EarnerFormResize(object sender, EventArgs e)
        {
            _DoNotChangeFontSize = WindowState == FormWindowState.Minimized;
        }

        private void EarnerFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                using ConfirmForm confirmForm = new();
                confirmForm.LblQuestion.Text = "Close application?";
                if (_Settings.ConfirmBeforeClose || DialogResult.Yes == confirmForm.ShowDialog(this))
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

        #endregion Private events
    }
}
