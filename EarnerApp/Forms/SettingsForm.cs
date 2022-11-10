using Earner.Settings;

namespace Earner.Forms
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
            _chkAutoShowTaskLog.Checked = _Settings.AutoShowTaskLog;
            _chkAutoStartWithWindows.Checked = _Settings.AutoStartWithWindows;
            _chkConfirmBeforeClose.Checked = _Settings.ConfirmBeforeClose;
            _chkShowProgressbar.Checked = _Settings.ShowProgressbar;
            SetTooltips();
        }

        private void SetTooltips()
        {
            if (_Settings.ShowTooltips)
            {
                _toolTip.SetToolTip(_btnClose, "Close settings");
                _toolTip.SetToolTip(_lblMaxBillableDailyHours, "Earnings will stop after specified hours been exceeded");
                _toolTip.SetToolTip(_btnSave, "Save settings");
                _toolTip.SetToolTip(_btnEditTasks, "Edit tasks");
                _toolTip.SetToolTip(_chkSaveTaskLog, "Show Excel file on Close/Reset");
                _toolTip.SetToolTip(_chkShowTooltips, "Show tooltips");
                _toolTip.SetToolTip(_chkShowApplicationLogOnErrors, "Show tooltips");
                _toolTip.SetToolTip(_chkAutoShowTaskLog, "Automatically show earnings when app is closed or reset is pressed");
                _toolTip.SetToolTip(_chkAutoStartWithWindows, "Automatically start Earner with Windows");
                _toolTip.SetToolTip(_chkConfirmBeforeClose, "Show confirmation dialog when Close is pressed");
                _toolTip.SetToolTip(_chkShowProgressbar, "Show work progress bar");
            }
            else
            {
                _toolTip.SetToolTip(_btnClose, null);
                _toolTip.SetToolTip(_lblMaxBillableDailyHours, null);
                _toolTip.SetToolTip(_btnSave, null);
                _toolTip.SetToolTip(_btnEditTasks, null);
                _toolTip.SetToolTip(_chkSaveTaskLog, null);
                _toolTip.SetToolTip(_chkShowTooltips, null);
                _toolTip.SetToolTip(_chkShowApplicationLogOnErrors, null);
                _toolTip.SetToolTip(_chkAutoShowTaskLog, null);
                _toolTip.SetToolTip(_chkAutoStartWithWindows, null);
                _toolTip.SetToolTip(_chkConfirmBeforeClose, null);
                _toolTip.SetToolTip(_chkShowProgressbar, null);
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
            _Settings.AutoShowTaskLog = _chkAutoShowTaskLog.Checked;
            _Settings.AutoStartWithWindows = _chkAutoStartWithWindows.Checked;
            _Settings.ConfirmBeforeClose = _chkConfirmBeforeClose.Checked;
            _Settings.ShowProgressbar = _chkShowProgressbar.Checked;
            _Settings.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditTasksClick(object sender, EventArgs e)
        {
            using TasksForm tasksForm = new();
            _ = tasksForm.ShowDialog();
        }

        private void KeyPressEnterSave(object sender, KeyPressEventArgs e)
        {
            if (e is not null && ((byte)e.KeyChar) == (byte)Keys.Enter)
            {
                SaveClick(sender, e);
            }
        }

        private void SettingsFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        #endregion Private events
    }
}
