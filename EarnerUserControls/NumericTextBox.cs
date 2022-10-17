namespace EarnerUserControls
{
    public class NumericTextBox : TextBox
    {
	    public NumericTextBox() : base()
        {
            KeyDown += new KeyEventHandler(KeyDownHandler);
            KeyPress += new KeyPressEventHandler(KeyPressHandler);
        }

        private bool _NonNumberEntered = false;

        private void KeyDownHandler(object? sender, KeyEventArgs? e)
        {
            _NonNumberEntered = false;
            if (e is not null) {
                if (e.KeyCode == Keys.Back) return;
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                {
                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    {
                        if (e.KeyCode != Keys.Back)
                        {
                            _NonNumberEntered = true;
                        }
                    }
                }
                if (Control.ModifierKeys == Keys.Shift)
                {
                    _NonNumberEntered = true;
                }
            }
        }

        private void KeyPressHandler(object? sender, KeyPressEventArgs? e)
        {
            
            if (e is not null) {
                if (((byte)e.KeyChar) == (byte)Keys.Back) return;
                if (_NonNumberEntered == true || (!double.TryParse(Text + e.KeyChar.ToString(), out double _)))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
