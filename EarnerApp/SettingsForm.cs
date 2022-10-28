namespace Earner
{
    public partial class SettingsForm : Form
    {
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
            _txtHourlyRate.Text = EarnerConfig.GetAppSettings<string>("HourlyRate");
            _txtFixedDailyCost.Text = EarnerConfig.GetAppSettings<string>("FixedDailyCost");
            _txtMaxBillableDailyHours.Text = EarnerConfig.GetAppSettings<string>("MaxBillableDailyHours");
            _txtCurrencySymbol.Text = EarnerConfig.GetAppSettings<string>("CurrencySymbol");
            _chkSaveTaskLog.Checked = EarnerConfig.GetAppSettings<bool>("SaveTaskLog");
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

            _ = EarnerConfig.SaveAppSettingsString("HourlyRate", _txtHourlyRate.Text);
            _ = EarnerConfig.SaveAppSettingsString("FixedDailyCost", _txtFixedDailyCost.Text);
            _ = EarnerConfig.SaveAppSettingsString("MaxBillableDailyHours", _txtMaxBillableDailyHours.Text);
            _ = EarnerConfig.SaveAppSettingsString("CurrencySymbol", _txtCurrencySymbol.Text);
            _ = EarnerConfig.SaveAppSettingsString("CurrencySymbol", _txtCurrencySymbol.Text);
            _ = EarnerConfig.SaveAppSettingsString("SaveTaskLog", _chkSaveTaskLog.Checked.ToString());
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
