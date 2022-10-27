using System.Configuration;
using System.Text;

namespace Earner
{
    public partial class TasksForm : Form
    {
        private List<string> EarnerTasks { get; set; } = new();

        public TasksForm()
        {
            InitializeComponent();
            LoadAppSettings();
        }

        private void LoadAppSettings()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                EarnerTasks = config.AppSettings.Settings["Tasks"].Value.Trim().Split(",").ToList();
                _cmbTasks.Items.Clear();
                _cmbTasks.Items.AddRange(EarnerTasks.ToArray());
                if (_cmbTasks.Items.Count >= 0)
                {
                    _cmbTasks.SelectedItem = _cmbTasks.Items[0];
                }
            }
            catch (Exception)
            {
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

        private void SaveClick(object sender, EventArgs e)
        {
            SaveTasksFromForm();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SaveTasksFromForm()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            StringBuilder tasks = new();
            EarnerTasks.Clear();
            if (_cmbTasks.SelectedItem is null)
            {
                EarnerTasks = _cmbTasks.Items.Cast<string>().ToList();
            }
            else
            {
                EarnerTasks.Add(_cmbTasks.SelectedItem.ToString() + "");
                EarnerTasks.AddRange(_cmbTasks.Items.Cast<string>().ToList().Where((task) => task != _cmbTasks.SelectedItem.ToString()).ToList());
            }
            EarnerTasks.ForEach((task) => tasks.Append($"{task},"));
            config.AppSettings.Settings["Tasks"].Value = tasks.ToString().TrimEnd(',');
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void AddTaskClick(object sender, EventArgs e)
        {
            string potentialNewTask = _cmbTasks.Text.Trim();
            if (!EarnerTasks.Contains(potentialNewTask))
            {
                _ = _cmbTasks.Items.Add(potentialNewTask);
                SaveTasksFromForm();
            }
        }

        private void RemoveTaskClick(object sender, EventArgs e)
        {
            string potentialRemoveTask = _cmbTasks.Text.Trim();
            if (EarnerTasks.Contains(potentialRemoveTask))
            {
                _cmbTasks.Items.Remove(potentialRemoveTask);
                SaveTasksFromForm();
                _cmbTasks.SelectedText = null;
            }
        }
    }
}
