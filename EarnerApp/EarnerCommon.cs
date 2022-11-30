﻿#region Using statements

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

        public static double ConvertToDouble(string value)
        {
            if (value == null)
            {
                return 0;
            }
            _ = double.TryParse(value, out double outVal);
            return double.IsNaN(outVal) || double.IsInfinity(outVal) ? 0 : outVal;
        }

        public static void ScaleFont(Label lab, int maxFontSize = 0)
        {
            while (TextRenderer.MeasureText(lab.Text, new Font(lab.Font.FontFamily, lab.Font.Size, lab.Font.Style)).Width > lab.Width - 10 && lab.Font.Size > 8)
            {
                lab.Font = new Font(lab.Font.FontFamily, lab.Font.Size - 0.01f, lab.Font.Style);
            }
            while (TextRenderer.MeasureText(lab.Text, new Font(lab.Font.FontFamily, lab.Font.Size, lab.Font.Style)).Width < lab.Width - 10 && lab.Font.Size < 130)
            {
                lab.Font = new Font(lab.Font.FontFamily, lab.Font.Size + 0.01f, lab.Font.Style);
            }
            if (maxFontSize > 0 && lab.Font.Size > maxFontSize)
            {
                lab.Font = new Font(lab.Font.FontFamily, maxFontSize, lab.Font.Style);
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

        public static void OpenUrl(string url)
        {
            try
            {
                using Process p = new();
                p.StartInfo = new ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = url
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
