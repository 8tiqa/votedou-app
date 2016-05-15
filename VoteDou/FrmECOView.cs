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
    public partial class FrmECOView : Form
    {
        public FrmECOView()
        {
            InitializeComponent();
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmECO next = new FrmECO();
            next.Show();
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
            PageAboutProg next = new PageAboutProg("ECO");
            next.ShowDialog();
        }

        private void aboutTheDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageAboutDev next = new PageAboutDev("ECO");
            next.ShowDialog();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageContactUs next = new PageContactUs("ECO");
            next.ShowDialog();
        }

        private void SearchSession_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM ElectionSession where Session_ID ='" + EditID.Text + "'";
                string sa;
                using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                {

                    SqlDataReader reader = selectCommand.ExecuteReader();
                    string searchID = EditID.Text;


                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (searchID == reader.GetValue(0).ToString())
                            {
                                EditYear.Text = reader.GetValue(1).ToString();

                                sa = "Select * from SessionNAConstituency where Session_ID ='" + searchID + "'";
                                DataTable dt = new DataTable();
                                SqlDataAdapter sda = new SqlDataAdapter(sa, connection1);
                                sda.Fill(dt);
                                dataGridView3.DataSource = dt;

                                sa = "Select * from SessionPAConstituency where Session_ID ='" + searchID + "'";
                                DataTable data = new DataTable();
                                SqlDataAdapter sada = new SqlDataAdapter(sa, connection1);
                                sada.Fill(data);
                                dataGridView2.DataSource = data;


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

        private void SearchNACons_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM NAConstituency where NAConstituency_ID ='" + SearchNACon.Text + "'";
                using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                {

                    SqlDataReader reader = selectCommand.ExecuteReader();
                    string searchID = SearchNACon.Text;


                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (searchID == reader.GetValue(0).ToString())
                            {
                               
                                EditConstituencyDetails.Text = reader.GetValue(1).ToString();
                                

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

        private void SearchContestant_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSearchPAContestant_Click(object sender, EventArgs e)
        {
            
        }

        private void SearchCand_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM Candidate where Candidate_ID ='" + SearchCandidate.Text + "'";
                using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                {

                    SqlDataReader reader = selectCommand.ExecuteReader();
                    string searchID = SearchCandidate.Text;


                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (searchID == reader.GetValue(0).ToString())
                            {
                                CandFirstName.Text = reader.GetValue(1).ToString();
                                CandLastName.Text = reader.GetValue(2).ToString();
                                CandCNIC.Text = reader.GetValue(3).ToString();
                                CandPartyID.Text = reader.GetValue(4).ToString();

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

        private void SearchPartVoter_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM ParticipatingVoters where CNIC ='" + SearchNIC.Text + 
                    "' AND Session_ID ='" + SearchSessionIDD.Text + "'";
                using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                {

                    SqlDataReader reader = selectCommand.ExecuteReader();
                    


                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                           
                                SearchCNIC.Text = reader.GetValue(1).ToString();
                                SearchSessionID.Text = reader.GetValue(2).ToString();
                                
                                EditNAConstituency.Text = reader.GetValue(4).ToString();
                                textBox7.Text = reader.GetValue(5).ToString();

                            

                        }
                    }
                    else
                    {
                        MessageBox.Show("No matching record exists.");
                    }


                }
            }
        }

        private void SearchVoter_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM Voter where CNIC ='" + SearchVoterCNIC.Text + "'";
                using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                {

                    SqlDataReader reader = selectCommand.ExecuteReader();
                    string searchCNIC = SearchVoterCNIC.Text;


                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (searchCNIC == reader.GetValue(0).ToString())
                            {
                               
                                VoterFirst.Text = reader.GetValue(1).ToString();
                                VoterLast.Text = reader.GetValue(2).ToString();
                                VoterContact.Text = reader.GetValue(3).ToString();
                                VoterFatherName.Text = reader.GetValue(4).ToString();
                                VoterDOB.Text = reader.GetValue(5).ToString();
                                VoterAddress.Text = reader.GetValue(6).ToString();

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM Party where Party_ID ='" + SearchPartyID.Text + "'";
                using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                {

                    SqlDataReader reader = selectCommand.ExecuteReader();
                    string searchID = SearchPartyID.Text;


                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (searchID == reader.GetValue(0).ToString())
                            {
                                EditName.Text = reader.GetValue(1).ToString();
                                EditFounder.Text = reader.GetValue(2).ToString();
                                EditChairman.Text = reader.GetValue(3).ToString();


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

        private void FrmECOView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voteDouDataSet8.Party' table. You can move, or remove it, as needed.
            this.partyTableAdapter1.Fill(this.voteDouDataSet8.Party);
            // TODO: This line of code loads data into the 'voteDouDataSet8.Voter' table. You can move, or remove it, as needed.
            this.voterTableAdapter1.Fill(this.voteDouDataSet8.Voter);
            // TODO: This line of code loads data into the 'voteDouDataSet8.ParticipatingVoters' table. You can move, or remove it, as needed.
            this.participatingVotersTableAdapter1.Fill(this.voteDouDataSet8.ParticipatingVoters);
            // TODO: This line of code loads data into the 'voteDouDataSet8.Candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter1.Fill(this.voteDouDataSet8.Candidate);
            // TODO: This line of code loads data into the 'voteDouDataSet8.View_PACandidate' table. You can move, or remove it, as needed.
            this.view_PACandidateTableAdapter.Fill(this.voteDouDataSet8.View_PACandidate);
            // TODO: This line of code loads data into the 'voteDouDataSet8.View_NACandidate' table. You can move, or remove it, as needed.
            this.view_NACandidateTableAdapter.Fill(this.voteDouDataSet8.View_NACandidate);
            // TODO: This line of code loads data into the 'voteDouDataSet7.PAConstituency' table. You can move, or remove it, as needed.
            this.pAConstituencyTableAdapter1.Fill(this.voteDouDataSet7.PAConstituency);
            // TODO: This line of code loads data into the 'voteDouDataSet7.SessionPAConstituency' table. You can move, or remove it, as needed.
            this.sessionPAConstituencyTableAdapter1.Fill(this.voteDouDataSet7.SessionPAConstituency);
            // TODO: This line of code loads data into the 'voteDouDataSet7.SessionNAConstituency' table. You can move, or remove it, as needed.
            this.sessionNAConstituencyTableAdapter1.Fill(this.voteDouDataSet7.SessionNAConstituency);
            // TODO: This line of code loads data into the 'voteDouDataSet7.NAConstituency' table. You can move, or remove it, as needed.
            this.nAConstituencyTableAdapter1.Fill(this.voteDouDataSet7.NAConstituency);
            // TODO: This line of code loads data into the 'voteDouDataSet7.ElectionSession' table. You can move, or remove it, as needed.
            this.electionSessionTableAdapter1.Fill(this.voteDouDataSet7.ElectionSession);
           

        }

        private void SearchPACons_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM PAConstituency where PAConstituency_ID ='" + SearchPACon.Text + "'";
                using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                {

                    SqlDataReader reader = selectCommand.ExecuteReader();
                    string searchID = SearchPACon.Text;


                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (searchID == reader.GetValue(0).ToString())
                            {
                               
                                EditPAConDetails.Text = reader.GetValue(1).ToString();
                               

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

        private void EditID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void SearchCandidate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void SearchSessionIDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void SearchPartyID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void SearchNACon_TextChanged(object sender, EventArgs e)
        {
            SearchNACon.MaxLength = 5;

            if (SearchNACon.Text.Length == 0)
            {
                SearchNACon.Text += "NA";
                SearchNACon.SelectionStart = SearchNACon.Text.Length;
            }
            
        }

        private void SearchPACon_TextChanged(object sender, EventArgs e)
        {
            SearchPACon.MaxLength = 5;

        }
    }
}
