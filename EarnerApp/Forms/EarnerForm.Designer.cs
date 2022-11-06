namespace Earner.Forms
{
    partial class EarnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EarnerForm));
            this._lblEarned = new System.Windows.Forms.Label();
            this._btnOptions = new System.Windows.Forms.Button();
            this._btnStart = new System.Windows.Forms.Button();
            this._earnerTimer = new System.Windows.Forms.Timer(this.components);
            this._lblWorkTime = new System.Windows.Forms.Label();
            this._btnHide = new System.Windows.Forms.Button();
            this._topPanel = new System.Windows.Forms.Panel();
            this._btnClose = new System.Windows.Forms.Button();
            this._btnRestart = new System.Windows.Forms.Button();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._btnShowRecords = new System.Windows.Forms.Button();
            this._lblActiveTask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblEarned
            // 
            this._lblEarned.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblEarned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblEarned.Font = new System.Drawing.Font("Segoe UI Light", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblEarned.ForeColor = System.Drawing.Color.White;
            this._lblEarned.Location = new System.Drawing.Point(0, 15);
            this._lblEarned.Margin = new System.Windows.Forms.Padding(0);
            this._lblEarned.Name = "_lblEarned";
            this._lblEarned.Size = new System.Drawing.Size(271, 82);
            this._lblEarned.TabIndex = 0;
            this._lblEarned.Text = "00000kr";
            this._lblEarned.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this._lblEarned.TextChanged += new System.EventHandler(this.ScaleTextChanged);
            // 
            // _btnOptions
            // 
            this._btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnOptions.BackgroundImage = global::Earner.Properties.Resources.cog_48x48;
            this._btnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnOptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnOptions.FlatAppearance.BorderSize = 0;
            this._btnOptions.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnOptions.Location = new System.Drawing.Point(164, 121);
            this._btnOptions.Margin = new System.Windows.Forms.Padding(0);
            this._btnOptions.Name = "_btnOptions";
            this._btnOptions.Size = new System.Drawing.Size(29, 29);
            this._btnOptions.TabIndex = 1;
            this._btnOptions.TabStop = false;
            this._btnOptions.Tag = "Options";
            this._btnOptions.UseVisualStyleBackColor = false;
            this._btnOptions.Click += new System.EventHandler(this.OptionsClick);
            // 
            // _btnStart
            // 
            this._btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnStart.BackgroundImage = global::Earner.Properties.Resources.pause_48x48;
            this._btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnStart.FlatAppearance.BorderSize = 0;
            this._btnStart.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnStart.Location = new System.Drawing.Point(242, 121);
            this._btnStart.Margin = new System.Windows.Forms.Padding(0);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(29, 29);
            this._btnStart.TabIndex = 2;
            this._btnStart.TabStop = false;
            this._btnStart.Tag = "Stop";
            this._btnStart.UseVisualStyleBackColor = false;
            this._btnStart.Click += new System.EventHandler(this.StartStopClick);
            // 
            // _earnerTimer
            // 
            this._earnerTimer.Interval = 1000;
            this._earnerTimer.Tick += new System.EventHandler(this.Tick);
            // 
            // _lblWorkTime
            // 
            this._lblWorkTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblWorkTime.AutoSize = true;
            this._lblWorkTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblWorkTime.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblWorkTime.ForeColor = System.Drawing.Color.White;
            this._lblWorkTime.Location = new System.Drawing.Point(2, 115);
            this._lblWorkTime.Margin = new System.Windows.Forms.Padding(0);
            this._lblWorkTime.Name = "_lblWorkTime";
            this._lblWorkTime.Size = new System.Drawing.Size(122, 41);
            this._lblWorkTime.TabIndex = 3;
            this._lblWorkTime.Text = "00:00:00";
            this._lblWorkTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // _btnHide
            // 
            this._btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnHide.BackgroundImage = global::Earner.Properties.Resources.minimize_48x48;
            this._btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnHide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnHide.FlatAppearance.BorderSize = 0;
            this._btnHide.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnHide.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnHide.Location = new System.Drawing.Point(242, 0);
            this._btnHide.Margin = new System.Windows.Forms.Padding(0);
            this._btnHide.Name = "_btnHide";
            this._btnHide.Size = new System.Drawing.Size(29, 29);
            this._btnHide.TabIndex = 0;
            this._btnHide.TabStop = false;
            this._btnHide.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this._btnHide.UseVisualStyleBackColor = false;
            this._btnHide.Click += new System.EventHandler(this.HideClick);
            // 
            // _topPanel
            // 
            this._topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.Location = new System.Drawing.Point(29, 0);
            this._topPanel.Margin = new System.Windows.Forms.Padding(0);
            this._topPanel.Name = "_topPanel";
            this._topPanel.Size = new System.Drawing.Size(213, 30);
            this._topPanel.TabIndex = 5;
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
            this._btnClose.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnClose.Location = new System.Drawing.Point(0, 0);
            this._btnClose.Margin = new System.Windows.Forms.Padding(0);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(29, 29);
            this._btnClose.TabIndex = 0;
            this._btnClose.TabStop = false;
            this._btnClose.UseVisualStyleBackColor = false;
            this._btnClose.Click += new System.EventHandler(this.CloseClick);
            // 
            // _btnRestart
            // 
            this._btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnRestart.BackgroundImage = global::Earner.Properties.Resources.refresh_48x48;
            this._btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnRestart.FlatAppearance.BorderSize = 0;
            this._btnRestart.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnRestart.Location = new System.Drawing.Point(203, 121);
            this._btnRestart.Margin = new System.Windows.Forms.Padding(0);
            this._btnRestart.Name = "_btnRestart";
            this._btnRestart.Size = new System.Drawing.Size(29, 29);
            this._btnRestart.TabIndex = 6;
            this._btnRestart.TabStop = false;
            this._btnRestart.Tag = "Options";
            this._btnRestart.UseVisualStyleBackColor = false;
            this._btnRestart.Click += new System.EventHandler(this.RestartClick);
            // 
            // _toolTip
            // 
            this._toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._toolTip.ForeColor = System.Drawing.Color.White;
            this._toolTip.IsBalloon = true;
            this._toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this._toolTip.ToolTipTitle = "Info";
            // 
            // _btnShowRecords
            // 
            this._btnShowRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnShowRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnShowRecords.BackgroundImage = global::Earner.Properties.Resources.xlsx_48x48;
            this._btnShowRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnShowRecords.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnShowRecords.FlatAppearance.BorderSize = 0;
            this._btnShowRecords.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnShowRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnShowRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnShowRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnShowRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnShowRecords.Location = new System.Drawing.Point(125, 121);
            this._btnShowRecords.Margin = new System.Windows.Forms.Padding(0);
            this._btnShowRecords.Name = "_btnShowRecords";
            this._btnShowRecords.Size = new System.Drawing.Size(29, 29);
            this._btnShowRecords.TabIndex = 7;
            this._btnShowRecords.TabStop = false;
            this._btnShowRecords.Tag = "Options";
            this._btnShowRecords.UseVisualStyleBackColor = false;
            this._btnShowRecords.Click += new System.EventHandler(this.ShowRecordsClick);
            // 
            // _lblActiveTask
            // 
            this._lblActiveTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblActiveTask.BackColor = System.Drawing.Color.Transparent;
            this._lblActiveTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblActiveTask.ForeColor = System.Drawing.Color.White;
            this._lblActiveTask.Location = new System.Drawing.Point(0, 100);
            this._lblActiveTask.Margin = new System.Windows.Forms.Padding(0);
            this._lblActiveTask.Name = "_lblActiveTask";
            this._lblActiveTask.Size = new System.Drawing.Size(271, 21);
            this._lblActiveTask.TabIndex = 8;
            this._lblActiveTask.Tag = "ActiveTask";
            this._lblActiveTask.Text = "Task A";
            this._lblActiveTask.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this._lblActiveTask.TextChanged += new System.EventHandler(this.ScaleTextChanged);
            // 
            // EarnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(271, 153);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._topPanel);
            this.Controls.Add(this._btnHide);
            this.Controls.Add(this._btnShowRecords);
            this.Controls.Add(this._btnRestart);
            this.Controls.Add(this._btnOptions);
            this.Controls.Add(this._btnStart);
            this.Controls.Add(this._lblActiveTask);
            this.Controls.Add(this._lblEarned);
            this.Controls.Add(this._lblWorkTime);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "EarnerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Earner";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EarnerForm_FormClosing);
            this.Resize += new System.EventHandler(this.EarnerFormResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lblEarned;
        private Button _btnOptions;
        private Button _btnStart;
        private System.Windows.Forms.Timer _earnerTimer;
        private Label _lblWorkTime;
        private Button _btnHide;
        private Panel _topPanel;
        private Button _btnClose;
        private Button _btnRestart;
        private ToolTip _toolTip;
        private Button _btnShowRecords;
        private Label _lblActiveTask;
    }
}