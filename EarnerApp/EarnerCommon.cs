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

        public static void ScaleFont(Label lab)
        {
            while (TextRenderer.MeasureText(lab.Text, new Font(lab.Font.FontFamily, lab.Font.Size, lab.Font.Style)).Width > lab.Width - 10)
            {
                lab.Font = new Font(lab.Font.FontFamily, lab.Font.Size - 0.01f, lab.Font.Style);
            }
            while (TextRenderer.MeasureText(lab.Text, new Font(lab.Font.FontFamily, lab.Font.Size, lab.Font.Style)).Width < lab.Width - 10)
            {
                lab.Font = new Font(lab.Font.FontFamily, lab.Font.Size + 0.01f, lab.Font.Style);
            }
        }

        #endregion Public functions
    }
}
