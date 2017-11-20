namespace PlanetariumClient
{
    partial class PlanetariumMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanetariumMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartInputBegin = new System.Windows.Forms.Button();
            this.btnCancelInputReset = new System.Windows.Forms.Button();
            this.btnErrorInputReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtStart = new System.Windows.Forms.RadioButton();
            this.rbtSelectCentralBody = new System.Windows.Forms.RadioButton();
            this.rbtSelectSatellite = new System.Windows.Forms.RadioButton();
            this.rbtCreateCBSys = new System.Windows.Forms.RadioButton();
            this.rbtCancel = new System.Windows.Forms.RadioButton();
            this.rbtError = new System.Windows.Forms.RadioButton();
            this.rbtFin = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSetCentralBody = new System.Windows.Forms.Button();
            this.tbxCentralBodyName = new System.Windows.Forms.TextBox();
            this.btnSelectCentralBodyInputCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectSatelliteInputAdd = new System.Windows.Forms.Button();
            this.tbxSatellite = new System.Windows.Forms.TextBox();
            this.btnSelectSatelliteCancel = new System.Windows.Forms.Button();
            this.btnSelectSatelliteInputAddLast = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateCBSysInputCreate = new System.Windows.Forms.Button();
            this.btnCreateCBSysInputCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblResultCentralBody = new System.Windows.Forms.Label();
            this.lblSatellites = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.massInKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceSatellites = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSatellites)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(600, 521);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Size = new System.Drawing.Size(592, 297);
            // 
            // lbxLog
            // 
            this.lbxLog.ItemHeight = 13;
            this.lbxLog.Size = new System.Drawing.Size(586, 199);
            // 
            // cbxLbxLogAnzeigeoptionen
            // 
            this.cbxLbxLogAnzeigeoptionen.Size = new System.Drawing.Size(119, 34);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Size = new System.Drawing.Size(592, 495);
            this.tabPage2.Text = "Create New CBSys";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStartInputBegin, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelInputReset, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnErrorInputReset, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.rbtStart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbtSelectCentralBody, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rbtSelectSatellite, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.rbtCreateCBSys, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.rbtCancel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.rbtError, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.rbtFin, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 2, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Step";
            // 
            // btnStartInputBegin
            // 
            this.btnStartInputBegin.Location = new System.Drawing.Point(203, 43);
            this.btnStartInputBegin.Name = "btnStartInputBegin";
            this.btnStartInputBegin.Size = new System.Drawing.Size(75, 23);
            this.btnStartInputBegin.TabIndex = 1;
            this.btnStartInputBegin.Text = "Begin";
            this.btnStartInputBegin.UseVisualStyleBackColor = true;
            this.btnStartInputBegin.Click += new System.EventHandler(this.btnStartInputBegin_Click);
            // 
            // btnCancelInputReset
            // 
            this.btnCancelInputReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelInputReset.Location = new System.Drawing.Point(203, 203);
            this.btnCancelInputReset.Name = "btnCancelInputReset";
            this.btnCancelInputReset.Size = new System.Drawing.Size(380, 34);
            this.btnCancelInputReset.TabIndex = 5;
            this.btnCancelInputReset.Text = "Reset";
            this.btnCancelInputReset.UseVisualStyleBackColor = true;
            this.btnCancelInputReset.Click += new System.EventHandler(this.btnCancelInputReset_Click);
            // 
            // btnErrorInputReset
            // 
            this.btnErrorInputReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnErrorInputReset.Location = new System.Drawing.Point(203, 243);
            this.btnErrorInputReset.Name = "btnErrorInputReset";
            this.btnErrorInputReset.Size = new System.Drawing.Size(380, 34);
            this.btnErrorInputReset.TabIndex = 6;
            this.btnErrorInputReset.Text = "Reset";
            this.btnErrorInputReset.UseVisualStyleBackColor = true;
            this.btnErrorInputReset.Click += new System.EventHandler(this.btnErrorInputReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SelectCentralBody";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select Satellite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "CreateCBSys";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cancel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Error";
            // 
            // rbtStart
            // 
            this.rbtStart.AutoSize = true;
            this.rbtStart.Location = new System.Drawing.Point(153, 43);
            this.rbtStart.Name = "rbtStart";
            this.rbtStart.Size = new System.Drawing.Size(14, 13);
            this.rbtStart.TabIndex = 14;
            this.rbtStart.TabStop = true;
            this.rbtStart.UseVisualStyleBackColor = true;
            // 
            // rbtSelectCentralBody
            // 
            this.rbtSelectCentralBody.AutoSize = true;
            this.rbtSelectCentralBody.Location = new System.Drawing.Point(153, 83);
            this.rbtSelectCentralBody.Name = "rbtSelectCentralBody";
            this.rbtSelectCentralBody.Size = new System.Drawing.Size(14, 13);
            this.rbtSelectCentralBody.TabIndex = 15;
            this.rbtSelectCentralBody.TabStop = true;
            this.rbtSelectCentralBody.UseVisualStyleBackColor = true;
            // 
            // rbtSelectSatellite
            // 
            this.rbtSelectSatellite.AutoSize = true;
            this.rbtSelectSatellite.Location = new System.Drawing.Point(153, 123);
            this.rbtSelectSatellite.Name = "rbtSelectSatellite";
            this.rbtSelectSatellite.Size = new System.Drawing.Size(14, 13);
            this.rbtSelectSatellite.TabIndex = 16;
            this.rbtSelectSatellite.TabStop = true;
            this.rbtSelectSatellite.UseVisualStyleBackColor = true;
            // 
            // rbtCreateCBSys
            // 
            this.rbtCreateCBSys.AutoSize = true;
            this.rbtCreateCBSys.Location = new System.Drawing.Point(153, 163);
            this.rbtCreateCBSys.Name = "rbtCreateCBSys";
            this.rbtCreateCBSys.Size = new System.Drawing.Size(14, 13);
            this.rbtCreateCBSys.TabIndex = 17;
            this.rbtCreateCBSys.TabStop = true;
            this.rbtCreateCBSys.UseVisualStyleBackColor = true;
            // 
            // rbtCancel
            // 
            this.rbtCancel.AutoSize = true;
            this.rbtCancel.Location = new System.Drawing.Point(153, 203);
            this.rbtCancel.Name = "rbtCancel";
            this.rbtCancel.Size = new System.Drawing.Size(14, 13);
            this.rbtCancel.TabIndex = 18;
            this.rbtCancel.TabStop = true;
            this.rbtCancel.UseVisualStyleBackColor = true;
            // 
            // rbtError
            // 
            this.rbtError.AutoSize = true;
            this.rbtError.Location = new System.Drawing.Point(153, 243);
            this.rbtError.Name = "rbtError";
            this.rbtError.Size = new System.Drawing.Size(14, 13);
            this.rbtError.TabIndex = 19;
            this.rbtError.TabStop = true;
            this.rbtError.UseVisualStyleBackColor = true;
            // 
            // rbtFin
            // 
            this.rbtFin.AutoSize = true;
            this.rbtFin.Location = new System.Drawing.Point(153, 283);
            this.rbtFin.Name = "rbtFin";
            this.rbtFin.Size = new System.Drawing.Size(14, 13);
            this.rbtFin.TabIndex = 20;
            this.rbtFin.TabStop = true;
            this.rbtFin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.Controls.Add(this.btnSetCentralBody, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbxCentralBodyName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSelectCentralBodyInputCancel, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(203, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(350, 34);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // btnSetCentralBody
            // 
            this.btnSetCentralBody.AutoSize = true;
            this.btnSetCentralBody.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetCentralBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetCentralBody.Location = new System.Drawing.Point(3, 3);
            this.btnSetCentralBody.Name = "btnSetCentralBody";
            this.btnSetCentralBody.Size = new System.Drawing.Size(109, 28);
            this.btnSetCentralBody.TabIndex = 2;
            this.btnSetCentralBody.Text = "Set";
            this.btnSetCentralBody.UseVisualStyleBackColor = true;
            this.btnSetCentralBody.Click += new System.EventHandler(this.btnSetCentralBody_Click);
            // 
            // tbxCentralBodyName
            // 
            this.tbxCentralBodyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxCentralBodyName.Location = new System.Drawing.Point(118, 3);
            this.tbxCentralBodyName.Name = "tbxCentralBodyName";
            this.tbxCentralBodyName.Size = new System.Drawing.Size(109, 20);
            this.tbxCentralBodyName.TabIndex = 3;
            // 
            // btnSelectCentralBodyInputCancel
            // 
            this.btnSelectCentralBodyInputCancel.AutoSize = true;
            this.btnSelectCentralBodyInputCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectCentralBodyInputCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectCentralBodyInputCancel.Location = new System.Drawing.Point(233, 3);
            this.btnSelectCentralBodyInputCancel.Name = "btnSelectCentralBodyInputCancel";
            this.btnSelectCentralBodyInputCancel.Size = new System.Drawing.Size(114, 28);
            this.btnSelectCentralBodyInputCancel.TabIndex = 4;
            this.btnSelectCentralBodyInputCancel.Text = "Cancel";
            this.btnSelectCentralBodyInputCancel.UseVisualStyleBackColor = true;
            this.btnSelectCentralBodyInputCancel.Click += new System.EventHandler(this.btnSelectCentralBodyInputCancel_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btnSelectSatelliteInputAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbxSatellite, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSelectSatelliteCancel, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSelectSatelliteInputAddLast, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(203, 123);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(350, 34);
            this.tableLayoutPanel3.TabIndex = 22;
            // 
            // btnSelectSatelliteInputAdd
            // 
            this.btnSelectSatelliteInputAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectSatelliteInputAdd.Location = new System.Drawing.Point(3, 3);
            this.btnSelectSatelliteInputAdd.Name = "btnSelectSatelliteInputAdd";
            this.btnSelectSatelliteInputAdd.Size = new System.Drawing.Size(64, 28);
            this.btnSelectSatelliteInputAdd.TabIndex = 3;
            this.btnSelectSatelliteInputAdd.Text = "Add";
            this.btnSelectSatelliteInputAdd.UseVisualStyleBackColor = true;
            this.btnSelectSatelliteInputAdd.Click += new System.EventHandler(this.btnSelectSatelliteInputAdd_Click);
            // 
            // tbxSatellite
            // 
            this.tbxSatellite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSatellite.Location = new System.Drawing.Point(143, 3);
            this.tbxSatellite.Name = "tbxSatellite";
            this.tbxSatellite.Size = new System.Drawing.Size(116, 20);
            this.tbxSatellite.TabIndex = 4;
            // 
            // btnSelectSatelliteCancel
            // 
            this.btnSelectSatelliteCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectSatelliteCancel.Location = new System.Drawing.Point(265, 3);
            this.btnSelectSatelliteCancel.Name = "btnSelectSatelliteCancel";
            this.btnSelectSatelliteCancel.Size = new System.Drawing.Size(82, 28);
            this.btnSelectSatelliteCancel.TabIndex = 5;
            this.btnSelectSatelliteCancel.Text = "Cancel";
            this.btnSelectSatelliteCancel.UseVisualStyleBackColor = true;
            this.btnSelectSatelliteCancel.Click += new System.EventHandler(this.btnSelectSatelliteCancel_Click);
            // 
            // btnSelectSatelliteInputAddLast
            // 
            this.btnSelectSatelliteInputAddLast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectSatelliteInputAddLast.Location = new System.Drawing.Point(73, 3);
            this.btnSelectSatelliteInputAddLast.Name = "btnSelectSatelliteInputAddLast";
            this.btnSelectSatelliteInputAddLast.Size = new System.Drawing.Size(64, 28);
            this.btnSelectSatelliteInputAddLast.TabIndex = 6;
            this.btnSelectSatelliteInputAddLast.Text = "Add Last";
            this.btnSelectSatelliteInputAddLast.UseVisualStyleBackColor = true;
            this.btnSelectSatelliteInputAddLast.Click += new System.EventHandler(this.btnSelectSatelliteInputAddLast_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnCreateCBSysInputCreate, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCreateCBSysInputCancel, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(203, 163);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(350, 34);
            this.tableLayoutPanel4.TabIndex = 23;
            // 
            // btnCreateCBSysInputCreate
            // 
            this.btnCreateCBSysInputCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateCBSysInputCreate.Location = new System.Drawing.Point(3, 3);
            this.btnCreateCBSysInputCreate.Name = "btnCreateCBSysInputCreate";
            this.btnCreateCBSysInputCreate.Size = new System.Drawing.Size(169, 28);
            this.btnCreateCBSysInputCreate.TabIndex = 4;
            this.btnCreateCBSysInputCreate.Text = "Create";
            this.btnCreateCBSysInputCreate.UseVisualStyleBackColor = true;
            this.btnCreateCBSysInputCreate.Click += new System.EventHandler(this.btnCreateCBSysInputCreate_Click);
            // 
            // btnCreateCBSysInputCancel
            // 
            this.btnCreateCBSysInputCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateCBSysInputCancel.Location = new System.Drawing.Point(178, 3);
            this.btnCreateCBSysInputCancel.Name = "btnCreateCBSysInputCancel";
            this.btnCreateCBSysInputCancel.Size = new System.Drawing.Size(169, 28);
            this.btnCreateCBSysInputCancel.TabIndex = 5;
            this.btnCreateCBSysInputCancel.Text = "Cancel";
            this.btnCreateCBSysInputCancel.UseVisualStyleBackColor = true;
            this.btnCreateCBSysInputCancel.Click += new System.EventHandler(this.btnCreateCBSysInputCancel_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblResultCentralBody, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblSatellites, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.dataGridView1, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(203, 283);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(380, 203);
            this.tableLayoutPanel5.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Central Body";
            // 
            // lblResultCentralBody
            // 
            this.lblResultCentralBody.AutoSize = true;
            this.lblResultCentralBody.Location = new System.Drawing.Point(103, 40);
            this.lblResultCentralBody.Name = "lblResultCentralBody";
            this.lblResultCentralBody.Size = new System.Drawing.Size(12, 13);
            this.lblResultCentralBody.TabIndex = 1;
            this.lblResultCentralBody.Text = "/";
            // 
            // lblSatellites
            // 
            this.lblSatellites.AutoSize = true;
            this.lblSatellites.Location = new System.Drawing.Point(3, 80);
            this.lblSatellites.Name = "lblSatellites";
            this.lblSatellites.Size = new System.Drawing.Size(49, 13);
            this.lblSatellites.TabIndex = 2;
            this.lblSatellites.Text = "Satellites";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.massInKgDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceSatellites;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(103, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(274, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // massInKgDataGridViewTextBoxColumn
            // 
            this.massInKgDataGridViewTextBoxColumn.DataPropertyName = "MassInKg";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.massInKgDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.massInKgDataGridViewTextBoxColumn.HeaderText = "MassInKg";
            this.massInKgDataGridViewTextBoxColumn.Name = "massInKgDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // bindingSourceSatellites
            // 
            this.bindingSourceSatellites.DataSource = typeof(PlanetariumClient.CBService.CBody);
            // 
            // PlanetariumMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 567);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlanetariumMain";
            this.Text = "Planetarium";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSatellites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartInputBegin;
        private System.Windows.Forms.Button btnCreateCBSysInputCreate;
        private System.Windows.Forms.Button btnCancelInputReset;
        private System.Windows.Forms.Button btnErrorInputReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbtStart;
        private System.Windows.Forms.RadioButton rbtSelectCentralBody;
        private System.Windows.Forms.RadioButton rbtSelectSatellite;
        private System.Windows.Forms.RadioButton rbtCreateCBSys;
        private System.Windows.Forms.RadioButton rbtCancel;
        private System.Windows.Forms.RadioButton rbtError;
        private System.Windows.Forms.RadioButton rbtFin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSetCentralBody;
        private System.Windows.Forms.TextBox tbxCentralBodyName;
        private System.Windows.Forms.Button btnSelectCentralBodyInputCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnSelectSatelliteInputAdd;
        private System.Windows.Forms.TextBox tbxSatellite;
        private System.Windows.Forms.Button btnSelectSatelliteCancel;
        private System.Windows.Forms.Button btnSelectSatelliteInputAddLast;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnCreateCBSysInputCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblResultCentralBody;
        private System.Windows.Forms.Label lblSatellites;
        private System.Windows.Forms.BindingSource bindingSourceSatellites;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn massInKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}