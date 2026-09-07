using System.Reflection;
using Earner.Records;
using MiniExcelLibs;

var records = EarnerRecords.Instance;
records.EarnerRecordList.Add(new EarnerRecord { Task = "Ångström & testing", Earned = 123.45, Time = TimeSpan.FromHours(1.5), CurrencySymbol = "kr", HourlyRate = 82.3, Date = DateTime.Today });
foreach (var period in Enum.GetValues<EarnerRecords.REPORT_PERIOD>())
{
    typeof(EarnerRecords).GetMethod("SaveToExcel", BindingFlags.NonPublic | BindingFlags.Instance)!.Invoke(records, new object[] { period });
    var path = (string)typeof(EarnerRecords).GetMethod("ExcelFileName", BindingFlags.NonPublic | BindingFlags.Static)!.Invoke(null, new object[] { period })!;
    var rows = MiniExcel.Query(path, useHeaderRow: true).Cast<IDictionary<string, object>>().ToList();
    if (rows.Count != 2 || (string)rows[0]["Task"] != "Ångström & testing" || Convert.ToDouble(rows[0]["Earned"]) != 123.45 || (string)rows[1]["Task"] != "Total")
        throw new Exception($"Export contents incorrect: {period}");
    Console.WriteLine($"PASS {period}: task, Unicode, numeric earnings and total survived XLSX round trip");
}

// Replace only environment owners so the real exporter never touches user settings or logs.
namespace Earner.Settings
{
    internal sealed class EarnerSettings
    {
        public static EarnerSettings Instance { get; } = new();
        public string TaskLogSaveLocation { get; } = Path.Combine(AppContext.BaseDirectory, "smoke-output");
        public string JsonSaveLocation => TaskLogSaveLocation;
        public bool SaveTaskLog => false;
        public bool AutoShowTaskLog => false;
        public string CurrencySymbol => "kr";
        public void Load() { Directory.CreateDirectory(TaskLogSaveLocation); }
    }
}
namespace Earner
{
    internal static class Log
    {
        public static string Info { set { } }
        public static Exception Error { set => throw new Exception("Exporter failed", value); }
        public static void LogCaller() { }
    }
    internal static class EarnerCommon
    {
        public static void OpenFileOrUrl(string path, bool shell) => throw new Exception("Smoke test must not open external applications");
    }
}
