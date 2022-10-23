using EarnerUserControls;

namespace Earner
{
    partial class TasksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksForm));
            this._topPanel = new System.Windows.Forms.Panel();
            this._btnClose = new System.Windows.Forms.Button();
            this._lblExistingTasks = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnAddTask = new System.Windows.Forms.Button();
            this._cmbTasks = new System.Windows.Forms.ComboBox();
            this._btnRemoveTask = new System.Windows.Forms.Button();
            this._lblTaskNote = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // _topPanel
            // 
            this._topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._topPanel.Location = new System.Drawing.Point(29, 0);
            this._topPanel.Margin = new System.Windows.Forms.Padding(0);
            this._topPanel.Name = "_topPanel";
            this._topPanel.Size = new System.Drawing.Size(445, 29);
            this._topPanel.TabIndex = 500;
            this._topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanelMouseDown);
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
            this._btnClose.TabIndex = 600;
            this._btnClose.TabStop = false;
            this._btnClose.UseVisualStyleBackColor = false;
            this._btnClose.Click += new System.EventHandler(this.CloseClick);
            // 
            // _lblExistingTasks
            // 
            this._lblExistingTasks.AutoSize = true;
            this._lblExistingTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblExistingTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblExistingTasks.ForeColor = System.Drawing.Color.White;
            this._lblExistingTasks.Location = new System.Drawing.Point(-1, 47);
            this._lblExistingTasks.Name = "_lblExistingTasks";
            this._lblExistingTasks.Size = new System.Drawing.Size(49, 21);
            this._lblExistingTasks.TabIndex = 90;
            this._lblExistingTasks.Text = "Tasks:";
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnSave.BackgroundImage = global::Earner.Properties.Resources.play_48x48;
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
            this._btnSave.Location = new System.Drawing.Point(436, 324);
            this._btnSave.Margin = new System.Windows.Forms.Padding(0);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(29, 29);
            this._btnSave.TabIndex = 1;
            this._btnSave.Tag = "";
            this.toolTip.SetToolTip(this._btnSave, "Use selected task");
            this._btnSave.UseVisualStyleBackColor = false;
            this._btnSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // _btnAddTask
            // 
            this._btnAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnAddTask.BackgroundImage = global::Earner.Properties.Resources.check_48x48;
            this._btnAddTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnAddTask.FlatAppearance.BorderSize = 0;
            this._btnAddTask.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnAddTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAddTask.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnAddTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnAddTask.Location = new System.Drawing.Point(436, 43);
            this._btnAddTask.Margin = new System.Windows.Forms.Padding(0);
            this._btnAddTask.Name = "_btnAddTask";
            this._btnAddTask.Size = new System.Drawing.Size(29, 29);
            this._btnAddTask.TabIndex = 602;
            this._btnAddTask.Tag = "";
            this.toolTip.SetToolTip(this._btnAddTask, "Add entered task");
            this._btnAddTask.UseVisualStyleBackColor = false;
            this._btnAddTask.Click += new System.EventHandler(this.AddTaskClick);
            // 
            // _cmbTasks
            // 
            this._cmbTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._cmbTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this._cmbTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cmbTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cmbTasks.ForeColor = System.Drawing.Color.White;
            this._cmbTasks.FormattingEnabled = true;
            this._cmbTasks.Items.AddRange(new object[] {
            "Task A",
            "Task B",
            "Task C"});
            this._cmbTasks.Location = new System.Drawing.Point(54, 44);
            this._cmbTasks.MaxDropDownItems = 40;
            this._cmbTasks.MaxLength = 255;
            this._cmbTasks.Name = "_cmbTasks";
            this._cmbTasks.Size = new System.Drawing.Size(341, 276);
            this._cmbTasks.TabIndex = 603;
            // 
            // _btnRemoveTask
            // 
            this._btnRemoveTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnRemoveTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnRemoveTask.BackgroundImage = global::Earner.Properties.Resources.close_48x48;
            this._btnRemoveTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._btnRemoveTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnRemoveTask.FlatAppearance.BorderSize = 0;
            this._btnRemoveTask.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnRemoveTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnRemoveTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnRemoveTask.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._btnRemoveTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._btnRemoveTask.Location = new System.Drawing.Point(398, 43);
            this._btnRemoveTask.Margin = new System.Windows.Forms.Padding(0);
            this._btnRemoveTask.Name = "_btnRemoveTask";
            this._btnRemoveTask.Size = new System.Drawing.Size(29, 29);
            this._btnRemoveTask.TabIndex = 605;
            this._btnRemoveTask.Tag = "";
            this.toolTip.SetToolTip(this._btnRemoveTask, "Delete selected task");
            this._btnRemoveTask.UseVisualStyleBackColor = false;
            this._btnRemoveTask.Click += new System.EventHandler(this.RemoveTaskClick);
            // 
            // _lblTaskNote
            // 
            this._lblTaskNote.AutoSize = true;
            this._lblTaskNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this._lblTaskNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblTaskNote.ForeColor = System.Drawing.Color.White;
            this._lblTaskNote.Location = new System.Drawing.Point(0, 332);
            this._lblTaskNote.Name = "_lblTaskNote";
            this._lblTaskNote.Size = new System.Drawing.Size(233, 21);
            this._lblTaskNote.TabIndex = 606;
            this._lblTaskNote.Text = "Note: Selected task = task in use";
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(474, 363);
            this.Controls.Add(this._lblTaskNote);
            this.Controls.Add(this._btnRemoveTask);
            this.Controls.Add(this._cmbTasks);
            this.Controls.Add(this._btnAddTask);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._lblExistingTasks);
            this.Controls.Add(this._topPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "TasksForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Earner Task Settings";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel _topPanel;
        private Button _btnClose;
        private Label _lblExistingTasks;
        private Button _btnSave;
        private Button _btnAddTask;
        private ComboBox _cmbTasks;
        private Button _btnRemoveTask;
        private Label _lblTaskNote;
        private ToolTip toolTip;
    }
}