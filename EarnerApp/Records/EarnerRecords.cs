#region Using statements

using Earner.Settings;
using MiniExcelLibs;
using MiniExcelLibs.Attributes;
using MiniExcelLibs.OpenXml;
using System.Diagnostics;

#endregion Using statements

namespace Earner.Records
{
    internal class EarnerRecords
    {
        #region Private variables

        private List<EarnerRecord> _earnerRecords = new();
        private readonly EarnerSettings _Settings = EarnerSettings.Instance;

        #endregion Private variables

        #region Public properties

        public static string CurrentExcelFileName
        {
            get
            {
                string excelFileName = $"{Path.GetFileNameWithoutExtension(Application.ExecutablePath)}_{DateTime.Now:yyyy-MM-dd}.xlsx";
                string appDataFolder = Path.Combine(Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                    Application.CompanyName, Application.ProductName);
                string excelFileFullPath = Path.Combine(appDataFolder, excelFileName);
                if (!Directory.Exists(appDataFolder))
                {
                    _ = Directory.CreateDirectory(appDataFolder);
                }
                return excelFileFullPath;
            }
        }

        #endregion Public properties

        #region Public methods

        public void UpdateRecord(string task, double hourlyRate, double earnings = 0.00d, string currencySymbol = "")
        {
            // create temp earner record
            double timeInSecondsFromEarnings = earnings == 0.0d ? earnings : earnings / hourlyRate * 3600;
            TimeSpan ts = TimeSpan.FromSeconds(timeInSecondsFromEarnings > 0.0d ? timeInSecondsFromEarnings : 0.00d);
            EarnerRecord tempEarnerRecord = new() { Task = task, Earned = earnings, Time = ts, CurrencySymbol = currencySymbol };
            // create new record
            if (_earnerRecords.Count == 0 || !_earnerRecords.Contains(tempEarnerRecord))
            {
                _earnerRecords.Add(tempEarnerRecord);
                Log.Info = $"Created a new Earner record; {tempEarnerRecord}";
                return;
            }
            // update existing record
            EarnerRecord existingRecord = _earnerRecords.Find((r) => r.Task == task && r.Date.Date == DateTime.Now.Date)!;
            double earnedInOtherTasks = _earnerRecords.Where((r) => r.Date.Date == DateTime.Now.Date && r.Task != task) is null ? 0.00d : _earnerRecords.Where((r) => r.Date.Date == DateTime.Now.Date && r.Task != task).Sum((r) => r.Earned);
            existingRecord.Earned = earnings - earnedInOtherTasks;
            timeInSecondsFromEarnings = existingRecord.Earned <= 0 ? 0.00d : existingRecord.Earned / hourlyRate * 3600;
            ts = TimeSpan.FromSeconds(Math.Abs(timeInSecondsFromEarnings));
            existingRecord.Time = ts;
        }
        public void RemoveTodaysEarningRecords()
        {
            Log.LogCaller();
            _earnerRecords = _earnerRecords.Where((r) => r.Date.Date != DateTime.Now.Date) is null ? new List<EarnerRecord>() : _earnerRecords.Where((r) => r.Date.Date != DateTime.Now.Date).ToList();
        }

        public void LogRecords()
        {
            _Settings.Load();
            if (!_Settings.SaveTaskLog || _earnerRecords.Count == 0)
            {
                return;
            }

            SaveToExcel();
            if (_Settings.AutoShowTaskLog)
            {
                ShowExcel();
            }
        }

        public static void ShowExcel()
        {
            try
            {
                if (!File.Exists(CurrentExcelFileName))
                {
                    return;
                }
                using Process process = new()
                {
                    StartInfo = new ProcessStartInfo(CurrentExcelFileName)
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

        private void SaveToExcel()
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
                    }
                };

                var values = _earnerRecords
                    .Where(i => i.Earned > 0)
                    .OrderByDescending(i => i.Earned)
                    .ThenByDescending(i => i.Task)
                    .Select(i => new
                    {
                        i.Task,
                        i.Date,
                        Day = i.Date.ToString("dddd"),
                        Earned = Math.Round(i.Earned, 2, MidpointRounding.AwayFromZero),
                        Currency = i.CurrencySymbol,
                        Time = $"{i.Time:c}"[..8],
                        Hours = Math.Round(i.Time.TotalSeconds / 3600, 1, MidpointRounding.AwayFromZero)
                    });
                values = values.Append(new
                {
                    Task = "Total",
                    Date = DateTime.Now,
                    Day = DateTime.Now.Date.ToString("dddd"),
                    Earned = Math.Round(_earnerRecords.Sum(i => i.Earned), 2, MidpointRounding.AwayFromZero),
                    Currency = _Settings.CurrencySymbol,
                    Time = $"{TimeSpan.FromSeconds(_earnerRecords.Sum(i => Math.Round(i.Time.TotalSeconds, 1, MidpointRounding.AwayFromZero))):c}"[..8],
                    Hours = Math.Round(_earnerRecords.Sum(i => Math.Round(i.Time.TotalSeconds / 3600, 1, MidpointRounding.AwayFromZero)), 1, MidpointRounding.AwayFromZero)
                });
                MiniExcel.SaveAs(CurrentExcelFileName, values, excelType: ExcelType.XLSX, configuration: config, overwriteFile: true);
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
        }

        #endregion Private methods
    }
}
