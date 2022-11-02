#region Using statments


#endregion Using statments

namespace Earner
{
    internal sealed class EarnerSettings
    {
        #region Private variables

        private double _HourlyRate = 1000;
        private double _FixedDailyCost = 0;
        private double _MaxBillableDailyHours = 8;
        private string _CurrencySymbol = "kr";
        private List<string> _EarnerTasks = new();
        private bool _SaveTaskLog = false;
        private bool _ShowApplicationLogOnErrors = false;
        private bool _ShowTooltips = false;

        #endregion Private variables

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

        public double HourlyRate { get => _HourlyRate; set => _HourlyRate = value; }

        public double FixedDailyCost { get => _FixedDailyCost; set => _FixedDailyCost = value; }

        public double MaxBillableDailyHours { get => _MaxBillableDailyHours; set => _MaxBillableDailyHours = value; }

        public string CurrencySymbol { get => _CurrencySymbol; set => _CurrencySymbol = value; }

        public List<string> EarnerTasks { get => _EarnerTasks; set => _EarnerTasks = value; }

        public bool SaveTaskLog { get => _SaveTaskLog; set => _SaveTaskLog = value; }

        public bool ShowApplicationLogOnErrors { get => _ShowApplicationLogOnErrors; set => _ShowApplicationLogOnErrors = value; }

        public bool ShowTooltips { get => _ShowTooltips; set => _ShowTooltips = value; }

        #endregion Public properties

        #region Public methods

        public void Load()
        {
            _HourlyRate = EarnerConfig.GetAppSettings<double>("HourlyRate");
            _FixedDailyCost = EarnerConfig.GetAppSettings<double>("FixedDailyCost");
            _MaxBillableDailyHours = EarnerConfig.GetAppSettings<double>("MaxBillableDailyHours");
            _CurrencySymbol = EarnerConfig.GetAppSettings<string>("CurrencySymbol");
            _EarnerTasks = EarnerConfig.GetAppSettings<List<string>>("Tasks");
            _SaveTaskLog = EarnerConfig.GetAppSettings<bool>("SaveTaskLog");
            _ShowApplicationLogOnErrors = EarnerConfig.GetAppSettings<bool>("ShowAppLogOnError");
            _ShowTooltips = EarnerConfig.GetAppSettings<bool>("ShowTooltips");
        }

        public void Save()
        {
            _ = EarnerConfig.SaveAppSettingsString("HourlyRate", _HourlyRate.ToString());
            _ = EarnerConfig.SaveAppSettingsString("FixedDailyCost", _FixedDailyCost.ToString());
            _ = EarnerConfig.SaveAppSettingsString("MaxBillableDailyHours", _MaxBillableDailyHours.ToString());
            _ = EarnerConfig.SaveAppSettingsString("CurrencySymbol", _CurrencySymbol.ToString());
            _ = EarnerConfig.SaveAppSettingsString("SaveTaskLog", _SaveTaskLog.ToString());
            _ = EarnerConfig.SaveAppSettingsString("ShowTooltips", _ShowTooltips.ToString());
            _ = EarnerConfig.SaveAppSettingsString("ShowAppLogOnError", _ShowApplicationLogOnErrors.ToString());
            _ = EarnerConfig.SaveAppSettingsList("Tasks", _EarnerTasks);
        }

        #endregion Public methods
    }
}
