using EarnerUserControls;

namespace Earner
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
            this._btnClose = new System.Windows.Forms.Button();
            this._lblHourlyRate = new System.Windows.Forms.Label();
            this._lblFixedDailyCost = new System.Windows.Forms.Label();
            this._lblMaxBillableDailyHours = new System.Windows.Forms.Label();
            this._lblCurrencySymbol = new System.Windows.Forms.Label();
            this._txtHourlyRate = new EarnerUserControls.NumericTextBox();
            this._txtFixedDailyCost = new EarnerUserControls.NumericTextBox();
            this._txtMaxBillableDailyHours = new EarnerUserControls.NumericTextBox();
            this._txtCurrencySymbol = new System.Windows.Forms.TextBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnEditTasks = new System.Windows.Forms.Button();
            this._chkSaveTaskLog = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._chkShowTooltips = new System.Windows.Forms.CheckBox();
            this._chkShowApplicationLogOnErrors = new System.Windows.Forms.CheckBox();
            this._grpBoxDeveloperSettings = new System.Windows.Forms.GroupBox();
            this._grpBoxInterfaceSettings = new System.Windows.Forms.GroupBox();
            this._grpBoxTaskSettings = new System.Windows.Forms.GroupBox();
            this._grpBoxGeneralSettings = new System.Windows.Forms.GroupBox();
            this._grpBoxDeveloperSettings.SuspendLayout();
            this._grpBoxInterfaceSettings.SuspendLayout();
            this._grpBoxTaskSettings.SuspendLayout();
            this._grpBoxGeneralSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // _topPanel
            // 
            this._topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.Location = new System.Drawing.Point(29, 0);
            this._topPanel.Margin = new System.Windows.Forms.Padding(0);
            this._topPanel.Name = "_topPanel";
            this._topPanel.Size = new System.Drawing.Size(322, 29);
            this._topPanel.TabIndex = 500;
            this._topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseDown);
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
            this._lblHourlyRate.Location = new System.Drawing.Point(10, 27);
            this._lblHourlyRate.Name = "_lblHourlyRate";
            this._lblHourlyRate.Size = new System.Drawing.Size(95, 21);
            this._lblHourlyRate.TabIndex = 70;
            this._lblHourlyRate.Text = "Hourly Rate:";
            // 
            // _lblFixedDailyCost
            // 
            this._lblFixedDailyCost.AutoSize = true;
            this._lblFixedDailyCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblFixedDailyCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblFixedDailyCost.ForeColor = System.Drawing.Color.White;
            this._lblFixedDailyCost.Location = new System.Drawing.Point(10, 59);
            this._lblFixedDailyCost.Name = "_lblFixedDailyCost";
            this._lblFixedDailyCost.Size = new System.Drawing.Size(123, 21);
            this._lblFixedDailyCost.TabIndex = 80;
            this._lblFixedDailyCost.Text = "Fixed Daily Cost:";
            // 
            // _lblMaxBillableDailyHours
            // 
            this._lblMaxBillableDailyHours.AutoSize = true;
            this._lblMaxBillableDailyHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblMaxBillableDailyHours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblMaxBillableDailyHours.ForeColor = System.Drawing.Color.White;
            this._lblMaxBillableDailyHours.Location = new System.Drawing.Point(10, 91);
            this._lblMaxBillableDailyHours.Name = "_lblMaxBillableDailyHours";
            this._lblMaxBillableDailyHours.Size = new System.Drawing.Size(181, 21);
            this._lblMaxBillableDailyHours.TabIndex = 90;
            this._lblMaxBillableDailyHours.Text = "Max Billable Daily Hours:";
            // 
            // _lblCurrencySymbol
            // 
            this._lblCurrencySymbol.AutoSize = true;
            this._lblCurrencySymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblCurrencySymbol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblCurrencySymbol.ForeColor = System.Drawing.Color.White;
            this._lblCurrencySymbol.Location = new System.Drawing.Point(10, 123);
            this._lblCurrencySymbol.Name = "_lblCurrencySymbol";
            this._lblCurrencySymbol.Size = new System.Drawing.Size(76, 21);
            this._lblCurrencySymbol.TabIndex = 100;
            this._lblCurrencySymbol.Text = "Currency:";
            // 
            // _txtHourlyRate
            // 
            this._txtHourlyRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._txtHourlyRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtHourlyRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtHourlyRate.ForeColor = System.Drawing.Color.White;
            this._txtHourlyRate.Location = new System.Drawing.Point(208, 27);
            this._txtHourlyRate.MaxLength = 5;
            this._txtHourlyRate.Name = "_txtHourlyRate";
            this._txtHourlyRate.Size = new System.Drawing.Size(57, 22);
            this._txtHourlyRate.TabIndex = 10;
            this._txtHourlyRate.Text = "1000";
            this._txtHourlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _txtFixedDailyCost
            // 
            this._txtFixedDailyCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._txtFixedDailyCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtFixedDailyCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtFixedDailyCost.ForeColor = System.Drawing.Color.White;
            this._txtFixedDailyCost.Location = new System.Drawing.Point(208, 59);
            this._txtFixedDailyCost.MaxLength = 5;
            this._txtFixedDailyCost.Name = "_txtFixedDailyCost";
            this._txtFixedDailyCost.Size = new System.Drawing.Size(57, 22);
            this._txtFixedDailyCost.TabIndex = 11;
            this._txtFixedDailyCost.Text = "200";
            this._txtFixedDailyCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _txtMaxBillableDailyHours
            // 
            this._txtMaxBillableDailyHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._txtMaxBillableDailyHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtMaxBillableDailyHours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtMaxBillableDailyHours.ForeColor = System.Drawing.Color.White;
            this._txtMaxBillableDailyHours.Location = new System.Drawing.Point(208, 91);
            this._txtMaxBillableDailyHours.MaxLength = 5;
            this._txtMaxBillableDailyHours.Name = "_txtMaxBillableDailyHours";
            this._txtMaxBillableDailyHours.Size = new System.Drawing.Size(57, 22);
            this._txtMaxBillableDailyHours.TabIndex = 12;
            this._txtMaxBillableDailyHours.Text = "8";
            this._txtMaxBillableDailyHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _txtCurrencySymbol
            // 
            this._txtCurrencySymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._txtCurrencySymbol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtCurrencySymbol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtCurrencySymbol.ForeColor = System.Drawing.Color.White;
            this._txtCurrencySymbol.Location = new System.Drawing.Point(208, 123);
            this._txtCurrencySymbol.MaxLength = 3;
            this._txtCurrencySymbol.Name = "_txtCurrencySymbol";
            this._txtCurrencySymbol.Size = new System.Drawing.Size(57, 22);
            this._txtCurrencySymbol.TabIndex = 13;
            this._txtCurrencySymbol.Text = "kr";
            this._txtCurrencySymbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this._btnSave.Location = new System.Drawing.Point(311, 427);
            this._btnSave.Margin = new System.Windows.Forms.Padding(0);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(29, 29);
            this._btnSave.TabIndex = 1;
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
            this._btnEditTasks.Location = new System.Drawing.Point(236, 21);
            this._btnEditTasks.Margin = new System.Windows.Forms.Padding(0);
            this._btnEditTasks.Name = "_btnEditTasks";
            this._btnEditTasks.Size = new System.Drawing.Size(29, 29);
            this._btnEditTasks.TabIndex = 602;
            this._btnEditTasks.TabStop = false;
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
            this._chkSaveTaskLog.Size = new System.Drawing.Size(117, 25);
            this._chkSaveTaskLog.TabIndex = 603;
            this._chkSaveTaskLog.Text = "Save task log";
            this._chkSaveTaskLog.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.toolTip.ForeColor = System.Drawing.Color.White;
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Info";
            // 
            // _chkShowTooltips
            // 
            this._chkShowTooltips.AutoSize = true;
            this._chkShowTooltips.Checked = true;
            this._chkShowTooltips.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkShowTooltips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._chkShowTooltips.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._chkShowTooltips.ForeColor = System.Drawing.Color.White;
            this._chkShowTooltips.Location = new System.Drawing.Point(10, 22);
            this._chkShowTooltips.Name = "_chkShowTooltips";
            this._chkShowTooltips.Size = new System.Drawing.Size(121, 25);
            this._chkShowTooltips.TabIndex = 604;
            this._chkShowTooltips.Text = "Show tooltips";
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
            this._chkShowApplicationLogOnErrors.Location = new System.Drawing.Point(10, 21);
            this._chkShowApplicationLogOnErrors.Name = "_chkShowApplicationLogOnErrors";
            this._chkShowApplicationLogOnErrors.Size = new System.Drawing.Size(239, 25);
            this._chkShowApplicationLogOnErrors.TabIndex = 605;
            this._chkShowApplicationLogOnErrors.Text = "Show application log on errors";
            this._chkShowApplicationLogOnErrors.UseVisualStyleBackColor = true;
            // 
            // _grpBoxDeveloperSettings
            // 
            this._grpBoxDeveloperSettings.Controls.Add(this._chkShowApplicationLogOnErrors);
            this._grpBoxDeveloperSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._grpBoxDeveloperSettings.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._grpBoxDeveloperSettings.ForeColor = System.Drawing.Color.White;
            this._grpBoxDeveloperSettings.Location = new System.Drawing.Point(30, 355);
            this._grpBoxDeveloperSettings.Name = "_grpBoxDeveloperSettings";
            this._grpBoxDeveloperSettings.Size = new System.Drawing.Size(277, 68);
            this._grpBoxDeveloperSettings.TabIndex = 606;
            this._grpBoxDeveloperSettings.TabStop = false;
            this._grpBoxDeveloperSettings.Text = "Developer settings";
            // 
            // _grpBoxInterfaceSettings
            // 
            this._grpBoxInterfaceSettings.Controls.Add(this._chkShowTooltips);
            this._grpBoxInterfaceSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._grpBoxInterfaceSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._grpBoxInterfaceSettings.ForeColor = System.Drawing.Color.White;
            this._grpBoxInterfaceSettings.Location = new System.Drawing.Point(30, 281);
            this._grpBoxInterfaceSettings.Name = "_grpBoxInterfaceSettings";
            this._grpBoxInterfaceSettings.Size = new System.Drawing.Size(277, 68);
            this._grpBoxInterfaceSettings.TabIndex = 607;
            this._grpBoxInterfaceSettings.TabStop = false;
            this._grpBoxInterfaceSettings.Text = "Interface settings";
            // 
            // _grpBoxTaskSettings
            // 
            this._grpBoxTaskSettings.Controls.Add(this._chkSaveTaskLog);
            this._grpBoxTaskSettings.Controls.Add(this._btnEditTasks);
            this._grpBoxTaskSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._grpBoxTaskSettings.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._grpBoxTaskSettings.ForeColor = System.Drawing.Color.White;
            this._grpBoxTaskSettings.Location = new System.Drawing.Point(30, 207);
            this._grpBoxTaskSettings.Name = "_grpBoxTaskSettings";
            this._grpBoxTaskSettings.Size = new System.Drawing.Size(277, 68);
            this._grpBoxTaskSettings.TabIndex = 608;
            this._grpBoxTaskSettings.TabStop = false;
            this._grpBoxTaskSettings.Text = "Task settings";
            // 
            // _grpBoxGeneralSettings
            // 
            this._grpBoxGeneralSettings.Controls.Add(this._lblHourlyRate);
            this._grpBoxGeneralSettings.Controls.Add(this._lblFixedDailyCost);
            this._grpBoxGeneralSettings.Controls.Add(this._lblMaxBillableDailyHours);
            this._grpBoxGeneralSettings.Controls.Add(this._lblCurrencySymbol);
            this._grpBoxGeneralSettings.Controls.Add(this._txtCurrencySymbol);
            this._grpBoxGeneralSettings.Controls.Add(this._txtMaxBillableDailyHours);
            this._grpBoxGeneralSettings.Controls.Add(this._txtHourlyRate);
            this._grpBoxGeneralSettings.Controls.Add(this._txtFixedDailyCost);
            this._grpBoxGeneralSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._grpBoxGeneralSettings.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._grpBoxGeneralSettings.ForeColor = System.Drawing.Color.White;
            this._grpBoxGeneralSettings.Location = new System.Drawing.Point(30, 32);
            this._grpBoxGeneralSettings.Name = "_grpBoxGeneralSettings";
            this._grpBoxGeneralSettings.Size = new System.Drawing.Size(277, 169);
            this._grpBoxGeneralSettings.TabIndex = 609;
            this._grpBoxGeneralSettings.TabStop = false;
            this._grpBoxGeneralSettings.Text = "General settings";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(349, 465);
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
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Earner Settings";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Cyan;
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
        private NumericTextBox _txtFixedDailyCost;
        private NumericTextBox _txtMaxBillableDailyHours;
        private TextBox _txtCurrencySymbol;
        private NumericTextBox _txtHourlyRate;
        private Button _btnEditTasks;
        private CheckBox _chkSaveTaskLog;
        private ToolTip toolTip;
        private CheckBox _chkShowTooltips;
        private CheckBox _chkShowApplicationLogOnErrors;
        private GroupBox _grpBoxDeveloperSettings;
        private GroupBox _grpBoxInterfaceSettings;
        private GroupBox _grpBoxTaskSettings;
        private GroupBox _grpBoxGeneralSettings;
    }
}