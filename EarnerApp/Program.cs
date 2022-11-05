namespace Earner
{
    internal static class Program
    {
        #region Entry point for the application

        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Forms.EarnerForm());
        }

        #endregion Entry point for the application
    }
}
