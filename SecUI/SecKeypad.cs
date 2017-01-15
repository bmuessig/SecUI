using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecUI
{
    public partial class SecKeypad : UserControl
    {
        public event EventHandler<SecKeyEventArgs> ButtonPressed;

        public SecKeypad()
        {
            InitializeComponent();
        }

        protected virtual void OnButtonPressed(SecKeyEventArgs e)
        {
            EventHandler<SecKeyEventArgs> handler = ButtonPressed;
            if (handler != null)
                handler(this, e);
        }

        private void cmdSecLeft_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Left));
        }

        private void cmdSecUp_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Up));
        }

        private void cmdSecDown_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Down));
        }

        private void cmdSecRight_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Right));
        }

        private void cmdSecHome_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Home));
        }

        private void cmdSecLock_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Lock));
        }

        private void cmdSecUnlock_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Unlock));
        }

        private void cmdSecN1_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Digit_1));
        }

        private void cmdSecN2_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Digit_2));
        }

        private void cmdSecN3_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Digit_3));
        }

        private void cmdSecN4_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Digit_4));
        }

        private void cmdSecN5_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Digit_5));
        }

        private void cmdSecN6_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Digit_6));
        }

        private void cmdSecN7_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Digit_7));
        }

        private void cmdSecN8_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Digit_8));
        }

        private void cmdSecN9_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Digit_9));
        }

        private void cmdSecStar_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Star));
        }

        private void cmdSecN0_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Digit_0));
        }

        private void cmdSecPound_Click(object sender, EventArgs e)
        {
            OnButtonPressed(new SecKeyEventArgs(SecAPI.Keypad.Key.Pound));
        }

        public class SecKeyEventArgs : EventArgs
        {
            public SecAPI.Keypad.Key Key;

            public SecKeyEventArgs(SecAPI.Keypad.Key Key)
                : base()
            {
                this.Key = Key;
            }
        }
    }
}
