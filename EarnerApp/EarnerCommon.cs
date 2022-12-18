#region Using statements

using Microsoft.Win32;
using System.Diagnostics;

#endregion Using statements

namespace Earner
{
    internal static class EarnerCommon
    {
        #region Public constants

        public const int CS_DROPSHADOW = 0x20000;

        public const int WS_EX_COMPOSITED = 0x02000000;

        #endregion Public constants

        #region Public properties

        public static bool StartWithWindows
        {
            get
            {
                bool startWithWindows = false;
                try
                {
                    startWithWindows = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run\", Application.ProductName, null) != null;
                }
                catch (Exception ex)
                {
                    Log.Error = ex;
                }
                return startWithWindows;
            }
            set
            {
                try
                {
                    using RegistryKey registryKey = Registry.CurrentUser;
                    using RegistryKey? regRun = registryKey?.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run\", true);
                    if (value)
                    {
                        regRun?.SetValue(Application.ProductName, $@"""{Application.ExecutablePath}""");
                    }
                    else
                    {
                        if (regRun?.GetValue(Application.ProductName) != null)
                        {
                            regRun?.DeleteValue(Application.ProductName);
                        }
                    }
                    registryKey?.Flush();
                }
                catch (Exception ex)
                {
                    Log.Error = ex;
                }
            }
        }

        #endregion Public properties

        #region Public methods

        public static double ConvertToDouble(string value, double defaultValue = 0)
        {
            if (string.IsNullOrEmpty(value) || !double.TryParse(value, out double result))
            {
                return defaultValue;
            }

            return double.IsNaN(result) || double.IsInfinity(result) ? defaultValue : result;
        }

        /// <summary>
        /// Scales the font size of the specified label to fit within the bounds of the label.
        /// </summary>
        /// <param name="lab">The label to scale the font size of.</param>
        public static void ScaleFont(Label lab, int maxFontSize = 130)
        {
            if (lab == null)
            {
                return;
            }

            // Iterate over a range of font sizes and break out of the loop once the optimal font size is found
            for (float fontSize = lab.Font.Size; fontSize >= 8; fontSize -= 0.01f)
            {
                // Set the font size and measure the text
                lab.Font = new Font(lab.Font.FontFamily, fontSize, lab.Font.Style);
                Size textSize = TextRenderer.MeasureText(lab.Text, lab.Font);

                // If the text fits within the bounds of the label, break out of the loop
                if (textSize.Width <= lab.Width - 10 || fontSize >= maxFontSize)
                {
                    break;
                }
            }
        }

        public static void SetProgressbarActive(IntPtr pbHandle)
        {
            _ = NativeMethods.SendMessage(pbHandle,
               0x400 + 16, //WM_USER + PBM_SETSTATE
               0x0001,
               0);
        }

        public static void SetProgressbarPaused(IntPtr pbHandle)
        {
            _ = NativeMethods.SendMessage(pbHandle,
               0x400 + 16, //WM_USER + PBM_SETSTATE
               0x0003, //PBST_PAUSED
               0);
        }

        public static void SetProgressbarErrorState(IntPtr pbHandle)
        {
            _ = NativeMethods.SendMessage(pbHandle,
               0x400 + 16, //WM_USER + PBM_SETSTATE
               0x0002, //PBST_ERROR
               0);
        }

        public static void OpenFileOrUrl(string fileOrUrl, Boolean checkIfFileExists = false)
        {
            try
            {
                if (checkIfFileExists)
                {
                    if (!File.Exists(fileOrUrl))
                    {
                        return;
                    }
                }

                using Process p = new()
                {
                    StartInfo = new ProcessStartInfo(fileOrUrl)
                    {
                        UseShellExecute = true
                    }
                };
                _ = p.Start();
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
        }

        #endregion Public methods

        #region Extension methods

        public static DateTime FirstDateInWeek(this DateTime dt)
        {
            while (dt.DayOfWeek != Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek)
            {
                _ = dt.AddDays(-1);
            }

            return dt;
        }

        #endregion Extension methods
    }
}
