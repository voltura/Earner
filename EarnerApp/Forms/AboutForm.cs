#region Using statements

using Earner.Settings;
using System.Media;
using System.Text.Encodings.Web;

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
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            InitializeComponent();
            LoadAppSettings();
            _lblAppInfo.Text = $"{Application.ProductName} {Application.ProductVersion} by Voltura AB";
            SetTooltips();
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


        private void LoadAppSettings()
        {
            _Settings.Load();
        }

        private void SetTooltips()
        {
            _toolTip.SetToolTip(_btnSupportMe, "Buy me a coffee!");
            if (_Settings.ShowTooltips)
            {
                _toolTip.SetToolTip(_btnOK, "Close about info");
                _toolTip.SetToolTip(_btnClose, "Close about info");
                _toolTip.SetToolTip(_lnkEarnerWebPage, "Open Earner web page");
                _toolTip.SetToolTip(_lnkSubmitBug, "Submit a bug report on the web");
                _toolTip.SetToolTip(_btnEarnerWebPage, "Open Earner web page");
                _toolTip.SetToolTip(_btnSubmitBug, "Submit a bug report on the web");
            }
            else
            {
                _toolTip.SetToolTip(_btnOK, null);
                _toolTip.SetToolTip(_btnClose, null);
                _toolTip.SetToolTip(_lnkEarnerWebPage, null);
                _toolTip.SetToolTip(_lnkSubmitBug, null);
                _toolTip.SetToolTip(_btnEarnerWebPage, null);
                _toolTip.SetToolTip(_btnSubmitBug, null);
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

        private void SubmitBugClick(object sender, EventArgs e)
        {
            Log.LogCaller();
            EarnerCommon.OpenUrl(@$"https://github.com/voltura/Earner/issues/new?assignees=&labels=&template=bug_report.md&title={UrlEncoder.Default.Encode(_lblAppInfo.Text)}");
        }

        private void EarnerWebPageClick(object sender, EventArgs e)
        {
            Log.LogCaller();
            EarnerCommon.OpenUrl(@"https://voltura.github.io/Earner/");
        }

        private void AboutFormShown(object sender, EventArgs e)
        {
            if (_Settings.PlaySounds)
            {
                SystemSounds.Exclamation.Play();
            }
        }

        private void SupportMeClick(object sender, EventArgs e)
        {
            Log.LogCaller();
            EarnerCommon.OpenUrl(@"https://ko-fi.com/voltura");
        }

        #endregion Private events
    }
}
