using Earner.Settings;

namespace Earner.Forms
{
    public partial class TasksForm : Form
    {
        #region Private variables

        private List<string> _EarnerTasks;

        private readonly EarnerSettings _Settings = EarnerSettings.Instance;

        #endregion Private variables

        #region Constructor

        public TasksForm()
        {
            InitializeComponent();
            _Settings.Load();
            _EarnerTasks = _Settings.EarnerTasks;
            SetTooltips();
            LoadTasksToUI();
        }

        #endregion Constructor

        #region Private methods

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
            _Settings.EarnerTasks = _EarnerTasks;
            _Settings.Save();
        }

        #endregion Private methods

        #region Private events

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
                SaveClick(sender, e);
            }
        }

        private void SaveClick(object sender, EventArgs e)
        {
            SaveTasksFromForm();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddTaskClick(object sender, EventArgs e)
        {
            string potentialNewTask = _cmbTasks.Text.Trim();
            if (potentialNewTask.Length == 0)
            {
                return;
            }
            if (!_EarnerTasks.Contains(potentialNewTask))
            {
                _ = _cmbTasks.Items.Add(potentialNewTask);
                SaveTasksFromForm();
                _cmbTasks.SelectedText = null;
                _cmbTasks.SelectedItem = potentialNewTask;
            }
        }

        private void RemoveTaskClick(object sender, EventArgs e)
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

        private void KeyPressEnterAddTask(object sender, KeyPressEventArgs e)
        {
            if (e is not null && ((byte)e.KeyChar) == (byte)Keys.Enter)
            {
                AddTaskClick(sender, e);
                return;
            }
        }

        #endregion Private events
    }
}
