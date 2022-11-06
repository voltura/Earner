using Earner.Settings;

namespace Earner.Forms
{
    public partial class ConfirmForm : Form
    {
        #region Private variables

        private readonly EarnerSettings _Settings = EarnerSettings.Instance;
        private bool _DoNotChangeFontSize = false;

        #endregion Private variables

        #region Constructor

        public ConfirmForm()
        {
            Log.Init();
            Log.LogCaller();
            InitializeComponent();
            LoadAppSettings();
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
                _toolTip.SetToolTip(LblQuestion, "Please confirm this question");
                _toolTip.SetToolTip(_btnYes, "Yes, continue");
                _toolTip.SetToolTip(_btnNo, "No, do not continue");
            }
            else
            {
                _toolTip.Hide(this);
                _toolTip.SetToolTip(LblQuestion, null);
                _toolTip.SetToolTip(_btnYes, null);
                _toolTip.SetToolTip(_btnNo, null);
            }
        }

        #endregion Private methods

        #region Private events

        private void YesClick(object sender, EventArgs e)
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

        private void NoClick(object sender, EventArgs e)
        {
            Log.LogCaller();
            Close();
        }

        private void ScaleTextChanged(object sender, EventArgs e)
        {
            if (_DoNotChangeFontSize)
            {
                return;
            }
            Label label = (Label)sender;
            EarnerCommon.ScaleFont(label, 24);
        }

        private void EarnerFormResize(object sender, EventArgs e)
        {
            _DoNotChangeFontSize = WindowState == FormWindowState.Minimized;
        }

        #endregion Private events
    }
}