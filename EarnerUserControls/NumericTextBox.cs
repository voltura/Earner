namespace EarnerUserControls
{
    public class NumericTextBox : TextBox
    {
        #region Private variables

        private bool _NonNumberEntered = false;

        #endregion Private variables

        #region Constructor

        public NumericTextBox() : base()
        {
            KeyDown += new KeyEventHandler(KeyDownHandler);
            KeyPress += new KeyPressEventHandler(KeyPressHandler);
        }

        #endregion Constructor

        #region Private event handlers

        private void KeyDownHandler(object? sender, KeyEventArgs? e)
        {
            _NonNumberEntered = false;
            if (e is null || e.KeyCode == Keys.Back)
            {
                return;
            }

            if (ModifierKeys == Keys.Shift || (e.KeyCode is < Keys.D0 or > Keys.D9 && e.KeyCode is < Keys.NumPad0 or > Keys.NumPad9 && e.KeyCode != Keys.Back))
            {
                _NonNumberEntered = true;
            }
        }

        private void KeyPressHandler(object? sender, KeyPressEventArgs? e)
        {
            if (e is null || ((byte)e.KeyChar) == (byte)Keys.Back)
            {
                return;
            }

            if (_NonNumberEntered || (!double.TryParse(Text + e.KeyChar.ToString(), out double _)))
            {
                e.Handled = true;
            }
        }

        #endregion Private event handlers
    }
}
