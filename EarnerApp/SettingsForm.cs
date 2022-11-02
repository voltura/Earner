namespace Earner
{
    public partial class SettingsForm : Form
    {
        #region Private variables

        private readonly EarnerSettings _Settings = EarnerSettings.Instance;

        #endregion Private variables

        #region Constructor

        public SettingsForm()
        {
            InitializeComponent();
            LoadAppSettings();
        }

        #endregion Constructor

        #region Private methods

        private void LoadAppSettings()
        {
            _Settings.Load();
            _txtHourlyRate.Text = _Settings.HourlyRate.ToString();
            _txtFixedDailyCost.Text = _Settings.FixedDailyCost.ToString();
            _txtMaxBillableDailyHours.Text = _Settings.MaxBillableDailyHours.ToString();
            _txtCurrencySymbol.Text = _Settings.CurrencySymbol.ToString();
            _chkSaveTaskLog.Checked = _Settings.SaveTaskLog;
            _chkShowApplicationLogOnErrors.Checked = _Settings.ShowApplicationLogOnErrors;
            _chkShowTooltips.Checked = _Settings.ShowTooltips;
            SetTooltips();
        }

        private void SetTooltips()
        {
            if (_Settings.ShowTooltips)
            {
                toolTip.SetToolTip(_btnClose, "Close settings");
                toolTip.SetToolTip(_lblMaxBillableDailyHours, "Earnings will stop after specified hours been exceeded");
                toolTip.SetToolTip(_btnSave, "Save settings");
                toolTip.SetToolTip(_btnEditTasks, "Edit tasks");
                toolTip.SetToolTip(_chkSaveTaskLog, "Show Excel file on Close/Reset");
                toolTip.SetToolTip(_chkShowTooltips, "Show tooltips");
                toolTip.SetToolTip(_chkShowApplicationLogOnErrors, "Show tooltips");
            }
            else
            {
                toolTip.SetToolTip(_btnClose, null);
                toolTip.SetToolTip(_lblMaxBillableDailyHours, null);
                toolTip.SetToolTip(_btnSave, null);
                toolTip.SetToolTip(_btnEditTasks, null);
                toolTip.SetToolTip(_chkSaveTaskLog, null);
                toolTip.SetToolTip(_chkShowTooltips, null);
                toolTip.SetToolTip(_chkShowApplicationLogOnErrors, null);
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

        private void CloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveClick(object sender, EventArgs e)
        {
            if (_txtFixedDailyCost.Text.Length == 0 || EarnerCommon.ConvertToDouble(_txtFixedDailyCost.Text) == 0)
            {
                _txtFixedDailyCost.Text = "0";
            }

            if (_txtHourlyRate.Text.Length == 0 || EarnerCommon.ConvertToDouble(_txtHourlyRate.Text) == 0)
            {
                _txtHourlyRate.Text = "1000";
            }

            if (EarnerCommon.ConvertToDouble(_txtMaxBillableDailyHours.Text) == 0 || _txtMaxBillableDailyHours.Text.Length == 0 || _txtMaxBillableDailyHours.Text == "0")
            {
                _txtMaxBillableDailyHours.Text = "8";
            }

            _Settings.HourlyRate = Convert.ToDouble(_txtHourlyRate.Text);
            _Settings.FixedDailyCost = Convert.ToDouble(_txtFixedDailyCost.Text);
            _Settings.MaxBillableDailyHours = Convert.ToDouble(_txtMaxBillableDailyHours.Text);
            _Settings.CurrencySymbol = _txtCurrencySymbol.Text;
            _Settings.SaveTaskLog = _chkSaveTaskLog.Checked;
            _Settings.ShowTooltips = _chkShowTooltips.Checked;
            _Settings.ShowApplicationLogOnErrors = _chkShowApplicationLogOnErrors.Checked;
            _Settings.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditTasksClick(object sender, EventArgs e)
        {
            using TasksForm tasksForm = new();
            _ = tasksForm.ShowDialog();
        }

        #endregion Private events
    }
}
