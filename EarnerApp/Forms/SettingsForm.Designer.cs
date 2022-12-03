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
            this._btnClearAppLog = new System.Windows.Forms.Button();
            this._btnShowAppLog = new System.Windows.Forms.Button();
            this._grpBoxApplicationSettings = new System.Windows.Forms.GroupBox();
            this._btnAbout = new System.Windows.Forms.Button();
            this._chkMinimizeToSystemTray = new System.Windows.Forms.CheckBox();
            this._chkStayOnTop = new System.Windows.Forms.CheckBox();
            this._chkUpdateChecks = new System.Windows.Forms.CheckBox();
            this._chkPlaySounds = new System.Windows.Forms.CheckBox();
            this._lblShow = new System.Windows.Forms.Label();
            this._chkShowProgressbar = new System.Windows.Forms.CheckBox();
            this._chkUseConfirmations = new System.Windows.Forms.CheckBox();
            this._chkAutoStartWithWindows = new System.Windows.Forms.CheckBox();
            this._grpBoxTaskSettings = new System.Windows.Forms.GroupBox();
            this._lnkTaskLogLocation = new System.Windows.Forms.LinkLabel();
            this._btnAdminJsonDb = new System.Windows.Forms.Button();
            this._btnEraseLogRecords = new System.Windows.Forms.Button();
            this._chkAutoShowTaskLog = new System.Windows.Forms.CheckBox();
            this._grpBoxGeneralSettings = new System.Windows.Forms.GroupBox();
            this._txtMaxBillableDailyHoursPlaceholder = new System.Windows.Forms.TextBox();
            this._txtFixedDailyCostPlaceholder = new System.Windows.Forms.TextBox();
            this._txtHourlyRatePlaceholder = new System.Windows.Forms.TextBox();
            this._topPanel.SuspendLayout();
            this._grpBoxDeveloperSettings.SuspendLayout();
            this._grpBoxApplicationSettings.SuspendLayout();
            this._grpBoxTaskSettings.SuspendLayout();
            this._grpBoxGeneralSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // _topPanel
            // 
            this._topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.Controls.Add(this._lblSettingsHeader);
            this._topPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.Location = new System.Drawing.Point(29, 0);
            this._topPanel.Margin = new System.Windows.Forms.Padding(0);
            this._topPanel.Name = "_topPanel";
            this._topPanel.Size = new System.Drawing.Size(309, 29);
            this._topPanel.TabIndex = 500;
            this._topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseDown);
            // 
            // _lblSettingsHeader
            // 
            this._lblSettingsHeader.AutoSize = true;
            this._lblSettingsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblSettingsHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblSettingsHeader.ForeColor = System.Drawing.Color.White;
            this._lblSettingsHeader.Location = new System.Drawing.Point(3, 4);
            this._lblSettingsHeader.Name = "_lblSettingsHeader";
            this._lblSettingsHeader.Size = new System.Drawing.Size(66, 21);
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
            this._btnClose.Size = new System.Drawing.Size(29, 29);
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
            this._lblHourlyRate.Location = new System.Drawing.Point(10, 18);
            this._lblHourlyRate.Name = "_lblHourlyRate";
            this._lblHourlyRate.Size = new System.Drawing.Size(91, 21);
            this._lblHourlyRate.TabIndex = 70;
            this._lblHourlyRate.Text = "Hourly rate:";
            // 
            // _lblFixedDailyCost
            // 
            this._lblFixedDailyCost.AutoSize = true;
            this._lblFixedDailyCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblFixedDailyCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblFixedDailyCost.ForeColor = System.Drawing.Color.White;
            this._lblFixedDailyCost.Location = new System.Drawing.Point(10, 45);
            this._lblFixedDailyCost.Name = "_lblFixedDailyCost";
            this._lblFixedDailyCost.Size = new System.Drawing.Size(118, 21);
            this._lblFixedDailyCost.TabIndex = 80;
            this._lblFixedDailyCost.Text = "Fixed daily cost:";
            // 
            // _lblMaxBillableDailyHours
            // 
            this._lblMaxBillableDailyHours.AutoSize = true;
            this._lblMaxBillableDailyHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblMaxBillableDailyHours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblMaxBillableDailyHours.ForeColor = System.Drawing.Color.White;
            this._lblMaxBillableDailyHours.Location = new System.Drawing.Point(10, 72);
            this._lblMaxBillableDailyHours.Name = "_lblMaxBillableDailyHours";
            this._lblMaxBillableDailyHours.Size = new System.Drawing.Size(177, 21);
            this._lblMaxBillableDailyHours.TabIndex = 90;
            this._lblMaxBillableDailyHours.Text = "Max daily billable hours:";
            // 
            // _lblCurrencySymbol
            // 
            this._lblCurrencySymbol.AutoSize = true;
            this._lblCurrencySymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblCurrencySymbol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblCurrencySymbol.ForeColor = System.Drawing.Color.White;
            this._lblCurrencySymbol.Location = new System.Drawing.Point(10, 99);
            this._lblCurrencySymbol.Name = "_lblCurrencySymbol";
            this._lblCurrencySymbol.Size = new System.Drawing.Size(76, 21);
            this._lblCurrencySymbol.TabIndex = 100;
            this._lblCurrencySymbol.Text = "Currency:";
            // 
            // _txtCurrencySymbol
            // 
            this._txtCurrencySymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this._txtCurrencySymbol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtCurrencySymbol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtCurrencySymbol.ForeColor = System.Drawing.Color.White;
            this._txtCurrencySymbol.Location = new System.Drawing.Point(208, 99);
            this._txtCurrencySymbol.MaxLength = 3;
            this._txtCurrencySymbol.Name = "_txtCurrencySymbol";
            this._txtCurrencySymbol.Size = new System.Drawing.Size(57, 22);
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
            this._btnSave.Location = new System.Drawing.Point(307, 493);
            this._btnSave.Margin = new System.Windows.Forms.Padding(0);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(29, 29);
            this._btnSave.TabIndex = 32;
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
            this._btnEditTasks.Location = new System.Drawing.Point(236, 17);
            this._btnEditTasks.Margin = new System.Windows.Forms.Padding(0);
            this._btnEditTasks.Name = "_btnEditTasks";
            this._btnEditTasks.Size = new System.Drawing.Size(29, 29);
            this._btnEditTasks.TabIndex = 18;
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
            this._chkSaveTaskLog.Location = new System.Drawing.Point(10, 21);
            this._chkSaveTaskLog.Name = "_chkSaveTaskLog";
            this._chkSaveTaskLog.Size = new System.Drawing.Size(85, 25);
            this._chkSaveTaskLog.TabIndex = 14;
            this._chkSaveTaskLog.Text = "Save log";
            this._chkSaveTaskLog.UseVisualStyleBackColor = true;
            this._chkSaveTaskLog.CheckedChanged += new System.EventHandler(this.SaveTaskLogCheckedChanged);
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
            this._chkShowTooltips.Location = new System.Drawing.Point(58, 23);
            this._chkShowTooltips.Name = "_chkShowTooltips";
            this._chkShowTooltips.Size = new System.Drawing.Size(78, 25);
            this._chkShowTooltips.TabIndex = 20;
            this._chkShowTooltips.Text = "tooltips";
            this._chkShowTooltips.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._chkShowTooltips.UseVisualStyleBackColor = true;
            this._chkShowTooltips.CheckedChanged += new System.EventHandler(this.ShowTooltipsCheckedChanged);
            // 
            // _chkShowApplicationLogOnErrors
            // 
            this._chkShowApplicationLogOnErrors.AutoSize = true;
            this._chkShowApplicationLogOnErrors.Checked = true;
            this._chkShowApplicationLogOnErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkShowApplicationLogOnErrors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkShowApplicationLogOnErrors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._chkShowApplicationLogOnErrors.ForeColor = System.Drawing.Color.White;
            this._chkShowApplicationLogOnErrors.Location = new System.Drawing.Point(10, 21);
            this._chkShowApplicationLogOnErrors.Name = "_chkShowApplicationLogOnErrors";
            this._chkShowApplicationLogOnErrors.Size = new System.Drawing.Size(123, 25);
            this._chkShowApplicationLogOnErrors.TabIndex = 29;
            this._chkShowApplicationLogOnErrors.Text = "Display errors";
            this._chkShowApplicationLogOnErrors.UseVisualStyleBackColor = true;
            this._chkShowApplicationLogOnErrors.CheckedChanged += new System.EventHandler(this.ShowApplicationLogOnErrorsCheckedChanged);
            // 
            // _grpBoxDeveloperSettings
            // 
            this._grpBoxDeveloperSettings.Controls.Add(this._btnClearAppLog);
            this._grpBoxDeveloperSettings.Controls.Add(this._btnShowAppLog);
            this._grpBoxDeveloperSettings.Controls.Add(this._chkShowApplicationLogOnErrors);
            this._grpBoxDeveloperSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._grpBoxDeveloperSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._grpBoxDeveloperSettings.ForeColor = System.Drawing.Color.White;
            this._grpBoxDeveloperSettings.Location = new System.Drawing.Point(29, 434);
            this._grpBoxDeveloperSettings.Name = "_grpBoxDeveloperSettings";
            this._grpBoxDeveloperSettings.Size = new System.Drawing.Size(277, 57);
            this._grpBoxDeveloperSettings.TabIndex = 3;
            this._grpBoxDeveloperSettings.TabStop = false;
            this._grpBoxDeveloperSettings.Text = "Advanced";
            // 
            // _btnClearAppLog
            // 
            this._btnClearAppLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnClearAppLog.BackgroundImage = global::Earner.Properties.Resources.close_48x48;
            this._btnClearAppLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnClearAppLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnClearAppLog.FlatAppearance.BorderSize = 0;
            this._btnClearAppLog.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnClearAppLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnClearAppLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnClearAppLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnClearAppLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnClearAppLog.Location = new System.Drawing.Point(197, 17);
            this._btnClearAppLog.Margin = new System.Windows.Forms.Padding(0);
            this._btnClearAppLog.Name = "_btnClearAppLog";
            this._btnClearAppLog.Size = new System.Drawing.Size(29, 29);
            this._btnClearAppLog.TabIndex = 30;
            this._btnClearAppLog.UseVisualStyleBackColor = false;
            this._btnClearAppLog.Click += new System.EventHandler(this.ClearAppLogClick);
            // 
            // _btnShowAppLog
            // 
            this._btnShowAppLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnShowAppLog.BackgroundImage = global::Earner.Properties.Resources.log;
            this._btnShowAppLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnShowAppLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnShowAppLog.FlatAppearance.BorderSize = 0;
            this._btnShowAppLog.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnShowAppLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnShowAppLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnShowAppLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnShowAppLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnShowAppLog.Location = new System.Drawing.Point(240, 17);
            this._btnShowAppLog.Margin = new System.Windows.Forms.Padding(0);
            this._btnShowAppLog.Name = "_btnShowAppLog";
            this._btnShowAppLog.Size = new System.Drawing.Size(27, 29);
            this._btnShowAppLog.TabIndex = 31;
            this._btnShowAppLog.UseVisualStyleBackColor = false;
            this._btnShowAppLog.Click += new System.EventHandler(this.ShowAppLogClick);
            // 
            // _grpBoxApplicationSettings
            // 
            this._grpBoxApplicationSettings.Controls.Add(this._btnAbout);
            this._grpBoxApplicationSettings.Controls.Add(this._chkMinimizeToSystemTray);
            this._grpBoxApplicationSettings.Controls.Add(this._chkStayOnTop);
            this._grpBoxApplicationSettings.Controls.Add(this._chkUpdateChecks);
            this._grpBoxApplicationSettings.Controls.Add(this._chkPlaySounds);
            this._grpBoxApplicationSettings.Controls.Add(this._lblShow);
            this._grpBoxApplicationSettings.Controls.Add(this._chkShowProgressbar);
            this._grpBoxApplicationSettings.Controls.Add(this._chkUseConfirmations);
            this._grpBoxApplicationSettings.Controls.Add(this._chkAutoStartWithWindows);
            this._grpBoxApplicationSettings.Controls.Add(this._chkShowTooltips);
            this._grpBoxApplicationSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._grpBoxApplicationSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._grpBoxApplicationSettings.ForeColor = System.Drawing.Color.White;
            this._grpBoxApplicationSettings.Location = new System.Drawing.Point(29, 255);
            this._grpBoxApplicationSettings.Name = "_grpBoxApplicationSettings";
            this._grpBoxApplicationSettings.Size = new System.Drawing.Size(277, 175);
            this._grpBoxApplicationSettings.TabIndex = 2;
            this._grpBoxApplicationSettings.TabStop = false;
            this._grpBoxApplicationSettings.Text = "Application";
            // 
            // _btnAbout
            // 
            this._btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnAbout.BackgroundImage = global::Earner.Properties.Resources.info_48x48;
            this._btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnAbout.FlatAppearance.BorderSize = 0;
            this._btnAbout.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnAbout.Location = new System.Drawing.Point(236, 135);
            this._btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this._btnAbout.Name = "_btnAbout";
            this._btnAbout.Size = new System.Drawing.Size(29, 29);
            this._btnAbout.TabIndex = 28;
            this._btnAbout.UseVisualStyleBackColor = false;
            this._btnAbout.Click += new System.EventHandler(this.AboutClick);
            // 
            // _chkMinimizeToSystemTray
            // 
            this._chkMinimizeToSystemTray.AutoSize = true;
            this._chkMinimizeToSystemTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkMinimizeToSystemTray.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._chkMinimizeToSystemTray.ForeColor = System.Drawing.Color.White;
            this._chkMinimizeToSystemTray.Location = new System.Drawing.Point(10, 142);
            this._chkMinimizeToSystemTray.Name = "_chkMinimizeToSystemTray";
            this._chkMinimizeToSystemTray.Size = new System.Drawing.Size(192, 25);
            this._chkMinimizeToSystemTray.TabIndex = 27;
            this._chkMinimizeToSystemTray.Text = "Minimize to system tray";
            this._chkMinimizeToSystemTray.UseVisualStyleBackColor = true;
            this._chkMinimizeToSystemTray.CheckedChanged += new System.EventHandler(this.MinimizeToSystemTrayCheckedChanged);
            // 
            // _chkStayOnTop
            // 
            this._chkStayOnTop.AutoSize = true;
            this._chkStayOnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkStayOnTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._chkStayOnTop.ForeColor = System.Drawing.Color.White;
            this._chkStayOnTop.Location = new System.Drawing.Point(10, 112);
            this._chkStayOnTop.Name = "_chkStayOnTop";
            this._chkStayOnTop.Size = new System.Drawing.Size(173, 25);
            this._chkStayOnTop.TabIndex = 26;
            this._chkStayOnTop.Text = "Place Earner topmost";
            this._chkStayOnTop.UseVisualStyleBackColor = true;
            this._chkStayOnTop.CheckedChanged += new System.EventHandler(this.StayOnTopCheckedChanged);
            // 
            // _chkUpdateChecks
            // 
            this._chkUpdateChecks.AutoSize = true;
            this._chkUpdateChecks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkUpdateChecks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._chkUpdateChecks.ForeColor = System.Drawing.Color.White;
            this._chkUpdateChecks.Location = new System.Drawing.Point(140, 82);
            this._chkUpdateChecks.Name = "_chkUpdateChecks";
            this._chkUpdateChecks.Size = new System.Drawing.Size(126, 25);
            this._chkUpdateChecks.TabIndex = 25;
            this._chkUpdateChecks.Text = "Update checks";
            this._chkUpdateChecks.UseVisualStyleBackColor = true;
            this._chkUpdateChecks.CheckedChanged += new System.EventHandler(this.UpdateChecksCheckedChanged);
            // 
            // _chkPlaySounds
            // 
            this._chkPlaySounds.AutoSize = true;
            this._chkPlaySounds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkPlaySounds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._chkPlaySounds.ForeColor = System.Drawing.Color.White;
            this._chkPlaySounds.Location = new System.Drawing.Point(140, 52);
            this._chkPlaySounds.Name = "_chkPlaySounds";
            this._chkPlaySounds.Size = new System.Drawing.Size(106, 25);
            this._chkPlaySounds.TabIndex = 23;
            this._chkPlaySounds.Text = "Use sounds";
            this._chkPlaySounds.UseVisualStyleBackColor = true;
            this._chkPlaySounds.CheckedChanged += new System.EventHandler(this.PlaySoundsCheckedChanged);
            // 
            // _lblShow
            // 
            this._lblShow.AutoSize = true;
            this._lblShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblShow.Location = new System.Drawing.Point(6, 24);
            this._lblShow.Name = "_lblShow";
            this._lblShow.Size = new System.Drawing.Size(49, 21);
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
            this._chkShowProgressbar.Location = new System.Drawing.Point(140, 23);
            this._chkShowProgressbar.Name = "_chkShowProgressbar";
            this._chkShowProgressbar.Size = new System.Drawing.Size(114, 25);
            this._chkShowProgressbar.TabIndex = 21;
            this._chkShowProgressbar.Text = "progress bar";
            this._chkShowProgressbar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._chkShowProgressbar.UseVisualStyleBackColor = true;
            this._chkShowProgressbar.CheckedChanged += new System.EventHandler(this.ShowProgressbarCheckedChanged);
            // 
            // _chkUseConfirmations
            // 
            this._chkUseConfirmations.AutoSize = true;
            this._chkUseConfirmations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkUseConfirmations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._chkUseConfirmations.ForeColor = System.Drawing.Color.White;
            this._chkUseConfirmations.Location = new System.Drawing.Point(10, 82);
            this._chkUseConfirmations.Name = "_chkUseConfirmations";
            this._chkUseConfirmations.Size = new System.Drawing.Size(125, 25);
            this._chkUseConfirmations.TabIndex = 24;
            this._chkUseConfirmations.Text = "Confirmations";
            this._chkUseConfirmations.UseVisualStyleBackColor = true;
            this._chkUseConfirmations.CheckedChanged += new System.EventHandler(this.UseConfirmationsCheckedChanged);
            // 
            // _chkAutoStartWithWindows
            // 
            this._chkAutoStartWithWindows.AutoSize = true;
            this._chkAutoStartWithWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkAutoStartWithWindows.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._chkAutoStartWithWindows.ForeColor = System.Drawing.Color.White;
            this._chkAutoStartWithWindows.Location = new System.Drawing.Point(10, 52);
            this._chkAutoStartWithWindows.Name = "_chkAutoStartWithWindows";
            this._chkAutoStartWithWindows.Size = new System.Drawing.Size(124, 25);
            this._chkAutoStartWithWindows.TabIndex = 22;
            this._chkAutoStartWithWindows.Text = "Run at startup";
            this._chkAutoStartWithWindows.UseVisualStyleBackColor = true;
            this._chkAutoStartWithWindows.CheckedChanged += new System.EventHandler(this.AutoStartWithWindowsCheckedChanged);
            // 
            // _grpBoxTaskSettings
            // 
            this._grpBoxTaskSettings.Controls.Add(this._lnkTaskLogLocation);
            this._grpBoxTaskSettings.Controls.Add(this._btnAdminJsonDb);
            this._grpBoxTaskSettings.Controls.Add(this._btnEraseLogRecords);
            this._grpBoxTaskSettings.Controls.Add(this._chkAutoShowTaskLog);
            this._grpBoxTaskSettings.Controls.Add(this._chkSaveTaskLog);
            this._grpBoxTaskSettings.Controls.Add(this._btnEditTasks);
            this._grpBoxTaskSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._grpBoxTaskSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._grpBoxTaskSettings.ForeColor = System.Drawing.Color.White;
            this._grpBoxTaskSettings.Location = new System.Drawing.Point(29, 164);
            this._grpBoxTaskSettings.Name = "_grpBoxTaskSettings";
            this._grpBoxTaskSettings.Size = new System.Drawing.Size(277, 87);
            this._grpBoxTaskSettings.TabIndex = 1;
            this._grpBoxTaskSettings.TabStop = false;
            this._grpBoxTaskSettings.Text = "Tasks && log";
            // 
            // _lnkTaskLogLocation
            // 
            this._lnkTaskLogLocation.ActiveLinkColor = System.Drawing.Color.White;
            this._lnkTaskLogLocation.AutoSize = true;
            this._lnkTaskLogLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lnkTaskLogLocation.LinkColor = System.Drawing.Color.White;
            this._lnkTaskLogLocation.Location = new System.Drawing.Point(90, 23);
            this._lnkTaskLogLocation.Name = "_lnkTaskLogLocation";
            this._lnkTaskLogLocation.Size = new System.Drawing.Size(41, 21);
            this._lnkTaskLogLocation.TabIndex = 15;
            this._lnkTaskLogLocation.TabStop = true;
            this._lnkTaskLogLocation.Text = "here";
            this._lnkTaskLogLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lnkTaskLogLocation.VisitedLinkColor = System.Drawing.Color.White;
            this._lnkTaskLogLocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TaskLogLocationLinkClicked);
            // 
            // _btnAdminJsonDb
            // 
            this._btnAdminJsonDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAdminJsonDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnAdminJsonDb.BackgroundImage = global::Earner.Properties.Resources.database_48x48;
            this._btnAdminJsonDb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnAdminJsonDb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnAdminJsonDb.FlatAppearance.BorderSize = 0;
            this._btnAdminJsonDb.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnAdminJsonDb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnAdminJsonDb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnAdminJsonDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAdminJsonDb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnAdminJsonDb.Location = new System.Drawing.Point(158, 17);
            this._btnAdminJsonDb.Margin = new System.Windows.Forms.Padding(0);
            this._btnAdminJsonDb.Name = "_btnAdminJsonDb";
            this._btnAdminJsonDb.Size = new System.Drawing.Size(29, 29);
            this._btnAdminJsonDb.TabIndex = 16;
            this._btnAdminJsonDb.Tag = "";
            this._btnAdminJsonDb.UseVisualStyleBackColor = false;
            this._btnAdminJsonDb.Click += new System.EventHandler(this.AdminJsonDbClick);
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
            this._btnEraseLogRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnEraseLogRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnEraseLogRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnEraseLogRecords.Location = new System.Drawing.Point(197, 17);
            this._btnEraseLogRecords.Margin = new System.Windows.Forms.Padding(0);
            this._btnEraseLogRecords.Name = "_btnEraseLogRecords";
            this._btnEraseLogRecords.Size = new System.Drawing.Size(29, 29);
            this._btnEraseLogRecords.TabIndex = 17;
            this._btnEraseLogRecords.UseVisualStyleBackColor = false;
            this._btnEraseLogRecords.Click += new System.EventHandler(this.EraseLogRecordsClick);
            // 
            // _chkAutoShowTaskLog
            // 
            this._chkAutoShowTaskLog.AutoSize = true;
            this._chkAutoShowTaskLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkAutoShowTaskLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._chkAutoShowTaskLog.ForeColor = System.Drawing.Color.White;
            this._chkAutoShowTaskLog.Location = new System.Drawing.Point(10, 52);
            this._chkAutoShowTaskLog.Name = "_chkAutoShowTaskLog";
            this._chkAutoShowTaskLog.Size = new System.Drawing.Size(207, 25);
            this._chkAutoShowTaskLog.TabIndex = 19;
            this._chkAutoShowTaskLog.Text = "Show log on close && reset";
            this._chkAutoShowTaskLog.UseVisualStyleBackColor = true;
            this._chkAutoShowTaskLog.CheckedChanged += new System.EventHandler(this.AutoShowTaskLogCheckedChanged);
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
            this._grpBoxGeneralSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._grpBoxGeneralSettings.ForeColor = System.Drawing.Color.White;
            this._grpBoxGeneralSettings.Location = new System.Drawing.Point(29, 29);
            this._grpBoxGeneralSettings.Name = "_grpBoxGeneralSettings";
            this._grpBoxGeneralSettings.Size = new System.Drawing.Size(277, 131);
            this._grpBoxGeneralSettings.TabIndex = 0;
            this._grpBoxGeneralSettings.TabStop = false;
            this._grpBoxGeneralSettings.Text = "General";
            // 
            // _txtMaxBillableDailyHoursPlaceholder
            // 
            this._txtMaxBillableDailyHoursPlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this._txtMaxBillableDailyHoursPlaceholder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtMaxBillableDailyHoursPlaceholder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtMaxBillableDailyHoursPlaceholder.ForeColor = System.Drawing.Color.White;
            this._txtMaxBillableDailyHoursPlaceholder.Location = new System.Drawing.Point(208, 72);
            this._txtMaxBillableDailyHoursPlaceholder.MaxLength = 3;
            this._txtMaxBillableDailyHoursPlaceholder.Name = "_txtMaxBillableDailyHoursPlaceholder";
            this._txtMaxBillableDailyHoursPlaceholder.Size = new System.Drawing.Size(57, 22);
            this._txtMaxBillableDailyHoursPlaceholder.TabIndex = 103;
            this._txtMaxBillableDailyHoursPlaceholder.TabStop = false;
            this._txtMaxBillableDailyHoursPlaceholder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._txtMaxBillableDailyHoursPlaceholder.Visible = false;
            // 
            // _txtFixedDailyCostPlaceholder
            // 
            this._txtFixedDailyCostPlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this._txtFixedDailyCostPlaceholder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtFixedDailyCostPlaceholder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtFixedDailyCostPlaceholder.ForeColor = System.Drawing.Color.White;
            this._txtFixedDailyCostPlaceholder.Location = new System.Drawing.Point(208, 45);
            this._txtFixedDailyCostPlaceholder.MaxLength = 3;
            this._txtFixedDailyCostPlaceholder.Name = "_txtFixedDailyCostPlaceholder";
            this._txtFixedDailyCostPlaceholder.Size = new System.Drawing.Size(57, 22);
            this._txtFixedDailyCostPlaceholder.TabIndex = 102;
            this._txtFixedDailyCostPlaceholder.TabStop = false;
            this._txtFixedDailyCostPlaceholder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._txtFixedDailyCostPlaceholder.Visible = false;
            // 
            // _txtHourlyRatePlaceholder
            // 
            this._txtHourlyRatePlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this._txtHourlyRatePlaceholder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtHourlyRatePlaceholder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtHourlyRatePlaceholder.ForeColor = System.Drawing.Color.White;
            this._txtHourlyRatePlaceholder.Location = new System.Drawing.Point(208, 18);
            this._txtHourlyRatePlaceholder.MaxLength = 3;
            this._txtHourlyRatePlaceholder.Name = "_txtHourlyRatePlaceholder";
            this._txtHourlyRatePlaceholder.Size = new System.Drawing.Size(57, 22);
            this._txtHourlyRatePlaceholder.TabIndex = 101;
            this._txtHourlyRatePlaceholder.TabStop = false;
            this._txtHourlyRatePlaceholder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._txtHourlyRatePlaceholder.Visible = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(336, 522);
            this.Controls.Add(this._grpBoxTaskSettings);
            this.Controls.Add(this._grpBoxApplicationSettings);
            this.Controls.Add(this._grpBoxDeveloperSettings);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._topPanel);
            this.Controls.Add(this._grpBoxGeneralSettings);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(1);
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
            this._grpBoxApplicationSettings.ResumeLayout(false);
            this._grpBoxApplicationSettings.PerformLayout();
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
        private GroupBox _grpBoxApplicationSettings;
        private GroupBox _grpBoxTaskSettings;
        private GroupBox _grpBoxGeneralSettings;
        private CheckBox _chkAutoShowTaskLog;
        private CheckBox _chkAutoStartWithWindows;
        private CheckBox _chkUseConfirmations;
        private Label _lblSettingsHeader;
        private Label _lblShow;
        private CheckBox _chkShowProgressbar;
        private LinkLabel _lnkTaskLogLocation;
        private Button _btnEraseLogRecords;
        private TextBox _txtMaxBillableDailyHoursPlaceholder;
        private TextBox _txtFixedDailyCostPlaceholder;
        private TextBox _txtHourlyRatePlaceholder;
        private Button _btnAbout;
        private Button _btnAdminJsonDb;
        private Button _btnShowAppLog;
        private Button _btnClearAppLog;
        private CheckBox _chkPlaySounds;
        private CheckBox _chkUpdateChecks;
        private CheckBox _chkStayOnTop;
        private CheckBox _chkMinimizeToSystemTray;
    }
}