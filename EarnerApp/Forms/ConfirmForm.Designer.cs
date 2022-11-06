namespace Earner.Forms
{
    partial class ConfirmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmForm));
            this.LblQuestion = new System.Windows.Forms.Label();
            this._btnYes = new System.Windows.Forms.Button();
            this._topPanel = new System.Windows.Forms.Panel();
            this._btnNo = new System.Windows.Forms.Button();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._lblConfirmHeader = new System.Windows.Forms.Label();
            this._topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblQuestion
            // 
            this.LblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.LblQuestion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblQuestion.ForeColor = System.Drawing.Color.White;
            this.LblQuestion.Location = new System.Drawing.Point(0, 29);
            this.LblQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(271, 92);
            this.LblQuestion.TabIndex = 0;
            this.LblQuestion.Text = "Are you sure?";
            this.LblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblQuestion.TextChanged += new System.EventHandler(this.ScaleTextChanged);
            // 
            // _btnYes
            // 
            this._btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnYes.BackgroundImage = global::Earner.Properties.Resources.check_48x48;
            this._btnYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this._btnYes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnYes.FlatAppearance.BorderSize = 0;
            this._btnYes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnYes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnYes.Location = new System.Drawing.Point(242, 121);
            this._btnYes.Margin = new System.Windows.Forms.Padding(0);
            this._btnYes.Name = "_btnYes";
            this._btnYes.Size = new System.Drawing.Size(29, 29);
            this._btnYes.TabIndex = 2;
            this._btnYes.TabStop = false;
            this._btnYes.Tag = "";
            this._btnYes.UseVisualStyleBackColor = false;
            this._btnYes.Click += new System.EventHandler(this.YesClick);
            // 
            // _topPanel
            // 
            this._topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.Controls.Add(this._lblConfirmHeader);
            this._topPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.Location = new System.Drawing.Point(0, 0);
            this._topPanel.Margin = new System.Windows.Forms.Padding(0);
            this._topPanel.Name = "_topPanel";
            this._topPanel.Size = new System.Drawing.Size(271, 30);
            this._topPanel.TabIndex = 5;
            this._topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseDown);
            // 
            // _btnNo
            // 
            this._btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnNo.BackgroundImage = global::Earner.Properties.Resources.close_48x48;
            this._btnNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this._btnNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnNo.FlatAppearance.BorderSize = 0;
            this._btnNo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnNo.Location = new System.Drawing.Point(203, 121);
            this._btnNo.Margin = new System.Windows.Forms.Padding(0);
            this._btnNo.Name = "_btnNo";
            this._btnNo.Size = new System.Drawing.Size(29, 29);
            this._btnNo.TabIndex = 6;
            this._btnNo.TabStop = false;
            this._btnNo.Tag = "";
            this._btnNo.UseVisualStyleBackColor = false;
            this._btnNo.Click += new System.EventHandler(this.NoClick);
            // 
            // _toolTip
            // 
            this._toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._toolTip.ForeColor = System.Drawing.Color.White;
            this._toolTip.IsBalloon = true;
            this._toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this._toolTip.ToolTipTitle = "Info";
            // 
            // _lblConfirmHeader
            // 
            this._lblConfirmHeader.AutoSize = true;
            this._lblConfirmHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblConfirmHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblConfirmHeader.ForeColor = System.Drawing.Color.White;
            this._lblConfirmHeader.Location = new System.Drawing.Point(4, 4);
            this._lblConfirmHeader.Name = "_lblConfirmHeader";
            this._lblConfirmHeader.Size = new System.Drawing.Size(112, 21);
            this._lblConfirmHeader.TabIndex = 91;
            this._lblConfirmHeader.Text = "Please confirm";
            this._lblConfirmHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseDown);
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(271, 153);
            this.Controls.Add(this._topPanel);
            this.Controls.Add(this._btnNo);
            this.Controls.Add(this._btnYes);
            this.Controls.Add(this.LblQuestion);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Earner - Confirm Message";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.Resize += new System.EventHandler(this.EarnerFormResize);
            this._topPanel.ResumeLayout(false);
            this._topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button _btnYes;
        private Panel _topPanel;
        private Button _btnNo;
        private ToolTip _toolTip;
        public Label LblQuestion;
        private Label _lblConfirmHeader;
    }
}