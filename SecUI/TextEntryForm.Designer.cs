namespace SecUI
{
    partial class TextEntryForm
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
            this.components = new System.ComponentModel.Container();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.screen = new SecUI.SecScreen();
            this.pBar = new System.Windows.Forms.Panel();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCapsStatus = new System.Windows.Forms.Label();
            this.lblEntryStatus = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbOverride = new System.Windows.Forms.CheckBox();
            this.cbLowercaseOverride = new System.Windows.Forms.CheckBox();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(10, 172);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(242, 20);
            this.tbMessage.TabIndex = 0;
            // 
            // screen
            // 
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screen.Image = null;
            this.screen.Location = new System.Drawing.Point(10, 40);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(242, 130);
            this.screen.TabIndex = 1;
            // 
            // pBar
            // 
            this.pBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBar.Location = new System.Drawing.Point(0, 33);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(449, 1);
            this.pBar.TabIndex = 9;
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.White;
            this.pHeader.Controls.Add(this.lblTitle);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(449, 33);
            this.pHeader.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(7, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 15);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Enter text into the current screen";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCapsStatus
            // 
            this.lblCapsStatus.AutoSize = true;
            this.lblCapsStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCapsStatus.Location = new System.Drawing.Point(3, 13);
            this.lblCapsStatus.Name = "lblCapsStatus";
            this.lblCapsStatus.Size = new System.Drawing.Size(173, 13);
            this.lblCapsStatus.TabIndex = 11;
            this.lblCapsStatus.Text = "Capslock status";
            // 
            // lblEntryStatus
            // 
            this.lblEntryStatus.AutoSize = true;
            this.lblEntryStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntryStatus.Location = new System.Drawing.Point(3, 0);
            this.lblEntryStatus.Name = "lblEntryStatus";
            this.lblEntryStatus.Size = new System.Drawing.Size(173, 13);
            this.lblEntryStatus.TabIndex = 12;
            this.lblEntryStatus.Text = "Entry status";
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnter.Location = new System.Drawing.Point(362, 170);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter text";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(281, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblEntryStatus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCapsStatus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbOverride, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbLowercaseOverride, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(258, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(179, 124);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // cbOverride
            // 
            this.cbOverride.AutoSize = true;
            this.cbOverride.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbOverride.Location = new System.Drawing.Point(3, 47);
            this.cbOverride.Name = "cbOverride";
            this.cbOverride.Size = new System.Drawing.Size(173, 17);
            this.cbOverride.TabIndex = 13;
            this.cbOverride.Text = "Override Warning";
            this.cbOverride.UseVisualStyleBackColor = true;
            this.cbOverride.Visible = false;
            this.cbOverride.CheckedChanged += new System.EventHandler(this.cbOverride_CheckedChanged);
            // 
            // cbLowercaseOverride
            // 
            this.cbLowercaseOverride.AutoSize = true;
            this.cbLowercaseOverride.Location = new System.Drawing.Point(3, 70);
            this.cbLowercaseOverride.Name = "cbLowercaseOverride";
            this.cbLowercaseOverride.Size = new System.Drawing.Size(153, 17);
            this.cbLowercaseOverride.TabIndex = 14;
            this.cbLowercaseOverride.Text = "Lowercase currently active";
            this.cbLowercaseOverride.UseVisualStyleBackColor = true;
            this.cbLowercaseOverride.Visible = false;
            // 
            // TextEntryForm
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(449, 205);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.tbMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Text entry";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TextEntryForm_Load);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMessage;
        private SecScreen screen;
        private System.Windows.Forms.Panel pBar;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCapsStatus;
        private System.Windows.Forms.Label lblEntryStatus;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox cbOverride;
        private System.Windows.Forms.CheckBox cbLowercaseOverride;
    }
}