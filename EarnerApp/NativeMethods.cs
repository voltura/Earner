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

        #endregion Public methods
    }
}
