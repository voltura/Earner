namespace Earner.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this._lblAppInfo = new System.Windows.Forms.Label();
            this._btnOK = new System.Windows.Forms.Button();
            this._topPanel = new System.Windows.Forms.Panel();
            this._lblAboutHeader = new System.Windows.Forms.Label();
            this._btnEarnerWebPage = new System.Windows.Forms.Button();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._lnkEarnerWebPage = new System.Windows.Forms.LinkLabel();
            this._btnClose = new System.Windows.Forms.Button();
            this._lnkSubmitBug = new System.Windows.Forms.LinkLabel();
            this._btnSubmitBug = new System.Windows.Forms.Button();
            this._btnSupportMe = new System.Windows.Forms.Button();
            this._topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblAppInfo
            // 
            this._lblAppInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblAppInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblAppInfo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblAppInfo.ForeColor = System.Drawing.Color.White;
            this._lblAppInfo.Location = new System.Drawing.Point(0, 29);
            this._lblAppInfo.Margin = new System.Windows.Forms.Padding(0);
            this._lblAppInfo.Name = "_lblAppInfo";
            this._lblAppInfo.Size = new System.Drawing.Size(271, 34);
            this._lblAppInfo.TabIndex = 0;
            this._lblAppInfo.Text = "Earner by Voltura AB";
            this._lblAppInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lblAppInfo.TextChanged += new System.EventHandler(this.ScaleTextChanged);
            // 
            // _btnOK
            // 
            this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnOK.BackgroundImage = global::Earner.Properties.Resources.check_48x48;
            this._btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnOK.FlatAppearance.BorderSize = 0;
            this._btnOK.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnOK.Location = new System.Drawing.Point(242, 124);
            this._btnOK.Margin = new System.Windows.Forms.Padding(0);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(29, 29);
            this._btnOK.TabIndex = 5;
            this._btnOK.Tag = "";
            this._btnOK.UseVisualStyleBackColor = false;
            this._btnOK.Click += new System.EventHandler(this.ButtonClick);
            // 
            // _topPanel
            // 
            this._topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.Controls.Add(this._lblAboutHeader);
            this._topPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.Location = new System.Drawing.Point(29, 0);
            this._topPanel.Margin = new System.Windows.Forms.Padding(0);
            this._topPanel.Name = "_topPanel";
            this._topPanel.Size = new System.Drawing.Size(242, 30);
            this._topPanel.TabIndex = 5;
            this._topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseDown);
            // 
            // _lblAboutHeader
            // 
            this._lblAboutHeader.AutoSize = true;
            this._lblAboutHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblAboutHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblAboutHeader.ForeColor = System.Drawing.Color.White;
            this._lblAboutHeader.Location = new System.Drawing.Point(4, 4);
            this._lblAboutHeader.Name = "_lblAboutHeader";
            this._lblAboutHeader.Size = new System.Drawing.Size(52, 21);
            this._lblAboutHeader.TabIndex = 91;
            this._lblAboutHeader.Text = "About";
            this._lblAboutHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseDown);
            // 
            // _btnEarnerWebPage
            // 
            this._btnEarnerWebPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnEarnerWebPage.BackgroundImage = global::Earner.Properties.Resources.Earner_icon;
            this._btnEarnerWebPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnEarnerWebPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnEarnerWebPage.FlatAppearance.BorderSize = 0;
            this._btnEarnerWebPage.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnEarnerWebPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnEarnerWebPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnEarnerWebPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnEarnerWebPage.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnEarnerWebPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnEarnerWebPage.Location = new System.Drawing.Point(29, 99);
            this._btnEarnerWebPage.Margin = new System.Windows.Forms.Padding(0);
            this._btnEarnerWebPage.Name = "_btnEarnerWebPage";
            this._btnEarnerWebPage.Size = new System.Drawing.Size(23, 23);
            this._btnEarnerWebPage.TabIndex = 1;
            this._btnEarnerWebPage.UseVisualStyleBackColor = false;
            this._btnEarnerWebPage.Click += new System.EventHandler(this.EarnerWebPageClick);
            // 
            // _toolTip
            // 
            this._toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._toolTip.ForeColor = System.Drawing.Color.White;
            this._toolTip.IsBalloon = true;
            this._toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this._toolTip.ToolTipTitle = "Info";
            // 
            // _lnkEarnerWebPage
            // 
            this._lnkEarnerWebPage.ActiveLinkColor = System.Drawing.Color.White;
            this._lnkEarnerWebPage.AutoSize = true;
            this._lnkEarnerWebPage.DisabledLinkColor = System.Drawing.Color.White;
            this._lnkEarnerWebPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lnkEarnerWebPage.ForeColor = System.Drawing.Color.White;
            this._lnkEarnerWebPage.LinkColor = System.Drawing.Color.White;
            this._lnkEarnerWebPage.Location = new System.Drawing.Point(60, 99);
            this._lnkEarnerWebPage.Name = "_lnkEarnerWebPage";
            this._lnkEarnerWebPage.Size = new System.Drawing.Size(168, 21);
            this._lnkEarnerWebPage.TabIndex = 2;
            this._lnkEarnerWebPage.TabStop = true;
            this._lnkEarnerWebPage.Text = "Open Earner web page";
            this._lnkEarnerWebPage.VisitedLinkColor = System.Drawing.Color.White;
            this._lnkEarnerWebPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EarnerWebPageLinkClicked);
            // 
            // _btnClose
            // 
            this._btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnClose.BackgroundImage = global::Earner.Properties.Resources.close_48x48;
            this._btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
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
            this._btnClose.TabIndex = 601;
            this._btnClose.TabStop = false;
            this._btnClose.UseVisualStyleBackColor = false;
            this._btnClose.Click += new System.EventHandler(this.ButtonClick);
            // 
            // _lnkSubmitBug
            // 
            this._lnkSubmitBug.ActiveLinkColor = System.Drawing.Color.White;
            this._lnkSubmitBug.AutoSize = true;
            this._lnkSubmitBug.DisabledLinkColor = System.Drawing.Color.White;
            this._lnkSubmitBug.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lnkSubmitBug.ForeColor = System.Drawing.Color.White;
            this._lnkSubmitBug.LinkColor = System.Drawing.Color.White;
            this._lnkSubmitBug.Location = new System.Drawing.Point(60, 125);
            this._lnkSubmitBug.Name = "_lnkSubmitBug";
            this._lnkSubmitBug.Size = new System.Drawing.Size(150, 21);
            this._lnkSubmitBug.TabIndex = 4;
            this._lnkSubmitBug.TabStop = true;
            this._lnkSubmitBug.Text = "Submit a bug report";
            this._lnkSubmitBug.VisitedLinkColor = System.Drawing.Color.White;
            this._lnkSubmitBug.Click += new System.EventHandler(this.SubmitBugClick);
            // 
            // _btnSubmitBug
            // 
            this._btnSubmitBug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnSubmitBug.BackgroundImage = global::Earner.Properties.Resources.bug;
            this._btnSubmitBug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnSubmitBug.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnSubmitBug.FlatAppearance.BorderSize = 0;
            this._btnSubmitBug.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnSubmitBug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnSubmitBug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnSubmitBug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSubmitBug.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnSubmitBug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnSubmitBug.Location = new System.Drawing.Point(29, 125);
            this._btnSubmitBug.Margin = new System.Windows.Forms.Padding(0);
            this._btnSubmitBug.Name = "_btnSubmitBug";
            this._btnSubmitBug.Size = new System.Drawing.Size(23, 23);
            this._btnSubmitBug.TabIndex = 3;
            this._btnSubmitBug.UseVisualStyleBackColor = false;
            this._btnSubmitBug.Click += new System.EventHandler(this.SubmitBugClick);
            // 
            // _btnSupportMe
            // 
            this._btnSupportMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnSupportMe.BackgroundImage = global::Earner.Properties.Resources.kofi;
            this._btnSupportMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnSupportMe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnSupportMe.FlatAppearance.BorderSize = 0;
            this._btnSupportMe.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnSupportMe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnSupportMe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnSupportMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSupportMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnSupportMe.Location = new System.Drawing.Point(121, 70);
            this._btnSupportMe.Margin = new System.Windows.Forms.Padding(0);
            this._btnSupportMe.Name = "_btnSupportMe";
            this._btnSupportMe.Size = new System.Drawing.Size(29, 29);
            this._btnSupportMe.TabIndex = 602;
            this._btnSupportMe.UseVisualStyleBackColor = false;
            this._btnSupportMe.Click += new System.EventHandler(this.SupportMeClick);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(271, 153);
            this.Controls.Add(this._btnSupportMe);
            this.Controls.Add(this._btnSubmitBug);
            this.Controls.Add(this._btnEarnerWebPage);
            this.Controls.Add(this._lnkSubmitBug);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._lnkEarnerWebPage);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._topPanel);
            this.Controls.Add(this._lblAppInfo);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Earner - About";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.Shown += new System.EventHandler(this.AboutFormShown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AboutFormKeyDown);
            this.Resize += new System.EventHandler(this.AboutFormResize);
            this._topPanel.ResumeLayout(false);
            this._topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button _btnOK;
        private Panel _topPanel;
        private ToolTip _toolTip;
        public Label _lblAppInfo;
        private Label _lblAboutHeader;
        private LinkLabel _lnkEarnerWebPage;
        private Button _btnClose;
        private Button _btnEarnerWebPage;
        private LinkLabel _lnkSubmitBug;
        private Button _btnSubmitBug;
        private Button _btnSupportMe;
    }
}