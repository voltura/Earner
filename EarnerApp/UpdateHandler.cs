namespace Earner
{
    internal sealed class UpdateHandler
    {
        #region Private constants

        private static readonly string VERSION_CHECK_BASE_URL = "http://github.com/voltura/Earner/releases/latest/download/";
        private static readonly string VERSION_CHECK_URL = $"{VERSION_CHECK_BASE_URL}VERSION.TXT";
        internal static readonly string APPLICATION_URL = "https://voltura.github.io/Earner/";

        #endregion Private constants

        #region Internal struct

        internal struct VersionInfo
        {
            public bool Error;
            public string Version;
            public string Installer;
        }

        #endregion Internal struct

        #region Private static variables

        private static readonly Lazy<UpdateHandler> _lazy = new(() => new UpdateHandler(), LazyThreadSafetyMode.ExecutionAndPublication);

        #endregion Private static variables

        #region Private variables

        private readonly HttpClient _client;

        #endregion Private variables

        #region Private constructor

        private UpdateHandler()
        {
            _client = new HttpClient();
        }

        #endregion Private constructor

        #region Internal instance (singleton)

        internal static UpdateHandler Instance => _lazy.Value;

        #endregion Internal instance (singleton)

        public delegate void UpdateCheckCallback(string internetVersion);

        #region Internal methods

        internal bool UpdateAvailable(out string version)
        {
            Log.LogCaller();
            string runningVersion = version = Application.ProductVersion;
            VersionInfo internetVersionInfo = GetInternetVersion();
            if (internetVersionInfo.Error)
            {
                return false;
            }
            if (!IsNewerVersion(runningVersion, internetVersionInfo.Version))
            {
                Log.Info = $"Update check: Latest version installed '{runningVersion}'";
                return false;
            }
            version = internetVersionInfo.Version;
            return true;
        }

        #endregion Internal methods

        #region Private methods

        private VersionInfo GetInternetVersion()
        {
            Log.LogCaller();
            VersionInfo vi = new()
            {
                Version = "0.0.0.0",
                Error = true
            };
            if (!NativeMethods.IsConnectedToInternet())
            {
                Log.Info = "No internet connection, cannot check for updated version";
                return vi;
            }
            string versionInfoFromInternet = GetVersionInfo();
            Log.Info = $"versionInfoFromInternet='{versionInfoFromInternet}'";
            string[] versionInfo = versionInfoFromInternet.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (versionInfo.Length != 2)
            {
                Log.ErrorString = $@"Failed to perform update check '{VERSION_CHECK_URL}'";
                return vi;
            }
            vi.Error = false;
            vi.Version = versionInfo[0];
            vi.Installer = versionInfo[1];
            return vi;
        }

        private string GetVersionInfo()
        {
            Log.LogCaller();
            string versionFromInternet = GetAsyncVersionInfo().GetAwaiter().GetResult();
            return versionFromInternet.Replace('\r', ' ').Replace('\n', ' ').TrimEnd();
        }

        internal async Task<string> GetAsyncVersionInfo()
        {
            Log.LogCaller();
            try
            {
                return await _client.GetStringAsync(VERSION_CHECK_URL).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
            return string.Empty;
        }

        internal async Task<string> GetAsyncVersionInfoWithCallback(UpdateCheckCallback callback)
        {
            Log.LogCaller();
            try
            {
                if (!NativeMethods.IsConnectedToInternet())
                {
                    Log.Info = "No internet connection, cannot check for updated version";
                    return string.Empty;
                }

                VersionInfo vi = new()
                {
                    Version = "0.0.0.0",
                    Error = true
                };

                string versionInfoFromInternet = await _client.GetStringAsync(VERSION_CHECK_URL).ConfigureAwait(false);
                Log.Info = $"versionInfoFromInternet='{versionInfoFromInternet}'";
                string[] versionInfo = versionInfoFromInternet.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (versionInfo.Length != 2)
                {
                    Log.ErrorString = $@"Failed to perform update check '{VERSION_CHECK_URL}'";
                    return string.Empty;
                }

                vi.Error = false;
                vi.Version = versionInfo[0];
                vi.Installer = versionInfo[1];
                callback(vi.Version);
            }
            catch (Exception ex)
            {
                Log.Error = ex;
            }
            return string.Empty;
        }

        /// <summary>
        /// Check if a newer version exist
        /// </summary>
        /// <param name="existingVersion"></param>
        /// <param name="internetVersion"></param>
        /// <returns></returns>
        internal static bool IsNewerVersion(string existingVersion, string internetVersion)
        {
            Log.LogCaller();
            bool result = existingVersion != internetVersion;
            if (!result)
            {
                return false;
            }

            char[] dotSeparator = new char[] { '.' };
            string[] existingVersionParts = existingVersion.Split(dotSeparator);
            string[] internetVersionParts = internetVersion.Split(dotSeparator);
            bool parseVer = int.TryParse(existingVersionParts[0], out int eMajor);
            if (!parseVer)
            {
                return result;
            }

            parseVer = int.TryParse(internetVersionParts[0], out int iMajor);
            if (!parseVer)
            {
                return result;
            }

            if (iMajor > eMajor)
            {
                return true;
            }

            parseVer = int.TryParse(existingVersionParts[1], out int eMinor);
            if (!parseVer)
            {
                return result;
            }

            parseVer = int.TryParse(internetVersionParts[1], out int iMinor);
            if (!parseVer)
            {
                return result;
            }

            if (iMinor > eMinor)
            {
                return true;
            }

            parseVer = int.TryParse(existingVersionParts[2], out int eBuild);
            if (!parseVer)
            {
                return result;
            }

            parseVer = int.TryParse(internetVersionParts[2], out int iBuild);
            if (!parseVer)
            {
                return result;
            }

            if (iBuild > eBuild)
            {
                return true;
            }

            parseVer = int.TryParse(existingVersionParts[3], out int eRevision);
            if (!parseVer)
            {
                return result;
            }

            parseVer = int.TryParse(internetVersionParts[3], out int iRevision);
            return !parseVer ? result : iRevision > eRevision;
        }

        #endregion Private methods
    }
}
