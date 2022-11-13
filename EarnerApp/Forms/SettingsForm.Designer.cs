#region Using statements

using EarnerUserControls;

#endregion Using statements

namespace Earner.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this._topPanel = new System.Windows.Forms.Panel();
            this._lblSettingsHeader = new System.Windows.Forms.Label();
            this._btnClose = new System.Windows.Forms.Button();
            this._lblHourlyRate = new System.Windows.Forms.Label();
            this._lblFixedDailyCost = new System.Windows.Forms.Label();
            this._lblMaxBillableDailyHours = new System.Windows.Forms.Label();
            this._lblCurrencySymbol = new System.Windows.Forms.Label();
            this._txtCurrencySymbol = new System.Windows.Forms.TextBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnEditTasks = new System.Windows.Forms.Button();
            this._chkSaveTaskLog = new System.Windows.Forms.CheckBox();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._chkShowTooltips = new System.Windows.Forms.CheckBox();
            this._chkShowApplicationLogOnErrors = new System.Windows.Forms.CheckBox();
            this._grpBoxDeveloperSettings = new System.Windows.Forms.GroupBox();
            this._grpBoxInterfaceSettings = new System.Windows.Forms.GroupBox();
            this._lblShow = new System.Windows.Forms.Label();
            this._chkShowProgressbar = new System.Windows.Forms.CheckBox();
            this._chkConfirmBeforeClose = new System.Windows.Forms.CheckBox();
            this._chkAutoStartWithWindows = new System.Windows.Forms.CheckBox();
            this._grpBoxTaskSettings = new System.Windows.Forms.GroupBox();
            this._btnEraseLogRecords = new System.Windows.Forms.Button();
            this._lnkTaskLogLocation = new System.Windows.Forms.LinkLabel();
            this._chkAutoShowTaskLog = new System.Windows.Forms.CheckBox();
            this._grpBoxGeneralSettings = new System.Windows.Forms.GroupBox();
            this._txtMaxBillableDailyHoursPlaceholder = new System.Windows.Forms.TextBox();
            this._txtFixedDailyCostPlaceholder = new System.Windows.Forms.TextBox();
            this._txtHourlyRatePlaceholder = new System.Windows.Forms.TextBox();
            this._topPanel.SuspendLayout();
            this._grpBoxDeveloperSettings.SuspendLayout();
            this._grpBoxInterfaceSettings.SuspendLayout();
            this._grpBoxTaskSettings.SuspendLayout();
            this._grpBoxGeneralSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // _topPanel
            // 
            this._topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.Controls.Add(this._lblSettingsHeader);
            this._topPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.Location = new System.Drawing.Point(41, 0);
            this._topPanel.Margin = new System.Windows.Forms.Padding(0);
            this._topPanel.Name = "_topPanel";
            this._topPanel.Size = new System.Drawing.Size(441, 48);
            this._topPanel.TabIndex = 500;
            this._topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseDown);
            // 
            // _lblSettingsHeader
            // 
            this._lblSettingsHeader.AutoSize = true;
            this._lblSettingsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblSettingsHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblSettingsHeader.ForeColor = System.Drawing.Color.White;
            this._lblSettingsHeader.Location = new System.Drawing.Point(4, 7);
            this._lblSettingsHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblSettingsHeader.Name = "_lblSettingsHeader";
            this._lblSettingsHeader.Size = new System.Drawing.Size(100, 32);
            this._lblSettingsHeader.TabIndex = 611;
            this._lblSettingsHeader.Text = "Settings";
            this._lblSettingsHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseDown);
            // 
            // _btnClose
            // 
            this._btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnClose.BackgroundImage = global::Earner.Properties.Resources.close_48x48;
            this._btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnClose.FlatAppearance.BorderSize = 0;
            this._btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this._btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnClose.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnClose.Location = new System.Drawing.Point(0, 0);
            this._btnClose.Margin = new System.Windows.Forms.Padding(0);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(41, 48);
            this._btnClose.TabIndex = 600;
            this._btnClose.TabStop = false;
            this._btnClose.UseVisualStyleBackColor = false;
            this._btnClose.Click += new System.EventHandler(this.CloseClick);
            // 
            // _lblHourlyRate
            // 
            this._lblHourlyRate.AutoSize = true;
            this._lblHourlyRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblHourlyRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblHourlyRate.ForeColor = System.Drawing.Color.White;
            this._lblHourlyRate.Location = new System.Drawing.Point(14, 30);
            this._lblHourlyRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblHourlyRate.Name = "_lblHourlyRate";
            this._lblHourlyRate.Size = new System.Drawing.Size(138, 32);
            this._lblHourlyRate.TabIndex = 70;
            this._lblHourlyRate.Text = "Hourly rate:";
            // 
            // _lblFixedDailyCost
            // 
            this._lblFixedDailyCost.AutoSize = true;
            this._lblFixedDailyCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblFixedDailyCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblFixedDailyCost.ForeColor = System.Drawing.Color.White;
            this._lblFixedDailyCost.Location = new System.Drawing.Point(14, 75);
            this._lblFixedDailyCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblFixedDailyCost.Name = "_lblFixedDailyCost";
            this._lblFixedDailyCost.Size = new System.Drawing.Size(182, 32);
            this._lblFixedDailyCost.TabIndex = 80;
            this._lblFixedDailyCost.Text = "Fixed daily cost:";
            // 
            // _lblMaxBillableDailyHours
            // 
            this._lblMaxBillableDailyHours.AutoSize = true;
            this._lblMaxBillableDailyHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblMaxBillableDailyHours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblMaxBillableDailyHours.ForeColor = System.Drawing.Color.White;
            this._lblMaxBillableDailyHours.Location = new System.Drawing.Point(14, 120);
            this._lblMaxBillableDailyHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblMaxBillableDailyHours.Name = "_lblMaxBillableDailyHours";
            this._lblMaxBillableDailyHours.Size = new System.Drawing.Size(272, 32);
            this._lblMaxBillableDailyHours.TabIndex = 90;
            this._lblMaxBillableDailyHours.Text = "Max daily billable hours:";
            // 
            // _lblCurrencySymbol
            // 
            this._lblCurrencySymbol.AutoSize = true;
            this._lblCurrencySymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblCurrencySymbol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblCurrencySymbol.ForeColor = System.Drawing.Color.White;
            this._lblCurrencySymbol.Location = new System.Drawing.Point(14, 165);
            this._lblCurrencySymbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblCurrencySymbol.Name = "_lblCurrencySymbol";
            this._lblCurrencySymbol.Size = new System.Drawing.Size(114, 32);
            this._lblCurrencySymbol.TabIndex = 100;
            this._lblCurrencySymbol.Text = "Currency:";
            // 
            // _txtCurrencySymbol
            // 
            this._txtCurrencySymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._txtCurrencySymbol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtCurrencySymbol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtCurrencySymbol.ForeColor = System.Drawing.Color.White;
            this._txtCurrencySymbol.Location = new System.Drawing.Point(297, 165);
            this._txtCurrencySymbol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtCurrencySymbol.MaxLength = 3;
            this._txtCurrencySymbol.Name = "_txtCurrencySymbol";
            this._txtCurrencySymbol.Size = new System.Drawing.Size(81, 32);
            this._txtCurrencySymbol.TabIndex = 13;
            this._txtCurrencySymbol.Text = "kr";
            this._txtCurrencySymbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._txtCurrencySymbol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEnterSave);
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnSave.BackgroundImage = global::Earner.Properties.Resources.check_48x48;
            this._btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnSave.FlatAppearance.BorderSize = 0;
            this._btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSave.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnSave.Location = new System.Drawing.Point(439, 735);
            this._btnSave.Margin = new System.Windows.Forms.Padding(0);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(41, 48);
            this._btnSave.TabIndex = 21;
            this._btnSave.Tag = "";
            this._btnSave.UseVisualStyleBackColor = false;
            this._btnSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // _btnEditTasks
            // 
            this._btnEditTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnEditTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnEditTasks.BackgroundImage = global::Earner.Properties.Resources.cog_48x48;
            this._btnEditTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnEditTasks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnEditTasks.FlatAppearance.BorderSize = 0;
            this._btnEditTasks.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnEditTasks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnEditTasks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnEditTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnEditTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnEditTasks.Location = new System.Drawing.Point(337, 30);
            this._btnEditTasks.Margin = new System.Windows.Forms.Padding(0);
            this._btnEditTasks.Name = "_btnEditTasks";
            this._btnEditTasks.Size = new System.Drawing.Size(41, 48);
            this._btnEditTasks.TabIndex = 16;
            this._btnEditTasks.Tag = "";
            this._btnEditTasks.UseVisualStyleBackColor = false;
            this._btnEditTasks.Click += new System.EventHandler(this.EditTasksClick);
            // 
            // _chkSaveTaskLog
            // 
            this._chkSaveTaskLog.AutoSize = true;
            this._chkSaveTaskLog.Checked = true;
            this._chkSaveTaskLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkSaveTaskLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkSaveTaskLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._chkSaveTaskLog.ForeColor = System.Drawing.Color.White;
            this._chkSaveTaskLog.Location = new System.Drawing.Point(14, 35);
            this._chkSaveTaskLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._chkSaveTaskLog.Name = "_chkSaveTaskLog";
            this._chkSaveTaskLog.Size = new System.Drawing.Size(126, 36);
            this._chkSaveTaskLog.TabIndex = 14;
            this._chkSaveTaskLog.Text = "Save log";
            this._chkSaveTaskLog.UseVisualStyleBackColor = true;
            // 
            // _toolTip
            // 
            this._toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._toolTip.ForeColor = System.Drawing.Color.White;
            this._toolTip.IsBalloon = true;
            this._toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this._toolTip.ToolTipTitle = "Info";
            // 
            // _chkShowTooltips
            // 
            this._chkShowTooltips.AutoSize = true;
            this._chkShowTooltips.Checked = true;
            this._chkShowTooltips.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkShowTooltips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkShowTooltips.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._chkShowTooltips.ForeColor = System.Drawing.Color.White;
            this._chkShowTooltips.Location = new System.Drawing.Point(83, 38);
            this._chkShowTooltips.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._chkShowTooltips.Name = "_chkShowTooltips";
            this._chkShowTooltips.Size = new System.Drawing.Size(115, 36);
            this._chkShowTooltips.TabIndex = 17;
            this._chkShowTooltips.Text = "tooltips";
            this._chkShowTooltips.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._chkShowTooltips.UseVisualStyleBackColor = true;
            // 
            // _chkShowApplicationLogOnErrors
            // 
            this._chkShowApplicationLogOnErrors.AutoSize = true;
            this._chkShowApplicationLogOnErrors.Checked = true;
            this._chkShowApplicationLogOnErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkShowApplicationLogOnErrors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkShowApplicationLogOnErrors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._chkShowApplicationLogOnErrors.ForeColor = System.Drawing.Color.White;
            this._chkShowApplicationLogOnErrors.Location = new System.Drawing.Point(14, 35);
            this._chkShowApplicationLogOnErrors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._chkShowApplicationLogOnErrors.Name = "_chkShowApplicationLogOnErrors";
            this._chkShowApplicationLogOnErrors.Size = new System.Drawing.Size(180, 36);
            this._chkShowApplicationLogOnErrors.TabIndex = 20;
            this._chkShowApplicationLogOnErrors.Text = "Display errors";
            this._chkShowApplicationLogOnErrors.UseVisualStyleBackColor = true;
            // 
            // _grpBoxDeveloperSettings
            // 
            this._grpBoxDeveloperSettings.Controls.Add(this._chkShowApplicationLogOnErrors);
            this._grpBoxDeveloperSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._grpBoxDeveloperSettings.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._grpBoxDeveloperSettings.ForeColor = System.Drawing.Color.White;
            this._grpBoxDeveloperSettings.Location = new System.Drawing.Point(41, 642);
            this._grpBoxDeveloperSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._grpBoxDeveloperSettings.Name = "_grpBoxDeveloperSettings";
            this._grpBoxDeveloperSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._grpBoxDeveloperSettings.Size = new System.Drawing.Size(396, 95);
            this._grpBoxDeveloperSettings.TabIndex = 3;
            this._grpBoxDeveloperSettings.TabStop = false;
            this._grpBoxDeveloperSettings.Text = "Developer settings";
            // 
            // _grpBoxInterfaceSettings
            // 
            this._grpBoxInterfaceSettings.Controls.Add(this._lblShow);
            this._grpBoxInterfaceSettings.Controls.Add(this._chkShowProgressbar);
            this._grpBoxInterfaceSettings.Controls.Add(this._chkConfirmBeforeClose);
            this._grpBoxInterfaceSettings.Controls.Add(this._chkAutoStartWithWindows);
            this._grpBoxInterfaceSettings.Controls.Add(this._chkShowTooltips);
            this._grpBoxInterfaceSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._grpBoxInterfaceSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._grpBoxInterfaceSettings.ForeColor = System.Drawing.Color.White;
            this._grpBoxInterfaceSettings.Location = new System.Drawing.Point(41, 437);
            this._grpBoxInterfaceSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._grpBoxInterfaceSettings.Name = "_grpBoxInterfaceSettings";
            this._grpBoxInterfaceSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._grpBoxInterfaceSettings.Size = new System.Drawing.Size(396, 195);
            this._grpBoxInterfaceSettings.TabIndex = 2;
            this._grpBoxInterfaceSettings.TabStop = false;
            this._grpBoxInterfaceSettings.Text = "Application settings";
            // 
            // _lblShow
            // 
            this._lblShow.AutoSize = true;
            this._lblShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblShow.Location = new System.Drawing.Point(9, 40);
            this._lblShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblShow.Name = "_lblShow";
            this._lblShow.Size = new System.Drawing.Size(72, 32);
            this._lblShow.TabIndex = 21;
            this._lblShow.Text = "Show";
            this._lblShow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _chkShowProgressbar
            // 
            this._chkShowProgressbar.AutoSize = true;
            this._chkShowProgressbar.Checked = true;
            this._chkShowProgressbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkShowProgressbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkShowProgressbar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._chkShowProgressbar.ForeColor = System.Drawing.Color.White;
            this._chkShowProgressbar.Location = new System.Drawing.Point(200, 38);
            this._chkShowProgressbar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._chkShowProgressbar.Name = "_chkShowProgressbar";
            this._chkShowProgressbar.Size = new System.Drawing.Size(167, 36);
            this._chkShowProgressbar.TabIndex = 20;
            this._chkShowProgressbar.Text = "progress bar";
            this._chkShowProgressbar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._chkShowProgressbar.UseVisualStyleBackColor = true;
            // 
            // _chkConfirmBeforeClose
            // 
            this._chkConfirmBeforeClose.AutoSize = true;
            this._chkConfirmBeforeClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkConfirmBeforeClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._chkConfirmBeforeClose.ForeColor = System.Drawing.Color.White;
            this._chkConfirmBeforeClose.Location = new System.Drawing.Point(14, 137);
            this._chkConfirmBeforeClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._chkConfirmBeforeClose.Name = "_chkConfirmBeforeClose";
            this._chkConfirmBeforeClose.Size = new System.Drawing.Size(182, 36);
            this._chkConfirmBeforeClose.TabIndex = 19;
            this._chkConfirmBeforeClose.Text = "Confirm close";
            this._chkConfirmBeforeClose.UseVisualStyleBackColor = true;
            // 
            // _chkAutoStartWithWindows
            // 
            this._chkAutoStartWithWindows.AutoSize = true;
            this._chkAutoStartWithWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkAutoStartWithWindows.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._chkAutoStartWithWindows.ForeColor = System.Drawing.Color.White;
            this._chkAutoStartWithWindows.Location = new System.Drawing.Point(14, 87);
            this._chkAutoStartWithWindows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._chkAutoStartWithWindows.Name = "_chkAutoStartWithWindows";
            this._chkAutoStartWithWindows.Size = new System.Drawing.Size(185, 36);
            this._chkAutoStartWithWindows.TabIndex = 18;
            this._chkAutoStartWithWindows.Text = "Run at startup";
            this._chkAutoStartWithWindows.UseVisualStyleBackColor = true;
            // 
            // _grpBoxTaskSettings
            // 
            this._grpBoxTaskSettings.Controls.Add(this._btnEraseLogRecords);
            this._grpBoxTaskSettings.Controls.Add(this._lnkTaskLogLocation);
            this._grpBoxTaskSettings.Controls.Add(this._chkAutoShowTaskLog);
            this._grpBoxTaskSettings.Controls.Add(this._chkSaveTaskLog);
            this._grpBoxTaskSettings.Controls.Add(this._btnEditTasks);
            this._grpBoxTaskSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._grpBoxTaskSettings.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._grpBoxTaskSettings.ForeColor = System.Drawing.Color.White;
            this._grpBoxTaskSettings.Location = new System.Drawing.Point(41, 282);
            this._grpBoxTaskSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._grpBoxTaskSettings.Name = "_grpBoxTaskSettings";
            this._grpBoxTaskSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._grpBoxTaskSettings.Size = new System.Drawing.Size(396, 145);
            this._grpBoxTaskSettings.TabIndex = 1;
            this._grpBoxTaskSettings.TabStop = false;
            this._grpBoxTaskSettings.Text = "Task settings";
            // 
            // _btnEraseLogRecords
            // 
            this._btnEraseLogRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnEraseLogRecords.BackgroundImage = global::Earner.Properties.Resources.close_48x48;
            this._btnEraseLogRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnEraseLogRecords.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnEraseLogRecords.FlatAppearance.BorderSize = 0;
            this._btnEraseLogRecords.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnEraseLogRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnEraseLogRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this._btnEraseLogRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnEraseLogRecords.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnEraseLogRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnEraseLogRecords.Location = new System.Drawing.Point(281, 30);
            this._btnEraseLogRecords.Margin = new System.Windows.Forms.Padding(0);
            this._btnEraseLogRecords.Name = "_btnEraseLogRecords";
            this._btnEraseLogRecords.Size = new System.Drawing.Size(41, 48);
            this._btnEraseLogRecords.TabIndex = 601;
            this._btnEraseLogRecords.TabStop = false;
            this._btnEraseLogRecords.UseVisualStyleBackColor = false;
            this._btnEraseLogRecords.Click += new System.EventHandler(this.EraseLogRecordsClick);
            // 
            // _lnkTaskLogLocation
            // 
            this._lnkTaskLogLocation.ActiveLinkColor = System.Drawing.Color.White;
            this._lnkTaskLogLocation.AutoSize = true;
            this._lnkTaskLogLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lnkTaskLogLocation.LinkColor = System.Drawing.Color.White;
            this._lnkTaskLogLocation.Location = new System.Drawing.Point(131, 38);
            this._lnkTaskLogLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lnkTaskLogLocation.Name = "_lnkTaskLogLocation";
            this._lnkTaskLogLocation.Size = new System.Drawing.Size(62, 32);
            this._lnkTaskLogLocation.TabIndex = 17;
            this._lnkTaskLogLocation.TabStop = true;
            this._lnkTaskLogLocation.Text = "here";
            this._lnkTaskLogLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lnkTaskLogLocation.VisitedLinkColor = System.Drawing.Color.White;
            this._lnkTaskLogLocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TaskLogLocationLinkClicked);
            // 
            // _chkAutoShowTaskLog
            // 
            this._chkAutoShowTaskLog.AutoSize = true;
            this._chkAutoShowTaskLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkAutoShowTaskLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._chkAutoShowTaskLog.ForeColor = System.Drawing.Color.White;
            this._chkAutoShowTaskLog.Location = new System.Drawing.Point(14, 87);
            this._chkAutoShowTaskLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._chkAutoShowTaskLog.Name = "_chkAutoShowTaskLog";
            this._chkAutoShowTaskLog.Size = new System.Drawing.Size(315, 36);
            this._chkAutoShowTaskLog.TabIndex = 15;
            this._chkAutoShowTaskLog.Text = "Show log on close && reset";
            this._chkAutoShowTaskLog.UseVisualStyleBackColor = true;
            // 
            // _grpBoxGeneralSettings
            // 
            this._grpBoxGeneralSettings.Controls.Add(this._txtMaxBillableDailyHoursPlaceholder);
            this._grpBoxGeneralSettings.Controls.Add(this._txtFixedDailyCostPlaceholder);
            this._grpBoxGeneralSettings.Controls.Add(this._txtHourlyRatePlaceholder);
            this._grpBoxGeneralSettings.Controls.Add(this._lblHourlyRate);
            this._grpBoxGeneralSettings.Controls.Add(this._lblFixedDailyCost);
            this._grpBoxGeneralSettings.Controls.Add(this._lblMaxBillableDailyHours);
            this._grpBoxGeneralSettings.Controls.Add(this._lblCurrencySymbol);
            this._grpBoxGeneralSettings.Controls.Add(this._txtCurrencySymbol);
            this._grpBoxGeneralSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._grpBoxGeneralSettings.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._grpBoxGeneralSettings.ForeColor = System.Drawing.Color.White;
            this._grpBoxGeneralSettings.Location = new System.Drawing.Point(41, 53);
            this._grpBoxGeneralSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._grpBoxGeneralSettings.Name = "_grpBoxGeneralSettings";
            this._grpBoxGeneralSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._grpBoxGeneralSettings.Size = new System.Drawing.Size(396, 218);
            this._grpBoxGeneralSettings.TabIndex = 0;
            this._grpBoxGeneralSettings.TabStop = false;
            this._grpBoxGeneralSettings.Text = "General settings";
            // 
            // _txtMaxBillableDailyHoursPlaceholder
            // 
            this._txtMaxBillableDailyHoursPlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._txtMaxBillableDailyHoursPlaceholder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtMaxBillableDailyHoursPlaceholder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtMaxBillableDailyHoursPlaceholder.ForeColor = System.Drawing.Color.White;
            this._txtMaxBillableDailyHoursPlaceholder.Location = new System.Drawing.Point(297, 120);
            this._txtMaxBillableDailyHoursPlaceholder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtMaxBillableDailyHoursPlaceholder.MaxLength = 3;
            this._txtMaxBillableDailyHoursPlaceholder.Name = "_txtMaxBillableDailyHoursPlaceholder";
            this._txtMaxBillableDailyHoursPlaceholder.Size = new System.Drawing.Size(81, 32);
            this._txtMaxBillableDailyHoursPlaceholder.TabIndex = 103;
            this._txtMaxBillableDailyHoursPlaceholder.TabStop = false;
            this._txtMaxBillableDailyHoursPlaceholder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._txtMaxBillableDailyHoursPlaceholder.Visible = false;
            // 
            // _txtFixedDailyCostPlaceholder
            // 
            this._txtFixedDailyCostPlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._txtFixedDailyCostPlaceholder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtFixedDailyCostPlaceholder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtFixedDailyCostPlaceholder.ForeColor = System.Drawing.Color.White;
            this._txtFixedDailyCostPlaceholder.Location = new System.Drawing.Point(297, 75);
            this._txtFixedDailyCostPlaceholder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtFixedDailyCostPlaceholder.MaxLength = 3;
            this._txtFixedDailyCostPlaceholder.Name = "_txtFixedDailyCostPlaceholder";
            this._txtFixedDailyCostPlaceholder.Size = new System.Drawing.Size(81, 32);
            this._txtFixedDailyCostPlaceholder.TabIndex = 102;
            this._txtFixedDailyCostPlaceholder.TabStop = false;
            this._txtFixedDailyCostPlaceholder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._txtFixedDailyCostPlaceholder.Visible = false;
            // 
            // _txtHourlyRatePlaceholder
            // 
            this._txtHourlyRatePlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._txtHourlyRatePlaceholder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtHourlyRatePlaceholder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtHourlyRatePlaceholder.ForeColor = System.Drawing.Color.White;
            this._txtHourlyRatePlaceholder.Location = new System.Drawing.Point(297, 30);
            this._txtHourlyRatePlaceholder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtHourlyRatePlaceholder.MaxLength = 3;
            this._txtHourlyRatePlaceholder.Name = "_txtHourlyRatePlaceholder";
            this._txtHourlyRatePlaceholder.Size = new System.Drawing.Size(81, 32);
            this._txtHourlyRatePlaceholder.TabIndex = 101;
            this._txtHourlyRatePlaceholder.TabStop = false;
            this._txtHourlyRatePlaceholder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._txtHourlyRatePlaceholder.Visible = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(480, 783);
            this.Controls.Add(this._grpBoxTaskSettings);
            this.Controls.Add(this._grpBoxInterfaceSettings);
            this.Controls.Add(this._grpBoxDeveloperSettings);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._topPanel);
            this.Controls.Add(this._grpBoxGeneralSettings);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Earner Settings";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsFormKeyDown);
            this._topPanel.ResumeLayout(false);
            this._topPanel.PerformLayout();
            this._grpBoxDeveloperSettings.ResumeLayout(false);
            this._grpBoxDeveloperSettings.PerformLayout();
            this._grpBoxInterfaceSettings.ResumeLayout(false);
            this._grpBoxInterfaceSettings.PerformLayout();
            this._grpBoxTaskSettings.ResumeLayout(false);
            this._grpBoxTaskSettings.PerformLayout();
            this._grpBoxGeneralSettings.ResumeLayout(false);
            this._grpBoxGeneralSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel _topPanel;
        private Button _btnClose;
        private Label _lblHourlyRate;
        private Label _lblFixedDailyCost;
        private Label _lblMaxBillableDailyHours;
        private Label _lblCurrencySymbol;
        private Button _btnSave;
        private TextBox _txtCurrencySymbol;
        private Button _btnEditTasks;
        private CheckBox _chkSaveTaskLog;
        private ToolTip _toolTip;
        private CheckBox _chkShowTooltips;
        private CheckBox _chkShowApplicationLogOnErrors;
        private GroupBox _grpBoxDeveloperSettings;
        private GroupBox _grpBoxInterfaceSettings;
        private GroupBox _grpBoxTaskSettings;
        private GroupBox _grpBoxGeneralSettings;
        private CheckBox _chkAutoShowTaskLog;
        private CheckBox _chkAutoStartWithWindows;
        private CheckBox _chkConfirmBeforeClose;
        private Label _lblSettingsHeader;
        private Label _lblShow;
        private CheckBox _chkShowProgressbar;
        private LinkLabel _lnkTaskLogLocation;
        private Button _btnEraseLogRecords;
        private TextBox _txtMaxBillableDailyHoursPlaceholder;
        private TextBox _txtFixedDailyCostPlaceholder;
        private TextBox _txtHourlyRatePlaceholder;
    }
}