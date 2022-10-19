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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this._topPanel = new System.Windows.Forms.Panel();
            this._btnClose = new System.Windows.Forms.Button();
            this._lblHourlyRate = new System.Windows.Forms.Label();
            this._lblFixedDailyCost = new System.Windows.Forms.Label();
            this._lblMaxBillableDailyHours = new System.Windows.Forms.Label();
            this._lblCurrencySymbol = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this._txtHourlyRate = new EarnerUserControls.NumericTextBox();
            this._txtFixedDailyCost = new EarnerUserControls.NumericTextBox();
            this._txtMaxBillableDailyHours = new EarnerUserControls.NumericTextBox();
            this._txtCurrencySymbol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _topPanel
            // 
            this._topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.Location = new System.Drawing.Point(29, 0);
            this._topPanel.Margin = new System.Windows.Forms.Padding(0);
            this._topPanel.Name = "_topPanel";
            this._topPanel.Size = new System.Drawing.Size(242, 29);
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
            this._lblHourlyRate.Location = new System.Drawing.Point(9, 49);
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
            this._lblFixedDailyCost.Location = new System.Drawing.Point(9, 82);
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
            this._lblMaxBillableDailyHours.Location = new System.Drawing.Point(9, 115);
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
            this._lblCurrencySymbol.Location = new System.Drawing.Point(9, 148);
            this._lblCurrencySymbol.Name = "_lblCurrencySymbol";
            this._lblCurrencySymbol.Size = new System.Drawing.Size(133, 21);
            this._lblCurrencySymbol.TabIndex = 100;
            this._lblCurrencySymbol.Text = "Currency Symbol:";
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnSave.BackgroundImage = global::Earner.Properties.Resources.save;
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
            this._btnSave.Location = new System.Drawing.Point(226, 172);
            this._btnSave.Margin = new System.Windows.Forms.Padding(0);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(45, 42);
            this._btnSave.TabIndex = 1;
            this._btnSave.Tag = "";
            this._btnSave.UseVisualStyleBackColor = false;
            this._btnSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // _txtHourlyRate
            // 
            this._txtHourlyRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._txtHourlyRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtHourlyRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._txtHourlyRate.ForeColor = System.Drawing.Color.White;
            this._txtHourlyRate.Location = new System.Drawing.Point(196, 51);
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
            this._txtFixedDailyCost.Location = new System.Drawing.Point(196, 82);
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
            this._txtMaxBillableDailyHours.Location = new System.Drawing.Point(196, 115);
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
            this._txtCurrencySymbol.Location = new System.Drawing.Point(196, 147);
            this._txtCurrencySymbol.MaxLength = 3;
            this._txtCurrencySymbol.Name = "_txtCurrencySymbol";
            this._txtCurrencySymbol.Size = new System.Drawing.Size(57, 22);
            this._txtCurrencySymbol.TabIndex = 13;
            this._txtCurrencySymbol.Text = "kr";
            this._txtCurrencySymbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(271, 214);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._txtCurrencySymbol);
            this.Controls.Add(this._txtMaxBillableDailyHours);
            this.Controls.Add(this._txtFixedDailyCost);
            this.Controls.Add(this._txtHourlyRate);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._lblCurrencySymbol);
            this.Controls.Add(this._lblMaxBillableDailyHours);
            this.Controls.Add(this._lblFixedDailyCost);
            this.Controls.Add(this._lblHourlyRate);
            this.Controls.Add(this._topPanel);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}