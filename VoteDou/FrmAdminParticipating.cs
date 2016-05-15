using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VoteDou
{
    public partial class FrmParticipating_Voters : Form
    {
        string sa;
        public FrmParticipating_Voters()
        {
            InitializeComponent();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdmin next = new FrmAdmin();
            next.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to Log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FrmLoginRoles next = new FrmLoginRoles();
                next.Show();
            }
            else
                return;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        private void aboutVoteDouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageAboutProg next = new PageAboutProg("Admin");
            next.ShowDialog();
        }

        private void aboutTheDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageAboutDev next = new PageAboutDev("Admin");
            next.ShowDialog();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageContactUs next = new PageContactUs("Admin");
            next.ShowDialog();
        }

        private void FrmParticipating_Voters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voteDouDataSet7.ParticipatingVoters' table. You can move, or remove it, as needed.
            this.participatingVotersTableAdapter2.Fill(this.voteDouDataSet7.ParticipatingVoters);
            // TODO: This line of code loads data into the 'voteDouDataSet7.PAConstituency' table. You can move, or remove it, as needed.
            this.pAConstituencyTableAdapter2.Fill(this.voteDouDataSet7.PAConstituency);
            // TODO: This line of code loads data into the 'voteDouDataSet7.NAConstituency' table. You can move, or remove it, as needed.
            this.nAConstituencyTableAdapter2.Fill(this.voteDouDataSet7.NAConstituency);
          
           
            // TODO: This line of code loads data into the 'voteDouDataSet.Voter' table. You can move, or remove it, as needed.
            this.voterTableAdapter.Fill(this.voteDouDataSet.Voter);
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try{

                if (AddPAConstituency.Text == "")
                {
                    sa = "INSERT INTO ParticipatingVoters (CNIC,Session_ID,Password,NAConstituency,PAConstituency,Voted) VALUES ('"
                   + AddCNIC.Text + "','" + AddSession.Text +
                   "', NEXT VALUE FOR Voter_Password_Sequence,'"
                   + AddNAConstituency.Text + "', NULL,0)";
                }
                else
                {
                    sa = "INSERT INTO ParticipatingVoters (CNIC,Session_ID,Password,NAConstituency,PAConstituency,Voted) VALUES ('"
                   + AddCNIC.Text + "','" + AddSession.Text +
                   "', NEXT VALUE FOR Voter_Password_Sequence,'"
                   + AddNAConstituency.Text + "','" + AddPAConstituency.Text + "',0)";
                }

                string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
                using (SqlConnection con = new SqlConnection(cons))
                {
                    con.Open();
                   
                    using (SqlCommand com = new SqlCommand(sa, con))
                    {
                        com.ExecuteNonQuery();

                        btnClear_Click(null, null);
                        MessageBox.Show("Record Entered", "Congratulations!", MessageBoxButtons.OK);



                    }
                }


            }
            catch
            {
                MessageBox.Show("Invalid Data Entry!");
                btnClear_Click(null, null);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AddCNIC.Clear();
            AddSession.Clear();
            AddNAConstituency.Clear();
            AddPAConstituency.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM ParticipatingVoters where CNIC ='" + SearchCNIC.Text + 
                    "' AND Session_ID ='"+ SearchSession.Text+"'";
                using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                {

                    SqlDataReader reader = selectCommand.ExecuteReader();
                    string searchCNIC = SearchCNIC.Text;
                    

                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (searchCNIC == reader.GetValue(0).ToString())
                            {
                                EditCNIC.Text = reader.GetValue(0).ToString();
                                EditSessionID.Text = reader.GetValue(1).ToString();
                                EditPassword.Text = reader.GetValue(2).ToString();
                                EditNAConstituency.Text = reader.GetValue(3).ToString();
                                EditPAConstituency.Text = reader.GetValue(4).ToString();
                                
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("No matching record exists.");
                    }


                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            SqlConnection con = new SqlConnection(cons);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from ParticipatingVoters", con);
            sda.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try 
            {
                using (SqlConnection connection1 = new SqlConnection(cons))
                {
                    connection1.Open();

                    string s = "Update ParticipatingVoters set CNIC ='"
                      + EditCNIC.Text + "', Session_ID ='" + EditSessionID.Text +
                  "', NAConstituency ='" + EditNAConstituency.Text +
                  "', PAConstituency ='" + EditPAConstituency.Text +
                  "'where CNIC ='" + SearchCNIC.Text +
                        "' AND Session_ID ='" + SearchSession.Text + "'";
                    using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                    {

                        SqlDataReader reader = selectCommand.ExecuteReader();
                        MessageBox.Show("Record Updated Successfully");


                    }
                }
            }
            catch
            {
                MessageBox.Show("Sorry, You cannot make these changes.");
            }
                SearchCNIC.Clear();
                SearchSession.Clear();
                EditCNIC.Clear();
                EditSessionID.Clear();
                EditNAConstituency.Clear();
                EditPAConstituency.Clear();
                EditPassword.Clear();

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try 
            {
                using (SqlConnection connection1 = new SqlConnection(cons))
                {
                    connection1.Open();
                    string s = "Delete FROM ParticipatingVoters where CNIC ='" + SearchCNIC.Text +
                        "' AND Session_ID ='" + SearchSession.Text + "'";
                    using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                    {

                        SqlDataReader reader = selectCommand.ExecuteReader();
                        MessageBox.Show("Record Deleted Successfully");

                    }
                }
            }
            catch
            {
                MessageBox.Show("Sorry, You cannot make these changes.");
                
            }
                SearchCNIC.Clear();
                SearchSession.Clear();
                EditCNIC.Clear();
                EditNAConstituency.Clear();
                EditPAConstituency.Clear();
                EditPassword.Clear();
                EditSessionID.Clear();


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            SqlConnection con = new SqlConnection(cons);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from ParticipatingVoters", con);
            sda.Fill(dt);
            dataGridView4.DataSource = dt;
        }

        private void AddSession_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void SearchSession_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void EditSessionID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void EditPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void AddCNIC_TextChanged(object sender, EventArgs e)
        {
            AddCNIC.MaxLength = 15;
            if (AddCNIC.Text.Length == 5)
            {
                AddCNIC.Text += "-";
                AddCNIC.SelectionStart = AddCNIC.Text.Length;
            }
            else if (AddCNIC.Text.Length == 13)
            {
                AddCNIC.Text += "-";
                AddCNIC.SelectionStart = AddCNIC.Text.Length;
            }
        }

        private void SearchCNIC_TextChanged(object sender, EventArgs e)
        {
            SearchCNIC.MaxLength = 15;
            if (SearchCNIC.Text.Length == 5)
            {
                SearchCNIC.Text += "-";
                SearchCNIC.SelectionStart = SearchCNIC.Text.Length;
            }
            else if (SearchCNIC.Text.Length == 13)
            {
                SearchCNIC.Text += "-";
                SearchCNIC.SelectionStart = SearchCNIC.Text.Length;
            }
        }

        private void EditCNIC_TextChanged(object sender, EventArgs e)
        {
            EditCNIC.MaxLength = 15;
            if (EditCNIC.Text.Length == 5)
            {
                EditCNIC.Text += "-";
                EditCNIC.SelectionStart = EditCNIC.Text.Length;
            }
            else if (EditCNIC.Text.Length == 13)
            {
                EditCNIC.Text += "-";
                EditCNIC.SelectionStart = EditCNIC.Text.Length;
            }
        }

        private void AddNAConstituency_TextChanged(object sender, EventArgs e)
        {
            AddNAConstituency.MaxLength = 5;

            if (AddNAConstituency.Text.Length == 0)
            {
                AddNAConstituency.Text += "NA";
                AddNAConstituency.SelectionStart = AddNAConstituency.Text.Length;
            }
        }

        private void EditNAConstituency_TextChanged(object sender, EventArgs e)
        {
            EditNAConstituency.MaxLength = 5;

            if (EditNAConstituency.Text.Length == 0)
            {
                EditNAConstituency.Text += "NA";
                EditNAConstituency.SelectionStart = EditNAConstituency.Text.Length;
            }
        }

        private void AddPAConstituency_TextChanged(object sender, EventArgs e)
        {
            AddPAConstituency.MaxLength = 5;
        }
    }
}
