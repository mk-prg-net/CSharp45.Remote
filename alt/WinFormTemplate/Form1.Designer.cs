namespace WinFormTemplate
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AppStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1Main = new System.Windows.Forms.TabPage();
            this.lbxLog = new System.Windows.Forms.ListBox();
            this.panLogTools = new System.Windows.Forms.Panel();
            this.btnTabLogClearLbxLog = new System.Windows.Forms.Button();
            this.btnTabLogGenTestmeldung = new System.Windows.Forms.Button();
            this.tabPage2Main = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1Main.SuspendLayout();
            this.panLogTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1035, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1035, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AppStatusLabel
            // 
            this.AppStatusLabel.Name = "AppStatusLabel";
            this.AppStatusLabel.Size = new System.Drawing.Size(16, 17);
            this.AppStatusLabel.Text = "...";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1Main);
            this.tabControlMain.Controls.Add(this.tabPage2Main);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1035, 406);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPage1Main
            // 
            this.tabPage1Main.Controls.Add(this.lbxLog);
            this.tabPage1Main.Controls.Add(this.panLogTools);
            this.tabPage1Main.Location = new System.Drawing.Point(4, 22);
            this.tabPage1Main.Name = "tabPage1Main";
            this.tabPage1Main.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Main.Size = new System.Drawing.Size(1027, 380);
            this.tabPage1Main.TabIndex = 0;
            this.tabPage1Main.Text = "Log";
            this.tabPage1Main.UseVisualStyleBackColor = true;
            // 
            // lbxLog
            // 
            this.lbxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxLog.FormattingEnabled = true;
            this.lbxLog.Location = new System.Drawing.Point(3, 56);
            this.lbxLog.Name = "lbxLog";
            this.lbxLog.Size = new System.Drawing.Size(1021, 321);
            this.lbxLog.TabIndex = 1;
            // 
            // panLogTools
            // 
            this.panLogTools.BackColor = System.Drawing.Color.AliceBlue;
            this.panLogTools.Controls.Add(this.btnTabLogClearLbxLog);
            this.panLogTools.Controls.Add(this.btnTabLogGenTestmeldung);
            this.panLogTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLogTools.Location = new System.Drawing.Point(3, 3);
            this.panLogTools.Name = "panLogTools";
            this.panLogTools.Size = new System.Drawing.Size(1021, 53);
            this.panLogTools.TabIndex = 0;
            // 
            // btnTabLogClearLbxLog
            // 
            this.btnTabLogClearLbxLog.Location = new System.Drawing.Point(147, 3);
            this.btnTabLogClearLbxLog.Name = "btnTabLogClearLbxLog";
            this.btnTabLogClearLbxLog.Size = new System.Drawing.Size(162, 23);
            this.btnTabLogClearLbxLog.TabIndex = 1;
            this.btnTabLogClearLbxLog.Text = "Alle Meldungen löschen";
            this.btnTabLogClearLbxLog.UseVisualStyleBackColor = true;
            this.btnTabLogClearLbxLog.Click += new System.EventHandler(this.btnTabLogClearLbxLog_Click);
            // 
            // btnTabLogGenTestmeldung
            // 
            this.btnTabLogGenTestmeldung.Location = new System.Drawing.Point(5, 3);
            this.btnTabLogGenTestmeldung.Name = "btnTabLogGenTestmeldung";
            this.btnTabLogGenTestmeldung.Size = new System.Drawing.Size(118, 23);
            this.btnTabLogGenTestmeldung.TabIndex = 0;
            this.btnTabLogGenTestmeldung.Text = "Testmeldung erzeugen";
            this.btnTabLogGenTestmeldung.UseVisualStyleBackColor = true;
            this.btnTabLogGenTestmeldung.Click += new System.EventHandler(this.btnTabLogGenTestmeldung_Click);
            // 
            // tabPage2Main
            // 
            this.tabPage2Main.Location = new System.Drawing.Point(4, 22);
            this.tabPage2Main.Name = "tabPage2Main";
            this.tabPage2Main.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Main.Size = new System.Drawing.Size(1027, 380);
            this.tabPage2Main.TabIndex = 1;
            this.tabPage2Main.Text = "tabPage2";
            this.tabPage2Main.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 452);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1Main.ResumeLayout(false);
            this.panLogTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel AppStatusLabel;
        private System.Windows.Forms.TabPage tabPage1Main;
        private System.Windows.Forms.Panel panLogTools;
        private System.Windows.Forms.Button btnTabLogGenTestmeldung;
        private System.Windows.Forms.Button btnTabLogClearLbxLog;
        protected System.Windows.Forms.TabControl tabControlMain;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ListBox lbxLog;
        protected System.Windows.Forms.TabPage tabPage2Main;
    }
}

