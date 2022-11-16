#region Using statements

using Earner.Records;
using Earner.Settings;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

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
            _dgvEarnerRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void SaveClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void EarnerRecordsCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (_dgvEarnerRecords.Columns[e.ColumnIndex].DataPropertyName == "Task" && e.Value is not null)
            {
                //_dgvEarnerRecords.Columns[e.ColumnIndex].ReadOnly = true;
            }
            else if (_dgvEarnerRecords.Columns[e.ColumnIndex].DataPropertyName == "Earned" && e.Value is not null)
            {
                e.Value = Math.Round((double)e.Value!, 2, MidpointRounding.AwayFromZero);
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            else if (_dgvEarnerRecords.Columns[e.ColumnIndex].DataPropertyName == "Time" && e.Value is not null)
            {
                e.Value = $"{TimeSpan.FromSeconds(Math.Round(((TimeSpan)e.Value!).TotalSeconds, 0)):c}"[..8];
            }
        }

        private void EarnerRecordsCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e is not null && e.ColumnIndex == 0)  // Task must be atleast one char and max 22
            {
                int len = e.FormattedValue is null ? 0 : e.FormattedValue.ToString()!.Length;
                if (len < 1 || len > 22)
                {
                    _lblValidation.Text = "Task must be atleast 1 character and max 22";
                    e.Cancel = true;
                    return;
                }

                return;
            }

            if (e is not null && e.ColumnIndex == 1)  // Earned must be a numeric value
            {
                if (!double.TryParse(e.FormattedValue.ToString(), out _))
                {
                    _lblValidation.Text = "Earned must be a numeric value";
                    e.Cancel = true;
                    return;
                }

                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    _lblValidation.Text = "Earned must be a numeric value, can be 0";
                    e.Cancel = true;
                    return;
                }
                _lblValidation.Text = "";
                return;
            }
            if (e is not null && e.ColumnIndex == 2)  // Date must be in yyyy-MM-dd format
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    _lblValidation.Text = "Please enter Date in yyyy-MM-dd format";
                    e.Cancel = true;
                    return;
                }
                else if (!DateTime.TryParseExact(e.FormattedValue.ToString(), @"yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out _))
                {
                    _lblValidation.Text = "Please enter Date in yyyy-MM-dd format";
                    e.Cancel = true;
                    return;
                }
                _lblValidation.Text = "";
                return;
            }

            if (e is not null && e.ColumnIndex == 3)  // Time must be in 00:00:00 format
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    _lblValidation.Text = "Please enter time in hh:mm:ss format";
                    e.Cancel = true;
                    return;
                }
                else if (e.FormattedValue is null)
                {
                    _lblValidation.Text = "Please enter time in hh:mm:ss format";
                    e.Cancel = true;
                    return;
                }
                else
                { 
                    try
                    {
                        if (!TimeSpan.TryParseExact(e.FormattedValue.ToString()+"", @"hh\:mm\:ss",
                                 CultureInfo.InvariantCulture, TimeSpanStyles.None, out _))
                        {
                            _lblValidation.Text = "Please enter time in hh:mm:ss format";
                            e.Cancel = true;
                            return;
                        }
                    }
                    catch
                    {
                        _lblValidation.Text = "Please enter time in hh:mm:ss format";
                        e.Cancel = true;
                        return;
                    }
                }
                _lblValidation.Text = "";
                return;
            }

            if (e is not null && e.ColumnIndex == 4)  // Currency Symbol 0-2 char
            {
                if (e.FormattedValue is null || string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                }
                else if (e.FormattedValue.ToString()!.Length > 2)
                {
                    _lblValidation.Text = "Currency Symbol cannot be more that 2 characters";
                    e.Cancel = true;
                    return;
                }
                _lblValidation.Text = "";
                return;
            }

            if (e is not null && e.ColumnIndex == 4)  // HourlyRate
            {
                if (e.FormattedValue is null || string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    _lblValidation.Text = "Need to specify an hourly rate";
                    e.Cancel = true;
                    return;
                }
                else if (!double.TryParse(e.FormattedValue.ToString(), out _))
                {
                    _lblValidation.Text = "Hourly rate need to be numeric";
                    e.Cancel = true;
                    return;
                }
                _lblValidation.Text = "";
                return;
            }

        }

        #endregion Private events

    }
}
