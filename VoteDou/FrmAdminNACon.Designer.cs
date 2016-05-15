namespace VoteDou
{
    partial class FrmAdminNACon
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.AddConstituencyDetails = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EditConstituencyDetails = new System.Windows.Forms.TextBox();
            this.EditID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nAConstituencyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constituencyDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAConstituencyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.voteDouDataSet7 = new VoteDou.VoteDouDataSet7();
            this.SearchID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nAConstituencyIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constituencyDetailsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAConstituencyBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.nAConstituencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voteDouDataSet2 = new VoteDou.VoteDouDataSet2();
            this.nAConstituencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutVoteDouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nAConstituencyTableAdapter = new VoteDou.VoteDouDataSet2TableAdapters.NAConstituencyTableAdapter();
            this.nAConstituencyTableAdapter1 = new VoteDou.VoteDouDataSet7TableAdapters.NAConstituencyTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAConstituencyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteDouDataSet7)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAConstituencyBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAConstituencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteDouDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAConstituencyBindingSource1)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 442);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.AddID);
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
            // AddID
            // 
            this.AddID.Location = new System.Drawing.Point(354, 117);
            this.AddID.Name = "AddID";
            this.AddID.Size = new System.Drawing.Size(203, 20);
            this.AddID.TabIndex = 20;
            this.AddID.TextChanged += new System.EventHandler(this.AddID_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(275, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 32);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(389, 219);
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
            this.AddConstituencyDetails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddConstituencyDetails_KeyPress);
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
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.EditConstituencyDetails);
            this.groupBox1.Controls.Add(this.EditID);
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
            // EditConstituencyDetails
            // 
            this.EditConstituencyDetails.Location = new System.Drawing.Point(157, 102);
            this.EditConstituencyDetails.Name = "EditConstituencyDetails";
            this.EditConstituencyDetails.Size = new System.Drawing.Size(134, 20);
            this.EditConstituencyDetails.TabIndex = 7;
            this.EditConstituencyDetails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditConstituencyDetails_KeyPress);
            // 
            // EditID
            // 
            this.EditID.Location = new System.Drawing.Point(157, 63);
            this.EditID.Name = "EditID";
            this.EditID.Size = new System.Drawing.Size(134, 20);
            this.EditID.TabIndex = 8;
            this.EditID.TextChanged += new System.EventHandler(this.EditID_TextChanged);
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
            this.constituencyDetailsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nAConstituencyBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(61, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 255);
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
            // nAConstituencyBindingSource2
            // 
            this.nAConstituencyBindingSource2.DataMember = "NAConstituency";
            this.nAConstituencyBindingSource2.DataSource = this.voteDouDataSet7;
            // 
            // voteDouDataSet7
            // 
            this.voteDouDataSet7.DataSetName = "VoteDouDataSet7";
            this.voteDouDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SearchID
            // 
            this.SearchID.Location = new System.Drawing.Point(115, 36);
            this.SearchID.Name = "SearchID";
            this.SearchID.Size = new System.Drawing.Size(155, 20);
            this.SearchID.TabIndex = 33;
            this.SearchID.TextChanged += new System.EventHandler(this.SearchID_TextChanged);
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
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(780, 416);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "View All";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAConstituencyIDDataGridViewTextBoxColumn1,
            this.constituencyDetailsDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.nAConstituencyBindingSource3;
            this.dataGridView2.Location = new System.Drawing.Point(255, 14);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(243, 378);
            this.dataGridView2.TabIndex = 36;
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
            // nAConstituencyBindingSource3
            // 
            this.nAConstituencyBindingSource3.DataMember = "NAConstituency";
            this.nAConstituencyBindingSource3.DataSource = this.voteDouDataSet7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 35;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // nAConstituencyBindingSource1
            // 
            this.nAConstituencyBindingSource1.DataMember = "NAConstituency";
            this.nAConstituencyBindingSource1.DataSource = this.voteDouDataSet2;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(785, 24);
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
            // nAConstituencyTableAdapter
            // 
            this.nAConstituencyTableAdapter.ClearBeforeFill = true;
            // 
            // nAConstituencyTableAdapter1
            // 
            this.nAConstituencyTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmAdminNACon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 465);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip3);
            this.Name = "FrmAdminNACon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage NA Constituency";
            this.Load += new System.EventHandler(this.FrmAdminNACon_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAConstituencyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteDouDataSet7)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAConstituencyBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAConstituencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voteDouDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAConstituencyBindingSource1)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox AddConstituencyDetails;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EditConstituencyDetails;
        private System.Windows.Forms.TextBox EditID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox SearchID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.BindingSource nAConstituencyBindingSource;
        private VoteDouDataSet2TableAdapters.NAConstituencyTableAdapter nAConstituencyTableAdapter;
        private System.Windows.Forms.BindingSource nAConstituencyBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private VoteDouDataSet7 voteDouDataSet7;
        private System.Windows.Forms.BindingSource nAConstituencyBindingSource2;
        private VoteDouDataSet7TableAdapters.NAConstituencyTableAdapter nAConstituencyTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAConstituencyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constituencyDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAConstituencyIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn constituencyDetailsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource nAConstituencyBindingSource3;
    }
}