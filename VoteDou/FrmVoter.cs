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
    public partial class FrmVoter : Form
    {
        string CNIC, Session; //Voter Info
        string NACon, PACon; //Voter Constituencies

        string NAVote, PAVote; //Votes Casted
        string NAcasted, PACasted; //Voting Checks

        public FrmVoter(string input, string inputs)
        {
            InitializeComponent();
            CNIC = input;
            Session = inputs;
            NAcasted = "1";
            PACasted = "1";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if ((comboPA.Enabled == true) && (comboNA.Enabled == true))
                if (NAcasted == "1")
                    if (PACasted == "1")
                    {
                        string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
                        using (SqlConnection connection1 = new SqlConnection(cons))
                        {
                            connection1.Open();

                            string s = "Update ParticipatingVoters set Voted = 1 where CNIC ='" + CNIC + "' AND Session_ID ='" + Session + "'";
                            using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                            {
                                SqlDataReader reader = selectCommand.ExecuteReader();

                            }

                        }


                        this.Hide();
                        FrmVoterConfirmSub form = new FrmVoterConfirmSub(NAVote, PAVote);
                        form.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("You have not submited your PA Vote. Click Submit Button to submit.");
                    }
                else
                {
                    MessageBox.Show("You have not submited your NA Vote. Click Submit Button.");
                }
            else if ((comboNA.Enabled == true) && (comboPA.Enabled == false))
            {
                if (NAcasted == "1")
                {
                    string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
                    using (SqlConnection connection1 = new SqlConnection(cons))
                    {
                        connection1.Open();

                        string s = "Update ParticipatingVoters set Voted = 1 where CNIC ='" + CNIC + "' AND Session_ID ='" + Session + "'";
                        using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                        {
                            SqlDataReader reader = selectCommand.ExecuteReader();

                        }

                    }


                    this.Hide();
                    FrmVoterConfirmSub form = new FrmVoterConfirmSub(NAVote, PAVote);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You have not submited your NA Vote. Click Submit Button.");
                }
            }
            else if ((comboNA.Enabled == false) && (comboPA.Enabled == true))
            {
                if (PACasted == "1")
                {
                    string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
                    using (SqlConnection connection1 = new SqlConnection(cons))
                    {
                        connection1.Open();

                        string s = "Update ParticipatingVoters set Voted = 1 where CNIC ='" + CNIC + "' AND Session_ID ='" + Session + "'";
                        using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                        {
                            SqlDataReader reader = selectCommand.ExecuteReader();

                        }

                    }


                    this.Hide();
                    FrmVoterConfirmSub form = new FrmVoterConfirmSub(NAVote, PAVote);
                    form.ShowDialog();

                }
                else
                {
                    MessageBox.Show("You have not submited your PA Vote. Click Submit Button.");
                }
            }
            else
            {
                string msg = "You have not casted any vote. Do you want to exit?";
                var result = MessageBox.Show(msg, "Confirm Your Vote", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    FrmLoginRoles next = new FrmLoginRoles();
                    next.Show();
                }
                else
                    return;

            }

        }

        private void btnVoteNA_Click(object sender, EventArgs e)
        {
            string output;
            if (comboNA.Enabled == true)
            {
                output = "Do you want to submit your vote?";
                var result = MessageBox.Show(output, "Confirm Your Vote", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
                    using (SqlConnection connection1 = new SqlConnection(cons))
                    {
                        connection1.Open();

                        string s = "Update ParticipatingVoters set NAVote ='" + NAVote +
                            "'where CNIC ='" + CNIC + "' AND Session_ID ='" + Session + "'";

                        using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                        {
                            SqlDataReader reader = selectCommand.ExecuteReader();

                        }
                        NAcasted = "1";

                    }
                }
                else
                    return;
            }
            else
                MessageBox.Show("Please tick the checkbox to submit a vote for National Assembly");
        }

        private void btnVotePA_Click(object sender, EventArgs e)
        {
            if (comboPA.Enabled == true)
            {
                if (PAVote == null)
                {
                    MessageBox.Show("No Candidate to vote.");
                    PACasted = "1";
                }
                else
                {

                    string output;
                    output = "Do you want to submit your vote?";
                    var result = MessageBox.Show(output, "Confirm Your Vote", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
                        using (SqlConnection connection1 = new SqlConnection(cons))
                        {
                            connection1.Open();

                            string s = "Update ParticipatingVoters set PAVote ='" + PAVote +
                                 "'where CNIC ='" + CNIC + "' AND Session_ID ='" + Session + "'";

                            using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                            {
                                SqlDataReader reader = selectCommand.ExecuteReader();

                            }
                            PACasted = "1";

                        }
                    }
                    else
                        return;
                }
            }
            else
                MessageBox.Show("Please tick the checkbox to submit a vote for Provincial Assembly");

        }

        private void FrmVoter_Load(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM View_VoterList where CNIC ='" + CNIC + "' AND Session_ID ='" + Session + "'";
                SqlCommand selectCommand = new SqlCommand(s, connection1);
                SqlDataReader reader = selectCommand.ExecuteReader();
                string searchID = CNIC;
                string searchSession = Session;

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        if (searchID == reader.GetValue(0).ToString() && searchSession == reader.GetValue(1).ToString())
                        {
                            AddFirstName.Text = reader.GetValue(2).ToString();
                            AddLastName.Text = reader.GetValue(3).ToString();
                            AddCNIC.Text = reader.GetValue(0).ToString();
                            AddNACon.Text = reader.GetValue(4).ToString();
                            AddPACon.Text = reader.GetValue(5).ToString();



                            NACon = reader.GetValue(4).ToString();
                            PACon = reader.GetValue(5).ToString();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("An error has occured.");
                    this.Hide();
                    FrmVoterLogin prev = new FrmVoterLogin();
                    prev.Show();
                }
                reader.Close();
            }

            comboNA.Enabled = false;
            comboPA.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void comboNA_SelectedIndexChanged(object sender, EventArgs e)
        {
            NAVote = comboNA.SelectedValue.ToString();

        }

        private void comboPA_SelectedIndexChanged(object sender, EventArgs e)
        {
            PAVote = comboPA.SelectedValue.ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
            comboNA.Enabled = true;
            NAcasted = "0"; 
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection = new SqlConnection(cons))
                {
                    connection.Open();
                    string q = "Select * FROM View_NACandList where Constituency_ID ='" + NACon + "' AND Session_ID ='" + Session + "'";

                    SqlCommand selectCommandtwo = new SqlCommand(q, connection);


                    SqlDataReader rad = selectCommandtwo.ExecuteReader();

                    DataTable dtab = new DataTable();
                    dtab.Columns.Add("Candidate_ID", typeof(string));
                    dtab.Columns.Add("Candidate_Name", typeof(string));
                    dtab.Load(rad);

                    comboNA.ValueMember = "Candidate_ID";
                    comboNA.DisplayMember = "Candidate_Name";
                    comboNA.DataSource = dtab;


                    rad.Close();
                }
            }
           else
           {
               comboNA.Enabled = false;
               NAcasted = "1"; 
           }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
            PACasted = "0";
            comboPA.Enabled = true;
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
                {
                    connection1.Open();
                    string p = "Select * FROM View_PACandList where Constituency_ID ='" + PACon + "' AND Session_ID ='" + Session + "'";
                    SqlCommand selectCommandthree = new SqlCommand(p, connection1);


                    SqlDataReader rado = selectCommandthree.ExecuteReader();

                    DataTable dtabo = new DataTable();
                    dtabo.Columns.Add("Candidate_ID", typeof(string));
                    dtabo.Columns.Add("Candidate_Name", typeof(string));
                    dtabo.Load(rado);

                    comboPA.ValueMember = "Candidate_ID";
                    comboPA.DisplayMember = "Candidate_Name";
                    comboPA.DataSource = dtabo;


                    rado.Close();
                }
            }
            else
            {
                comboPA.Enabled = false;
                PACasted = "1"; 
            }
        }

        
    
    }
}
