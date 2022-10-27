﻿namespace Earner
{
    internal record EarnerRecord : IEquatable<EarnerRecord>
    {
        public string Task { get; init; } = string.Empty;
        public double Earned { get; set; } = 0.0d;
        public DateTime Date { get; set; } = DateTime.Now;
        public TimeSpan Time { get; set; } = TimeSpan.Zero;
        public string CurrencySymbol { get; init; } = string.Empty;
        public override string ToString()
        {
            return $"Task: '{Task}' Day: '{Date:yyyy-MM-dd}' Earned: '{Earned:0.00}{CurrencySymbol}' Time: '" + $"{Time:c}"[..8] + "'";
        }

        public override int GetHashCode()
        {
            int hashKeyAndValueKey = Task.GetHashCode();
            int hashKeyAndValueTag = Date.Date.GetHashCode();
            return hashKeyAndValueKey ^ hashKeyAndValueTag;
        }

        bool IEquatable<EarnerRecord>.Equals(EarnerRecord? other)
        {
            return other is not null && (ReferenceEquals(this, other) || (other.Task == Task && other.Date.Date == Date.Date));
        }
    }
}
