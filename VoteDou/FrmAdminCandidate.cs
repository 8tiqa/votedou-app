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
    public partial class FrmAdminCandidate : Form
    {
        public FrmAdminCandidate()
        {
            DoubleBuffered = true;
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AddFirstName.Text.Length < 1 || AddLastName.Text.Length < 1 || AddCNIC.Text.Length < 1 || AddPartyID.Text.Length < 1)
            {
                MessageBox.Show("Empty Field");
            }
            else
            {

                string firstname = AddFirstName.Text.ToString();
                string lastname = AddLastName.Text.ToString();
                string cnic = AddCNIC.Text.ToString();
                string partyid = AddPartyID.Text.ToString();

                string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
                try
                {
                    using (SqlConnection con = new SqlConnection(cons))
                    {
                        con.Open();
                        using (SqlCommand com = new SqlCommand("INSERT INTO Candidate (Candidate_ID,FirstName,LastName,CNIC,Party_ID) VALUES (NEXT VALUE FOR Candidate_ID_Sequence, @firstname,@lastname,@cnic,@partyid)", con))
                        {
                            com.Parameters.AddWithValue("@firstname", firstname);
                            com.Parameters.AddWithValue("@lastname", lastname);
                            com.Parameters.AddWithValue("@cnic", cnic);
                            com.Parameters.AddWithValue("@partyid", partyid);
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

        private void comboParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = comboParty.SelectedValue.ToString();
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connect = new SqlConnection(cons))
            {
                connect.Open();
                using (SqlCommand com = new SqlCommand("Select * from Party where PartyName ='" + comboParty.Text + "'", connect))
                {
                    SqlDataReader red = com.ExecuteReader();
                    string searchparty = comboParty.Text;

                    if (red.HasRows)
                    {
                        if (red.Read())
                        {
                            if (searchparty == red.GetValue(1).ToString())
                                AddPartyID.Text = red.GetValue(0).ToString();

                        }
                    }


                }
            }
            
        }

        private void FrmAdminCandidate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voteDouDataSet.Candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter.Fill(this.voteDouDataSet.Candidate);
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connect = new SqlConnection(cons))
            {
                connect.Open();
                using (SqlCommand com = new SqlCommand("Select * from Party", connect))
                {
                    SqlDataReader rad = com.ExecuteReader();
                    DataTable dtab = new DataTable();
                    dtab.Columns.Add("Party_ID", typeof(string));
                    dtab.Columns.Add("PartyName", typeof(string));
                    dtab.Load(rad);

                    comboParty.ValueMember = "Party_ID";
                    comboParty.DisplayMember = "PartyName";
                    comboParty.DataSource = dtab;

                    
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AddFirstName.Text = "";
            AddLastName.Text = "";
            AddCNIC.Text = "";
            AddPartyID.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM Candidate where Candidate_ID ='" + EditID.Text + "'";
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
                                EditFirstName.Text = reader.GetValue(1).ToString();
                                EditLastName.Text = reader.GetValue(2).ToString();
                                EditCNIC.Text = reader.GetValue(3).ToString();
                                EditPartyID.Text = reader.GetValue(4).ToString();
                                
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try
            {
                using (SqlConnection connection1 = new SqlConnection(cons))
                {
                    connection1.Open();

                    string s = "Update Candidate set FirstName ='" + EditFirstName.Text + "', LastName ='" + EditLastName.Text +
                    "', CNIC ='" + EditCNIC.Text + "', Party_ID ='" + EditPartyID.Text +
                    "'where Candidate_ID ='" + EditID.Text + "'";

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
                EditID.Clear();
                EditFirstName.Clear();
                EditLastName.Clear();
                EditCNIC.Clear();
                EditPartyID.Clear();

               

            

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try 
            {
                using (SqlConnection connection1 = new SqlConnection(cons))
                {
                    connection1.Open();
                    string s = "Delete FROM Candidate where Candidate_ID ='" + EditID.Text + "'";
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
                EditID.Clear();
                EditFirstName.Clear();
                EditLastName.Clear();
                EditCNIC.Clear();
                EditPartyID.Clear();
               


            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            

        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            SqlConnection con = new SqlConnection(cons);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Candidate", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            SqlConnection con = new SqlConnection(cons);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Candidate", con);
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void AddFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            { e.Handled = true; }
        }

        private void AddLastName_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void AddPartyID_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            { e.Handled = true; }
        }

        private void AddPartyID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            { e.Handled = true; }
        }

        private void EditFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            { e.Handled = true; }
        }

        private void EditLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
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

        private void AddCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 45)
            { e.Handled = true; }
        }

        private void EditCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 45)
            { e.Handled = true; }
        }


    }
}
