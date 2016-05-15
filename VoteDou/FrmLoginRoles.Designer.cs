namespace VoteDou
{
    partial class FrmLoginRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginRoles));
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.btnECO = new System.Windows.Forms.Button();
            this.btnVoter = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(565, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Welcome to Pakistan E-Voting System!   Please select your login details to log in" +
    "to the system.";
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.Location = new System.Drawing.Point(261, 233);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(144, 41);
            this.btnAdministrator.TabIndex = 0;
            this.btnAdministrator.Text = "Login as Administrator";
            this.btnAdministrator.UseVisualStyleBackColor = true;
            this.btnAdministrator.Click += new System.EventHandler(this.btnAdministrator_Click);
            // 
            // btnECO
            // 
            this.btnECO.Location = new System.Drawing.Point(261, 179);
            this.btnECO.Name = "btnECO";
            this.btnECO.Size = new System.Drawing.Size(144, 39);
            this.btnECO.TabIndex = 1;
            this.btnECO.Text = "Login as ECO";
            this.btnECO.UseVisualStyleBackColor = true;
            this.btnECO.Click += new System.EventHandler(this.btnECO_Click);
            // 
            // btnVoter
            // 
            this.btnVoter.Location = new System.Drawing.Point(261, 126);
            this.btnVoter.Name = "btnVoter";
            this.btnVoter.Size = new System.Drawing.Size(144, 37);
            this.btnVoter.TabIndex = 2;
            this.btnVoter.Text = "Cast A Vote";
            this.btnVoter.UseVisualStyleBackColor = true;
            this.btnVoter.Click += new System.EventHandler(this.btnVoter_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(261, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 41);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmLoginRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(649, 412);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdministrator);
            this.Controls.Add(this.btnECO);
            this.Controls.Add(this.btnVoter);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoginRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdministrator;
        private System.Windows.Forms.Button btnECO;
        private System.Windows.Forms.Button btnVoter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
    }
}