namespace Earner.Records
{
    /// <summary>
    /// Keep track of task and earnings for the same for specific date
    /// </summary>
    internal record EarnerRecord : IEquatable<EarnerRecord>
    {
        #region Public properties

        /// <summary>
        /// Task description (also used as identifier)
        /// </summary>
        public string Task { get; init; } = string.Empty;

        /// <summary>
        /// Total earnings for date
        /// </summary>
        public double Earned { get; set; } = 0.0d;

        /// <summary>
        /// Date for earner record
        /// </summary>
        public DateTime Date { get; set; } = DateTime.Now;

        /// <summary>
        /// Time spent on task today
        /// </summary>
        public TimeSpan Time { get; set; } = TimeSpan.Zero;

        /// <summary>
        /// Currency symbol (max 3 characters)
        /// </summary>
        public string CurrencySymbol { get; set; } = string.Empty;

        /// <summary>
        /// Hourly rate for this task
        /// </summary>
        public double HourlyRate { get; set; }

        #endregion Public properties

        #region Public methods

        public override string ToString()
        {
            return $"Task: '{Task}' Date: '{Date:yyyy-MM-dd}' Day: '{Date:dddd}' Earned: '{Earned:0.00}{CurrencySymbol}' Time: '" + $"{Time:c}"[..8] + "'";
        }

        public override int GetHashCode()
        {
            int hashKeyAndValueKey = Task.GetHashCode();
            int hashKeyAndValueTag = Date.Date.GetHashCode();
            return hashKeyAndValueKey ^ hashKeyAndValueTag;
        }

        #endregion Public methods

        #region IEquatable interface

        bool IEquatable<EarnerRecord>.Equals(EarnerRecord? other)
        {
            return other is not null && (ReferenceEquals(this, other) || other.Task == Task && other.Date.Date == Date.Date);
        }

        #endregion IEquatable interface
    }
}
