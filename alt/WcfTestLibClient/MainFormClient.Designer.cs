namespace WcfTestLibClient
{
    partial class MainFormClient
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxLongRunningOpMinExecTime = new System.Windows.Forms.TextBox();
            this.btnLongRunningOpStartSync = new System.Windows.Forms.Button();
            this.btnLongRunningOpStartAsync = new System.Windows.Forms.Button();
            this.progressBarLongRunningOp = new System.Windows.Forms.ProgressBar();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnFertig = new System.Windows.Forms.Button();
            this.lblResultDelaydReturn = new System.Windows.Forms.Label();
            this.btnDeleayedReturnAsyncCallback = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOpenUploadFile = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tbxUploadFilename = new System.Windows.Forms.TextBox();
            this.tbxDownloadFilename = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDownloadVerzeichnis = new System.Windows.Forms.Label();
            this.btnDownloadStream = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAllFilesRequery = new System.Windows.Forms.Button();
            this.grdDataServiceResult = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diruidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superdiruidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkeyfileidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkeydiridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkeysuperdiridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilesDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFilesDb1 = new WcfTestLibClient.DataSetServiceRef.DsFilesDb();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFilesDbSaveChanges = new System.Windows.Forms.Button();
            this.btnFilesDbRequery = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGetUploadFilelist = new System.Windows.Forms.Button();
            this.grdUploadedFiles = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabControlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataServiceResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilesDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFilesDb1)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUploadedFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Size = new System.Drawing.Size(600, 323);
            // 
            // lbxLog
            // 
            this.lbxLog.Items.AddRange(new object[] {
            "22:41 INFO  WinFormTemplate.Form1.Form_Load \"erfolgreich gestartet\" "});
            this.lbxLog.Location = new System.Drawing.Point(2, 55);
            this.lbxLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxLog.Size = new System.Drawing.Size(588, 238);
            // 
            // tabPage2Main
            // 
            this.tabPage2Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2Main.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 60);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.64631F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.35369F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 62);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.62996F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.370044F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 279);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Langläufer- Operation: Aufruf Synchron und Asynchron";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.98489F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.01511F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbxLongRunningOpMinExecTime, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLongRunningOpStartSync, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnLongRunningOpStartAsync, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.progressBarLongRunningOp, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnBegin, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnFertig, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblResultDelaydReturn, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleayedReturnAsyncCallback, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(181, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(602, 230);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dauer der Ausführung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Synchroner Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Asynchroner Start";
            // 
            // tbxLongRunningOpMinExecTime
            // 
            this.tbxLongRunningOpMinExecTime.Location = new System.Drawing.Point(215, 2);
            this.tbxLongRunningOpMinExecTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLongRunningOpMinExecTime.Name = "tbxLongRunningOpMinExecTime";
            this.tbxLongRunningOpMinExecTime.Size = new System.Drawing.Size(100, 20);
            this.tbxLongRunningOpMinExecTime.TabIndex = 3;
            this.tbxLongRunningOpMinExecTime.Text = "1000";
            // 
            // btnLongRunningOpStartSync
            // 
            this.btnLongRunningOpStartSync.Location = new System.Drawing.Point(215, 40);
            this.btnLongRunningOpStartSync.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLongRunningOpStartSync.Name = "btnLongRunningOpStartSync";
            this.btnLongRunningOpStartSync.Size = new System.Drawing.Size(100, 23);
            this.btnLongRunningOpStartSync.TabIndex = 4;
            this.btnLongRunningOpStartSync.Text = "Start";
            this.btnLongRunningOpStartSync.UseVisualStyleBackColor = true;
            this.btnLongRunningOpStartSync.Click += new System.EventHandler(this.btnLongRunningOpStartSync_Click);
            // 
            // btnLongRunningOpStartAsync
            // 
            this.btnLongRunningOpStartAsync.Location = new System.Drawing.Point(215, 78);
            this.btnLongRunningOpStartAsync.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLongRunningOpStartAsync.Name = "btnLongRunningOpStartAsync";
            this.btnLongRunningOpStartAsync.Size = new System.Drawing.Size(100, 25);
            this.btnLongRunningOpStartAsync.TabIndex = 5;
            this.btnLongRunningOpStartAsync.Text = "Start";
            this.btnLongRunningOpStartAsync.UseVisualStyleBackColor = true;
            this.btnLongRunningOpStartAsync.Click += new System.EventHandler(this.btnLongRunningOpStartAsync_Click);
            // 
            // progressBarLongRunningOp
            // 
            this.progressBarLongRunningOp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarLongRunningOp.Location = new System.Drawing.Point(389, 78);
            this.progressBarLongRunningOp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarLongRunningOp.Name = "progressBarLongRunningOp";
            this.progressBarLongRunningOp.Size = new System.Drawing.Size(210, 30);
            this.progressBarLongRunningOp.TabIndex = 6;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(216, 114);
            this.btnBegin.Margin = new System.Windows.Forms.Padding(4);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(100, 26);
            this.btnBegin.TabIndex = 7;
            this.btnBegin.Text = "Beginn";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnFertig
            // 
            this.btnFertig.Location = new System.Drawing.Point(216, 148);
            this.btnFertig.Margin = new System.Windows.Forms.Padding(4);
            this.btnFertig.Name = "btnFertig";
            this.btnFertig.Size = new System.Drawing.Size(100, 31);
            this.btnFertig.TabIndex = 8;
            this.btnFertig.Text = "Fertig?";
            this.btnFertig.UseVisualStyleBackColor = true;
            this.btnFertig.Click += new System.EventHandler(this.btnFertig_Click);
            // 
            // lblResultDelaydReturn
            // 
            this.lblResultDelaydReturn.AutoSize = true;
            this.lblResultDelaydReturn.Location = new System.Drawing.Point(390, 144);
            this.lblResultDelaydReturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultDelaydReturn.Name = "lblResultDelaydReturn";
            this.lblResultDelaydReturn.Size = new System.Drawing.Size(10, 13);
            this.lblResultDelaydReturn.TabIndex = 9;
            this.lblResultDelaydReturn.Text = "-";
            // 
            // btnDeleayedReturnAsyncCallback
            // 
            this.btnDeleayedReturnAsyncCallback.Location = new System.Drawing.Point(216, 195);
            this.btnDeleayedReturnAsyncCallback.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleayedReturnAsyncCallback.Name = "btnDeleayedReturnAsyncCallback";
            this.btnDeleayedReturnAsyncCallback.Size = new System.Drawing.Size(116, 28);
            this.btnDeleayedReturnAsyncCallback.TabIndex = 10;
            this.btnDeleayedReturnAsyncCallback.Text = "AsyncCallback";
            this.btnDeleayedReturnAsyncCallback.UseVisualStyleBackColor = true;
            this.btnDeleayedReturnAsyncCallback.Click += new System.EventHandler(this.btnDeleayedReturnAsyncCallback_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Asynchrone Op starten";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Warten bis Ende der async. Operation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 26);
            this.label11.TabIndex = 13;
            this.label11.Text = "Asynchrone Op starten. Ende mit Callback signalisieren";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Up/Downloads";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.40404F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.59596F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOpenUploadFile, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUpload, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbxUploadFilename, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbxDownloadFilename, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnDownload, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblDownloadVerzeichnis, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnDownloadStream, 3, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(792, 308);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Upload";
            // 
            // btnOpenUploadFile
            // 
            this.btnOpenUploadFile.Location = new System.Drawing.Point(527, 2);
            this.btnOpenUploadFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenUploadFile.Name = "btnOpenUploadFile";
            this.btnOpenUploadFile.Size = new System.Drawing.Size(99, 46);
            this.btnOpenUploadFile.TabIndex = 1;
            this.btnOpenUploadFile.Text = "Datei wählen";
            this.btnOpenUploadFile.UseVisualStyleBackColor = true;
            this.btnOpenUploadFile.Click += new System.EventHandler(this.btnOpenUploadFile_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(650, 2);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(105, 46);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Hochladen";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tbxUploadFilename
            // 
            this.tbxUploadFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxUploadFilename.Location = new System.Drawing.Point(83, 2);
            this.tbxUploadFilename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxUploadFilename.Name = "tbxUploadFilename";
            this.tbxUploadFilename.Size = new System.Drawing.Size(438, 20);
            this.tbxUploadFilename.TabIndex = 3;
            // 
            // tbxDownloadFilename
            // 
            this.tbxDownloadFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDownloadFilename.Location = new System.Drawing.Point(83, 60);
            this.tbxDownloadFilename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDownloadFilename.Name = "tbxDownloadFilename";
            this.tbxDownloadFilename.Size = new System.Drawing.Size(438, 20);
            this.tbxDownloadFilename.TabIndex = 5;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(650, 60);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(105, 46);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Runterladen";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Download";
            // 
            // lblDownloadVerzeichnis
            // 
            this.lblDownloadVerzeichnis.AutoSize = true;
            this.lblDownloadVerzeichnis.Location = new System.Drawing.Point(83, 116);
            this.lblDownloadVerzeichnis.Name = "lblDownloadVerzeichnis";
            this.lblDownloadVerzeichnis.Size = new System.Drawing.Size(10, 13);
            this.lblDownloadVerzeichnis.TabIndex = 7;
            this.lblDownloadVerzeichnis.Text = "-";
            // 
            // btnDownloadStream
            // 
            this.btnDownloadStream.Location = new System.Drawing.Point(650, 118);
            this.btnDownloadStream.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDownloadStream.Name = "btnDownloadStream";
            this.btnDownloadStream.Size = new System.Drawing.Size(105, 53);
            this.btnDownloadStream.TabIndex = 8;
            this.btnDownloadStream.Text = "Runterladen Stream";
            this.btnDownloadStream.UseVisualStyleBackColor = true;
            this.btnDownloadStream.Click += new System.EventHandler(this.btnDownloadStream_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 55);
            this.panel3.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel4);
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 376);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "WCF Data Services";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.95652F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.04348F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAllFilesRequery, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.grdDataServiceResult, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 47);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(792, 250);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Alle Dateien";
            // 
            // btnAllFilesRequery
            // 
            this.btnAllFilesRequery.Location = new System.Drawing.Point(682, 2);
            this.btnAllFilesRequery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllFilesRequery.Name = "btnAllFilesRequery";
            this.btnAllFilesRequery.Size = new System.Drawing.Size(75, 30);
            this.btnAllFilesRequery.TabIndex = 2;
            this.btnAllFilesRequery.Text = "Requery";
            this.btnAllFilesRequery.UseVisualStyleBackColor = true;
            this.btnAllFilesRequery.Click += new System.EventHandler(this.btnAllFilesRequery_Click);
            // 
            // grdDataServiceResult
            // 
            this.grdDataServiceResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataServiceResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDataServiceResult.Location = new System.Drawing.Point(119, 4);
            this.grdDataServiceResult.Margin = new System.Windows.Forms.Padding(4);
            this.grdDataServiceResult.Name = "grdDataServiceResult";
            this.grdDataServiceResult.RowTemplate.Height = 24;
            this.grdDataServiceResult.Size = new System.Drawing.Size(556, 117);
            this.grdDataServiceResult.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(792, 47);
            this.panel4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Controls.Add(this.panel5);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 376);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "DataSet Up/Download";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fileuidDataGridViewTextBoxColumn,
            this.diruidDataGridViewTextBoxColumn,
            this.superdiruidDataGridViewTextBoxColumn,
            this.fkeyfileidDataGridViewTextBoxColumn,
            this.fkeydiridDataGridViewTextBoxColumn,
            this.fkeysuperdiridDataGridViewTextBoxColumn,
            this.filenameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.FilesDbDataSetBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(792, 307);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileuidDataGridViewTextBoxColumn
            // 
            this.fileuidDataGridViewTextBoxColumn.DataPropertyName = "file_uid";
            this.fileuidDataGridViewTextBoxColumn.HeaderText = "file_uid";
            this.fileuidDataGridViewTextBoxColumn.Name = "fileuidDataGridViewTextBoxColumn";
            // 
            // diruidDataGridViewTextBoxColumn
            // 
            this.diruidDataGridViewTextBoxColumn.DataPropertyName = "dir_uid";
            this.diruidDataGridViewTextBoxColumn.HeaderText = "dir_uid";
            this.diruidDataGridViewTextBoxColumn.Name = "diruidDataGridViewTextBoxColumn";
            // 
            // superdiruidDataGridViewTextBoxColumn
            // 
            this.superdiruidDataGridViewTextBoxColumn.DataPropertyName = "super_dir_uid";
            this.superdiruidDataGridViewTextBoxColumn.HeaderText = "super_dir_uid";
            this.superdiruidDataGridViewTextBoxColumn.Name = "superdiruidDataGridViewTextBoxColumn";
            // 
            // fkeyfileidDataGridViewTextBoxColumn
            // 
            this.fkeyfileidDataGridViewTextBoxColumn.DataPropertyName = "fkey_file_id";
            this.fkeyfileidDataGridViewTextBoxColumn.HeaderText = "fkey_file_id";
            this.fkeyfileidDataGridViewTextBoxColumn.Name = "fkeyfileidDataGridViewTextBoxColumn";
            // 
            // fkeydiridDataGridViewTextBoxColumn
            // 
            this.fkeydiridDataGridViewTextBoxColumn.DataPropertyName = "fkey_dir_id";
            this.fkeydiridDataGridViewTextBoxColumn.HeaderText = "fkey_dir_id";
            this.fkeydiridDataGridViewTextBoxColumn.Name = "fkeydiridDataGridViewTextBoxColumn";
            // 
            // fkeysuperdiridDataGridViewTextBoxColumn
            // 
            this.fkeysuperdiridDataGridViewTextBoxColumn.DataPropertyName = "fkey_super_dir_id";
            this.fkeysuperdiridDataGridViewTextBoxColumn.HeaderText = "fkey_super_dir_id";
            this.fkeysuperdiridDataGridViewTextBoxColumn.Name = "fkeysuperdiridDataGridViewTextBoxColumn";
            // 
            // filenameDataGridViewTextBoxColumn
            // 
            this.filenameDataGridViewTextBoxColumn.DataPropertyName = "filename";
            this.filenameDataGridViewTextBoxColumn.HeaderText = "filename";
            this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
            // 
            // FilesDbDataSetBindingSource
            // 
            this.FilesDbDataSetBindingSource.DataMember = "files";
            this.FilesDbDataSetBindingSource.DataSource = this.dsFilesDb1;
            // 
            // dsFilesDb1
            // 
            this.dsFilesDb1.DataSetName = "DsFilesDb";
            this.dsFilesDb1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnFilesDbSaveChanges);
            this.panel5.Controls.Add(this.btnFilesDbRequery);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(792, 69);
            this.panel5.TabIndex = 0;
            // 
            // btnFilesDbSaveChanges
            // 
            this.btnFilesDbSaveChanges.Location = new System.Drawing.Point(139, 16);
            this.btnFilesDbSaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilesDbSaveChanges.Name = "btnFilesDbSaveChanges";
            this.btnFilesDbSaveChanges.Size = new System.Drawing.Size(128, 28);
            this.btnFilesDbSaveChanges.TabIndex = 1;
            this.btnFilesDbSaveChanges.Text = "Save Changes";
            this.btnFilesDbSaveChanges.UseVisualStyleBackColor = true;
            this.btnFilesDbSaveChanges.Click += new System.EventHandler(this.btnFilesDbSaveChanges_Click);
            // 
            // btnFilesDbRequery
            // 
            this.btnFilesDbRequery.Location = new System.Drawing.Point(11, 16);
            this.btnFilesDbRequery.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilesDbRequery.Name = "btnFilesDbRequery";
            this.btnFilesDbRequery.Size = new System.Drawing.Size(100, 28);
            this.btnFilesDbRequery.TabIndex = 0;
            this.btnFilesDbRequery.Text = "Requery";
            this.btnFilesDbRequery.UseVisualStyleBackColor = true;
            this.btnFilesDbRequery.Click += new System.EventHandler(this.btnFilesDbRequery_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tableLayoutPanel5);
            this.tabPage6.Controls.Add(this.panel6);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(792, 376);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Security";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.40713F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.59287F));
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnGetUploadFilelist, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.grdUploadedFiles, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 51);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.45963F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.54037F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(786, 322);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "Anmelden und Liste der Dateien aus dem Uploadverzeichnis abrufen.";
            // 
            // btnGetUploadFilelist
            // 
            this.btnGetUploadFilelist.Location = new System.Drawing.Point(242, 3);
            this.btnGetUploadFilelist.Name = "btnGetUploadFilelist";
            this.btnGetUploadFilelist.Size = new System.Drawing.Size(292, 23);
            this.btnGetUploadFilelist.TabIndex = 1;
            this.btnGetUploadFilelist.Text = "Liste der hochgeladenen Dateien abrufen";
            this.btnGetUploadFilelist.UseVisualStyleBackColor = true;
            this.btnGetUploadFilelist.Click += new System.EventHandler(this.btnGetUploadFilelist_Click);
            // 
            // grdUploadedFiles
            // 
            this.grdUploadedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUploadedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUploadedFiles.Location = new System.Drawing.Point(242, 56);
            this.grdUploadedFiles.Name = "grdUploadedFiles";
            this.grdUploadedFiles.RowTemplate.Height = 24;
            this.grdUploadedFiles.Size = new System.Drawing.Size(541, 263);
            this.grdUploadedFiles.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(786, 48);
            this.panel6.TabIndex = 0;
            // 
            // MainFormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 369);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainFormClient";
            this.Text = "WcfTestLibClient";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataServiceResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilesDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFilesDb1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUploadedFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxLongRunningOpMinExecTime;
        private System.Windows.Forms.Button btnLongRunningOpStartSync;
        private System.Windows.Forms.Button btnLongRunningOpStartAsync;
        private System.Windows.Forms.ProgressBar progressBarLongRunningOp;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOpenUploadFile;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox tbxUploadFilename;
        private System.Windows.Forms.TextBox tbxDownloadFilename;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDownloadVerzeichnis;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDownloadStream;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAllFilesRequery;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnFertig;
        private System.Windows.Forms.Label lblResultDelaydReturn;
        private System.Windows.Forms.Button btnDeleayedReturnAsyncCallback;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diruidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn superdiruidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkeyfileidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkeydiridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkeysuperdiridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource FilesDbDataSetBindingSource;
        private WcfTestLibClient.DataSetServiceRef.DsFilesDb dsFilesDb1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnFilesDbSaveChanges;
        private System.Windows.Forms.Button btnFilesDbRequery;
        private System.Windows.Forms.DataGridView grdDataServiceResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGetUploadFilelist;
        private System.Windows.Forms.DataGridView grdUploadedFiles;
    }
}
