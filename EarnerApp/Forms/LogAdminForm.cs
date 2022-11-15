#region Using statements

using Earner.Records;
using Earner.Settings;
using System.ComponentModel;

#endregion Using statements

namespace Earner.Forms
{
    public partial class LogAdminForm : Form
    {
        #region Private variables

        private readonly EarnerSettings _Settings = EarnerSettings.Instance;

        private readonly EarnerRecords _EarnerRecords = EarnerRecords.Instance;

        #endregion Private variables

        #region Constructor

        public LogAdminForm()
        {
            InitializeComponent();
            _Settings.Load();
            SetTooltips();
            PopulateDatagrid();
        }

        private void PopulateDatagrid()
        {
            BindingList<EarnerRecord> bindingsList = new();
            
            foreach (EarnerRecord record in _EarnerRecords.EarnerRecordList)
            {
                bindingsList.Add(record);
            }

            _dgvEarnerRecords.DataSource = bindingsList;
        }

        #endregion Constructor

        #region Private methods

        private void SetTooltips()
        {
            if (_Settings.ShowTooltips)
            {
                _toolTip.SetToolTip(_btnClose, "Close");
                _toolTip.SetToolTip(_btnCloseForm, "Close");
                _toolTip.SetToolTip(_btnSave, "Save");
            }
            else
            {
                _toolTip.SetToolTip(_btnClose, null);
                _toolTip.SetToolTip(_btnCloseForm, null);
                _toolTip.SetToolTip(_btnSave, null);
            }
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
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LogAdminFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void SaveClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        #endregion Private events
    }
}
