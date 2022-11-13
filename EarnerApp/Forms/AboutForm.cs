#region Using statements

using Earner.Settings;

#endregion Using statements

namespace Earner.Forms
{
    public partial class AboutForm : Form
    {
        #region Private variables

        private readonly EarnerSettings _Settings = EarnerSettings.Instance;

        private bool _DoNotChangeFontSize = false;

        #endregion Private variables

        #region Constructor

        public AboutForm()
        {
            Log.Init();
            Log.LogCaller();
            InitializeComponent();
            LoadAppSettings();
            _lblAppInfo.Text = $"{Application.ProductName} {Application.ProductVersion} by Voltura AB";
            SetTooltips();
        }

        #endregion Constructor

        #region Private methods

        private void LoadAppSettings()
        {
            _Settings.Load();
        }

        private void SetTooltips()
        {
            if (_Settings.ShowTooltips)
            {
                _toolTip.SetToolTip(_btnOK, "Close about info");
            }
            else
            {
                _toolTip.Hide(this);
                _toolTip.SetToolTip(_btnOK, null);
            }
        }

        #endregion Private methods

        #region Private events

        private void ButtonClick(object sender, EventArgs e)
        {
            Log.LogCaller();
            Close();
        }

        private void TopPanelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _ = NativeMethods.ReleaseCapture();
                _ = NativeMethods.SendMessage(Handle, NativeMethods.WM_NCLBUTTONDOWN, NativeMethods.HT_CAPTION, 0);
            }
        }

        private void ScaleTextChanged(object sender, EventArgs e)
        {
            if (_DoNotChangeFontSize)
            {
                return;
            }

            Label label = (Label)sender;
            EarnerCommon.ScaleFont(label, 14);
        }

        private void AboutFormResize(object sender, EventArgs e)
        {
            _DoNotChangeFontSize = WindowState == FormWindowState.Minimized;
        }

        private void AboutFormKeyDown(object sender, KeyEventArgs e)
        {
            Log.LogCaller();
            if (e.KeyCode is Keys.Escape or Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void EarnerWebPageLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Log.LogCaller();
            EarnerCommon.OpenUrl(@"https://voltura.github.io/Earner/");
        }

        #endregion Private events
    }
}
