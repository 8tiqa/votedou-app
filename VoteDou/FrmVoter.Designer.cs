namespace VoteDou
{
    partial class FrmVoter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVoter));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVoteNA = new System.Windows.Forms.Button();
            this.btnVotePA = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.AddCNIC = new System.Windows.Forms.TextBox();
            this.AddNACon = new System.Windows.Forms.TextBox();
            this.AddFirstName = new System.Windows.Forms.TextBox();
            this.AddPACon = new System.Windows.Forms.TextBox();
            this.comboPA = new System.Windows.Forms.ComboBox();
            this.comboNA = new System.Windows.Forms.ComboBox();
            this.AddLastName = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "National Assembly Candidates:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Provincial Assembly Candidates:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Voter Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Constituency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "CNIC";
            // 
            // btnVoteNA
            // 
            this.btnVoteNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoteNA.Location = new System.Drawing.Point(444, 25);
            this.btnVoteNA.Name = "btnVoteNA";
            this.btnVoteNA.Size = new System.Drawing.Size(109, 32);
            this.btnVoteNA.TabIndex = 5;
            this.btnVoteNA.Text = "Submit Vote";
            this.btnVoteNA.UseVisualStyleBackColor = true;
            this.btnVoteNA.Click += new System.EventHandler(this.btnVoteNA_Click);
            // 
            // btnVotePA
            // 
            this.btnVotePA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotePA.Location = new System.Drawing.Point(444, 19);
            this.btnVotePA.Name = "btnVotePA";
            this.btnVotePA.Size = new System.Drawing.Size(109, 32);
            this.btnVotePA.TabIndex = 6;
            this.btnVotePA.Text = "Submit Vote";
            this.btnVotePA.UseVisualStyleBackColor = true;
            this.btnVotePA.Click += new System.EventHandler(this.btnVotePA_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(482, 303);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(109, 35);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddCNIC
            // 
            this.AddCNIC.Location = new System.Drawing.Point(157, 80);
            this.AddCNIC.Name = "AddCNIC";
            this.AddCNIC.Size = new System.Drawing.Size(305, 20);
            this.AddCNIC.TabIndex = 8;
            // 
            // AddNACon
            // 
            this.AddNACon.Location = new System.Drawing.Point(157, 56);
            this.AddNACon.Name = "AddNACon";
            this.AddNACon.Size = new System.Drawing.Size(100, 20);
            this.AddNACon.TabIndex = 9;
            // 
            // AddFirstName
            // 
            this.AddFirstName.Location = new System.Drawing.Point(157, 30);
            this.AddFirstName.Name = "AddFirstName";
            this.AddFirstName.Size = new System.Drawing.Size(137, 20);
            this.AddFirstName.TabIndex = 10;
            // 
            // AddPACon
            // 
            this.AddPACon.Location = new System.Drawing.Point(263, 56);
            this.AddPACon.Name = "AddPACon";
            this.AddPACon.Size = new System.Drawing.Size(199, 20);
            this.AddPACon.TabIndex = 11;
            // 
            // comboPA
            // 
            this.comboPA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPA.FormattingEnabled = true;
            this.comboPA.Location = new System.Drawing.Point(257, 235);
            this.comboPA.Name = "comboPA";
            this.comboPA.Size = new System.Drawing.Size(205, 21);
            this.comboPA.TabIndex = 12;
            this.comboPA.SelectedIndexChanged += new System.EventHandler(this.comboPA_SelectedIndexChanged);
            // 
            // comboNA
            // 
            this.comboNA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNA.FormattingEnabled = true;
            this.comboNA.Location = new System.Drawing.Point(257, 153);
            this.comboNA.Name = "comboNA";
            this.comboNA.Size = new System.Drawing.Size(205, 21);
            this.comboNA.TabIndex = 13;
            this.comboNA.SelectedIndexChanged += new System.EventHandler(this.comboNA_SelectedIndexChanged);
            // 
            // AddLastName
            // 
            this.AddLastName.Location = new System.Drawing.Point(292, 30);
            this.AddLastName.Name = "AddLastName";
            this.AddLastName.Size = new System.Drawing.Size(170, 20);
            this.AddLastName.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.LawnGreen;
            this.checkBox1.Location = new System.Drawing.Point(8, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(256, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Tick to select a candidate for  National Assembly";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.LawnGreen;
            this.checkBox2.Location = new System.Drawing.Point(6, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(263, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Tick to select a candidate for  Provincial Assembly";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btnVoteNA);
            this.groupBox1.Location = new System.Drawing.Point(38, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 79);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.btnVotePA);
            this.groupBox2.Location = new System.Drawing.Point(38, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 79);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // FrmVoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(645, 350);
            this.Controls.Add(this.AddLastName);
            this.Controls.Add(this.comboNA);
            this.Controls.Add(this.comboPA);
            this.Controls.Add(this.AddPACon);
            this.Controls.Add(this.AddFirstName);
            this.Controls.Add(this.AddNACon);
            this.Controls.Add(this.AddCNIC);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVoter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cast A Vote";
            this.Load += new System.EventHandler(this.FrmVoter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVoteNA;
        private System.Windows.Forms.Button btnVotePA;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox AddCNIC;
        private System.Windows.Forms.TextBox AddNACon;
        private System.Windows.Forms.TextBox AddFirstName;
        private System.Windows.Forms.TextBox AddPACon;
        private System.Windows.Forms.ComboBox comboPA;
        private System.Windows.Forms.ComboBox comboNA;
        private System.Windows.Forms.TextBox AddLastName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}