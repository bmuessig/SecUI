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
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        public ConnectionForm(string Hostname, string Username = "", string Password = "") : base()
        {
            tbHostname.Text = Hostname;
            tbUsername.Text = Username;
            tbPassword.Text = Password;
        }

        public string Hostname
        {
            get
            {
                return tbHostname.Text;
            }
        }

        public uint Port
        {
            get
            {
                uint port;
                try
                {
                    port = Convert.ToUInt32(tbPort.Text);
                }
                catch (Exception)
                {
                    return 4433;
                }

                return port;
            }
        }

        public string Username
        {
            get
            {
                return tbUsername.Text;
            }
        }

        public string Password
        {
            get
            {
                return tbPassword.Text;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
