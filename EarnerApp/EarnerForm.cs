using Earner.Properties;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Earner
{
    public partial class EarnerForm : Form
    {
        private double _Earned;
        private double _HourlyRate = 1000;
        private double _FixedDailyCost = 200;
        private double _MaxBillableDailyHours = 8;
        private TimeSpan _ElapsedTime;
        private string _ActiveTask = string.Empty;
        private List<string> _EarnerTasks = new();
        private readonly EarnerRecords _EarnerRecords = new();
        private bool _SaveTaskLog = false;
        private string _CurrencySymbol = "kr";
        private readonly Stopwatch _stopwatch = new();

        public EarnerForm()
        {
            Log.Init();
            Log.LogCaller();
            InitializeComponent();
            LoadAppSettings();
            SetupEarnerRecord();
            StartEarning();
        }

        private void LoadAppSettings()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                _HourlyRate = ConvertToDouble(config.AppSettings.Settings["HourlyRate"].Value);
                _FixedDailyCost = ConvertToDouble(config.AppSettings.Settings["FixedDailyCost"].Value);
                _MaxBillableDailyHours = ConvertToDouble(config.AppSettings.Settings["MaxBillableDailyHours"].Value);
                _CurrencySymbol = config.AppSettings.Settings["CurrencySymbol"].Value.Trim();
                _EarnerTasks = config.AppSettings.Settings["Tasks"].Value.Trim().Split(",").ToList();
                _ActiveTask = _EarnerTasks.FirstOrDefault("Default Task");
                _SaveTaskLog = Convert.ToBoolean(config.AppSettings.Settings["SaveTaskLog"].Value);
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
        }

        private void SetupEarnerRecord()
        {
            _EarnerRecords.UpdateRecord(_ActiveTask, _HourlyRate, 0.00d, _CurrencySymbol);
        }

        private void StartEarning()
        {
            Tick(this, new EventArgs());
            _stopwatch.Start();
            _earnerTimer.Start();
        }

        private void StartStopClick(object sender, EventArgs e)
        {
            Log.LogCaller();
            if (_btnStart.Tag.ToString() == "Start")
            {
                using TasksForm tasksForm = new();
                if (DialogResult.OK != tasksForm.ShowDialog(this))
                {
                    return;
                }
                LoadAppSettings();
                _stopwatch.Start();
                _earnerTimer.Start();
                _btnStart.Tag = "Stop";
                _btnStart.BackgroundImage = Resources.pause_48x48;
                Tick(this, new EventArgs());
            }
            else
            {
                _stopwatch.Stop();
                _earnerTimer.Stop();
                _btnStart.Tag = "Start";
                _btnStart.BackgroundImage = Resources.play_48x48;
            }
        }

        private void OptionsClick(object sender, EventArgs e)
        {
            Log.LogCaller();
            using SettingsForm sf = new();
            if (sf.ShowDialog(this) == DialogResult.OK) {
                LoadAppSettings();
                Tick(this, new EventArgs());
            }
        }

        private void Tick(object sender, EventArgs e)
        {
            double weightedEarnings = UpdateEarnings();
            UpdateEarningsUI(weightedEarnings);
        }

        private void UpdateEarningsUI(double weightedEarnings)
        {
            _lblEarned.Text = $"{weightedEarnings:00000}{_CurrencySymbol}";
            _lblWorkTime.Text = $"{_ElapsedTime:c}"[..8];
            _lblWorkTime.ForeColor = _ElapsedTime.TotalHours <= _MaxBillableDailyHours ? Color.White : Color.Red;
        }

        private double UpdateEarnings()
        {
            _ElapsedTime = _stopwatch.Elapsed;
            double totalEarnings = _ElapsedTime.TotalSeconds * (_HourlyRate / 3600.00d);
            if (_ElapsedTime.TotalSeconds <= _MaxBillableDailyHours * 3600)
            {
                _Earned = totalEarnings;
                _EarnerRecords.UpdateRecord(_ActiveTask, _HourlyRate, totalEarnings, _CurrencySymbol);
            } else
            {
                Log.Info = "Working overtime";
            }
            double weightedEarnings = _Earned - _FixedDailyCost;
            return weightedEarnings;
        }

        private void HideClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TopPanelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                _ = NativeMethods.SendMessage(Handle, NativeMethods.WM_NCLBUTTONDOWN, NativeMethods.HT_CAPTION, 0);
            }
        }
        public static double ConvertToDouble(string Value)
        {
            if (Value == null)
            {
                return 0;
            }
            else
            {
                _ = double.TryParse(Value, out double OutVal);

                if (double.IsNaN(OutVal) || double.IsInfinity(OutVal))
                {
                    return 0;
                }
                return OutVal;
            }
        }

        private void CloseClick(object sender, EventArgs e) => Close();

        private void RestartClick(object sender, EventArgs e)
        {
            if (_SaveTaskLog) _EarnerRecords.LogRecords();
            _EarnerRecords.RemoveTodaysEarningRecords();
            _Earned = 0;
            _stopwatch.Reset();
            _btnStart.Tag = "Stop";
            _btnStart.BackgroundImage = Resources.pause_48x48;
            StartEarning();
        }

        private void EarnerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_SaveTaskLog) _EarnerRecords.LogRecords();
        }
    }
}
