namespace Earner
{
    internal static class EarnerCommon
    {
        #region Public functions

        public static double ConvertToDouble(string value)
        {
            if (value == null)
            {
                return 0;
            }
            _ = double.TryParse(value, out double outVal);
            return double.IsNaN(outVal) || double.IsInfinity(outVal) ? 0 : outVal;
        }

        #endregion Public functions
    }
}
