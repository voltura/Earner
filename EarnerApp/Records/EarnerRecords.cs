﻿#region Using statements

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

        private readonly EarnerSettings _Settings = EarnerSettings.Instance;

        private const int SECONDS_IN_A_DAY = 24 * 60 * 60;

        private readonly object _RecordLock = new();

        #endregion Private variables

        #region Private constructor

        private EarnerRecords()
        {
            LoadRecordsFromJsonDb();
        }

        #endregion Private constructor

        #region Singleton instance via Lazy

        private static readonly Lazy<EarnerRecords> lazy = new(() => new EarnerRecords(), LazyThreadSafetyMode.ExecutionAndPublication);

        public static EarnerRecords Instance => lazy.Value;

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

        public List<EarnerRecord> EarnerRecordList { get; set; } = new();

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
                double totalSecondsWorkedToday = EarnerRecordList.Sum((er) => er.Date.Date == DateTime.Now.Date ? er.Time.TotalSeconds : 0.00d);
                return totalSecondsWorkedToday >= SECONDS_IN_A_DAY ? SECONDS_IN_A_DAY : totalSecondsWorkedToday;
            }
        }

        public double TotalEarningsToday => EarnerRecordList.Sum((er) => er.Date.Date == DateTime.Now.Date ? er.Earned : 0.00d);

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

        public double TotalEarningsTodayForTask(string task)
        {
            double totalEarningsTodayForTask = EarnerRecordList.Sum((er) => er.Date.Date == DateTime.Now.Date && er.Task == task ? er.Earned : 0.00d);
            return totalEarningsTodayForTask;
        }

        public double TotalSecondsTodayForTask(string task)
        {
            return EarnerRecordList.Sum((er) => er.Date.Date == DateTime.Now.Date && er.Task == task ? er.Time.TotalSeconds : 0.00d);
        }

        private void LoadRecordsFromJsonDb()
        {
            try
            {
                Log.LogCaller();
                EarnerRecordList = new List<EarnerRecord>();
                if (File.Exists(CurrentJsonFileName))
                {
                    string jsonEarnerRecordList = File.ReadAllText(CurrentJsonFileName);
                    if (jsonEarnerRecordList.Length > 0)
                    {
                        EarnerRecordList.AddRange(JsonSerializer.Deserialize<List<EarnerRecord>>(jsonEarnerRecordList)!);
                    }
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
                TimeSpan ts = TimeSpan.FromSeconds(totalElapsedSecondsForTaskToday);
                // create temp earner record
                EarnerRecord tempEarnerRecord = GenerateEarnerRecord(task, totalEarningsForTaskToday, currencySymbol, hourlyRate, ts);

                // create new record
                if (EarnerRecordList.Count == 0 || !EarnerRecordList.Contains(tempEarnerRecord))
                {
                    EarnerRecordList.Add(tempEarnerRecord);
                    Log.Info = $"Created a new Earner record; {tempEarnerRecord}";
                    return;
                }

                // update existing record
                EarnerRecord existingRecord = EarnerRecordList.Find((r) => r.Task == task && r.Date.Date == DateTime.Now.Date)!;
                existingRecord.Earned = totalEarningsForTaskToday;
                existingRecord.HourlyRate = hourlyRate;
                existingRecord.CurrencySymbol = currencySymbol;
                existingRecord.Time = ts;
            }
        }

        public void RemoveTodaysEarningRecords()
        {
            Log.LogCaller();
            EarnerRecordList = EarnerRecordList.Where((r) => r.Date.Date != DateTime.Now.Date) is null ?
                new List<EarnerRecord>() :
                EarnerRecordList.Where((r) => r.Date.Date != DateTime.Now.Date).ToList();
            _Settings.Load();
            if (!_Settings.SaveTaskLog)
            {
                return;
            }
            if (EarnerRecordList.Count == 0)
            {
                RemoveJsonDb(); // remove json database
            }
            else
            {
                SaveToJsonDb(); // remove todays records from json database
            }
        }

        public void RemoveAllEarningRecords()
        {
            Log.LogCaller();
            EarnerRecordList = new List<EarnerRecord>();
            _Settings.Load();
            if (!_Settings.SaveTaskLog)
            {
                return;
            }
            RemoveJsonDb();
        }

        public void LogRecords(bool forceDisplayExcel = false, REPORT_PERIOD period = REPORT_PERIOD.DAY)
        {
            _Settings.Load();
            if (!_Settings.SaveTaskLog || EarnerRecordList.Count == 0)
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

        #endregion Public methods

        #region Private methods

        private static EarnerRecord GenerateEarnerRecord(string task, double totalEarningsForTaskToday, string currencySymbol, double hourlyRate, TimeSpan ts)
        {
            return new()
            {
                Task = task,
                Earned = totalEarningsForTaskToday,
                Time = ts,
                CurrencySymbol = currencySymbol,
                HourlyRate = hourlyRate,
                Date = DateTime.Now.Date
            };
        }

        /// <summary>
        /// Excel file name
        /// </summary>
        private static string ExcelFileName(REPORT_PERIOD period = REPORT_PERIOD.DAY)
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

        private void SaveToExcel(REPORT_PERIOD period)
        {
            try
            {
                OpenXmlConfiguration config = new()
                {
                    DynamicColumns = new DynamicExcelColumn[] {
                        new DynamicExcelColumn("Task") { Index = 0, Width = 22 },
                        new DynamicExcelColumn("Date") { Index = 1, Width = 12 },
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
                var values = EarnerRecordList
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
                        Date = $"{i.Date:yyyy-MM-dd}",
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
                    Date = "",
                    Day = "",
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

        private void SaveToJsonDb()
        {
            try
            {
                Log.LogCaller();
                JsonSerializerOptions options = new(JsonSerializerDefaults.General) { WriteIndented = true };
                string jsonEarnerRecordList = JsonSerializer.Serialize(EarnerRecordList, options);
                File.WriteAllText(CurrentJsonFileName, jsonEarnerRecordList);
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
        }

        private static void RemoveJsonDb()
        {
            try
            {
                Log.LogCaller();
                string fileName = CurrentJsonFileName;
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
        }

        private static void DisplayExcel(REPORT_PERIOD period = REPORT_PERIOD.DAY)
        {
            EarnerCommon.OpenFileOrUrl(ExcelFileName(period), true);
        }

        #endregion Private methods
    }
}
