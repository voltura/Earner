#region Using statements

using MiniExcelLibs;
using MiniExcelLibs.Attributes;
using MiniExcelLibs.OpenXml;
using System.Diagnostics;

#endregion Using statements

namespace Earner
{
    internal class EarnerRecords
    {
        #region Private variables

        private List<EarnerRecord> _earnerRecords = new();

        #endregion Private variables

        #region Public methods

        public void UpdateRecord(string task, double hourlyRate, double earnings = 0.0d, string currencySymbol = "")
        {
            // create temp earner record
            double timeInSecondsFromEarnings = earnings == 0.0d ? earnings : earnings / hourlyRate * 3600;
            TimeSpan ts = TimeSpan.FromSeconds(timeInSecondsFromEarnings > 0.0d ? timeInSecondsFromEarnings : 0.01d);
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
            double earnedInOtherTasks = _earnerRecords.Where((r) => r.Date.Date == DateTime.Now.Date && r.Task != task) is null ? 0.0d : _earnerRecords.Where((r) => r.Date.Date == DateTime.Now.Date && r.Task != task).Sum((r) => r.Earned);
            existingRecord.Earned = earnings - earnedInOtherTasks;
            timeInSecondsFromEarnings = existingRecord.Earned <= 0 ? 0.00d : existingRecord.Earned / hourlyRate * 3600;
            ts = TimeSpan.FromSeconds(Math.Abs(timeInSecondsFromEarnings));
            existingRecord.Time = ts;
        }
        public void RemoveTodaysEarningRecords()
        {
            Log.LogCaller();
            _earnerRecords = _earnerRecords.Where((r) => r.Date.Date != DateTime.Now.Date) is null ? new List<EarnerRecord>() : _earnerRecords.Where((r) => r.Date.Date != DateTime.Now.Date).ToList<EarnerRecord>();
        }

        public void LogRecords()
        {
            string excelFileName = $"{Path.GetFileNameWithoutExtension(Application.ExecutablePath)}_{DateTime.Now:yyyy-MM-dd}.xlsx";
            string appDataFolder = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData),
                Application.CompanyName, Application.ProductName);
            string excelFileFullPath = Path.Combine(appDataFolder, excelFileName);
            try
            {
                if (_earnerRecords.Count == 0)
                {
                    return;
                }

                if (!Directory.Exists(appDataFolder))
                {
                    _ = Directory.CreateDirectory(appDataFolder);
                }

                OpenXmlConfiguration config = new()
                {
                    DynamicColumns = new DynamicExcelColumn[] {
                        new DynamicExcelColumn("Task") { Index = 0, Width = 20 },
                        new DynamicExcelColumn("Day") { Index = 1, Width = 10 },
                        new DynamicExcelColumn("Earned") { Index = 2, Width = 10 },
                        new DynamicExcelColumn("Currency") { Index = 3, Width = 10 },
                        new DynamicExcelColumn("Time") { Index = 4, Width = 10 },
                    }
                };
                var values = _earnerRecords.Select(i => new
                {
                    i.Task,
                    Day = $"{i.Date:yyyy-MM-dd}",
                    Earned = Math.Round(i.Earned, 2, MidpointRounding.AwayFromZero),
                    Currency = i.CurrencySymbol,
                    Time = $"{i.Time:c}"[..8]
                });
                MiniExcel.SaveAs(excelFileFullPath, values, excelType: ExcelType.XLSX, configuration: config, overwriteFile: true);
                if (File.Exists(excelFileFullPath))
                {
                    using Process process = new() { StartInfo = new ProcessStartInfo(excelFileFullPath) { UseShellExecute = true } };
                    _ = process.Start();
                }
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
        }

        #endregion Public methods
    }
}
