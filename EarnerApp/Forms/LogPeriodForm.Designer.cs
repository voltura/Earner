namespace Earner.Forms
{
    partial class LogPeriodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogPeriodForm));
            this._topPanel = new System.Windows.Forms.Panel();
            this._lblSelectHeader = new System.Windows.Forms.Label();
            this._btnDay = new System.Windows.Forms.Button();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._picBoxLogPeriodHeader = new System.Windows.Forms.PictureBox();
            this._btnMonth = new System.Windows.Forms.Button();
            this._btnYear = new System.Windows.Forms.Button();
            this._btnAll = new System.Windows.Forms.Button();
            this._btnThisWeek = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picBoxLogPeriodHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // _topPanel
            // 
            this._topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.Controls.Add(this._lblSelectHeader);
            this._topPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.Location = new System.Drawing.Point(29, 0);
            this._topPanel.Margin = new System.Windows.Forms.Padding(0);
            this._topPanel.Name = "_topPanel";
            this._topPanel.Size = new System.Drawing.Size(242, 30);
            this._topPanel.TabIndex = 5;
            this._topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseDown);
            // 
            // _lblSelectHeader
            // 
            this._lblSelectHeader.AutoSize = true;
            this._lblSelectHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblSelectHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblSelectHeader.ForeColor = System.Drawing.Color.White;
            this._lblSelectHeader.Location = new System.Drawing.Point(4, 4);
            this._lblSelectHeader.Name = "_lblSelectHeader";
            this._lblSelectHeader.Size = new System.Drawing.Size(146, 21);
            this._lblSelectHeader.TabIndex = 91;
            this._lblSelectHeader.Text = "Please select period";
            this._lblSelectHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseDown);
            // 
            // _btnDay
            // 
            this._btnDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnDay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnDay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnDay.FlatAppearance.BorderSize = 0;
            this._btnDay.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnDay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnDay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnDay.ForeColor = System.Drawing.Color.White;
            this._btnDay.Location = new System.Drawing.Point(0, 59);
            this._btnDay.Margin = new System.Windows.Forms.Padding(0);
            this._btnDay.Name = "_btnDay";
            this._btnDay.Size = new System.Drawing.Size(271, 29);
            this._btnDay.TabIndex = 0;
            this._btnDay.Tag = "";
            this._btnDay.Text = "Today";
            this._btnDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnDay.UseVisualStyleBackColor = false;
            this._btnDay.Click += new System.EventHandler(this.DayClick);
            // 
            // _toolTip
            // 
            this._toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._toolTip.ForeColor = System.Drawing.Color.White;
            this._toolTip.IsBalloon = true;
            this._toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this._toolTip.ToolTipTitle = "Info";
            // 
            // _picBoxLogPeriodHeader
            // 
            this._picBoxLogPeriodHeader.BackgroundImage = global::Earner.Properties.Resources.check_48x48;
            this._picBoxLogPeriodHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._picBoxLogPeriodHeader.Location = new System.Drawing.Point(0, 0);
            this._picBoxLogPeriodHeader.Name = "_picBoxLogPeriodHeader";
            this._picBoxLogPeriodHeader.Size = new System.Drawing.Size(29, 29);
            this._picBoxLogPeriodHeader.TabIndex = 7;
            this._picBoxLogPeriodHeader.TabStop = false;
            this._picBoxLogPeriodHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseDown);
            // 
            // _btnMonth
            // 
            this._btnMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnMonth.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnMonth.FlatAppearance.BorderSize = 0;
            this._btnMonth.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnMonth.ForeColor = System.Drawing.Color.White;
            this._btnMonth.Location = new System.Drawing.Point(0, 117);
            this._btnMonth.Margin = new System.Windows.Forms.Padding(0);
            this._btnMonth.Name = "_btnMonth";
            this._btnMonth.Size = new System.Drawing.Size(271, 29);
            this._btnMonth.TabIndex = 1;
            this._btnMonth.Tag = "";
            this._btnMonth.Text = "This month";
            this._btnMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnMonth.UseVisualStyleBackColor = false;
            this._btnMonth.Click += new System.EventHandler(this.MonthClick);
            // 
            // _btnYear
            // 
            this._btnYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnYear.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnYear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnYear.FlatAppearance.BorderSize = 0;
            this._btnYear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnYear.ForeColor = System.Drawing.Color.White;
            this._btnYear.Location = new System.Drawing.Point(0, 146);
            this._btnYear.Margin = new System.Windows.Forms.Padding(0);
            this._btnYear.Name = "_btnYear";
            this._btnYear.Size = new System.Drawing.Size(271, 29);
            this._btnYear.TabIndex = 2;
            this._btnYear.Tag = "";
            this._btnYear.Text = "This year";
            this._btnYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnYear.UseVisualStyleBackColor = false;
            this._btnYear.Click += new System.EventHandler(this.YearClick);
            // 
            // _btnAll
            // 
            this._btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnAll.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnAll.FlatAppearance.BorderSize = 0;
            this._btnAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnAll.ForeColor = System.Drawing.Color.White;
            this._btnAll.Location = new System.Drawing.Point(0, 175);
            this._btnAll.Margin = new System.Windows.Forms.Padding(0);
            this._btnAll.Name = "_btnAll";
            this._btnAll.Size = new System.Drawing.Size(271, 29);
            this._btnAll.TabIndex = 3;
            this._btnAll.Tag = "";
            this._btnAll.Text = "All time";
            this._btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnAll.UseVisualStyleBackColor = false;
            this._btnAll.Click += new System.EventHandler(this.AllClick);
            // 
            // _btnThisWeek
            // 
            this._btnThisWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnThisWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnThisWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnThisWeek.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnThisWeek.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnThisWeek.FlatAppearance.BorderSize = 0;
            this._btnThisWeek.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnThisWeek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnThisWeek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnThisWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnThisWeek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnThisWeek.ForeColor = System.Drawing.Color.White;
            this._btnThisWeek.Location = new System.Drawing.Point(0, 88);
            this._btnThisWeek.Margin = new System.Windows.Forms.Padding(0);
            this._btnThisWeek.Name = "_btnThisWeek";
            this._btnThisWeek.Size = new System.Drawing.Size(271, 29);
            this._btnThisWeek.TabIndex = 8;
            this._btnThisWeek.Tag = "";
            this._btnThisWeek.Text = "This week";
            this._btnThisWeek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnThisWeek.UseVisualStyleBackColor = false;
            this._btnThisWeek.Click += new System.EventHandler(this.ThisWeekClick);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnCancel.FlatAppearance.BorderSize = 0;
            this._btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnCancel.ForeColor = System.Drawing.Color.White;
            this._btnCancel.Location = new System.Drawing.Point(0, 30);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(271, 29);
            this._btnCancel.TabIndex = 9;
            this._btnCancel.Tag = "";
            this._btnCancel.Text = "Cancel";
            this._btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnCancel.UseVisualStyleBackColor = false;
            this._btnCancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // LogPeriodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(271, 207);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnThisWeek);
            this.Controls.Add(this._btnAll);
            this.Controls.Add(this._btnYear);
            this.Controls.Add(this._btnMonth);
            this.Controls.Add(this._picBoxLogPeriodHeader);
            this.Controls.Add(this._btnDay);
            this.Controls.Add(this._topPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "LogPeriodForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Earner - Select period";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogPeriodFormKeyDown);
            this.Resize += new System.EventHandler(this.LogPeriodFormResize);
            this._topPanel.ResumeLayout(false);
            this._topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picBoxLogPeriodHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel _topPanel;
        private Button _btnDay;
        private ToolTip _toolTip;
        private Label _lblSelectHeader;
        private PictureBox _picBoxLogPeriodHeader;
        private Button _btnMonth;
        private Button _btnYear;
        private Button _btnAll;
        private Button _btnThisWeek;
        private Button _btnCancel;
    }
}