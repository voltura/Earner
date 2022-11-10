using Earner.Records;
using Earner.Settings;
using System.Runtime;

namespace Earner.Forms
{
    public partial class EarnerForm : Form
    {
        #region Private variables

        private double _Earned;
        private TimeSpan _ElapsedTime;
        private DateTime _ActiveDay;
        private string _ActiveTask = string.Empty;
        private readonly EarnerRecords _EarnerRecords = new();
        private readonly System.Diagnostics.Stopwatch _stopwatch = new();
        private readonly EarnerSettings _Settings = EarnerSettings.Instance;
        private bool _DoNotChangeFontSize = false;

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
            using TasksForm tasksForm = new();
            if (DialogResult.OK != tasksForm.ShowDialog(this))
            {
                return false;
            }
            LoadAppSettings();
            _pbWorkProgress.Value = 0;
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
            _pbWorkProgress.Value = 0;
            _pbWorkProgress.Visible = _Settings.ShowProgressbar;
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
                _pbWorkProgress.Value = Convert.ToInt32(Math.Round((_ElapsedTime.TotalSeconds / (_Settings.MaxBillableDailyHours * 3600)) * 100, 0));
                _pbWorkProgress.Visible = _Settings.ShowProgressbar;
                _Earned = totalEarnings;
                _EarnerRecords.UpdateRecord(_ActiveTask, _Settings.HourlyRate, totalEarnings, _Settings.CurrencySymbol);
            }
            else
            {
                _pbWorkProgress.Value = 100;
                EarnerCommon.MakeProgressbarError(_pbWorkProgress.Handle);
                _pbWorkProgress.Visible = _Settings.ShowProgressbar;
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
                _Earned = 0;
                _stopwatch.Reset();
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
                if (_Settings.ConfirmBeforeClose || DialogResult.Yes == confirmForm.ShowDialog())
                {
                    CloseClick(sender, e);
                }
            }
        }

        #endregion Private events
    }
}
