namespace SecUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTakeScreenshot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTextEntry = new System.Windows.Forms.ToolStripButton();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.screen = new SecUI.SecScreen();
            this.keypad = new SecUI.SecKeypad();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.progressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 430);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(266, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(89, 17);
            this.lblStatus.Text = "Not connected.";
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(50, 16);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.Visible = false;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMenu,
            this.btnTextEntry,
            this.btnAbout});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(266, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbMenu
            // 
            this.tsbMenu.AutoToolTip = false;
            this.tsbMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConnect,
            this.btnDisconnect,
            this.toolStripSeparator1,
            this.btnTakeScreenshot,
            this.toolStripSeparator4,
            this.btnQuit});
            this.tsbMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsbMenu.Image")));
            this.tsbMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMenu.Name = "tsbMenu";
            this.tsbMenu.Size = new System.Drawing.Size(51, 22);
            this.tsbMenu.Text = "Menu";
            // 
            // btnConnect
            // 
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(160, 22);
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(160, 22);
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // btnTakeScreenshot
            // 
            this.btnTakeScreenshot.Enabled = false;
            this.btnTakeScreenshot.Name = "btnTakeScreenshot";
            this.btnTakeScreenshot.Size = new System.Drawing.Size(160, 22);
            this.btnTakeScreenshot.Text = "Take Screenshot";
            this.btnTakeScreenshot.Click += new System.EventHandler(this.btnTakeScreenshot_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(157, 6);
            // 
            // btnQuit
            // 
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(160, 22);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnTextEntry
            // 
            this.btnTextEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTextEntry.Enabled = false;
            this.btnTextEntry.Image = ((System.Drawing.Image)(resources.GetObject("btnTextEntry.Image")));
            this.btnTextEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTextEntry.Name = "btnTextEntry";
            this.btnTextEntry.Size = new System.Drawing.Size(63, 22);
            this.btnTextEntry.Text = "Text entry";
            this.btnTextEntry.Click += new System.EventHandler(this.btnTextEntry_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.AutoToolTip = false;
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(44, 22);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // screen
            // 
            this.screen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screen.Image = null;
            this.screen.Location = new System.Drawing.Point(12, 28);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(242, 130);
            this.screen.TabIndex = 3;
            // 
            // keypad
            // 
            this.keypad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keypad.AutoSize = true;
            this.keypad.Enabled = false;
            this.keypad.Location = new System.Drawing.Point(12, 164);
            this.keypad.Name = "keypad";
            this.keypad.Size = new System.Drawing.Size(242, 263);
            this.keypad.TabIndex = 2;
            this.keypad.ButtonPressed += new System.EventHandler<SecUI.SecKeypad.SecKeyEventArgs>(this.keypad_ButtonPressed);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 452);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.keypad);
            this.Controls.Add(this.toolStrip);
            this.MinimumSize = new System.Drawing.Size(282, 490);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private SecKeypad keypad;
        private SecScreen screen;
        private System.Windows.Forms.ToolStripDropDownButton tsbMenu;
        private System.Windows.Forms.ToolStripMenuItem btnConnect;
        private System.Windows.Forms.ToolStripMenuItem btnDisconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnTakeScreenshot;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem btnQuit;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripButton btnTextEntry;

    }
}