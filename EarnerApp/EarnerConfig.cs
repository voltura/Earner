#region Using statements

using System.Configuration;
using System.Text;

#endregion Using statements

namespace Earner
{
    internal static class EarnerConfig
    {
        #region Private variables

        private static readonly Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        #endregion Private variables

        #region Public functions

        public static T GetAppSettings<T>(string settingsKey)
        {
            T? settingsValue = default;
            try
            {
                settingsValue = typeof(T).IsAssignableFrom(typeof(double))
                    ? (T)Convert.ChangeType(GetAppSettingsDouble(settingsKey), typeof(T))
                    : typeof(T).IsAssignableFrom(typeof(string))
                        ? (T)Convert.ChangeType(GetAppSettingsString(settingsKey), typeof(T))
                        : typeof(T).IsAssignableFrom(typeof(bool))
                                            ? (T)Convert.ChangeType(GetAppSettingsBool(settingsKey), typeof(T))
                                            : typeof(T).IsAssignableFrom(typeof(List<string>))
                                                                ? (T)Convert.ChangeType(GetAppSettingsStringList(settingsKey), typeof(T))
                                                                : (T)Convert.ChangeType(GetAppSettingsString(settingsKey), typeof(T));
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
            return settingsValue!;
        }

        public static bool SaveAppSettingsString(string settingsKey, string settingsValue)
        {
            try
            {
                _config.AppSettings.Settings[settingsKey].Value = settingsValue;
                _config.Save(ConfigurationSaveMode.Modified);
                return true;
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
            return false;
        }

        public static bool SaveAppSettingsList(string settingsKey, List<string> settingsValue)
        {
            try
            {
                StringBuilder listValues = new();
                settingsValue.ForEach((listValue) => listValues.Append($"{listValue},"));
                _config.AppSettings.Settings[settingsKey].Value = listValues.ToString().TrimEnd(',');
                _config.Save(ConfigurationSaveMode.Modified);
                return true;
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
            return false;
        }

        #endregion Public functions

        #region Private functions

        private static double GetAppSettingsDouble(string settingsKey)
        {
            try
            {
                return EarnerCommon.ConvertToDouble(_config.AppSettings.Settings[settingsKey].Value.Trim());
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
            return 0;
        }

        private static string GetAppSettingsString(string settingsKey)
        {
            try
            {
                return _config.AppSettings.Settings[settingsKey].Value.Trim();
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
            return string.Empty;
        }

        private static List<string> GetAppSettingsStringList(string settingsKey)
        {
            try
            {
                return _config.AppSettings.Settings[settingsKey].Value.Trim().Split(",").ToList();
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
            return new List<string>();
        }

        private static bool GetAppSettingsBool(string settingsKey)
        {
            try
            {
                return Convert.ToBoolean(_config.AppSettings.Settings[settingsKey].Value.Trim());
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
            return false;
        }

        #endregion Private functions
    }
}
