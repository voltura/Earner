using System.Threading.Tasks;

namespace Earner
{
    internal class EarnerRecords
    {
        internal List<EarnerRecord> _earnerRecords = new();

        public void UpdateRecord(string task, double hourlyRate, double earnings = 0.0d)
        {
            // create temp earner record
            double timeInSecondsFromEarnings = (earnings / hourlyRate) * 3600;
            TimeSpan ts = TimeSpan.FromSeconds(timeInSecondsFromEarnings);
            var tempEarnerRecord = new EarnerRecord() { Task = task, Earned = earnings, Time = ts };
            // create new record
            if (_earnerRecords.Count == 0 || !_earnerRecords.Contains(tempEarnerRecord)) {
                _earnerRecords.Add(tempEarnerRecord);
                return;
            }
            // update existing record
            EarnerRecord existingRecord = _earnerRecords.Find((r) => r.Task == task && r.Date.Date == DateTime.Now.Date)!;
            double earnedInOtherTasks = _earnerRecords.Where((r) => r.Date.Date == DateTime.Now.Date && r.Task != task) is null ? 0.0d : _earnerRecords.Where((r) => r.Date.Date == DateTime.Now.Date && r.Task != task).Sum((r) => r.Earned);
            existingRecord.Earned = earnings - earnedInOtherTasks;
            timeInSecondsFromEarnings = (existingRecord.Earned / hourlyRate) * 3600;
            ts = TimeSpan.FromSeconds(timeInSecondsFromEarnings);
            existingRecord.Time = ts;
        }
        public void RemoveTodaysEarningRecords()
        {
            _earnerRecords = _earnerRecords.Where((r) => r.Date.Date != DateTime.Now.Date) is null ? new List<EarnerRecord>() : _earnerRecords.Where((r) => r.Date.Date != DateTime.Now.Date).ToList<EarnerRecord>();
        }

        public void LogRecords()
        {
            Log.Clear();
            foreach (var record in _earnerRecords)
            {
                Log.Info = record.ToString();
            }
            Log.Show();
        }
    }
}
