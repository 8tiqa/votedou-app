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
    public partial class FrmAdminParty : Form
    {
        public FrmAdminParty()
        {
            DoubleBuffered = true;
            InitializeComponent();
            DoubleBuffered = true;
        }
        
        private void FrmAdminParty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voteDouDataSet.Party' table. You can move, or remove it, as needed.
            this.partyTableAdapter.Fill(this.voteDouDataSet.Party);

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = AddPartyName.Text.ToString();
            string founder = AddFounder.Text.ToString();
            string chairman = AddChairman.Text.ToString();
           

            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(cons))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand(
                        "INSERT INTO Party(Party_ID,PartyName,Founder,Chairman) VALUES (NEXT VALUE FOR Party_ID_Sequence,@name,@founder,@chairman)", con))
                    {
                        com.Parameters.AddWithValue("@name", name);
                        com.Parameters.AddWithValue("@Founder", founder);
                        com.Parameters.AddWithValue("@Chairman", chairman);



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
            AddPartyName.Clear();
            AddFounder.Clear();
            AddChairman.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM Party where Party_ID ='" + SearchID.Text + "'";
                using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                {

                    SqlDataReader reader = selectCommand.ExecuteReader();
                    string searchID = SearchID.Text;


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

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            SqlConnection con = new SqlConnection(cons);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Party", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try 
            {
                using (SqlConnection connection1 = new SqlConnection(cons))
                {
                    connection1.Open();

                    string s = "Update Party set PartyName ='" + EditName.Text +
                        "', Founder ='" + EditFounder.Text +
                        "', Chairman ='" + EditChairman.Text +
                        "'where Party_ID ='" + SearchID.Text + "'";

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
                EditName.Clear();
                EditFounder.Clear();
                EditChairman.Clear();
                SearchID.Clear();
            
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try 
            {
                using (SqlConnection connection1 = new SqlConnection(cons))
                {
                    connection1.Open();
                    string s = "Delete FROM Party where Party_ID ='" + SearchID.Text + "'";
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
                EditName.Clear();
                EditFounder.Clear();
                EditChairman.Clear();
                SearchID.Clear();


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            SqlConnection con = new SqlConnection(cons);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Party", con);
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void AddPartyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            { e.Handled = true; }
        }

        private void AddFounder_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            { e.Handled = true; }
        }

        private void AddChairman_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            { e.Handled = true; }
        }

        private void EditName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            { e.Handled = true; }
        }

        private void EditFounder_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            { e.Handled = true; }
        }

        private void EditChairman_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            { e.Handled = true; }
        }

        private void SearchID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

    }
}
