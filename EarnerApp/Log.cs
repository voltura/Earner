#region Using statements

using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

#endregion Using statements

namespace Earner
{
    internal static partial class Log
    {
        #region Static variables

        private static string lastInfo = "";

        private static readonly string logFile = Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".log";

        private static readonly string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            Application.CompanyName, Application.ProductName);

        private static readonly string logFileFullPath = Path.Combine(appDataFolder, logFile);

        private static readonly int DEFAULT_LOGFILE_SIZE_IN_MEGABYTES = 10;

        #endregion

        #region Internal static constructor

        /// <summary>
        ///     Constructor - Init log
        /// </summary>
        static Log()
        {
            Init();
        }

        #endregion

        #region Internal methods

        /// <summary>
        ///     Init log
        /// </summary>
        internal static void Init()
        {
            try
            {
                if (!Directory.Exists(appDataFolder))
                {
                    _ = Directory.CreateDirectory(appDataFolder);
                }
                Trace.Listeners.Clear();
                FileStream fs = new(logFileFullPath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite | FileShare.Delete, 1024, FileOptions.WriteThrough);
                TextWriterTraceListener traceListener = new(fs);
                _ = Trace.Listeners.Add(traceListener);
                Trace.AutoFlush = true;
                Trace.UseGlobalLock = false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        internal static void Close(string info)
        {
            Info = info;
            Close();
        }

        internal static void Close()
        {
            Truncate();
            Trace.Flush();
            Trace.Close();
        }

        /// <summary>
        ///     Clear log
        /// </summary>
        internal static void Clear()
        {
            try
            {
                Trace.Flush();
                Trace.Close();
                Trace.Listeners.Clear();
                FileInfo fi = new(logFileFullPath);
                if (fi.Exists)
                {
                    fi.Delete();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            Init();
        }

        /// <summary>
        ///     Truncate log
        /// </summary>
        internal static void Truncate()
        {
            try
            {
                Trace.Flush();
                Trace.Close();
                Trace.Listeners.Clear();
                FileInfo fi = new(logFileFullPath);
                if (fi.Exists)
                {
                    int trimSize = DEFAULT_LOGFILE_SIZE_IN_MEGABYTES * 1024 * 1024;
                    try
                    {
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        trimSize = Convert.ToInt16(config.AppSettings.Settings["MaxLogFileSizeInMB"].Value);
                    }
                    catch (Exception)
                    {
                    }
                    if (fi.Length > trimSize)
                    {
                        using MemoryStream ms = new(trimSize);
                        using FileStream s = new(logFileFullPath, FileMode.Open, FileAccess.ReadWrite);
                        _ = s.Seek(-trimSize, SeekOrigin.End);
                        byte[] bytes = new byte[trimSize];
                        _ = s.Read(bytes, 0, trimSize);
                        ms.Write(bytes, 0, trimSize);
                        ms.Position = 0;
                        s.SetLength(trimSize);
                        s.Position = 0;
                        ms.CopyTo(s);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            Init();
        }

        internal static void Show(string info)
        {
            Info = info;
            Show();
        }

        internal static void Show()
        {
            EarnerCommon.OpenFileOrUrl(logFileFullPath, true);
        }

        internal static void LogCaller()
        {
            StackTrace stackTrace = new();
            if (stackTrace.FrameCount > 1)
            {
                string method = stackTrace.GetFrame(1)!.GetMethod()!.Name;
                string methodClass = stackTrace.GetFrame(1)!.GetMethod()!.DeclaringType!.FullName!;
                string calleeMethod = stackTrace.GetFrame(2)!.GetMethod()!.Name!;
                string calleeClass = stackTrace.GetFrame(2)!.GetMethod()!.DeclaringType!.FullName!;
                string infoText = $"{methodClass}::{(method == ".ctor" ? "constructor" : method)} called from {calleeClass}::{(calleeMethod == ".ctor" ? "constructor" : calleeMethod)}";
                Info = infoText;
            }
        }

        #endregion

        #region Internal static log properties

        /// <summary>
        ///     Log info
        /// </summary>
        internal static string Info
        {
            private get => "";
            set
            {
                if (value is null)
                {
                    return;
                }

                try
                {
                    string formattedValue = value.Normalize(NormalizationForm.FormC).Trim();
                    if (lastInfo != formattedValue)
                    {
                        Trace.TraceInformation($"{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff", CultureInfo.InvariantCulture)} {formattedValue}");
                        lastInfo = formattedValue;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }

        /// <summary>
        ///     Log error
        /// </summary>
        internal static Exception Error
        {
            private get => new ArgumentNullException(logFile);
            set
            {
                if (value is null)
                {
                    return;
                }

                try
                {
                    string formattedValue = value.ToString().Normalize(NormalizationForm.FormC).Trim();
                    Trace.TraceError($"{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff", CultureInfo.InvariantCulture)} {formattedValue}");
                    if (Settings.EarnerSettings.Instance.ShowApplicationLogOnErrors)
                    {
                        Show();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }

        /// <summary>
        ///     Log an error string
        /// </summary>
        internal static string ErrorString
        {
            private get => "";
            set
            {
                if (value is null)
                {
                    return;
                }

                try
                {
                    string formattedValue = value.Normalize(NormalizationForm.FormC).Trim();
                    Trace.TraceError($"{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff", CultureInfo.InvariantCulture)} {formattedValue}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }

        #endregion
    }
}
