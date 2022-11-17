#region Using statements

using Earner.Settings;
using MiniExcelLibs;
using MiniExcelLibs.Attributes;
using MiniExcelLibs.OpenXml;
using System.Diagnostics;
using System.Globalization;
using System.Text.Json;

#endregion Using statements

namespace Earner.Records
{
    internal class EarnerRecords
    {
        #region Private variables

        private List<EarnerRecord> _EarnerRecordList = new();

        private readonly EarnerSettings _Settings = EarnerSettings.Instance;

        private readonly object _RecordLock = new();

        #endregion Private variables

        #region Private constructor

        private EarnerRecords()
        {
            LoadRecordsFromJsonDb();
        }

        #endregion Private constructor

        #region Singleton instance via Lazy

        private static readonly Lazy<EarnerRecords> lazy = new(() => new EarnerRecords());

        public static EarnerRecords Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        #endregion Singleton instance via Lazy

        #region Public enums

        public enum REPORT_PERIOD
        {
            DAY,
            WEEK,
            MONTH,
            YEAR,
            ALL
        }

        #endregion Public enums

        #region Public properties

        public List<EarnerRecord> EarnerRecordList { get => _EarnerRecordList; set => _EarnerRecordList = value; }

        public static string CurrentJsonFileName
        {
            get
            {
                string jsonFileName = $"{Path.GetFileNameWithoutExtension(Application.ExecutablePath)}.json";
                string jsonSaveLocation = EarnerSettings.Instance.JsonSaveLocation;
                string jsonFileFullPath = Path.Combine(jsonSaveLocation, jsonFileName);
                if (!Directory.Exists(jsonSaveLocation))
                {
                    _ = Directory.CreateDirectory(jsonSaveLocation);
                }
                return jsonFileFullPath;
            }
        }

        public double TotalSecondsWorkedToday
        {
            get
            {
                double totalSecondsWorkedToday = _EarnerRecordList.Sum((er) => er.Date.Date == DateTime.Now.Date ? er.Time.TotalSeconds : 0.00d);
                return totalSecondsWorkedToday >= 24 * 60 * 60 ? (24 * 60 * 60) - 1 : totalSecondsWorkedToday;
            }
        }

        public double TotalEarningsToday
        {
            get
            {
                return _EarnerRecordList.Sum((er) => er.Date.Date == DateTime.Now.Date ? er.Earned : 0.00d);
            }
        }

        #endregion Public properties

        #region Public methods

        public static void EraseLog()
        {
            try
            {
                Log.LogCaller();
                if (File.Exists(CurrentJsonFileName))
                {
                    File.Delete(CurrentJsonFileName);
                }
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
        }

        /// <summary>
        /// Excel file name
        /// </summary>
        public static string ExcelFileName(REPORT_PERIOD period = REPORT_PERIOD.DAY)
        {
            string periodStr = period switch
            {
                REPORT_PERIOD.ALL => $"{DateTime.Now:yyyy-MM-dd}_AllRecords",
                REPORT_PERIOD.YEAR => $"{DateTime.Now:yyyy}_ThisYearsRecords",
                REPORT_PERIOD.MONTH => $"{DateTime.Now:yyyy-MM}_ThisMonthsRecords",
                _ => $"{DateTime.Now:yyyy-MM-dd}_TodaysRecords"
            };
            string excelFileName = $"{Path.GetFileNameWithoutExtension(Application.ExecutablePath)}_{periodStr}.xlsx";
            string taskLogSaveLocation = EarnerSettings.Instance.TaskLogSaveLocation;
            string excelFileFullPath = Path.Combine(taskLogSaveLocation, excelFileName);
            if (!Directory.Exists(taskLogSaveLocation))
            {
                _ = Directory.CreateDirectory(taskLogSaveLocation);
            }
            return excelFileFullPath;
        }

        public double TotalEarningsTodayForTask(string task)
        {
            double totalEarningsTodayForTask = _EarnerRecordList.Sum((er) => er.Date.Date == DateTime.Now.Date && er.Task == task ? er.Earned : 0.00d);
            return totalEarningsTodayForTask;
        }

        public double TotalSecondsTodayForTask(string task)
        {
            return _EarnerRecordList.Sum((er) => er.Date.Date == DateTime.Now.Date && er.Task == task ? er.Time.TotalSeconds : 0.00d);
        }

        public void LoadRecordsFromJsonDb()
        {
            try
            {
                Log.LogCaller();
                if (File.Exists(CurrentJsonFileName))
                {
                    string jsonEarnerRecordList = File.ReadAllText(CurrentJsonFileName);
                    _EarnerRecordList.AddRange(JsonSerializer.Deserialize<List<EarnerRecord>>(jsonEarnerRecordList)!);
                }

            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
        }

        public void UpdateRecord
        (
            string task,
            double totalEarningsForTaskToday,
            double totalElapsedSecondsForTaskToday,
            string currencySymbol,
            double hourlyRate
        )
        {
            lock (_RecordLock)
            {
                // create temp earner record
                TimeSpan ts = TimeSpan.FromSeconds(totalElapsedSecondsForTaskToday);
                EarnerRecord tempEarnerRecord = new()
                {
                    Task = task,
                    Earned = totalEarningsForTaskToday,
                    Time = ts,
                    CurrencySymbol = currencySymbol,
                    HourlyRate = hourlyRate,
                    Date = DateTime.Now.Date
                };

                // create new record
                if (_EarnerRecordList.Count == 0 || !_EarnerRecordList.Contains(tempEarnerRecord))
                {
                    _EarnerRecordList.Add(tempEarnerRecord);
                    Log.Info = $"Created a new Earner record; {tempEarnerRecord}";
                    return;
                }

                // update existing record
                EarnerRecord existingRecord = _EarnerRecordList.Find((r) => r.Task == task && r.Date.Date == DateTime.Now.Date)!;
                existingRecord.Earned = totalEarningsForTaskToday;
                existingRecord.HourlyRate = hourlyRate;
                existingRecord.CurrencySymbol = currencySymbol;
                existingRecord.Time = ts;
            }
        }

        public void RemoveTodaysEarningRecords()
        {
            Log.LogCaller();
            _EarnerRecordList = _EarnerRecordList.Where((r) => r.Date.Date != DateTime.Now.Date) is null ? new List<EarnerRecord>() : _EarnerRecordList.Where((r) => r.Date.Date != DateTime.Now.Date).ToList();
            _Settings.Load();
            if (!_Settings.SaveTaskLog || _EarnerRecordList.Count == 0)
            {
                return;
            }

            SaveToJsonDb(); // remove todays records from json database
        }

        public void RemoveAllEarningRecords()
        {
            Log.LogCaller();
            _EarnerRecordList = new List<EarnerRecord>();
            _Settings.Load();
            if (!_Settings.SaveTaskLog || _EarnerRecordList.Count == 0)
            {
                return;
            }

            SaveToJsonDb(); // remove todays records from json database
        }

        public void LogRecords(bool forceDisplayExcel = false, REPORT_PERIOD period = REPORT_PERIOD.DAY)
        {
            _Settings.Load();
            if (!_Settings.SaveTaskLog || _EarnerRecordList.Count == 0)
            {
                return;
            }

            SaveToJsonDb();
            SaveToExcel(period);
            if (_Settings.AutoShowTaskLog || forceDisplayExcel)
            {
                DisplayExcel(period);
            }
        }

        public void SaveToJsonDb()
        {
            try
            {
                Log.LogCaller();
                JsonSerializerOptions options = new(JsonSerializerDefaults.General) { WriteIndented = true };
                string jsonEarnerRecordList = JsonSerializer.Serialize(_EarnerRecordList, options);
                File.WriteAllText(CurrentJsonFileName, jsonEarnerRecordList);
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
        }

        public static void DisplayExcel(REPORT_PERIOD period = REPORT_PERIOD.DAY)
        {
            try
            {
                if (!File.Exists(ExcelFileName(period)))
                {
                    return;
                }
                using Process process = new()
                {
                    StartInfo = new ProcessStartInfo(ExcelFileName(period))
                    {
                        UseShellExecute = true
                    }
                };
                _ = process.Start();
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
        }

        #endregion Public methods

        #region Private methods

        private void SaveToExcel(REPORT_PERIOD period)
        {
            try
            {
                OpenXmlConfiguration config = new()
                {
                    DynamicColumns = new DynamicExcelColumn[] {
                        new DynamicExcelColumn("Task") { Index = 0, Width = 22 },
                        new DynamicExcelColumn("Date") { Format = "yyyy-MM-dd", Index = 1, Width = 12 },
                        new DynamicExcelColumn("Day") { Index = 2, Width = 12 },
                        new DynamicExcelColumn("Earned") { Index = 3, Width = 12 },
                        new DynamicExcelColumn("Currency") { Index = 4, Width = 12 },
                        new DynamicExcelColumn("Time") { Index = 5, Width = 12 },
                        new DynamicExcelColumn("Hours") { Index = 6, Width = 12 },
                        new DynamicExcelColumn("Seconds") { Index = 7, Width = 12 }
                    }
                };
                DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = dfi.Calendar;
                var values = _EarnerRecordList
                    .Where(i => i.Earned > 0)
                    .Where(i =>
                    {
                        return period switch
                        {
                            REPORT_PERIOD.ALL => true,
                            REPORT_PERIOD.YEAR => DateTime.Now.Year == i.Date.Year,
                            REPORT_PERIOD.MONTH => DateTime.Now.Month == i.Date.Month && DateTime.Now.Year == i.Date.Year,
                            REPORT_PERIOD.WEEK => cal.GetWeekOfYear(DateTime.Now.Date, dfi.CalendarWeekRule, dfi.FirstDayOfWeek) == cal.GetWeekOfYear(i.Date, dfi.CalendarWeekRule, dfi.FirstDayOfWeek) && DateTime.Now.Month == i.Date.Month && DateTime.Now.Year == i.Date.Year,
                            REPORT_PERIOD.DAY => DateTime.Now.Day == i.Date.Day && DateTime.Now.Year == i.Date.Year && DateTime.Now.Month == i.Date.Month,
                            _ => DateTime.Now.Day == i.Date.Day && DateTime.Now.Year == i.Date.Year && DateTime.Now.Month == i.Date.Month
                        };
                    })
                    .OrderByDescending(i => i.Earned)
                    .ThenByDescending(i => i.Task)
                    .Select(i => new
                    {
                        i.Task,
                        i.Date,
                        Day = $"{i.Date:dddd}",
                        Earned = Math.Round(i.Earned, 2, MidpointRounding.AwayFromZero),
                        Currency = i.CurrencySymbol,
                        Time = $"{TimeSpan.FromSeconds(Math.Round(i.Time.TotalSeconds, 0)):c}"[..8],
                        Hours = Math.Round(i.Time.TotalSeconds / 3600, 1, MidpointRounding.AwayFromZero),
                        Seconds = Math.Round(i.Time.TotalSeconds, 2)
                    });
                values = values.Append(new
                {
                    Task = "Total",
                    Date = DateTime.Now,
                    Day = $"{DateTime.Now.Date:dddd}",
                    Earned = Math.Round(values.Sum(i => i.Earned), 2, MidpointRounding.AwayFromZero),
                    Currency = _Settings.CurrencySymbol,
                    Time = $"{TimeSpan.FromSeconds(Math.Round(values.Sum((v) => v.Seconds), 0)):c}"[..8],
                    Hours = values.Sum(v => v.Hours),
                    Seconds = Math.Round(values.Sum(v => v.Seconds), 2)
                });
                MiniExcel.SaveAs(ExcelFileName(period), values, excelType: ExcelType.XLSX, configuration: config, overwriteFile: true);
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
        }

        #endregion Private methods
    }
}
