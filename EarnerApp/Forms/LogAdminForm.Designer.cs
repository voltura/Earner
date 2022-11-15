namespace Earner.Forms
{
    partial class LogAdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogAdminForm));
            this._topPanel = new System.Windows.Forms.Panel();
            this._lblLogAdminHeader = new System.Windows.Forms.Label();
            this._btnClose = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._dgvEarnerRecords = new System.Windows.Forms.DataGridView();
            this._btnCloseForm = new System.Windows.Forms.Button();
            this._topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvEarnerRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // _topPanel
            // 
            this._topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.Controls.Add(this._lblLogAdminHeader);
            this._topPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.Location = new System.Drawing.Point(29, 0);
            this._topPanel.Margin = new System.Windows.Forms.Padding(0);
            this._topPanel.Name = "_topPanel";
            this._topPanel.Size = new System.Drawing.Size(769, 29);
            this._topPanel.TabIndex = 500;
            this._topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseDown);
            // 
            // _lblLogAdminHeader
            // 
            this._lblLogAdminHeader.AutoSize = true;
            this._lblLogAdminHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblLogAdminHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblLogAdminHeader.ForeColor = System.Drawing.Color.White;
            this._lblLogAdminHeader.Location = new System.Drawing.Point(3, 4);
            this._lblLogAdminHeader.Name = "_lblLogAdminHeader";
            this._lblLogAdminHeader.Size = new System.Drawing.Size(200, 21);
            this._lblLogAdminHeader.TabIndex = 90;
            this._lblLogAdminHeader.Text = "Earner - Log administration";
            this._lblLogAdminHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseDown);
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
            this._btnClose.TabIndex = 4;
            this._btnClose.TabStop = false;
            this._btnClose.UseVisualStyleBackColor = false;
            this._btnClose.Click += new System.EventHandler(this.CloseClick);
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
            this._btnSave.Location = new System.Drawing.Point(769, 405);
            this._btnSave.Margin = new System.Windows.Forms.Padding(0);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(29, 29);
            this._btnSave.TabIndex = 3;
            this._btnSave.Tag = "";
            this._btnSave.UseVisualStyleBackColor = false;
            this._btnSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // _toolTip
            // 
            this._toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._toolTip.ForeColor = System.Drawing.Color.White;
            this._toolTip.IsBalloon = true;
            this._toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this._toolTip.ToolTipTitle = "Info";
            // 
            // _dgvEarnerRecords
            // 
            this._dgvEarnerRecords.AllowUserToOrderColumns = true;
            this._dgvEarnerRecords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this._dgvEarnerRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this._dgvEarnerRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dgvEarnerRecords.DefaultCellStyle = dataGridViewCellStyle1;
            this._dgvEarnerRecords.Enabled = false;
            this._dgvEarnerRecords.Location = new System.Drawing.Point(12, 32);
            this._dgvEarnerRecords.Name = "_dgvEarnerRecords";
            this._dgvEarnerRecords.RowTemplate.Height = 25;
            this._dgvEarnerRecords.Size = new System.Drawing.Size(774, 370);
            this._dgvEarnerRecords.TabIndex = 501;
            // 
            // _btnCloseForm
            // 
            this._btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnCloseForm.BackgroundImage = global::Earner.Properties.Resources.close_48x48;
            this._btnCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnCloseForm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnCloseForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnCloseForm.FlatAppearance.BorderSize = 0;
            this._btnCloseForm.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnCloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnCloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this._btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCloseForm.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnCloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnCloseForm.Location = new System.Drawing.Point(740, 405);
            this._btnCloseForm.Margin = new System.Windows.Forms.Padding(0);
            this._btnCloseForm.Name = "_btnCloseForm";
            this._btnCloseForm.Size = new System.Drawing.Size(29, 29);
            this._btnCloseForm.TabIndex = 502;
            this._btnCloseForm.TabStop = false;
            this._btnCloseForm.UseVisualStyleBackColor = false;
            this._btnCloseForm.Click += new System.EventHandler(this.CloseClick);
            // 
            // LogAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(798, 433);
            this.Controls.Add(this._btnCloseForm);
            this.Controls.Add(this._dgvEarnerRecords);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._topPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "LogAdminForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Earner - Log administration";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.DoubleClick += new System.EventHandler(this.SaveClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogAdminFormKeyDown);
            this._topPanel.ResumeLayout(false);
            this._topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvEarnerRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel _topPanel;
        private Button _btnClose;
        private Label _lblLogAdminHeader;
        private Button _btnSave;
        private ToolTip _toolTip;
        private DataGridView _dgvEarnerRecords;
        private Button _btnCloseForm;
    }
}