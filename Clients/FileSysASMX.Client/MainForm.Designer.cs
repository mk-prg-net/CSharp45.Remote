namespace FileSysASMX.Client
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeInBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.displayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDirsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeInBytesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grdDirs = new System.Windows.Forms.DataGridView();
            grdFiles = new System.Windows.Forms.DataGridView();
            this.tabControlBaseFormMain.SuspendLayout();
            this.tabPageBaseFormLogs.SuspendLayout();
            this.tabPageBaseForm1.SuspendLayout();
            this.panelBaseFormtabPageLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(grdDirs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(grdFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageBaseForm1
            // 
            this.tabPageBaseForm1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(grdDirs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(grdFiles);
            this.splitContainer1.Size = new System.Drawing.Size(831, 382);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.TabIndex = 0;
            // 
            // grdDirs
            // 
            grdDirs.AllowUserToAddRows = false;
            grdDirs.AllowUserToDeleteRows = false;
            grdDirs.AutoGenerateColumns = false;
            grdDirs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdDirs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DisplayName,
            this.displayNameDataGridViewTextBoxColumn,
            this.filesDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.subDirsDataGridViewTextBoxColumn});
            grdDirs.DataSource = this.DirBindingSource;
            grdDirs.Dock = System.Windows.Forms.DockStyle.Fill;
            grdDirs.Location = new System.Drawing.Point(0, 0);
            grdDirs.Name = "grdDirs";
            grdDirs.ReadOnly = true;
            grdDirs.Size = new System.Drawing.Size(277, 382);
            grdDirs.TabIndex = 0;
            grdDirs.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDirs_CellContentDoubleClick);
            grdDirs.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdDirs_RowHeaderMouseDoubleClick);
            grdDirs.SelectionChanged += new System.EventHandler(this.grdDirs_SelectionChanged);
            // 
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.HeaderText = "DisplayName";
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            // 
            // DirBindingSource
            // 
            this.DirBindingSource.DataSource = typeof(FileSysASMX.Client.Decos.DirDeco);
            this.DirBindingSource.CurrentChanged += new System.EventHandler(this.DirBindingSource_CurrentChanged);
            // 
            // grdFiles
            // 
            grdFiles.AllowUserToAddRows = false;
            grdFiles.AllowUserToDeleteRows = false;
            grdFiles.AutoGenerateColumns = false;
            grdFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.SizeInBytes,
            this.displayNameDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.sizeInBytesDataGridViewTextBoxColumn});
            grdFiles.DataSource = this.FilesBindingSource;
            grdFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            grdFiles.Location = new System.Drawing.Point(0, 0);
            grdFiles.Name = "grdFiles";
            grdFiles.ReadOnly = true;
            grdFiles.Size = new System.Drawing.Size(550, 382);
            grdFiles.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DisplayName";
            this.dataGridViewTextBoxColumn1.HeaderText = "DisplayName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // SizeInBytes
            // 
            this.SizeInBytes.DataPropertyName = "SizeInBytes";
            this.SizeInBytes.HeaderText = "SizeInBytes";
            this.SizeInBytes.Name = "SizeInBytes";
            this.SizeInBytes.ReadOnly = true;
            // 
            // FilesBindingSource
            // 
            this.FilesBindingSource.DataSource = typeof(FileSysASMX.Client.Decos.FileDeco);
            // 
            // displayNameDataGridViewTextBoxColumn
            // 
            this.displayNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayName";
            this.displayNameDataGridViewTextBoxColumn.HeaderText = "DisplayName";
            this.displayNameDataGridViewTextBoxColumn.Name = "displayNameDataGridViewTextBoxColumn";
            this.displayNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filesDataGridViewTextBoxColumn
            // 
            this.filesDataGridViewTextBoxColumn.DataPropertyName = "Files";
            this.filesDataGridViewTextBoxColumn.HeaderText = "Files";
            this.filesDataGridViewTextBoxColumn.Name = "filesDataGridViewTextBoxColumn";
            this.filesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subDirsDataGridViewTextBoxColumn
            // 
            this.subDirsDataGridViewTextBoxColumn.DataPropertyName = "SubDirs";
            this.subDirsDataGridViewTextBoxColumn.HeaderText = "SubDirs";
            this.subDirsDataGridViewTextBoxColumn.Name = "subDirsDataGridViewTextBoxColumn";
            this.subDirsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // displayNameDataGridViewTextBoxColumn1
            // 
            this.displayNameDataGridViewTextBoxColumn1.DataPropertyName = "DisplayName";
            this.displayNameDataGridViewTextBoxColumn1.HeaderText = "DisplayName";
            this.displayNameDataGridViewTextBoxColumn1.Name = "displayNameDataGridViewTextBoxColumn1";
            this.displayNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sizeInBytesDataGridViewTextBoxColumn
            // 
            this.sizeInBytesDataGridViewTextBoxColumn.DataPropertyName = "SizeInBytes";
            this.sizeInBytesDataGridViewTextBoxColumn.HeaderText = "SizeInBytes";
            this.sizeInBytesDataGridViewTextBoxColumn.Name = "sizeInBytesDataGridViewTextBoxColumn";
            this.sizeInBytesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 460);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlBaseFormMain.ResumeLayout(false);
            this.tabPageBaseFormLogs.ResumeLayout(false);
            this.tabPageBaseForm1.ResumeLayout(false);
            this.panelBaseFormtabPageLogs.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(grdDirs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(grdFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataGridView grdDirs;
        protected  System.Windows.Forms.DataGridView grdFiles;

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource DirBindingSource;
        private System.Windows.Forms.BindingSource FilesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeInBytes;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subDirsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeInBytesDataGridViewTextBoxColumn;
    }
}