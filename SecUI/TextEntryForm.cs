using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecUI
{
    public partial class TextEntryForm : Form
    {
        public string Message
        {
            get
            {
                return tbMessage.Text;
            }
        }

        public EntryType Type
        {
            get;
            private set;
        }

        private Bitmap Screenshot
        {
            get;
            set;
        }

        public TextEntryForm(Bitmap Screenshot)
        {
            InitializeComponent();

            this.Screenshot = new Bitmap(Screenshot);
            Type = AnalyzeScreenshot(Screenshot);
        }

        /* *
         * Pointmap to determine if we are entering text and whether we have upper or lowercase
         * 
         * 237, 7 :   light (lc),   dark  (uc)
         * 216, 13:   dark  (lc),   dark  (uc)
         * 212, 13:   light (lc),   dark  (uc)
         * 216, 5 :   dark  (lc),   dark  (uc)
         * 222, 3 :   dark  (lc),   light (uc)
         * 
         * */

        private EntryType AnalyzeScreenshot(Bitmap Screenshot)
        {
            if (IsPointLight(Screenshot.GetPixel(237, 7)) &&
                !IsPointLight(Screenshot.GetPixel(216, 13)) &&
                IsPointLight(Screenshot.GetPixel(212, 13)) &&
                !IsPointLight(Screenshot.GetPixel(216, 5)) &&
                !IsPointLight(Screenshot.GetPixel(222, 3)))
            {
                // We certainly have lowercase on and are allowed to enter stuff
                return EntryType.CapsOff;
            }
            else if (!IsPointLight(Screenshot.GetPixel(237, 7)) &&
              !IsPointLight(Screenshot.GetPixel(216, 13)) &&
              !IsPointLight(Screenshot.GetPixel(212, 13)) &&
              !IsPointLight(Screenshot.GetPixel(216, 5)) &&
              IsPointLight(Screenshot.GetPixel(222, 3)))
            {
                return EntryType.CapsOn;
            }
            else // No text entry is supported
                return EntryType.Unsupported;
        }
       

        private bool IsPointLight(Color Point)
        {
            return (bool)(Point.R > 127 && Point.G > 127 && Point.B > 127);
        }

        public enum EntryType
        {
            CapsOn,
            CapsOff,
            Unsupported
        }

        private void TextEntryForm_Load(object sender, EventArgs e)
        {
            screen.Image = Screenshot;
            lblEntryStatus.Text = string.Format("The current screen {0} support text entry.", (Type == EntryType.Unsupported) ? "doesn't" : "does");

            if (Type != EntryType.Unsupported)
                lblCapsStatus.Text = string.Format("Caps lock is currently {0}.", (Type == EntryType.CapsOn) ? "enabled" : "disabled");
            else
            {
                btnEnter.Enabled = false;
                lblCapsStatus.Text = "";
                errorProvider.SetError(tbMessage, "The current screen does not support text entry!");
                cbOverride.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (cbOverride.Checked)
            {
                if (cbLowercaseOverride.Checked)
                    Type = EntryType.CapsOff;
                else
                    Type = EntryType.CapsOn;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void cbOverride_CheckedChanged(object sender, EventArgs e)
        {
            cbLowercaseOverride.Visible = cbOverride.Checked;
            btnEnter.Enabled = (bool)(Type == EntryType.Unsupported && cbOverride.Checked);
        }
    }
}
