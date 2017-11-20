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
            this.grdDirs = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdFiles = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlBaseFormMain.SuspendLayout();
            this.tabPageBaseFormLogs.SuspendLayout();
            this.tabPageBaseForm1.SuspendLayout();
            this.panelBaseFormtabPageLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDirs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.grdDirs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdFiles);
            this.splitContainer1.Size = new System.Drawing.Size(831, 382);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.TabIndex = 0;
            // 
            // grdDirs
            // 
            this.grdDirs.AutoGenerateColumns = false;
            this.grdDirs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDirs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1});
            this.grdDirs.DataSource = this.DirBindingSource;
            this.grdDirs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDirs.Location = new System.Drawing.Point(0, 0);
            this.grdDirs.Name = "grdDirs";
            this.grdDirs.Size = new System.Drawing.Size(277, 382);
            this.grdDirs.TabIndex = 0;
            this.grdDirs.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDirs_RowEnter);
            this.grdDirs.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDirs_RowLeave);
            this.grdDirs.SelectionChanged += new System.EventHandler(this.grdDirs_SelectionChanged);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // DirBindingSource
            // 
            this.DirBindingSource.DataSource = typeof(mko.FileSys.IDir);
            this.DirBindingSource.CurrentChanged += new System.EventHandler(this.DirBindingSource_CurrentChanged);
            // 
            // grdFiles
            // 
            this.grdFiles.AutoGenerateColumns = false;
            this.grdFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.grdFiles.DataSource = this.FilesBindingSource;
            this.grdFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFiles.Location = new System.Drawing.Point(0, 0);
            this.grdFiles.Name = "grdFiles";
            this.grdFiles.Size = new System.Drawing.Size(550, 382);
            this.grdFiles.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // FilesBindingSource
            // 
            this.FilesBindingSource.DataSource = typeof(mko.FileSys.IFile);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdDirs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView grdFiles;
        private System.Windows.Forms.BindingSource DirBindingSource;
        private System.Windows.Forms.DataGridView grdDirs;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource FilesBindingSource;
    }
}