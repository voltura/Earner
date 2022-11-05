using Earner.Records;
using Earner.Settings;

namespace Earner.Forms
{
    public partial class EarnerForm : Form
    {
        #region Private variables

        private double _Earned;
        private TimeSpan _ElapsedTime;
        private string _ActiveTask = string.Empty;
        private readonly EarnerRecords _EarnerRecords = new();
        private readonly System.Diagnostics.Stopwatch _stopwatch = new();
        private readonly EarnerSettings _Settings = EarnerSettings.Instance;

        #endregion Private variables

        #region Constructor

        public EarnerForm()
        {
            Log.Init();
            Log.LogCaller();
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
        }

        private void SetTooltips()
        {
            if (_Settings.ShowTooltips)
            {
                toolTip.SetToolTip(_lblEarned, "Earnings");
                toolTip.SetToolTip(_btnOptions, "Show settings");
                toolTip.SetToolTip(_btnStart, "Start/Stop task");
                toolTip.SetToolTip(_lblWorkTime, "Time elapsed");
                toolTip.SetToolTip(_btnHide, "Minimize app");
                toolTip.SetToolTip(_btnClose, "Close app");
                toolTip.SetToolTip(_btnRestart, "Reset earnings");
                toolTip.SetToolTip(_btnShowRecords, "Show earnings");
            }
            else
            {
                toolTip.Hide(this);
                toolTip.SetToolTip(_lblEarned, null);
                toolTip.SetToolTip(_btnOptions, null);
                toolTip.SetToolTip(_btnStart, null);
                toolTip.SetToolTip(_lblWorkTime, null);
                toolTip.SetToolTip(_btnHide, null);
                toolTip.SetToolTip(_btnClose, null);
                toolTip.SetToolTip(_btnRestart, null);
                toolTip.SetToolTip(_btnShowRecords, null);
            }
        }

        private bool StartEarning()
        {
            using TasksForm tasksForm = new();
            if (DialogResult.OK != tasksForm.ShowDialog(this))
            {
                return false;
            }
            LoadAppSettings();
            _stopwatch.Start();
            _earnerTimer.Start();
            _btnStart.Tag = "Stop";
            _btnStart.BackgroundImage = Properties.Resources.pause_48x48;
            Tick(this, new EventArgs());
            return true;
        }

        private bool StopEarning()
        {
            _stopwatch.Stop();
            _earnerTimer.Stop();
            _btnStart.Tag = "Start";
            _btnStart.BackgroundImage = Properties.Resources.play_48x48;
            return true;
        }

        private double UpdateEarnings()
        {
            _ElapsedTime = _stopwatch.Elapsed;
            double totalEarnings = _ElapsedTime.TotalSeconds * (_Settings.HourlyRate / 3600.00d);
            if (_ElapsedTime.TotalSeconds <= _Settings.MaxBillableDailyHours * 3600)
            {
                _Earned = totalEarnings;
                _EarnerRecords.UpdateRecord(_ActiveTask, _Settings.HourlyRate, totalEarnings, _Settings.CurrencySymbol);
            }
            else
            {
                Log.Info = "Working overtime";
            }
            double weightedEarnings = _Earned - _Settings.FixedDailyCost;
            return weightedEarnings;
        }

        private void UpdateEarningsUI(double weightedEarnings)
        {
            _lblEarned.Text = $"{weightedEarnings:00000}{_Settings.CurrencySymbol}";
            _lblWorkTime.Text = $"{_ElapsedTime:c}"[..8];
            _lblWorkTime.ForeColor = _ElapsedTime.TotalHours <= _Settings.MaxBillableDailyHours ? Color.White : Color.Red;
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
            if (sf.ShowDialog(this) == DialogResult.OK)
            {
                LoadAppSettings();
                Tick(this, new EventArgs());
            }
        }

        private void Tick(object sender, EventArgs e)
        {
            double weightedEarnings = UpdateEarnings();
            UpdateEarningsUI(weightedEarnings);
        }

        private void HideClick(object sender, EventArgs e)
        {
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
            Close();
        }

        private void RestartClick(object sender, EventArgs e)
        {
            _EarnerRecords.LogRecords();
            _EarnerRecords.RemoveTodaysEarningRecords();
            _Earned = 0;
            _stopwatch.Reset();
            _ = StartEarning();
        }

        private void ShowRecordsClick(object sender, EventArgs e)
        {
            _EarnerRecords.LogRecords();
            if (!_Settings.AutoShowTaskLog)
            {
                EarnerRecords.ShowExcel();
            }
        }

        private void EarnerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_Settings.SaveTaskLog)
            {
                _EarnerRecords.LogRecords();
            }
        }

        private void EarnedTextChanged(object sender, EventArgs e)
        {
            EarnerCommon.ScaleFont(_lblEarned);
        }

        #endregion Private events
    }
}
