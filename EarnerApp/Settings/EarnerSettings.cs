namespace Earner.Settings
{
    internal sealed class EarnerSettings
    {
        #region Private constructor

        private EarnerSettings()
        {
        }

        #endregion Private constructor

        #region Singleton instance via Lazy

        private static readonly Lazy<EarnerSettings> lazy = new(() => new EarnerSettings());

        public static EarnerSettings Instance
        {
            get
            {
                lazy.Value.Load();
                return lazy.Value;
            }
        }

        #endregion Singleton instance via Lazy

        #region Public properties

        public double HourlyRate { get; set; } = 1000;

        public double FixedDailyCost { get; set; } = 0;

        public double MaxBillableDailyHours { get; set; } = 8;

        public string CurrencySymbol { get; set; } = "kr";

        public List<string> EarnerTasks { get; set; } = new();

        public bool SaveTaskLog { get; set; } = false;

        public bool ShowApplicationLogOnErrors { get; set; } = false;

        public bool ShowTooltips { get; set; } = false;

        public bool AutoShowTaskLog { get; set; } = false;

        public bool AutoStartWithWindows { get; set; } = false;

        public bool ConfirmBeforeClose { get; set; } = true;

        #endregion Public properties

        #region Public methods

        public void Load()
        {
            HourlyRate = EarnerConfig.GetAppSettings<double>("HourlyRate");
            FixedDailyCost = EarnerConfig.GetAppSettings<double>("FixedDailyCost");
            MaxBillableDailyHours = EarnerConfig.GetAppSettings<double>("MaxBillableDailyHours");
            CurrencySymbol = EarnerConfig.GetAppSettings<string>("CurrencySymbol");
            EarnerTasks = EarnerConfig.GetAppSettings<List<string>>("Tasks");
            SaveTaskLog = EarnerConfig.GetAppSettings<bool>("SaveTaskLog");
            ShowApplicationLogOnErrors = EarnerConfig.GetAppSettings<bool>("ShowAppLogOnError");
            ShowTooltips = EarnerConfig.GetAppSettings<bool>("ShowTooltips");
            AutoShowTaskLog = EarnerConfig.GetAppSettings<bool>("AutoShowTaskLog");
            AutoStartWithWindows = EarnerConfig.GetAppSettings<bool>("AutoStartWithWindows");
            ConfirmBeforeClose = EarnerConfig.GetAppSettings<bool>("ConfirmBeforeClose");
            EarnerCommon.StartWithWindows = AutoStartWithWindows;
        }

        public void Save()
        {
            _ = EarnerConfig.SaveAppSettingsString("HourlyRate", HourlyRate.ToString());
            _ = EarnerConfig.SaveAppSettingsString("FixedDailyCost", FixedDailyCost.ToString());
            _ = EarnerConfig.SaveAppSettingsString("MaxBillableDailyHours", MaxBillableDailyHours.ToString());
            _ = EarnerConfig.SaveAppSettingsString("CurrencySymbol", CurrencySymbol.ToString());
            _ = EarnerConfig.SaveAppSettingsString("SaveTaskLog", SaveTaskLog.ToString());
            _ = EarnerConfig.SaveAppSettingsString("ShowTooltips", ShowTooltips.ToString());
            _ = EarnerConfig.SaveAppSettingsString("AutoShowTaskLog", AutoShowTaskLog.ToString());
            _ = EarnerConfig.SaveAppSettingsString("AutoStartWithWindows", AutoStartWithWindows.ToString());
            _ = EarnerConfig.SaveAppSettingsString("ShowAppLogOnError", ShowApplicationLogOnErrors.ToString());
            _ = EarnerConfig.SaveAppSettingsString("ConfirmBeforeClose", ConfirmBeforeClose.ToString());
            _ = EarnerConfig.SaveAppSettingsList("Tasks", EarnerTasks);
            EarnerCommon.StartWithWindows = AutoStartWithWindows;
        }

        #endregion Public methods
    }
}
