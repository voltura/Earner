#region Using statements

using Earner.Records;
using Earner.Settings;
using System.ComponentModel;
using System.Globalization;
using static Earner.Records.EarnerRecords;

#endregion Using statements

namespace Earner.Forms
{
    internal partial class LogAdminForm : Form
    {
        #region Private variables

        private readonly EarnerSettings _Settings = EarnerSettings.Instance;

        private readonly EarnerRecords _EarnerRecords = EarnerRecords.Instance;

        private readonly REPORT_PERIOD _REPORT_PERIOD;

        #endregion Private variables

        #region Constructor

        public LogAdminForm(REPORT_PERIOD period = REPORT_PERIOD.ALL)
        {
            _REPORT_PERIOD = period;
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            InitializeComponent();
            _Settings.Load();
            SetTooltips();
            PopulateDatagrid();
        }

        private void PopulateDatagrid()
        {
            BindingList<EarnerRecord> bindingsList = new();
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;

            foreach (EarnerRecord record in _EarnerRecords.EarnerRecordList
                    .Where(i => i.Earned > 0)
                    .Where(i =>
                    {
                        return _REPORT_PERIOD switch
                        {
                            REPORT_PERIOD.ALL => true,
                            REPORT_PERIOD.YEAR => DateTime.Now.Year == i.Date.Year,
                            REPORT_PERIOD.MONTH => DateTime.Now.Month == i.Date.Month && DateTime.Now.Year == i.Date.Year,
                            REPORT_PERIOD.WEEK => cal.GetWeekOfYear(DateTime.Now.Date, dfi.CalendarWeekRule, dfi.FirstDayOfWeek) == cal.GetWeekOfYear(i.Date, dfi.CalendarWeekRule, dfi.FirstDayOfWeek) && DateTime.Now.Month == i.Date.Month && DateTime.Now.Year == i.Date.Year,
                            REPORT_PERIOD.DAY => DateTime.Now.Day == i.Date.Day && DateTime.Now.Year == i.Date.Year && DateTime.Now.Month == i.Date.Month,
                            _ => DateTime.Now.Day == i.Date.Day && DateTime.Now.Year == i.Date.Year && DateTime.Now.Month == i.Date.Month
                        };
                    })
                    .OrderByDescending(i => i.Date)
                    .ThenByDescending(i => i.Earned)
                    .ThenByDescending(i => i.Task))
            {
                bindingsList.Add(record);
            }
            _dgvEarnerRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvEarnerRecords.DataSource = bindingsList;
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

        private void EarnerRecordsDefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = $"Task_{DateTime.Now.Ticks.ToString()[10..]}";
            e.Row.Cells[1].Value = "0";
            e.Row.Cells[2].Value = DateTime.Now.ToString("yyyy-MM-dd");
            e.Row.Cells[3].Value = "0";
            e.Row.Cells[4].Value = _Settings.CurrencySymbol;
            e.Row.Cells[5].Value = Math.Round(_Settings.HourlyRate, 2, MidpointRounding.AwayFromZero).ToString();
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
                _dgvEarnerRecords.Columns[e.ColumnIndex].ReadOnly = true;
            }
            else if (_dgvEarnerRecords.Columns[e.ColumnIndex].DataPropertyName == "Earned" && e.Value is not null)
            {
                e.Value = Math.Round((double)e.Value!, 2, MidpointRounding.AwayFromZero);
                if (e.CellStyle is not null)
                {
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            else if (_dgvEarnerRecords.Columns[e.ColumnIndex].DataPropertyName == "Time" && e.Value is not null)
            {
                e.Value = $"{TimeSpan.FromSeconds(Math.Round(((TimeSpan)e.Value!).TotalSeconds, 0)):c}"[..8];
            }
        }

        private void EarnerRecordsCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e is not null && e.ColumnIndex == 0)  // Task must be at least one char and max 22
            {
                e.Cancel = true;
                int len = e.FormattedValue is null ? 0 : e.FormattedValue.ToString()!.Length;
                if (len is < 1 or > 22)
                {
                    _lblValidation.Text = "Task must be at least 1 character and max 22";
                }
                else
                {
                    e.Cancel = false;
                }

                return;
            }

            if (e is not null && e.ColumnIndex == 1)  // Earned must be a numeric value
            {
                e.Cancel = true;
                if (e.FormattedValue is null || string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    _lblValidation.Text = "Earned must be a numeric value, can be 0";
                }
                else if (!double.TryParse(e.FormattedValue.ToString(), out _))
                {
                    _lblValidation.Text = "Earned must be a numeric value";
                }
                else
                {
                    e.Cancel = false;
                    _lblValidation.Text = "";
                }

                return;
            }

            if (e is not null && e.ColumnIndex == 2)  // Date must be in yyyy-MM-dd format
            {
                e.Cancel = true;
                if (e.FormattedValue is null || string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    _lblValidation.Text = "Please enter Date in yyyy-MM-dd format";
                }
                else if (!DateTime.TryParseExact(e.FormattedValue.ToString(), @"yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime enteredDateTime))
                {
                    _lblValidation.Text = "Please enter Date in yyyy-MM-dd format";
                }
                else
                {
                    DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                    Calendar cal = dfi.Calendar;
                    switch (_REPORT_PERIOD)
                    {
                        case REPORT_PERIOD.ALL:
                            break;
                        case REPORT_PERIOD.YEAR:
                            if (DateTime.Now.Year != enteredDateTime.Date.Year)
                            {
                                _lblValidation.Text = "Please enter date from this year";
                                return;
                            }

                            break;
                        case REPORT_PERIOD.MONTH:
                            bool inThisMonth = DateTime.Now.Month == enteredDateTime.Date.Month && DateTime.Now.Year == enteredDateTime.Date.Year;
                            if (!inThisMonth)
                            {
                                _lblValidation.Text = "Please enter date from this month";
                                return;
                            }

                            break;
                        case REPORT_PERIOD.WEEK:
                            bool inThisWeek = cal.GetWeekOfYear(DateTime.Now.Date, dfi.CalendarWeekRule, dfi.FirstDayOfWeek) == cal.GetWeekOfYear(enteredDateTime.Date, dfi.CalendarWeekRule, dfi.FirstDayOfWeek) && DateTime.Now.Month == enteredDateTime.Date.Month && DateTime.Now.Year == enteredDateTime.Date.Year;
                            if (!inThisWeek)
                            {
                                _lblValidation.Text = "Please enter date from this week";
                                return;
                            }

                            break;
                        case REPORT_PERIOD.DAY:
                            if (enteredDateTime.Date != DateTime.Now.Date)
                            {
                                _lblValidation.Text = "Please enter todays date";
                                return;
                            }

                            break;
                        default:
                            break;
                    }
                    int numberOfRecords = _EarnerRecords.EarnerRecordList.Count(er =>
                    {
                        bool sameTaskAndDate = er.Date.Date == enteredDateTime.Date && er.Task == _dgvEarnerRecords.Rows[e.RowIndex].Cells[0].Value.ToString();
                        return sameTaskAndDate;
                    });
                    if (numberOfRecords > 1)
                    {
                        _lblValidation.Text = "Same task already exist for this day - only one allowed";
                    }
                    else
                    {
                        e.Cancel = false;
                        _lblValidation.Text = "";
                    }
                }

                return;
            }

            if (e is not null && e.ColumnIndex == 3)  // Time must be in 00:00:00 format
            {
                e.Cancel = true;
                if (e.FormattedValue is null)
                {
                    _lblValidation.Text = "Please enter time in hh:mm:ss format";
                }
                else if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    _lblValidation.Text = "Please enter time in hh:mm:ss format";
                }
                else if (!TimeSpan.TryParseExact(e.FormattedValue.ToString() + "", @"hh\:mm\:ss",
                                CultureInfo.InvariantCulture, TimeSpanStyles.None, out _))
                {
                    _lblValidation.Text = "Please enter time in hh:mm:ss format";
                }
                else
                {
                    e.Cancel = false;
                    _lblValidation.Text = "";
                }

                return;
            }

            if (e is not null && e.ColumnIndex == 4)  // Currency Symbol 0-3 char
            {
                e.Cancel = false;
                if (e.FormattedValue is null || string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    _lblValidation.Text = "";
                }
                else if (e.FormattedValue.ToString()!.Length > 3)
                {
                    e.Cancel = true;
                    _lblValidation.Text = "Currency Symbol cannot be more that 3 characters";
                }

                return;
            }

            if (e is not null && e.ColumnIndex == 4)  // HourlyRate
            {
                e.Cancel = true;
                if (e.FormattedValue is null || string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    _lblValidation.Text = "Need to specify an hourly rate";
                }
                else if (!double.TryParse(e.FormattedValue.ToString(), out double hr))
                {
                    _lblValidation.Text = "Hourly rate need to be numeric";
                }
                else if (hr > 100000)
                {
                    _lblValidation.Text = "Hourly rate need to be less than 100000";
                }
                else
                {
                    e.Cancel = false;
                    _lblValidation.Text = "";
                }

                return;
            }

        }

        #endregion Private events
    }
}
