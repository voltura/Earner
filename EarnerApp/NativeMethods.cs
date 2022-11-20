#region Using statements

using System.Runtime.InteropServices;

#endregion Using statements

namespace Earner
{
    internal class NativeMethods
    {
        #region Public constants

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        #endregion Public constants

        #region Public methods

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("wininet.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);

        #endregion Public methods

        #region External wininet.dll function to check Internet connection state

        internal static bool IsConnectedToInternet()
        {
            return InternetGetConnectedState(out _, 0);
        }

        #endregion External wininet.dll function to check Internet connection state
    }
}
