using Earner.Properties;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Earner
{
    public partial class EarnerForm : Form
    {
        private double Earned { get; set; } = 0;
        private double HourRate { get; set; } = 920;
        private double FixedDailyCost { get; set; } = 0;
        private double MaxBillableDailyHours { get; set; } = 8;
        private TimeSpan ElapsedTime { get; set; }
        private string CurrencySymbols { get; set; } = "kr";

        private readonly Stopwatch _stopwatch = new();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        
        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();

        public EarnerForm()
        {
            InitializeComponent();
            InitializeCostsAndEarnings();
        }

        private void InitializeCostsAndEarnings()
        {
          /*  FixedDailyCost = 40.00d * 2.00d;    // road tolls
            FixedDailyCost += 17.5d;            // parking
            FixedDailyCost += 30.00d * 4.00d;   // diesel + car value reduction
            FixedDailyCost += 1500.00d / 200d;  // insurance
            FixedDailyCost += 106.00d;          // lunch */
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
                _btnStart.BackgroundImage = Resources.pause;
            }
            else
            {
                _stopwatch.Stop();
                _earnerTimer.Stop();
                _btnStart.Tag = "Start";
                _btnStart.BackgroundImage = Resources.play;
            }
        }

        private void OptionsClick(object sender, EventArgs e)
        {
            // TODO; Allow edit of fixed daily costs and hourly rate
        }

        private void Tick(object sender, EventArgs e)
        {
            double weightedEarnings = UpdateEarnings();
            UpdateEarningsUI(weightedEarnings);
        }

        private void UpdateEarningsUI(double weightedEarnings)
        {
            _lblEarned.Text = $"{weightedEarnings:00000}{CurrencySymbols}";
            _lblWorkTime.Text = $"{ElapsedTime:c}".Substring(0, 8);
            _lblWorkTime.ForeColor = ElapsedTime.TotalHours <= MaxBillableDailyHours ? Color.White : Color.Red;
        }

        private double UpdateEarnings()
        {
            ElapsedTime = _stopwatch.Elapsed;
            if (ElapsedTime.TotalHours <= MaxBillableDailyHours)
                Earned += HourRate / 3600;
            double weightedEarnings = Earned - FixedDailyCost;
            return weightedEarnings;
        }

        private void HideClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TopPanelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CloseClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}