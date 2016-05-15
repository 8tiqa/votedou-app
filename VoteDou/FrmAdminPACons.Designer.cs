namespace VoteDou
{
    partial class FrmAdminPACons
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EditEligible = new System.Windows.Forms.TextBox();
            this.EditSession = new System.Windows.Forms.TextBox();
            this.EditConstituencyDetails = new System.Windows.Forms.TextBox();
            this.EditID = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SearchID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.voteDouDataSet = new VoteDou.VoteDouDataSet();
            this.pAConstituencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAConstituencyTableAdapter = new VoteDou.VoteDouDataSetTableAdapters.PAConstituencyTableAdapter();
            this.pAConstituencyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constituencyDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofEligibleVotersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pAConstituencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pAConstituencyIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constituencyDetailsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofEligibleVotersDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteDouDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAConstituencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAConstituencyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 472);
            this.tabControl1.TabIndex = 1;
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
            this.tabPage1.Size = new System.Drawing.Size(789, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddEligible
            // 
            this.AddEligible.Location = new System.Drawing.Point(358, 255);
            this.AddEligible.Name = "AddEligible";
            this.AddEligible.Size = new System.Drawing.Size(203, 20);
            this.AddEligible.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Please Enter The Details Of The Provincial Assembly Constituency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Constituency ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Constituency Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Session ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Number of Eligible Voters";
            // 
            // AddID
            // 
            this.AddID.Location = new System.Drawing.Point(358, 132);
            this.AddID.Name = "AddID";
            this.AddID.Size = new System.Drawing.Size(203, 20);
            this.AddID.TabIndex = 20;
            // 
            // AddSession
            // 
            this.AddSession.Location = new System.Drawing.Point(358, 214);
            this.AddSession.Name = "AddSession";
            this.AddSession.Size = new System.Drawing.Size(203, 20);
            this.AddSession.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(264, 328);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 32);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(389, 328);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 32);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddConstituencyDetails
            // 
            this.AddConstituencyDetails.Location = new System.Drawing.Point(358, 173);
            this.AddConstituencyDetails.Name = "AddConstituencyDetails";
            this.AddConstituencyDetails.Size = new System.Drawing.Size(203, 20);
            this.AddConstituencyDetails.TabIndex = 21;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.btnLoad);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.SearchID);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(548, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 29);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(446, 350);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(79, 29);
            this.btnLoad.TabIndex = 43;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(646, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 29);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(429, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 267);
            this.groupBox1.TabIndex = 39;
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(50, 92);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(365, 304);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Existing Constituencies";
            // 
            // SearchID
            // 
            this.SearchID.Location = new System.Drawing.Point(135, 55);
            this.SearchID.Name = "SearchID";
            this.SearchID.Size = new System.Drawing.Size(155, 20);
            this.SearchID.TabIndex = 42;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(306, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 26);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Constituency ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(789, 446);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View All";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pAConstituencyIDDataGridViewTextBoxColumn,
            this.constituencyDetailsDataGridViewTextBoxColumn,
            this.sessionIDDataGridViewTextBoxColumn,
            this.numberofEligibleVotersDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pAConstituencyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 279);
            this.dataGridView1.TabIndex = 48;
            // 
            // voteDouDataSet
            // 
            this.voteDouDataSet.DataSetName = "VoteDouDataSet";
            this.voteDouDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pAConstituencyBindingSource
            // 
            this.pAConstituencyBindingSource.DataMember = "PAConstituency";
            this.pAConstituencyBindingSource.DataSource = this.voteDouDataSet;
            // 
            // pAConstituencyTableAdapter
            // 
            this.pAConstituencyTableAdapter.ClearBeforeFill = true;
            // 
            // pAConstituencyIDDataGridViewTextBoxColumn
            // 
            this.pAConstituencyIDDataGridViewTextBoxColumn.DataPropertyName = "PAConstituency_ID";
            this.pAConstituencyIDDataGridViewTextBoxColumn.HeaderText = "PAConstituency_ID";
            this.pAConstituencyIDDataGridViewTextBoxColumn.Name = "pAConstituencyIDDataGridViewTextBoxColumn";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 29);
            this.button1.TabIndex = 44;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pAConstituencyIDDataGridViewTextBoxColumn1,
            this.constituencyDetailsDataGridViewTextBoxColumn1,
            this.sessionIDDataGridViewTextBoxColumn1,
            this.numberofEligibleVotersDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.pAConstituencyBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(186, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(443, 424);
            this.dataGridView2.TabIndex = 45;
            // 
            // pAConstituencyBindingSource1
            // 
            this.pAConstituencyBindingSource1.DataMember = "PAConstituency";
            this.pAConstituencyBindingSource1.DataSource = this.voteDouDataSet;
            // 
            // pAConstituencyIDDataGridViewTextBoxColumn1
            // 
            this.pAConstituencyIDDataGridViewTextBoxColumn1.DataPropertyName = "PAConstituency_ID";
            this.pAConstituencyIDDataGridViewTextBoxColumn1.HeaderText = "PAConstituency_ID";
            this.pAConstituencyIDDataGridViewTextBoxColumn1.Name = "pAConstituencyIDDataGridViewTextBoxColumn1";
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
            // FrmAdminPACons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 497);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdminPACons";
            this.Text = "Manage PA Constituencies";
            this.Load += new System.EventHandler(this.FrmAdminPACons_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteDouDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAConstituencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAConstituencyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EditEligible;
        private System.Windows.Forms.TextBox EditSession;
        private System.Windows.Forms.TextBox EditConstituencyDetails;
        private System.Windows.Forms.TextBox EditID;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox SearchID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VoteDouDataSet voteDouDataSet;
        private System.Windows.Forms.BindingSource pAConstituencyBindingSource;
        private VoteDouDataSetTableAdapters.PAConstituencyTableAdapter pAConstituencyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAConstituencyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constituencyDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofEligibleVotersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAConstituencyIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn constituencyDetailsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofEligibleVotersDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource pAConstituencyBindingSource1;
        private System.Windows.Forms.Button button1;
    }
}