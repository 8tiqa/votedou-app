namespace VoteDou
{
    partial class FrmAdminNACons
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutVoteDouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddEligible = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddID = new System.Windows.Forms.TextBox();
            this.AddSession = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.AddConstituencyDetails = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EditEligible = new System.Windows.Forms.TextBox();
            this.EditSession = new System.Windows.Forms.TextBox();
            this.EditConstituencyDetails = new System.Windows.Forms.TextBox();
            this.EditID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nAConstituencyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constituencyDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofEligibleVotersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAConstituencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voteDouDataSet = new VoteDou.VoteDouDataSet();
            this.SearchID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nAConstituencyIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constituencyDetailsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofEligibleVotersDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAConstituencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nAConstituencyTableAdapter = new VoteDou.VoteDouDataSetTableAdapters.NAConstituencyTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAConstituencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteDouDataSet)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAConstituencyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(788, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(788, 24);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutVoteDouToolStripMenuItem,
            this.aboutTheDeveloperToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutVoteDouToolStripMenuItem
            // 
            this.aboutVoteDouToolStripMenuItem.Name = "aboutVoteDouToolStripMenuItem";
            this.aboutVoteDouToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aboutVoteDouToolStripMenuItem.Text = "About Vote Dou";
            this.aboutVoteDouToolStripMenuItem.Click += new System.EventHandler(this.aboutVoteDouToolStripMenuItem_Click);
            // 
            // aboutTheDeveloperToolStripMenuItem
            // 
            this.aboutTheDeveloperToolStripMenuItem.Name = "aboutTheDeveloperToolStripMenuItem";
            this.aboutTheDeveloperToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aboutTheDeveloperToolStripMenuItem.Text = "About The Developer";
            this.aboutTheDeveloperToolStripMenuItem.Click += new System.EventHandler(this.aboutTheDeveloperToolStripMenuItem_Click);
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            this.contactUsToolStripMenuItem.Click += new System.EventHandler(this.contactUsToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 442);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddEligible);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.AddID);
            this.tabPage1.Controls.Add(this.AddSession);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.AddConstituencyDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddEligible
            // 
            this.AddEligible.Location = new System.Drawing.Point(354, 240);
            this.AddEligible.Name = "AddEligible";
            this.AddEligible.Size = new System.Drawing.Size(203, 20);
            this.AddEligible.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Please Enter The Details Of The National Assembly Constituency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Constituency ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Constituency Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Session ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Number of Eligible Voters";
            // 
            // AddID
            // 
            this.AddID.Location = new System.Drawing.Point(354, 117);
            this.AddID.Name = "AddID";
            this.AddID.Size = new System.Drawing.Size(203, 20);
            this.AddID.TabIndex = 20;
            // 
            // AddSession
            // 
            this.AddSession.Location = new System.Drawing.Point(354, 199);
            this.AddSession.Name = "AddSession";
            this.AddSession.Size = new System.Drawing.Size(203, 20);
            this.AddSession.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(260, 313);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 32);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(385, 313);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 32);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddConstituencyDetails
            // 
            this.AddConstituencyDetails.Location = new System.Drawing.Point(354, 158);
            this.AddConstituencyDetails.Name = "AddConstituencyDetails";
            this.AddConstituencyDetails.Size = new System.Drawing.Size(203, 20);
            this.AddConstituencyDetails.TabIndex = 21;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.btnLoad);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.SearchID);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(526, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 29);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(419, 331);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(83, 29);
            this.btnLoad.TabIndex = 34;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.EditEligible);
            this.groupBox1.Controls.Add(this.EditSession);
            this.groupBox1.Controls.Add(this.EditConstituencyDetails);
            this.groupBox1.Controls.Add(this.EditID);
            this.groupBox1.Location = new System.Drawing.Point(409, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 267);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Constituency";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Session ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Number of Eligible Voters";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Constituency Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Constituency ID";
            // 
            // EditEligible
            // 
            this.EditEligible.Location = new System.Drawing.Point(157, 179);
            this.EditEligible.Name = "EditEligible";
            this.EditEligible.Size = new System.Drawing.Size(134, 20);
            this.EditEligible.TabIndex = 5;
            // 
            // EditSession
            // 
            this.EditSession.Location = new System.Drawing.Point(157, 140);
            this.EditSession.Name = "EditSession";
            this.EditSession.Size = new System.Drawing.Size(134, 20);
            this.EditSession.TabIndex = 6;
            // 
            // EditConstituencyDetails
            // 
            this.EditConstituencyDetails.Location = new System.Drawing.Point(157, 102);
            this.EditConstituencyDetails.Name = "EditConstituencyDetails";
            this.EditConstituencyDetails.Size = new System.Drawing.Size(134, 20);
            this.EditConstituencyDetails.TabIndex = 7;
            // 
            // EditID
            // 
            this.EditID.Location = new System.Drawing.Point(157, 63);
            this.EditID.Name = "EditID";
            this.EditID.Size = new System.Drawing.Size(134, 20);
            this.EditID.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(636, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 29);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(30, 73);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(365, 304);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Existing Constituencies";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAConstituencyIDDataGridViewTextBoxColumn,
            this.constituencyDetailsDataGridViewTextBoxColumn,
            this.sessionIDDataGridViewTextBoxColumn,
            this.numberofEligibleVotersDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nAConstituencyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 279);
            this.dataGridView1.TabIndex = 39;
            // 
            // nAConstituencyIDDataGridViewTextBoxColumn
            // 
            this.nAConstituencyIDDataGridViewTextBoxColumn.DataPropertyName = "NAConstituency_ID";
            this.nAConstituencyIDDataGridViewTextBoxColumn.HeaderText = "NAConstituency_ID";
            this.nAConstituencyIDDataGridViewTextBoxColumn.Name = "nAConstituencyIDDataGridViewTextBoxColumn";
            // 
            // constituencyDetailsDataGridViewTextBoxColumn
            // 
            this.constituencyDetailsDataGridViewTextBoxColumn.DataPropertyName = "ConstituencyDetails";
            this.constituencyDetailsDataGridViewTextBoxColumn.HeaderText = "ConstituencyDetails";
            this.constituencyDetailsDataGridViewTextBoxColumn.Name = "constituencyDetailsDataGridViewTextBoxColumn";
            // 
            // sessionIDDataGridViewTextBoxColumn
            // 
            this.sessionIDDataGridViewTextBoxColumn.DataPropertyName = "Session_ID";
            this.sessionIDDataGridViewTextBoxColumn.HeaderText = "Session_ID";
            this.sessionIDDataGridViewTextBoxColumn.Name = "sessionIDDataGridViewTextBoxColumn";
            // 
            // numberofEligibleVotersDataGridViewTextBoxColumn
            // 
            this.numberofEligibleVotersDataGridViewTextBoxColumn.DataPropertyName = "Number_of_Eligible_Voters";
            this.numberofEligibleVotersDataGridViewTextBoxColumn.HeaderText = "Number_of_Eligible_Voters";
            this.numberofEligibleVotersDataGridViewTextBoxColumn.Name = "numberofEligibleVotersDataGridViewTextBoxColumn";
            // 
            // nAConstituencyBindingSource
            // 
            this.nAConstituencyBindingSource.DataMember = "NAConstituency";
            this.nAConstituencyBindingSource.DataSource = this.voteDouDataSet;
            // 
            // voteDouDataSet
            // 
            this.voteDouDataSet.DataSetName = "VoteDouDataSet";
            this.voteDouDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SearchID
            // 
            this.SearchID.Location = new System.Drawing.Point(115, 36);
            this.SearchID.Name = "SearchID";
            this.SearchID.Size = new System.Drawing.Size(155, 20);
            this.SearchID.TabIndex = 33;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(286, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 26);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Constituency ID";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(780, 416);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "View All";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAConstituencyIDDataGridViewTextBoxColumn1,
            this.constituencyDetailsDataGridViewTextBoxColumn1,
            this.sessionIDDataGridViewTextBoxColumn1,
            this.numberofEligibleVotersDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.nAConstituencyBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(163, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(441, 382);
            this.dataGridView2.TabIndex = 0;
            // 
            // nAConstituencyIDDataGridViewTextBoxColumn1
            // 
            this.nAConstituencyIDDataGridViewTextBoxColumn1.DataPropertyName = "NAConstituency_ID";
            this.nAConstituencyIDDataGridViewTextBoxColumn1.HeaderText = "NAConstituency_ID";
            this.nAConstituencyIDDataGridViewTextBoxColumn1.Name = "nAConstituencyIDDataGridViewTextBoxColumn1";
            // 
            // constituencyDetailsDataGridViewTextBoxColumn1
            // 
            this.constituencyDetailsDataGridViewTextBoxColumn1.DataPropertyName = "ConstituencyDetails";
            this.constituencyDetailsDataGridViewTextBoxColumn1.HeaderText = "ConstituencyDetails";
            this.constituencyDetailsDataGridViewTextBoxColumn1.Name = "constituencyDetailsDataGridViewTextBoxColumn1";
            // 
            // sessionIDDataGridViewTextBoxColumn1
            // 
            this.sessionIDDataGridViewTextBoxColumn1.DataPropertyName = "Session_ID";
            this.sessionIDDataGridViewTextBoxColumn1.HeaderText = "Session_ID";
            this.sessionIDDataGridViewTextBoxColumn1.Name = "sessionIDDataGridViewTextBoxColumn1";
            // 
            // numberofEligibleVotersDataGridViewTextBoxColumn1
            // 
            this.numberofEligibleVotersDataGridViewTextBoxColumn1.DataPropertyName = "Number_of_Eligible_Voters";
            this.numberofEligibleVotersDataGridViewTextBoxColumn1.HeaderText = "Number_of_Eligible_Voters";
            this.numberofEligibleVotersDataGridViewTextBoxColumn1.Name = "numberofEligibleVotersDataGridViewTextBoxColumn1";
            // 
            // nAConstituencyBindingSource1
            // 
            this.nAConstituencyBindingSource1.DataMember = "NAConstituency";
            this.nAConstituencyBindingSource1.DataSource = this.voteDouDataSet;
            // 
            // nAConstituencyTableAdapter
            // 
            this.nAConstituencyTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 35;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAdminNACons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 471);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdminNACons";
            this.Text = "Manange NA Constituency";
            this.Load += new System.EventHandler(this.FrmAdminNACons_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAConstituencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteDouDataSet)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAConstituencyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutVoteDouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheDeveloperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EditEligible;
        private System.Windows.Forms.TextBox EditSession;
        private System.Windows.Forms.TextBox EditConstituencyDetails;
        private System.Windows.Forms.TextBox EditID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox SearchID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AddEligible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddID;
        private System.Windows.Forms.TextBox AddSession;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox AddConstituencyDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VoteDouDataSet voteDouDataSet;
        private System.Windows.Forms.BindingSource nAConstituencyBindingSource;
        private VoteDouDataSetTableAdapters.NAConstituencyTableAdapter nAConstituencyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAConstituencyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constituencyDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofEligibleVotersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAConstituencyIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn constituencyDetailsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofEligibleVotersDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource nAConstituencyBindingSource1;
        private System.Windows.Forms.Button button1;
    }
}