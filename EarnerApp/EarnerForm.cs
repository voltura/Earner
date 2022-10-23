using Earner.Properties;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Earner
{
    public partial class EarnerForm : Form
    {
        private double Earned { get; set; } = 0;
        private double HourlyRate { get; set; } = 1000;
        private double FixedDailyCost { get; set; } = 200;
        private double MaxBillableDailyHours { get; set; } = 8;
        private TimeSpan ElapsedTime { get; set; }
        private string ActiveTask { get; set; } = string.Empty;
        private List<string> EarnerTasks { get; set; } = new();
        private readonly EarnerRecords _EarnerRecords = new();

        private string CurrencySymbol { get; set; } = "kr";
        private readonly Stopwatch _stopwatch = new();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        
        [DllImport("user32.dll")]
        static extern bool ReleaseCapture();

        public EarnerForm()
        {
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
                HourlyRate = ConvertToDouble(config.AppSettings.Settings["HourlyRate"].Value);
                FixedDailyCost = ConvertToDouble(config.AppSettings.Settings["FixedDailyCost"].Value);
                MaxBillableDailyHours = ConvertToDouble(config.AppSettings.Settings["MaxBillableDailyHours"].Value);
                CurrencySymbol = config.AppSettings.Settings["CurrencySymbol"].Value.Trim();
                EarnerTasks = config.AppSettings.Settings["Tasks"].Value.Trim().Split(",").ToList();
                ActiveTask = EarnerTasks.FirstOrDefault("Default Task");
            }
            catch (Exception)
            {
            }
        }

        private void SetupEarnerRecord()
        {
            _EarnerRecords.UpdateRecord(ActiveTask, HourlyRate);
        }

        private void StartEarning()
        {
            Tick(this, new EventArgs());
            _stopwatch.Start();
            _earnerTimer.Start();
        }

        private void StartStopClick(object sender, EventArgs e)
        {
            if (_btnStart.Tag.ToString() == "Start")
            {
                _stopwatch.Start();
                _earnerTimer.Start();
                _btnStart.Tag = "Stop";
                _btnStart.BackgroundImage = Resources.pause_48x48;
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
            _lblEarned.Text = $"{weightedEarnings:00000}{CurrencySymbol}";
            _lblWorkTime.Text = $"{ElapsedTime:c}"[..8];
            _lblWorkTime.ForeColor = ElapsedTime.TotalHours <= MaxBillableDailyHours ? Color.White : Color.Red;
        }

        private double UpdateEarnings()
        {
            ElapsedTime = _stopwatch.Elapsed;
            double totalEarnings = ElapsedTime.TotalSeconds * (HourlyRate / 3600.00d);
            if (ElapsedTime.TotalSeconds <= MaxBillableDailyHours * 3600)
            {
                Earned = totalEarnings;
                _EarnerRecords.UpdateRecord(ActiveTask, HourlyRate, totalEarnings);
            }
            double weightedEarnings = Earned - FixedDailyCost;
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
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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
            _EarnerRecords.LogRecords();
            _EarnerRecords.RemoveTodaysEarningRecords();
            Earned = 0;
            _stopwatch.Reset();
            _btnStart.Tag = "Stop";
            _btnStart.BackgroundImage = Resources.pause_48x48;
            StartEarning();
        }
    }
}