namespace Earner
{
    internal record EarnerRecord : IEquatable<EarnerRecord>
    {
        public string Task { get; init; } = string.Empty;
        public double Earned { get; set; } = 0.0d;
        public DateTime Date { get; set; } = DateTime.Now;
        public TimeSpan Time { get; set; } = TimeSpan.Zero;

        public override string ToString() => $"Task: '{Task}' Day: '{Date:yyyy-MM-dd}' Earned: '{Earned:0.00}' Seconds: '{Time.TotalSeconds}'";

        public override int GetHashCode()
        {
            int hashKeyAndValueKey = Task.GetHashCode();
            int hashKeyAndValueTag = Date.Date.GetHashCode();
            return hashKeyAndValueKey ^ hashKeyAndValueTag;
        }

        bool IEquatable<EarnerRecord>.Equals(EarnerRecord? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.Task == Task && other.Date.Date == Date.Date;
        }
    }
}
