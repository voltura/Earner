namespace Earner
{
    public partial class EarnerForm : Form
    {
        #region Private variables

        private double _Earned;
        private double _HourlyRate = 1000;
        private double _FixedDailyCost = 0;
        private double _MaxBillableDailyHours = 8;
        private TimeSpan _ElapsedTime;
        private string _ActiveTask = string.Empty;
        private List<string> _EarnerTasks = new();
        private readonly EarnerRecords _EarnerRecords = new();
        private bool _SaveTaskLog = false;
        private string _CurrencySymbol = "kr";
        private readonly System.Diagnostics.Stopwatch _stopwatch = new();

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
            _HourlyRate = EarnerConfig.GetAppSettings<double>("HourlyRate");
            _FixedDailyCost = EarnerConfig.GetAppSettings<double>("FixedDailyCost");
            _MaxBillableDailyHours = EarnerConfig.GetAppSettings<double>("MaxBillableDailyHours");
            _CurrencySymbol = EarnerConfig.GetAppSettings<string>("CurrencySymbol");
            _EarnerTasks = EarnerConfig.GetAppSettings<List<string>>("Tasks");
            _ActiveTask = _EarnerTasks.FirstOrDefault("Default Task");
            _SaveTaskLog = EarnerConfig.GetAppSettings<bool>("SaveTaskLog");
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
            double totalEarnings = _ElapsedTime.TotalSeconds * (_HourlyRate / 3600.00d);
            if (_ElapsedTime.TotalSeconds <= _MaxBillableDailyHours * 3600)
            {
                _Earned = totalEarnings;
                _EarnerRecords.UpdateRecord(_ActiveTask, _HourlyRate, totalEarnings, _CurrencySymbol);
            }
            else
            {
                Log.Info = "Working overtime";
            }
            double weightedEarnings = _Earned - _FixedDailyCost;
            return weightedEarnings;
        }

        private void UpdateEarningsUI(double weightedEarnings)
        {
            _lblEarned.Text = $"{weightedEarnings:00000}{_CurrencySymbol}";
            _lblWorkTime.Text = $"{_ElapsedTime:c}"[..8];
            _lblWorkTime.ForeColor = _ElapsedTime.TotalHours <= _MaxBillableDailyHours ? Color.White : Color.Red;
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
            if (_SaveTaskLog)
            {
                _EarnerRecords.LogRecords();
            }

            _EarnerRecords.RemoveTodaysEarningRecords();
            _Earned = 0;
            _stopwatch.Reset();
            _ = StartEarning();
        }

        private void EarnerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_SaveTaskLog)
            {
                _EarnerRecords.LogRecords();
            }
        }

        #endregion Private events
    }
}
