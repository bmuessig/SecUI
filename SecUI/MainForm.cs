using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace SecUI
{
    public partial class MainForm : Form
    {
        SecAPI.Session.SessionEngine SessionEngine;
        SecAPI.Keypad.KeyEngine KeyEngine;
        SecAPI.Screen.ScreenEngine ScreenEngine;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectionForm cfrm = new ConnectionForm();
            if (cfrm.ShowDialog() == DialogResult.OK)
            {
                // Show on the UI that something is happening
                ToggleConnectionFields(false);
                btnConnect.Enabled = false;
                progressBar.Visible = true;
                lblStatus.Text = string.Format("Connecting to {0}:{1}...", cfrm.Hostname, cfrm.Port);

                UriBuilder baseUri = new UriBuilder();
                baseUri.Host = cfrm.Hostname;
                baseUri.Port = (int)cfrm.Port;
                baseUri.Scheme = "https";
                baseUri.Path = "/";

                NetworkCredential credentials = new NetworkCredential(cfrm.Username, cfrm.Password);

                // Configure the screen first

                ScreenEngine = new SecAPI.Screen.ScreenEngine(baseUri.Uri, credentials);
                ScreenEngine.FrameRendered += new EventHandler<SecAPI.Screen.RenderEventArgs>(ScreenEngine_FrameRendered);

                // Then configure the key engine
                KeyEngine = new SecAPI.Keypad.KeyEngine(baseUri.Uri, credentials);

                // Now obtain a session ID

                SessionEngine = new SecAPI.Session.SessionEngine(baseUri.Uri, credentials);
                SessionEngine.LogIn += new EventHandler<SecAPI.Session.ConnectionEventArgs>(SessionEngine_LogIn);
                SessionEngine.LogOut += new EventHandler<EventArgs>(SessionEngine_LogOut);

                loginLauncher.RunWorkerAsync(SessionEngine);
            }
        }

        private void SessionEngine_LogOut(object sender, EventArgs e)
        {
            lblStatus.Text = "Disconnected.";
        }

        private void SessionEngine_LogIn(object sender, SecAPI.Session.ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (e.Success)
                {
                    KeyEngine.SessionID = e.SessionID;
                    ScreenEngine.Run();
                    KeyEngine.Run();
                    ToggleConnectionFields(true);
                    lblStatus.Text = "Connected.";
                    progressBar.Visible = false;
                }
                else
                {
                    ToggleConnectionFields(false);
                    lblStatus.Text = "Connection failed!";
                    progressBar.Visible = false;
                }
            });
        }

        private void ToggleConnectionFields(bool IsConnected)
        {
            btnConnect.Enabled = !IsConnected;
            btnDisconnect.Enabled = IsConnected;
            btnTakeScreenshot.Enabled = IsConnected;
            btnTextEntry.Enabled = IsConnected;
            keypad.Enabled = IsConnected;
        }

        private void Disconnect()
        {
            if (KeyEngine != null)
            {
                if (KeyEngine.IsRunning)
                    KeyEngine.Stop();
                KeyEngine = null;
            }

            if (ScreenEngine != null)
            {
                if (ScreenEngine.IsRunning)
                    ScreenEngine.Stop();
                ScreenEngine = null;
            }

            if (SessionEngine != null)
            {
                if(SessionEngine.IsLoggedIn)
                    SessionEngine.DoLogOut();
            }
        }

        private void ScreenEngine_FrameRendered(object sender, SecAPI.Screen.RenderEventArgs e)
        {
            screen.Image = e.Frame;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }

        private void keypad_ButtonPressed(object sender, SecKeypad.SecKeyEventArgs e)
        {
            KeyEngine.EnqueueKey(SecAPI.Keypad.KeyTokens.GetToken(e.Key));
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
            ToggleConnectionFields(false);
            screen.Image = null;
        }

        private void btnTakeScreenshot_Click(object sender, EventArgs e)
        {
            if (screen.Image != null)
            {
                bool wasRunning = ScreenEngine.IsRunning;
                if (wasRunning)
                    ScreenEngine.Stop();
                Bitmap screenshot = new Bitmap(screen.Image);

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PNG-Graphics|.png";
                saveDialog.Title = "Select path to save screenshot to";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        screenshot.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Saving the image failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (wasRunning)
                    ScreenEngine.Run();
                if (screenshot != null)
                {
                    try
                    {
                        screenshot.Dispose();
                    }
                    catch (Exception) { }
                }
            }
            else
                MessageBox.Show("No image received yet!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnTextEntry_Click(object sender, EventArgs e)
        {
            bool wasRunning = ScreenEngine.IsRunning;
            if (wasRunning)
                ScreenEngine.Stop();

            try
            {
                using (Bitmap screenshot = new Bitmap(screen.Image))
                {
                    TextEntryForm tef = new TextEntryForm(screenshot);

                    if (tef.ShowDialog() == DialogResult.OK)
                    {
                        if (tef.Type == TextEntryForm.EntryType.CapsOff)
                            SecAPI.Keypad.KeyTokens.EnqueueToken(SecAPI.Keypad.Key.Pound, KeyEngine);
                        SecAPI.Keypad.KeyTokens.EnqueueTokens(tef.Message, KeyEngine);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went terribly wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (wasRunning)
                ScreenEngine.Run();
        }

        private void loginLauncher_DoWork(object sender, DoWorkEventArgs e)
        {
            ((SecAPI.Session.SessionEngine)e.Argument).DoLogIn();
        }
    }
}
