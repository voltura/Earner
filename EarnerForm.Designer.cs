namespace Earner
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
            this._lblEarned = new System.Windows.Forms.Label();
            this._btnOptions = new System.Windows.Forms.Button();
            this._btnStart = new System.Windows.Forms.Button();
            this._earnerTimer = new System.Windows.Forms.Timer(this.components);
            this._lblWorkTime = new System.Windows.Forms.Label();
            this._btnHide = new System.Windows.Forms.Button();
            this._topPanel = new System.Windows.Forms.Panel();
            this._btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblEarned
            // 
            this._lblEarned.AutoSize = true;
            this._lblEarned.BackColor = System.Drawing.Color.Transparent;
            this._lblEarned.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblEarned.ForeColor = System.Drawing.Color.White;
            this._lblEarned.Location = new System.Drawing.Point(-10, 26);
            this._lblEarned.Name = "_lblEarned";
            this._lblEarned.Size = new System.Drawing.Size(495, 212);
            this._lblEarned.TabIndex = 0;
            this._lblEarned.Text = "0.00kr";
            // 
            // _btnOptions
            // 
            this._btnOptions.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this._btnOptions.BackgroundImage = global::Earner.Properties.Resources.settings;
            this._btnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnOptions.FlatAppearance.BorderSize = 0;
            this._btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOptions.Font = new System.Drawing.Font("Segoe UI Light", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnOptions.ForeColor = System.Drawing.Color.White;
            this._btnOptions.Location = new System.Drawing.Point(548, 226);
            this._btnOptions.Name = "_btnOptions";
            this._btnOptions.Size = new System.Drawing.Size(119, 79);
            this._btnOptions.TabIndex = 1;
            this._btnOptions.UseVisualStyleBackColor = false;
            this._btnOptions.Click += new System.EventHandler(this.OptionsClick);
            // 
            // _btnStart
            // 
            this._btnStart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this._btnStart.BackgroundImage = global::Earner.Properties.Resources.pause;
            this._btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnStart.FlatAppearance.BorderSize = 0;
            this._btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnStart.Font = new System.Drawing.Font("Segoe UI Light", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnStart.ForeColor = System.Drawing.Color.White;
            this._btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnStart.Location = new System.Drawing.Point(678, 226);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(119, 79);
            this._btnStart.TabIndex = 2;
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
            this._lblWorkTime.AutoSize = true;
            this._lblWorkTime.BackColor = System.Drawing.Color.Transparent;
            this._lblWorkTime.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblWorkTime.ForeColor = System.Drawing.Color.White;
            this._lblWorkTime.Location = new System.Drawing.Point(12, 200);
            this._lblWorkTime.Name = "_lblWorkTime";
            this._lblWorkTime.Size = new System.Drawing.Size(302, 99);
            this._lblWorkTime.TabIndex = 3;
            this._lblWorkTime.Text = "00:00:00";
            // 
            // _btnHide
            // 
            this._btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnHide.BackColor = System.Drawing.Color.Transparent;
            this._btnHide.FlatAppearance.BorderSize = 0;
            this._btnHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnHide.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnHide.ForeColor = System.Drawing.Color.White;
            this._btnHide.Location = new System.Drawing.Point(695, -44);
            this._btnHide.Name = "_btnHide";
            this._btnHide.Size = new System.Drawing.Size(108, 98);
            this._btnHide.TabIndex = 4;
            this._btnHide.Text = "__";
            this._btnHide.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this._btnHide.UseVisualStyleBackColor = false;
            this._btnHide.Click += new System.EventHandler(this.HideClick);
            // 
            // _topPanel
            // 
            this._topPanel.Location = new System.Drawing.Point(57, 0);
            this._topPanel.Name = "_topPanel";
            this._topPanel.Size = new System.Drawing.Size(632, 57);
            this._topPanel.TabIndex = 5;
            this._topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseDown);
            // 
            // _btnClose
            // 
            this._btnClose.BackColor = System.Drawing.Color.Transparent;
            this._btnClose.FlatAppearance.BorderSize = 0;
            this._btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnClose.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnClose.ForeColor = System.Drawing.Color.White;
            this._btnClose.Location = new System.Drawing.Point(-37, -36);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(108, 98);
            this._btnClose.TabIndex = 6;
            this._btnClose.Text = "x";
            this._btnClose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this._btnClose.UseVisualStyleBackColor = false;
            this._btnClose.Click += new System.EventHandler(this.CloseClick);
            // 
            // EarnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 302);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._topPanel);
            this.Controls.Add(this._btnHide);
            this.Controls.Add(this._btnOptions);
            this.Controls.Add(this._lblWorkTime);
            this.Controls.Add(this._btnStart);
            this.Controls.Add(this._lblEarned);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "EarnerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Earner";
            this.TopMost = true;
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
    }
}