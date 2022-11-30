#region Using statements

using Earner.Records;
using Earner.Settings;
using static Earner.Records.EarnerRecords;

#endregion Using statements

namespace Earner.Forms
{
    internal partial class LogPeriodForm : Form
    {
        #region Private variables

        private readonly EarnerSettings _Settings = EarnerSettings.Instance;

        private bool _DoNotChangeFontSize = false;

        #endregion Private variables

        #region Constructor

        public LogPeriodForm()
        {
            Log.Init();
            Log.LogCaller();
            InitializeComponent();
            LoadAppSettings();
            SetTooltips();
        }

        #endregion Constructor

        #region Public properties

        public REPORT_PERIOD ReportPeriod { get; private set; } = REPORT_PERIOD.ALL;

        #endregion Public properties

        #region Private methods

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

        private void LoadAppSettings()
        {
            _Settings.Load();
        }

        private void SetTooltips()
        {
            if (_Settings.ShowTooltips)
            {
                _toolTip.SetToolTip(_btnDay, "Log of todays work");
                _toolTip.SetToolTip(_btnThisWeek, "Log of current weeks work");
                _toolTip.SetToolTip(_btnMonth, "Log of current months work");
                _toolTip.SetToolTip(_btnYear, "Log of current years work");
                _toolTip.SetToolTip(_btnAll, "Log of all work");
            }
            else
            {
                _toolTip.Hide(this);
                _toolTip.SetToolTip(_btnDay, null);
                _toolTip.SetToolTip(_btnThisWeek, null);
                _toolTip.SetToolTip(_btnMonth, null);
                _toolTip.SetToolTip(_btnYear, null);
                _toolTip.SetToolTip(_btnAll, null);
            }
        }

        #endregion Private methods

        #region Private events

        private void TopPanelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _ = NativeMethods.ReleaseCapture();
                _ = NativeMethods.SendMessage(Handle, NativeMethods.WM_NCLBUTTONDOWN, NativeMethods.HT_CAPTION, 0);
            }
        }

        private void DayClick(object sender, EventArgs e)
        {
            Log.LogCaller();
            ReportPeriod = REPORT_PERIOD.DAY;
            Close();
        }

        private void MonthClick(object sender, EventArgs e)
        {
            Log.LogCaller();
            ReportPeriod = REPORT_PERIOD.MONTH;
            Close();
        }
        private void YearClick(object sender, EventArgs e)
        {
            Log.LogCaller();
            ReportPeriod = REPORT_PERIOD.YEAR;
            Close();
        }
        private void AllClick(object sender, EventArgs e)
        {
            Log.LogCaller();
            ReportPeriod = EarnerRecords.REPORT_PERIOD.ALL;
            Close();
        }

        private void ScaleTextChanged(object sender, EventArgs e)
        {
            if (_DoNotChangeFontSize)
            {
                return;
            }

            Label label = (Label)sender;
            EarnerCommon.ScaleFont(label, 14);
        }

        private void LogPeriodFormResize(object sender, EventArgs e)
        {
            _DoNotChangeFontSize = WindowState == FormWindowState.Minimized;
        }

        private void LogPeriodFormKeyDown(object sender, KeyEventArgs e)
        {
            Log.LogCaller();
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ThisWeekClick(object sender, EventArgs e)
        {
            Log.LogCaller();
            ReportPeriod = REPORT_PERIOD.WEEK;
            Close();
        }

        #endregion Private events
    }
}
