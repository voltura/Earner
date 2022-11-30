#region Using statements

using Earner.Settings;

#endregion Using statements

namespace Earner.Forms
{
    public partial class TasksForm : Form
    {
        #region Private constants

        private const int MAX_NUMBER_OF_TASKS = 40;

        #endregion Private constants

        #region Private variables

        private List<string> _EarnerTasks;

        private readonly EarnerSettings _Settings = EarnerSettings.Instance;

        private DateTime _LastClick = DateTime.Now;

        #endregion Private variables

        #region Constructor

        public TasksForm()
        {
            InitializeComponent();
            _Settings.Load();
            _EarnerTasks = _Settings.Tasks;
            SetTooltips();
            LoadTasksToUI();
            WireupTasksDoubleClickHandler();
        }

        #endregion Constructor

        #region Private methods

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= EarnerCommon.WS_EX_COMPOSITED;
                cp.ClassStyle |= EarnerCommon.CS_DROPSHADOW;
                return cp;
            }
        }

        private void WireupTasksDoubleClickHandler()
        {
            _cmbTasks.MouseDown += new MouseEventHandler(TasksMouseDown);
        }

        private void LoadTasksToUI()
        {
            _cmbTasks.Items.Clear();
            _cmbTasks.Items.AddRange(_EarnerTasks.ToArray());
            AddDefaultTaskIfMissing();
        }

        private void SetTooltips()
        {
            if (_Settings.ShowTooltips)
            {
                _toolTip.SetToolTip(_btnClose, "Close settings");
                _toolTip.SetToolTip(_btnSave, "Use selected task");
                _toolTip.SetToolTip(_btnAddTask, "Add entered task");
                _toolTip.SetToolTip(_cmbTasks, "Select, Add or Remove tasks");
                _toolTip.SetToolTip(_btnRemoveTask, "Delete selected task");
            }
            else
            {
                _toolTip.SetToolTip(_btnClose, null);
                _toolTip.SetToolTip(_btnSave, null);
                _toolTip.SetToolTip(_btnAddTask, null);
                _toolTip.SetToolTip(_cmbTasks, null);
                _toolTip.SetToolTip(_btnRemoveTask, null);
            }
        }

        private void AddDefaultTaskIfMissing()
        {
            if (_cmbTasks.Items.Count == 0)
            {
                _ = _cmbTasks.Items.Add("Default task");
            }
            _cmbTasks.SelectedItem ??= _cmbTasks.Items[0];
        }

        private void SaveTasksFromForm()
        {
            _EarnerTasks.Clear();
            AddDefaultTaskIfMissing();
            if (_cmbTasks.SelectedItem is null)
            {
                _EarnerTasks = _cmbTasks.Items.Cast<string>().ToList();
            }
            else
            {
                _EarnerTasks.Add(_cmbTasks.SelectedItem.ToString() + "");
                _EarnerTasks.AddRange(_cmbTasks.Items.Cast<string>().ToList().Where((task) => task != _cmbTasks.SelectedItem.ToString()).ToList());
            }
            _Settings.Tasks = _EarnerTasks;
            _Settings.Save();
        }

        private bool AddTask()
        {
            string potentialNewTask = _cmbTasks.Text.Trim();
            if (potentialNewTask.Length == 0)
            {
                return false;
            }

            if (!_EarnerTasks.Contains(potentialNewTask))
            {
                if (_cmbTasks.Items.Count > MAX_NUMBER_OF_TASKS)
                {
                    try
                    {
                        Visible = false;
                        using ConfirmForm confirmForm = new();
                        confirmForm.LblQuestion.Text = $"Max {MAX_NUMBER_OF_TASKS} tasks.\nPlease delete one before adding new.";
                        _ = confirmForm.ShowDialog(this);
                    }
                    finally
                    {
                        Visible = true;
                    }
                    return false;
                }

                _ = _cmbTasks.Items.Add(potentialNewTask);
                SaveTasksFromForm();
                _cmbTasks.SelectedText = null;
                _cmbTasks.SelectedItem = potentialNewTask;
            }
            return true;
        }

        private void SaveTasksAndClose()
        {
            SaveTasksFromForm();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void RemoveTaskAndSelectItem()
        {
            string potentialRemoveTask = _cmbTasks.Text.Trim();
            if (_EarnerTasks.Contains(potentialRemoveTask))
            {
                _cmbTasks.Items.Remove(potentialRemoveTask);
                SaveTasksFromForm();
                _cmbTasks.SelectedText = null;
                _cmbTasks.Text = null;
                if (_cmbTasks.Items.Count > 0)
                {
                    _cmbTasks.SelectedItem = _cmbTasks.Items[0];
                }
            }
        }

        #endregion Private methods

        #region Private events

        private void TasksMouseDown(object? sender, MouseEventArgs? e)
        {
            if (e is not null && e.Button == MouseButtons.Left)
            {
                TimeSpan Current = DateTime.Now - _LastClick;
                TimeSpan DblClickSpan =
                TimeSpan.FromMilliseconds(SystemInformation.DoubleClickTime);

                if (Current.TotalMilliseconds <= DblClickSpan.TotalMilliseconds)
                {
                    SaveClick(this, e);
                }

                _LastClick = DateTime.Now;
            }
        }

        private void TopPanelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _ = NativeMethods.ReleaseCapture();
                _ = NativeMethods.SendMessage(Handle, NativeMethods.WM_NCLBUTTONDOWN, NativeMethods.HT_CAPTION, 0);
            }
        }

        private void CloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void TasksFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SaveTasksAndClose();
            }
        }

        private void SaveClick(object sender, EventArgs e)
        {
            SaveTasksAndClose();
        }

        private void AddTaskClick(object sender, EventArgs e)
        {
            _ = AddTask();
        }

        private void RemoveTaskClick(object sender, EventArgs e)
        {
            RemoveTaskAndSelectItem();
        }

        private void KeyPressEnterAddTask(object sender, KeyPressEventArgs e)
        {
            if (e is not null && ((byte)e.KeyChar) == (byte)Keys.Enter)
            {
                if (AddTask())
                {
                    SaveTasksAndClose();
                }

                return;
            }
        }

        private void TasksDoubleClick(object sender, MouseEventArgs e)
        {
            SaveTasksAndClose();
        }

        #endregion Private events
    }
}
