#region Using statements

using Earner.Settings;
using EarnerUserControls;

#endregion Using statements

namespace Earner.Forms
{
    public partial class SettingsForm : Form
    {
        #region Private variables

        private readonly EarnerSettings _Settings = EarnerSettings.Instance;

        private readonly NumericTextBox _txtFixedDailyCost;

        private readonly NumericTextBox _txtMaxBillableDailyHours;

        private readonly NumericTextBox _txtHourlyRate;

        #endregion Private variables

        #region Constructor

        public SettingsForm()
        {
            InitializeComponent();
            _txtHourlyRate = new NumericTextBox();
            _txtFixedDailyCost = new NumericTextBox();
            _txtMaxBillableDailyHours = new NumericTextBox();
            AddNumericTextBoxFieldsToForm();
            LoadAppSettings();
        }

        #endregion Constructor

        #region Private methods

        private void AddNumericTextBoxFieldsToForm()
        {
            _grpBoxGeneralSettings.SuspendLayout();
            SuspendLayout();
            _txtHourlyRate.BackColor = Color.FromArgb(47, 47, 47);
            _txtHourlyRate.BorderStyle = BorderStyle.None;
            _txtHourlyRate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _txtHourlyRate.ForeColor = Color.White;
            _txtHourlyRate.Location = _txtHourlyRatePlaceholder.Location;
            _txtHourlyRate.MaxLength = 5;
            _txtHourlyRate.Name = "_txtHourlyRate";
            _txtHourlyRate.Size = _txtHourlyRatePlaceholder.Size;
            _txtHourlyRate.TabIndex = 10;
            _txtHourlyRate.Text = "1000";
            _txtHourlyRate.TextAlign = HorizontalAlignment.Right;
            _txtHourlyRate.KeyPress += new KeyPressEventHandler(KeyPressEnterSave);
            _txtFixedDailyCost.BackColor = Color.FromArgb(47, 47, 47);
            _txtFixedDailyCost.BorderStyle = BorderStyle.None;
            _txtFixedDailyCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _txtFixedDailyCost.ForeColor = Color.White;
            _txtFixedDailyCost.Location = _txtFixedDailyCostPlaceholder.Location;
            _txtFixedDailyCost.MaxLength = 5;
            _txtFixedDailyCost.Name = "_txtFixedDailyCost";
            _txtFixedDailyCost.Size = _txtFixedDailyCostPlaceholder.Size;
            _txtFixedDailyCost.TabIndex = 11;
            _txtFixedDailyCost.Text = "0";
            _txtFixedDailyCost.TextAlign = HorizontalAlignment.Right;
            _txtFixedDailyCost.KeyPress += new KeyPressEventHandler(KeyPressEnterSave);
            _txtMaxBillableDailyHours.BackColor = Color.FromArgb(47, 47, 47);
            _txtMaxBillableDailyHours.BorderStyle = BorderStyle.None;
            _txtMaxBillableDailyHours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _txtMaxBillableDailyHours.ForeColor = Color.White;
            _txtMaxBillableDailyHours.Location = _txtMaxBillableDailyHoursPlaceholder.Location;
            _txtMaxBillableDailyHours.MaxLength = 5;
            _txtMaxBillableDailyHours.Name = "_txtMaxBillableDailyHours";
            _txtMaxBillableDailyHours.Size = _txtMaxBillableDailyHoursPlaceholder.Size;
            _txtMaxBillableDailyHours.TabIndex = 12;
            _txtMaxBillableDailyHours.Text = "8";
            _txtMaxBillableDailyHours.TextAlign = HorizontalAlignment.Right;
            _txtMaxBillableDailyHours.KeyPress += new KeyPressEventHandler(KeyPressEnterSave);
            _grpBoxGeneralSettings.Controls.Add(_txtMaxBillableDailyHours);
            _grpBoxGeneralSettings.Controls.Add(_txtHourlyRate);
            _grpBoxGeneralSettings.Controls.Add(_txtFixedDailyCost);
            _grpBoxGeneralSettings.ResumeLayout(false);
            _grpBoxGeneralSettings.PerformLayout();
            ResumeLayout(false);
        }

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
                _toolTip.SetToolTip(_lblHourlyRate, "Earnings per hour");
                _toolTip.SetToolTip(_txtHourlyRate, "Earnings per hour");
                _toolTip.SetToolTip(_lblFixedDailyCost, "Daily expenditures that should be deducted from earnings");
                _toolTip.SetToolTip(_txtFixedDailyCost, "Daily expenditures that should be deducted from earnings");
                _toolTip.SetToolTip(_lblMaxBillableDailyHours, "Earnings will stop after specified hours been exceeded");
                _toolTip.SetToolTip(_txtMaxBillableDailyHours, "Max number of hours earnings are counted for per day");
                _toolTip.SetToolTip(_lblCurrencySymbol, "Currency identifier text (max 3 characters)");
                _toolTip.SetToolTip(_txtCurrencySymbol, "Currency identifier text (max 3 characters)");
                _toolTip.SetToolTip(_btnClose, "Close settings");
                _toolTip.SetToolTip(_btnSave, "Save settings");
                _toolTip.SetToolTip(_btnAbout, "Show information about Earner");
                _toolTip.SetToolTip(_btnAdminJsonDb, "Administer work log");
                _toolTip.SetToolTip(_btnEraseLogRecords, "Erase ALL log earnings and work");
                _toolTip.SetToolTip(_lnkTaskLogLocation, "Select folder that Excel files are stored");
                _toolTip.SetToolTip(_btnEditTasks, "Edit tasks; Add and Delete");
                _toolTip.SetToolTip(_chkSaveTaskLog, "Show Excel file on Close/Reset");
                _toolTip.SetToolTip(_chkShowTooltips, "Show tooltips");
                _toolTip.SetToolTip(_chkShowApplicationLogOnErrors, "Show application log on errors (technical)");
                _toolTip.SetToolTip(_chkAutoShowTaskLog, "Automatically show earnings when app is closed or reset is pressed");
                _toolTip.SetToolTip(_chkAutoStartWithWindows, "Automatically start Earner with Windows");
                _toolTip.SetToolTip(_chkConfirmBeforeClose, "Show confirmation dialog when Close is pressed");
                _toolTip.SetToolTip(_chkShowProgressbar, "Show work progress bar");
                _toolTip.SetToolTip(_btnShowAppLog, "Show application log (advanced)");
                _toolTip.SetToolTip(_btnClearAppLog, "Clear application log (advanced)");
            }
            else
            {
                _toolTip.SetToolTip(_lblHourlyRate, null);
                _toolTip.SetToolTip(_txtHourlyRate, null);
                _toolTip.SetToolTip(_lblFixedDailyCost, null);
                _toolTip.SetToolTip(_txtFixedDailyCost, null);
                _toolTip.SetToolTip(_lblMaxBillableDailyHours, null);
                _toolTip.SetToolTip(_txtMaxBillableDailyHours, null);
                _toolTip.SetToolTip(_lblCurrencySymbol, null);
                _toolTip.SetToolTip(_txtCurrencySymbol, null);
                _toolTip.SetToolTip(_lnkTaskLogLocation, null);
                _toolTip.SetToolTip(_btnEraseLogRecords, null);
                _toolTip.SetToolTip(_btnAdminJsonDb, null);
                _toolTip.SetToolTip(_btnAbout, null);
                _toolTip.SetToolTip(_btnClose, null);
                _toolTip.SetToolTip(_btnSave, null);
                _toolTip.SetToolTip(_btnEditTasks, null);
                _toolTip.SetToolTip(_chkSaveTaskLog, null);
                _toolTip.SetToolTip(_chkShowTooltips, null);
                _toolTip.SetToolTip(_chkShowApplicationLogOnErrors, null);
                _toolTip.SetToolTip(_chkAutoShowTaskLog, null);
                _toolTip.SetToolTip(_chkAutoStartWithWindows, null);
                _toolTip.SetToolTip(_chkConfirmBeforeClose, null);
                _toolTip.SetToolTip(_chkShowProgressbar, null);
                _toolTip.SetToolTip(_btnShowAppLog, null);
                _toolTip.SetToolTip(_btnClearAppLog, null);
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
            try
            {
                Visible = false;
                using TasksForm tasksForm = new();
                _ = tasksForm.ShowDialog(this);
            }
            finally
            {
                Visible = true;
            }
        }

        private void KeyPressEnterSave(object? sender, KeyPressEventArgs? e)
        {
            if (sender is not null && e is not null && ((byte)e.KeyChar) == (byte)Keys.Enter)
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

        private void TaskLogLocationLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using FolderBrowserDialog fbd = new();
            fbd.InitialDirectory = _Settings.TaskLogSaveLocation;

            if (fbd.ShowDialog(this) == DialogResult.OK && _Settings.TaskLogSaveLocation != fbd.SelectedPath && Directory.Exists(fbd.SelectedPath))
            {
                _Settings.TaskLogSaveLocation = fbd.SelectedPath;
                _Settings.Save();
                Log.Info = $"Saved task log path '{fbd.SelectedPath}'";
            }
        }

        private void EraseLogRecordsClick(object sender, EventArgs e)
        {
            Visible = false;
            using ConfirmForm confirmForm = new();
            confirmForm.LblQuestion.Text = "Erase ALL work log records\nincluding todays work progress?";
            if (DialogResult.Yes == confirmForm.ShowDialog(this))
            {
                DialogResult = DialogResult.TryAgain;
                Close();
            }
            Visible = true;
        }

        private void AboutClick(object sender, EventArgs e)
        {
            try
            {
                Visible = false;
                using AboutForm aboutForm = new();
                _ = aboutForm.ShowDialog(this);
            }
            finally
            {
                Visible = true;
            }
        }

        private void AdminJsonDbClick(object sender, EventArgs e)
        {
            try
            {
                Visible = false;
                using LogPeriodForm logPeriodForm = new();
                if (DialogResult.OK == logPeriodForm.ShowDialog(this))
                {
                    using LogAdminForm logAdminForm = new(logPeriodForm.ReportPeriod);
                    _ = logAdminForm.ShowDialog(this);
                }

            }
            finally
            {
                Visible = true;
            }
        }

        private void ShowTooltipsCheckedChanged(object sender, EventArgs e)
        {
            _Settings.ShowTooltips = _chkShowTooltips.Checked;
            _Settings.Save();
        }

        private void ShowProgressbarCheckedChanged(object sender, EventArgs e)
        {
            _Settings.ShowProgressbar = _chkShowProgressbar.Checked;
            _Settings.Save();
        }

        private void AutoStartWithWindowsCheckedChanged(object sender, EventArgs e)
        {
            _Settings.AutoStartWithWindows = _chkAutoStartWithWindows.Checked;
            _Settings.Save();
        }

        private void ConfirmBeforeCloseCheckedChanged(object sender, EventArgs e)
        {
            _Settings.ConfirmBeforeClose = _chkConfirmBeforeClose.Checked;
            _Settings.Save();
        }

        private void ShowApplicationLogOnErrorsCheckedChanged(object sender, EventArgs e)
        {
            _Settings.ShowApplicationLogOnErrors = _chkShowApplicationLogOnErrors.Checked;
            _Settings.Save();
        }

        private void SaveTaskLogCheckedChanged(object sender, EventArgs e)
        {
            _Settings.SaveTaskLog = _chkSaveTaskLog.Checked;
            _Settings.Save();
        }

        private void AutoShowTaskLogCheckedChanged(object sender, EventArgs e)
        {
            _Settings.AutoShowTaskLog = _chkAutoShowTaskLog.Checked;
            _Settings.Save();
        }

        private void ShowAppLogClick(object sender, EventArgs e)
        {
            Log.Show();
        }

        private void ClearAppLogClick(object sender, EventArgs e)
        {
            Log.Clear();
        }

        #endregion Private events
    }
}
