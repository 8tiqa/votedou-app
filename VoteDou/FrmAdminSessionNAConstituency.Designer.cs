namespace VoteDou
{
    partial class FrmAdminSessionNAConstituency
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nAConstituencyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constituencyDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAConstituencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.voteDouDataSet7 = new VoteDou.VoteDouDataSet7();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.AddSession = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EditSession = new System.Windows.Forms.TextBox();
            this.EditID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nAConstituencyIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionNAConstituencyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nAConstituencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voteDouDataSet2 = new VoteDou.VoteDouDataSet2();
            this.sessionNAConstituencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionNAConstituencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutVoteDouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionNAConstituencyTableAdapter = new VoteDou.VoteDouDataSet2TableAdapters.SessionNAConstituencyTableAdapter();
            this.nAConstituencyTableAdapter = new VoteDou.VoteDouDataSet2TableAdapters.NAConstituencyTableAdapter();
            this.nAConstituencyTableAdapter1 = new VoteDou.VoteDouDataSet7TableAdapters.NAConstituencyTableAdapter();
            this.sessionNAConstituencyTableAdapter1 = new VoteDou.VoteDouDataSet7TableAdapters.SessionNAConstituencyTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAConstituencyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteDouDataSet7)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionNAConstituencyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAConstituencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteDouDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionNAConstituencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionNAConstituencyBindingSource1)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 442);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.AddID);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.AddSession);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(406, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 332);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Constituency Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAConstituencyIDDataGridViewTextBoxColumn,
            this.constituencyDetailsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nAConstituencyBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(51, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(242, 307);
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
            // nAConstituencyBindingSource1
            // 
            this.nAConstituencyBindingSource1.DataMember = "NAConstituency";
            this.nAConstituencyBindingSource1.DataSource = this.voteDouDataSet7;
            // 
            // voteDouDataSet7
            // 
            this.voteDouDataSet7.DataSetName = "VoteDouDataSet7";
            this.voteDouDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Constituency ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Session ID";
            // 
            // AddID
            // 
            this.AddID.Location = new System.Drawing.Point(155, 142);
            this.AddID.Name = "AddID";
            this.AddID.Size = new System.Drawing.Size(219, 20);
            this.AddID.TabIndex = 20;
            this.AddID.TextChanged += new System.EventHandler(this.AddID_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 289);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 32);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(212, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 32);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddSession
            // 
            this.AddSession.Location = new System.Drawing.Point(155, 189);
            this.AddSession.Name = "AddSession";
            this.AddSession.Size = new System.Drawing.Size(219, 20);
            this.AddSession.TabIndex = 21;
            this.AddSession.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddSession_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.btnLoad);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.groupBox5);
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
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.EditSession);
            this.groupBox1.Controls.Add(this.EditID);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(409, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 267);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Constituency";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Session ID";
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
            // EditSession
            // 
            this.EditSession.Location = new System.Drawing.Point(114, 102);
            this.EditSession.Name = "EditSession";
            this.EditSession.Size = new System.Drawing.Size(177, 20);
            this.EditSession.TabIndex = 7;
            this.EditSession.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditSession_KeyPress);
            // 
            // EditID
            // 
            this.EditID.Location = new System.Drawing.Point(114, 63);
            this.EditID.Name = "EditID";
            this.EditID.Size = new System.Drawing.Size(177, 20);
            this.EditID.TabIndex = 8;
            this.EditID.TextChanged += new System.EventHandler(this.EditID_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(205, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 26);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(30, 39);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(365, 338);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Existing Constituencies";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAConstituencyIDDataGridViewTextBoxColumn1,
            this.sessionIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.sessionNAConstituencyBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(63, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(244, 302);
            this.dataGridView2.TabIndex = 0;
            // 
            // nAConstituencyIDDataGridViewTextBoxColumn1
            // 
            this.nAConstituencyIDDataGridViewTextBoxColumn1.DataPropertyName = "NAConstituency_ID";
            this.nAConstituencyIDDataGridViewTextBoxColumn1.HeaderText = "NAConstituency_ID";
            this.nAConstituencyIDDataGridViewTextBoxColumn1.Name = "nAConstituencyIDDataGridViewTextBoxColumn1";
            // 
            // sessionIDDataGridViewTextBoxColumn
            // 
            this.sessionIDDataGridViewTextBoxColumn.DataPropertyName = "Session_ID";
            this.sessionIDDataGridViewTextBoxColumn.HeaderText = "Session_ID";
            this.sessionIDDataGridViewTextBoxColumn.Name = "sessionIDDataGridViewTextBoxColumn";
            // 
            // sessionNAConstituencyBindingSource2
            // 
            this.sessionNAConstituencyBindingSource2.DataMember = "SessionNAConstituency";
            this.sessionNAConstituencyBindingSource2.DataSource = this.voteDouDataSet7;
            // 
            // nAConstituencyBindingSource
            // 
            this.nAConstituencyBindingSource.DataMember = "NAConstituency";
            this.nAConstituencyBindingSource.DataSource = this.voteDouDataSet2;
            // 
            // voteDouDataSet2
            // 
            this.voteDouDataSet2.DataSetName = "VoteDouDataSet2";
            this.voteDouDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionNAConstituencyBindingSource
            // 
            this.sessionNAConstituencyBindingSource.DataMember = "SessionNAConstituency";
            this.sessionNAConstituencyBindingSource.DataSource = this.voteDouDataSet2;
            // 
            // sessionNAConstituencyBindingSource1
            // 
            this.sessionNAConstituencyBindingSource1.DataMember = "SessionNAConstituency";
            this.sessionNAConstituencyBindingSource1.DataSource = this.voteDouDataSet2;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(775, 24);
            this.menuStrip3.TabIndex = 4;
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
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click_1);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click_1);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click_1);
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
            this.aboutVoteDouToolStripMenuItem.Click += new System.EventHandler(this.aboutVoteDouToolStripMenuItem_Click_1);
            // 
            // aboutTheDeveloperToolStripMenuItem
            // 
            this.aboutTheDeveloperToolStripMenuItem.Name = "aboutTheDeveloperToolStripMenuItem";
            this.aboutTheDeveloperToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aboutTheDeveloperToolStripMenuItem.Text = "About The Developer";
            this.aboutTheDeveloperToolStripMenuItem.Click += new System.EventHandler(this.aboutTheDeveloperToolStripMenuItem_Click_1);
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            this.contactUsToolStripMenuItem.Click += new System.EventHandler(this.contactUsToolStripMenuItem_Click_1);
            // 
            // sessionNAConstituencyTableAdapter
            // 
            this.sessionNAConstituencyTableAdapter.ClearBeforeFill = true;
            // 
            // nAConstituencyTableAdapter
            // 
            this.nAConstituencyTableAdapter.ClearBeforeFill = true;
            // 
            // nAConstituencyTableAdapter1
            // 
            this.nAConstituencyTableAdapter1.ClearBeforeFill = true;
            // 
            // sessionNAConstituencyTableAdapter1
            // 
            this.sessionNAConstituencyTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmAdminSessionNAConstituency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 482);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip3);
            this.Name = "FrmAdminSessionNAConstituency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add NA Constituency In An Election Session";
            this.Load += new System.EventHandler(this.FrmAdminSessionNAConstituency_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAConstituencyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteDouDataSet7)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionNAConstituencyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAConstituencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteDouDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionNAConstituencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionNAConstituencyBindingSource1)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox AddSession;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EditSession;
        private System.Windows.Forms.TextBox EditID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutVoteDouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheDeveloperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private VoteDouDataSet2 voteDouDataSet2;
        private System.Windows.Forms.BindingSource sessionNAConstituencyBindingSource;
        private VoteDouDataSet2TableAdapters.SessionNAConstituencyTableAdapter sessionNAConstituencyTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource nAConstituencyBindingSource;
        private VoteDouDataSet2TableAdapters.NAConstituencyTableAdapter nAConstituencyTableAdapter;
        private System.Windows.Forms.BindingSource sessionNAConstituencyBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VoteDouDataSet7 voteDouDataSet7;
        private System.Windows.Forms.BindingSource nAConstituencyBindingSource1;
        private VoteDouDataSet7TableAdapters.NAConstituencyTableAdapter nAConstituencyTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAConstituencyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constituencyDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource sessionNAConstituencyBindingSource2;
        private VoteDouDataSet7TableAdapters.SessionNAConstituencyTableAdapter sessionNAConstituencyTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAConstituencyIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
    }
}