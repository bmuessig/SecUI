namespace SecUI
{
    partial class SecKeypad
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdSecDown = new System.Windows.Forms.Button();
            this.cmdSecUp = new System.Windows.Forms.Button();
            this.cmdSecRight = new System.Windows.Forms.Button();
            this.cmdSecLeft = new System.Windows.Forms.Button();
            this.cmdSecPound = new System.Windows.Forms.Button();
            this.cmdSecN0 = new System.Windows.Forms.Button();
            this.cmdSecStar = new System.Windows.Forms.Button();
            this.cmdSecN9 = new System.Windows.Forms.Button();
            this.cmdSecN8 = new System.Windows.Forms.Button();
            this.cmdSecN7 = new System.Windows.Forms.Button();
            this.cmdSecN6 = new System.Windows.Forms.Button();
            this.cmdSecN5 = new System.Windows.Forms.Button();
            this.cmdSecN4 = new System.Windows.Forms.Button();
            this.cmdSecN3 = new System.Windows.Forms.Button();
            this.cmdSecN2 = new System.Windows.Forms.Button();
            this.cmdSecN1 = new System.Windows.Forms.Button();
            this.cmdSecUnlock = new System.Windows.Forms.Button();
            this.cmdSecLock = new System.Windows.Forms.Button();
            this.cmdSecHome = new System.Windows.Forms.Button();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSecDown
            // 
            this.tableLayout.SetColumnSpan(this.cmdSecDown, 3);
            this.cmdSecDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecDown.Location = new System.Drawing.Point(97, 29);
            this.cmdSecDown.Name = "cmdSecDown";
            this.cmdSecDown.Size = new System.Drawing.Size(88, 20);
            this.cmdSecDown.TabIndex = 3;
            this.cmdSecDown.Text = "Down [&S]";
            this.cmdSecDown.UseVisualStyleBackColor = true;
            this.cmdSecDown.Click += new System.EventHandler(this.cmdSecDown_Click);
            // 
            // cmdSecUp
            // 
            this.tableLayout.SetColumnSpan(this.cmdSecUp, 3);
            this.cmdSecUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecUp.Location = new System.Drawing.Point(97, 3);
            this.cmdSecUp.Name = "cmdSecUp";
            this.cmdSecUp.Size = new System.Drawing.Size(88, 20);
            this.cmdSecUp.TabIndex = 2;
            this.cmdSecUp.Text = "Up [&W]";
            this.cmdSecUp.UseVisualStyleBackColor = true;
            this.cmdSecUp.Click += new System.EventHandler(this.cmdSecUp_Click);
            // 
            // cmdSecRight
            // 
            this.tableLayout.SetColumnSpan(this.cmdSecRight, 3);
            this.cmdSecRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecRight.Location = new System.Drawing.Point(191, 3);
            this.cmdSecRight.Name = "cmdSecRight";
            this.cmdSecRight.Size = new System.Drawing.Size(91, 20);
            this.cmdSecRight.TabIndex = 1;
            this.cmdSecRight.Text = "Right [&E]";
            this.cmdSecRight.UseVisualStyleBackColor = true;
            this.cmdSecRight.Click += new System.EventHandler(this.cmdSecRight_Click);
            // 
            // cmdSecLeft
            // 
            this.tableLayout.SetColumnSpan(this.cmdSecLeft, 3);
            this.cmdSecLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecLeft.Location = new System.Drawing.Point(3, 3);
            this.cmdSecLeft.Name = "cmdSecLeft";
            this.cmdSecLeft.Size = new System.Drawing.Size(88, 20);
            this.cmdSecLeft.TabIndex = 0;
            this.cmdSecLeft.Text = "Left [&Q]";
            this.cmdSecLeft.UseVisualStyleBackColor = true;
            this.cmdSecLeft.Click += new System.EventHandler(this.cmdSecLeft_Click);
            // 
            // cmdSecPound
            // 
            this.cmdSecPound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecPound.Location = new System.Drawing.Point(191, 186);
            this.cmdSecPound.Name = "cmdSecPound";
            this.cmdSecPound.Size = new System.Drawing.Size(46, 27);
            this.cmdSecPound.TabIndex = 18;
            this.cmdSecPound.Text = "&#";
            this.cmdSecPound.UseVisualStyleBackColor = true;
            this.cmdSecPound.Click += new System.EventHandler(this.cmdSecPound_Click);
            // 
            // cmdSecN0
            // 
            this.cmdSecN0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecN0.Location = new System.Drawing.Point(118, 186);
            this.cmdSecN0.Name = "cmdSecN0";
            this.cmdSecN0.Size = new System.Drawing.Size(46, 27);
            this.cmdSecN0.TabIndex = 16;
            this.cmdSecN0.Text = "&0";
            this.cmdSecN0.UseVisualStyleBackColor = true;
            this.cmdSecN0.Click += new System.EventHandler(this.cmdSecN0_Click);
            // 
            // cmdSecStar
            // 
            this.cmdSecStar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecStar.Location = new System.Drawing.Point(45, 186);
            this.cmdSecStar.Name = "cmdSecStar";
            this.cmdSecStar.Size = new System.Drawing.Size(46, 27);
            this.cmdSecStar.TabIndex = 17;
            this.cmdSecStar.Text = "&*";
            this.cmdSecStar.UseVisualStyleBackColor = true;
            this.cmdSecStar.Click += new System.EventHandler(this.cmdSecStar_Click);
            // 
            // cmdSecN9
            // 
            this.cmdSecN9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecN9.Location = new System.Drawing.Point(191, 160);
            this.cmdSecN9.Name = "cmdSecN9";
            this.cmdSecN9.Size = new System.Drawing.Size(46, 20);
            this.cmdSecN9.TabIndex = 15;
            this.cmdSecN9.Text = "&9";
            this.cmdSecN9.UseVisualStyleBackColor = true;
            this.cmdSecN9.Click += new System.EventHandler(this.cmdSecN9_Click);
            // 
            // cmdSecN8
            // 
            this.cmdSecN8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecN8.Location = new System.Drawing.Point(118, 160);
            this.cmdSecN8.Name = "cmdSecN8";
            this.cmdSecN8.Size = new System.Drawing.Size(46, 20);
            this.cmdSecN8.TabIndex = 14;
            this.cmdSecN8.Text = "&8";
            this.cmdSecN8.UseVisualStyleBackColor = true;
            this.cmdSecN8.Click += new System.EventHandler(this.cmdSecN8_Click);
            // 
            // cmdSecN7
            // 
            this.cmdSecN7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecN7.Location = new System.Drawing.Point(45, 160);
            this.cmdSecN7.Name = "cmdSecN7";
            this.cmdSecN7.Size = new System.Drawing.Size(46, 20);
            this.cmdSecN7.TabIndex = 13;
            this.cmdSecN7.Text = "&7";
            this.cmdSecN7.UseVisualStyleBackColor = true;
            this.cmdSecN7.Click += new System.EventHandler(this.cmdSecN7_Click);
            // 
            // cmdSecN6
            // 
            this.cmdSecN6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecN6.Location = new System.Drawing.Point(191, 134);
            this.cmdSecN6.Name = "cmdSecN6";
            this.cmdSecN6.Size = new System.Drawing.Size(46, 20);
            this.cmdSecN6.TabIndex = 12;
            this.cmdSecN6.Text = "&6";
            this.cmdSecN6.UseVisualStyleBackColor = true;
            this.cmdSecN6.Click += new System.EventHandler(this.cmdSecN6_Click);
            // 
            // cmdSecN5
            // 
            this.cmdSecN5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecN5.Location = new System.Drawing.Point(118, 134);
            this.cmdSecN5.Name = "cmdSecN5";
            this.cmdSecN5.Size = new System.Drawing.Size(46, 20);
            this.cmdSecN5.TabIndex = 11;
            this.cmdSecN5.Text = "&5";
            this.cmdSecN5.UseVisualStyleBackColor = true;
            this.cmdSecN5.Click += new System.EventHandler(this.cmdSecN5_Click);
            // 
            // cmdSecN4
            // 
            this.cmdSecN4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecN4.Location = new System.Drawing.Point(45, 134);
            this.cmdSecN4.Name = "cmdSecN4";
            this.cmdSecN4.Size = new System.Drawing.Size(46, 20);
            this.cmdSecN4.TabIndex = 10;
            this.cmdSecN4.Text = "&4";
            this.cmdSecN4.UseVisualStyleBackColor = true;
            this.cmdSecN4.Click += new System.EventHandler(this.cmdSecN4_Click);
            // 
            // cmdSecN3
            // 
            this.cmdSecN3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecN3.Location = new System.Drawing.Point(191, 108);
            this.cmdSecN3.Name = "cmdSecN3";
            this.cmdSecN3.Size = new System.Drawing.Size(46, 20);
            this.cmdSecN3.TabIndex = 9;
            this.cmdSecN3.Text = "&3";
            this.cmdSecN3.UseVisualStyleBackColor = true;
            this.cmdSecN3.Click += new System.EventHandler(this.cmdSecN3_Click);
            // 
            // cmdSecN2
            // 
            this.cmdSecN2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecN2.Location = new System.Drawing.Point(118, 108);
            this.cmdSecN2.Name = "cmdSecN2";
            this.cmdSecN2.Size = new System.Drawing.Size(46, 20);
            this.cmdSecN2.TabIndex = 8;
            this.cmdSecN2.Text = "&2";
            this.cmdSecN2.UseVisualStyleBackColor = true;
            this.cmdSecN2.Click += new System.EventHandler(this.cmdSecN2_Click);
            // 
            // cmdSecN1
            // 
            this.cmdSecN1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecN1.Location = new System.Drawing.Point(45, 108);
            this.cmdSecN1.Name = "cmdSecN1";
            this.cmdSecN1.Size = new System.Drawing.Size(46, 20);
            this.cmdSecN1.TabIndex = 7;
            this.cmdSecN1.Text = "&1";
            this.cmdSecN1.UseVisualStyleBackColor = true;
            this.cmdSecN1.Click += new System.EventHandler(this.cmdSecN1_Click);
            // 
            // cmdSecUnlock
            // 
            this.tableLayout.SetColumnSpan(this.cmdSecUnlock, 3);
            this.cmdSecUnlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecUnlock.Location = new System.Drawing.Point(191, 55);
            this.cmdSecUnlock.Name = "cmdSecUnlock";
            this.cmdSecUnlock.Size = new System.Drawing.Size(91, 20);
            this.cmdSecUnlock.TabIndex = 6;
            this.cmdSecUnlock.Text = "&Unlock";
            this.cmdSecUnlock.UseVisualStyleBackColor = true;
            this.cmdSecUnlock.Click += new System.EventHandler(this.cmdSecUnlock_Click);
            // 
            // cmdSecLock
            // 
            this.tableLayout.SetColumnSpan(this.cmdSecLock, 3);
            this.cmdSecLock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecLock.Location = new System.Drawing.Point(97, 55);
            this.cmdSecLock.Name = "cmdSecLock";
            this.cmdSecLock.Size = new System.Drawing.Size(88, 20);
            this.cmdSecLock.TabIndex = 5;
            this.cmdSecLock.Text = "&Lock";
            this.cmdSecLock.UseVisualStyleBackColor = true;
            this.cmdSecLock.Click += new System.EventHandler(this.cmdSecLock_Click);
            // 
            // cmdSecHome
            // 
            this.tableLayout.SetColumnSpan(this.cmdSecHome, 3);
            this.cmdSecHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSecHome.Location = new System.Drawing.Point(3, 55);
            this.cmdSecHome.Name = "cmdSecHome";
            this.cmdSecHome.Size = new System.Drawing.Size(88, 20);
            this.cmdSecHome.TabIndex = 4;
            this.cmdSecHome.Text = "&Home";
            this.cmdSecHome.UseVisualStyleBackColor = true;
            this.cmdSecHome.Click += new System.EventHandler(this.cmdSecHome_Click);
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 9;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.410741F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.410741F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51185F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.410741F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51185F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.410741F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51185F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.410741F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.410741F));
            this.tableLayout.Controls.Add(this.cmdSecHome, 0, 2);
            this.tableLayout.Controls.Add(this.cmdSecLeft, 0, 0);
            this.tableLayout.Controls.Add(this.cmdSecRight, 6, 0);
            this.tableLayout.Controls.Add(this.cmdSecUp, 3, 0);
            this.tableLayout.Controls.Add(this.cmdSecDown, 3, 1);
            this.tableLayout.Controls.Add(this.cmdSecUnlock, 6, 2);
            this.tableLayout.Controls.Add(this.cmdSecLock, 3, 2);
            this.tableLayout.Controls.Add(this.cmdSecN2, 4, 4);
            this.tableLayout.Controls.Add(this.cmdSecN5, 4, 5);
            this.tableLayout.Controls.Add(this.cmdSecN8, 4, 6);
            this.tableLayout.Controls.Add(this.cmdSecN0, 4, 7);
            this.tableLayout.Controls.Add(this.cmdSecN3, 6, 4);
            this.tableLayout.Controls.Add(this.cmdSecN6, 6, 5);
            this.tableLayout.Controls.Add(this.cmdSecN9, 6, 6);
            this.tableLayout.Controls.Add(this.cmdSecPound, 6, 7);
            this.tableLayout.Controls.Add(this.cmdSecStar, 2, 7);
            this.tableLayout.Controls.Add(this.cmdSecN7, 2, 6);
            this.tableLayout.Controls.Add(this.cmdSecN4, 2, 5);
            this.tableLayout.Controls.Add(this.cmdSecN1, 2, 4);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 8;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50328F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayout.Size = new System.Drawing.Size(285, 216);
            this.tableLayout.TabIndex = 19;
            // 
            // SecKeypad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayout);
            this.Name = "SecKeypad";
            this.Size = new System.Drawing.Size(285, 216);
            this.tableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSecDown;
        private System.Windows.Forms.Button cmdSecUp;
        private System.Windows.Forms.Button cmdSecRight;
        private System.Windows.Forms.Button cmdSecLeft;
        private System.Windows.Forms.Button cmdSecPound;
        private System.Windows.Forms.Button cmdSecN0;
        private System.Windows.Forms.Button cmdSecStar;
        private System.Windows.Forms.Button cmdSecN9;
        private System.Windows.Forms.Button cmdSecN8;
        private System.Windows.Forms.Button cmdSecN7;
        private System.Windows.Forms.Button cmdSecN6;
        private System.Windows.Forms.Button cmdSecN5;
        private System.Windows.Forms.Button cmdSecN4;
        private System.Windows.Forms.Button cmdSecN3;
        private System.Windows.Forms.Button cmdSecN2;
        private System.Windows.Forms.Button cmdSecN1;
        private System.Windows.Forms.Button cmdSecUnlock;
        private System.Windows.Forms.Button cmdSecLock;
        private System.Windows.Forms.Button cmdSecHome;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
    }
}
