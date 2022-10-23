using System.Configuration;
using System.Runtime.InteropServices;

namespace Earner
{
    public partial class SettingsForm : Form
    {
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        
        [DllImport("user32.dll")]
        static extern bool ReleaseCapture();

        public SettingsForm()
        {
            InitializeComponent();
            LoadAppSettings();
        }

        private void LoadAppSettings()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                _txtHourlyRate.Text = config.AppSettings.Settings["HourlyRate"].Value;
                _txtFixedDailyCost.Text = config.AppSettings.Settings["FixedDailyCost"].Value;
                _txtMaxBillableDailyHours.Text = config.AppSettings.Settings["MaxBillableDailyHours"].Value;
                _txtCurrencySymbol.Text = config.AppSettings.Settings["CurrencySymbol"].Value;
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
            if (_txtFixedDailyCost.Text.Length == 0 || EarnerForm.ConvertToDouble(_txtFixedDailyCost.Text) == 0) _txtFixedDailyCost.Text = "0";
            if (_txtHourlyRate.Text.Length == 0 || EarnerForm.ConvertToDouble(_txtHourlyRate.Text) == 0) _txtHourlyRate.Text = "10";
            if (EarnerForm.ConvertToDouble(_txtMaxBillableDailyHours.Text) == 0 || _txtMaxBillableDailyHours.Text.Length == 0 || _txtMaxBillableDailyHours.Text == "0") _txtMaxBillableDailyHours.Text = "8";
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["HourlyRate"].Value = _txtHourlyRate.Text;
            config.AppSettings.Settings["FixedDailyCost"].Value = _txtFixedDailyCost.Text;
            config.AppSettings.Settings["MaxBillableDailyHours"].Value = _txtMaxBillableDailyHours.Text;
            config.AppSettings.Settings["CurrencySymbol"].Value = _txtCurrencySymbol.Text;
            config.Save(ConfigurationSaveMode.Modified);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditTasksClick(object sender, EventArgs e)
        {
            using TasksForm tasksForm = new();
            tasksForm.ShowDialog();
        }
    }
}