namespace WcfTestLibWinFormHost
{
    partial class MainFormHost
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartHosting = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageCreationPattern = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreatePerCallStartHosting = new System.Windows.Forms.Button();
            this.btnCreateSingleStartHosting = new System.Windows.Forms.Button();
            this.btnCreatePerSessionStartHosting = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabPageMTOM = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStartDataUpDownload = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbxDir = new System.Windows.Forms.TextBox();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageCreationPattern.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPageMTOM.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCreationPattern);
            this.tabControl1.Controls.Add(this.tabPageMTOM);
            this.tabControl1.Controls.SetChildIndex(this.tabPageMTOM, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabPageCreationPattern, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabPage2, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabPage1, 0);
            // 
            // tabPage1
            // 
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // lbxLog
            // 
            this.lbxLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxLog.Size = new System.Drawing.Size(784, 260);
            // 
            // cbxLbxLogAnzeigeoptionen
            // 
            this.cbxLbxLogAnzeigeoptionen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxLbxLogAnzeigeoptionen.Size = new System.Drawing.Size(157, 38);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Text = "HelloService";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 59);
            this.panel2.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 61);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(786, 313);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStartHosting, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "CreationPatternPerCall";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hello ";
            // 
            // btnStartHosting
            // 
            this.btnStartHosting.Location = new System.Drawing.Point(396, 2);
            this.btnStartHosting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartHosting.Name = "btnStartHosting";
            this.btnStartHosting.Size = new System.Drawing.Size(175, 27);
            this.btnStartHosting.TabIndex = 2;
            this.btnStartHosting.Text = "Start Hosting";
            this.btnStartHosting.UseVisualStyleBackColor = true;
            this.btnStartHosting.Click += new System.EventHandler(this.btnStartHosting_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "CreationPatternPer";
            // 
            // tabPageCreationPattern
            // 
            this.tabPageCreationPattern.Controls.Add(this.tableLayoutPanel2);
            this.tabPageCreationPattern.Controls.Add(this.panel3);
            this.tabPageCreationPattern.Location = new System.Drawing.Point(4, 25);
            this.tabPageCreationPattern.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCreationPattern.Name = "tabPageCreationPattern";
            this.tabPageCreationPattern.Size = new System.Drawing.Size(792, 376);
            this.tabPageCreationPattern.TabIndex = 2;
            this.tabPageCreationPattern.Text = "CreationPatterns";
            this.tabPageCreationPattern.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnCreatePerCallStartHosting, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCreateSingleStartHosting, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCreatePerSessionStartHosting, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(789, 167);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Create Per Call";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Create Single";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Create Per Session";
            // 
            // btnCreatePerCallStartHosting
            // 
            this.btnCreatePerCallStartHosting.Location = new System.Drawing.Point(397, 2);
            this.btnCreatePerCallStartHosting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreatePerCallStartHosting.Name = "btnCreatePerCallStartHosting";
            this.btnCreatePerCallStartHosting.Size = new System.Drawing.Size(157, 30);
            this.btnCreatePerCallStartHosting.TabIndex = 3;
            this.btnCreatePerCallStartHosting.Text = "Start Hosting";
            this.btnCreatePerCallStartHosting.UseVisualStyleBackColor = true;
            this.btnCreatePerCallStartHosting.Click += new System.EventHandler(this.btnCreatePerCallStartHosting_Click);
            // 
            // btnCreateSingleStartHosting
            // 
            this.btnCreateSingleStartHosting.Location = new System.Drawing.Point(397, 60);
            this.btnCreateSingleStartHosting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateSingleStartHosting.Name = "btnCreateSingleStartHosting";
            this.btnCreateSingleStartHosting.Size = new System.Drawing.Size(157, 33);
            this.btnCreateSingleStartHosting.TabIndex = 4;
            this.btnCreateSingleStartHosting.Text = "Start Hosting";
            this.btnCreateSingleStartHosting.UseVisualStyleBackColor = true;
            this.btnCreateSingleStartHosting.Click += new System.EventHandler(this.btnCreateSingleStartHosting_Click);
            // 
            // btnCreatePerSessionStartHosting
            // 
            this.btnCreatePerSessionStartHosting.Location = new System.Drawing.Point(397, 118);
            this.btnCreatePerSessionStartHosting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreatePerSessionStartHosting.Name = "btnCreatePerSessionStartHosting";
            this.btnCreatePerSessionStartHosting.Size = new System.Drawing.Size(157, 34);
            this.btnCreatePerSessionStartHosting.TabIndex = 5;
            this.btnCreatePerSessionStartHosting.Text = "Start Hosting";
            this.btnCreatePerSessionStartHosting.UseVisualStyleBackColor = true;
            this.btnCreatePerSessionStartHosting.Click += new System.EventHandler(this.btnCreatePerSessionStartHosting_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(789, 55);
            this.panel3.TabIndex = 0;
            // 
            // tabPageMTOM
            // 
            this.tabPageMTOM.Controls.Add(this.tableLayoutPanel3);
            this.tabPageMTOM.Controls.Add(this.panel5);
            this.tabPageMTOM.Location = new System.Drawing.Point(4, 25);
            this.tabPageMTOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMTOM.Name = "tabPageMTOM";
            this.tabPageMTOM.Size = new System.Drawing.Size(792, 376);
            this.tabPageMTOM.TabIndex = 4;
            this.tabPageMTOM.Text = "Data Up/Downloads";
            this.tabPageMTOM.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.29798F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.70202F));
            this.tableLayoutPanel3.Controls.Add(this.btnStartDataUpDownload, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(792, 100);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnStartDataUpDownload
            // 
            this.btnStartDataUpDownload.Location = new System.Drawing.Point(338, 2);
            this.btnStartDataUpDownload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartDataUpDownload.Name = "btnStartDataUpDownload";
            this.btnStartDataUpDownload.Size = new System.Drawing.Size(120, 34);
            this.btnStartDataUpDownload.TabIndex = 0;
            this.btnStartDataUpDownload.Text = "StartHosting";
            this.btnStartDataUpDownload.UseVisualStyleBackColor = true;
            this.btnStartDataUpDownload.Click += new System.EventHandler(this.btnStartDataUpDownload_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbxDir);
            this.panel5.Controls.Add(this.btnOpenDir);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(792, 42);
            this.panel5.TabIndex = 0;
            // 
            // tbxDir
            // 
            this.tbxDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDir.Location = new System.Drawing.Point(9, 4);
            this.tbxDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDir.Name = "tbxDir";
            this.tbxDir.Size = new System.Drawing.Size(695, 22);
            this.tbxDir.TabIndex = 1;
            this.tbxDir.Text = "c:\\temp";
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDir.Location = new System.Drawing.Point(710, 2);
            this.btnOpenDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(75, 36);
            this.btnOpenDir.TabIndex = 0;
            this.btnOpenDir.Text = "OpenDir";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // MainFormHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainFormHost";
            this.Text = "WcfTestLibHost";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageCreationPattern.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPageMTOM.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartHosting;
        private System.Windows.Forms.TabPage tabPageCreationPattern;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreatePerCallStartHosting;
        private System.Windows.Forms.Button btnCreateSingleStartHosting;
        private System.Windows.Forms.Button btnCreatePerSessionStartHosting;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageMTOM;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbxDir;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnStartDataUpDownload;
    }
}
