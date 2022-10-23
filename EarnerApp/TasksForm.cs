using System.Configuration;
using System.Runtime.InteropServices;
using System.Text;

namespace Earner
{
    public partial class TasksForm : Form
    {
        private List<string> EarnerTasks { get; set; } = new();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        
        [DllImport("user32.dll")]
        static extern bool ReleaseCapture();

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
            }
            catch (Exception)
            {
            }
        }

        private void TopPanelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CloseClick(object sender, EventArgs e) => Close();

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
            if (_cmbTasks.SelectedItem is null) {
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
            var potentialNewTask = _cmbTasks.Text.Trim();
            if (!EarnerTasks.Contains(potentialNewTask)) 
            {
                _cmbTasks.Items.Add(potentialNewTask);
                SaveTasksFromForm();
            }
        }

        private void RemoveTaskClick(object sender, EventArgs e)
        {
            var potentialRemoveTask = _cmbTasks.Text.Trim();
            if (EarnerTasks.Contains(potentialRemoveTask))
            {
                _cmbTasks.Items.Remove(potentialRemoveTask);
                SaveTasksFromForm();
                _cmbTasks.SelectedText = null;
            }
        }
    }
}