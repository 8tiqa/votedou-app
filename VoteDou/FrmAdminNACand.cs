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
    public partial class FrmAdminNACand : Form
    {
        string Cand_id, Con_id, Session_id;
        public FrmAdminNACand()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdmin next = new FrmAdmin();
            next.ShowDialog();
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdminNACand_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voteDouDataSet7.NAConstituency' table. You can move, or remove it, as needed.
            this.nAConstituencyTableAdapter1.Fill(this.voteDouDataSet7.NAConstituency);
            
            // TODO: This line of code loads data into the 'voteDouDataSet6.NAContestingCandidates' table. You can move, or remove it, as needed.
            this.nAContestingCandidatesTableAdapter2.Fill(this.voteDouDataSet6.NAContestingCandidates);
           

            // TODO: This line of code loads data into the 'voteDouDataSet.Candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter.Fill(this.voteDouDataSet.Candidate);
            
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AddCandidate.Text.Length < 1 || AddConstituency.Text.Length < 1 || AddSession.Text.Length < 1)
            {
                MessageBox.Show("Empty Field");
            }
            else
            {
                string candidate = AddCandidate.Text.ToString();
                string constituency = AddConstituency.Text.ToString();
                string session = AddSession.Text.ToString();


                string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
                try
                {
                    using (SqlConnection con = new SqlConnection(cons))
                    {
                        con.Open();
                        using (SqlCommand com = new SqlCommand("INSERT INTO NAContestingCandidates (Candidate_ID, Constituency_ID,Session_ID) VALUES (@cand,@con,@session)", con))
                        {
                            com.Parameters.AddWithValue("@cand", candidate);
                            com.Parameters.AddWithValue("@con", constituency);
                            com.Parameters.AddWithValue("@session", session);

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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AddCandidate.Text = "";
            AddConstituency.Text ="";
            AddSession.Text= "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try 
            {
                using (SqlConnection connection1 = new SqlConnection(cons))
                {
                    connection1.Open();

                    string s = "Update NAContestingCandidates set Candidate_ID ='"
                        + EditFirstName.Text + "', Constituency_ID ='" + EditLastName.Text +
                    "', Session_ID ='" + EditCNIC.Text +
                    "'where Candidate_ID ='" + Cand_id +
                        "' AND Constituency_ID ='" + Con_id +
                        "' AND Session_ID ='" + Session_id + "'";



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
                
                EditFirstName.Clear();
                EditLastName.Clear();
                EditCNIC.Clear();
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            SqlConnection con = new SqlConnection(cons);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from NAContestingCandidates", con);
            sda.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try
            {
                using (SqlConnection connection1 = new SqlConnection(cons))
                {
                    connection1.Open();
                    string s = "Delete FROM NAContestingCandidates where Candidate_ID ='" + Cand_id +
                        "' AND Constituency_ID ='" + Con_id +
                        "' AND Session_ID ='" + Session_id + "'";

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
                EditFirstName.Clear();
                EditLastName.Clear();
                EditCNIC.Clear();



            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            SqlConnection con = new SqlConnection(cons);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from NAContestingCandidates", con);
            sda.Fill(dt);
            dataGridView4.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM NAContestingCandidates where Candidate_ID ='" + EditFirstName.Text +
                    "' AND Constituency_ID ='" + EditLastName.Text +
                    "' AND Session_ID ='" + EditCNIC.Text + "'";

                using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                {

                    SqlDataReader reader = selectCommand.ExecuteReader();
                


                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Record Found!");
                            Cand_id = reader.GetValue(0).ToString();
                            Con_id = reader.GetValue(1).ToString();
                            Session_id = reader.GetValue(2).ToString();

                            

                        }
                    }
                    else
                    {
                        MessageBox.Show("No matching record exists.");
                    }


                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddCandidate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void AddSession_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void EditFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void EditCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }
    }
}
