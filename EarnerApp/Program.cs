#region Using statements

using System.Windows.Forms.VisualStyles;

#endregion Using statements

namespace Earner
{
    internal static class Program
    {
        #region Private variable to allow only one instance of application

        private static readonly Mutex _Mutex = new(true, "0136F656-B892-4BA5-A143-0F75CEEF1B74");

        #endregion Private variable to allow only one instance of application

        #region Entry point for the application

        [STAThread]
        private static void Main()
        {
            if (!_Mutex.WaitOne(TimeSpan.Zero, true))
            {
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;
            Log.Info = "=== Application started ===";
            Log.Info = $"{Application.ProductName} version {Application.ProductVersion}";
            Application.Run(new Forms.EarnerForm());
        }

        #endregion Entry point for the application

        #region Global unhandled Exception trap

        /// <summary>
        /// Catches all unhandled exceptions for the application
        /// Writes the exception to the application log file
        /// Terminates the application with exit code -1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            Log.Error = (Exception)e.ExceptionObject;
            if (Settings.EarnerSettings.Instance.ShowApplicationLogOnErrors)
            {
                Log.Show();
            }

            Log.Close("=== Application ended ===");
            Environment.Exit(-1);
        }

        #endregion Global unhandled Exception trap
    }
}
