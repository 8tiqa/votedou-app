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
    public partial class FrmAdminNACon : Form
    {
        public FrmAdminNACon()
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
            if (AddID.Text.Length < 1 || AddConstituencyDetails.Text.Length < 1)
            {
                MessageBox.Show("Empty Field");
            }
            else
            {
                string ConstituencyID = AddID.Text.ToString();
                string ConstituencyDetails = AddConstituencyDetails.Text.ToString();


                string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
                try
                {
                    using (SqlConnection con = new SqlConnection(cons))
                    {
                        con.Open();

                        using (SqlCommand com = new SqlCommand("INSERT INTO NAConstituency (NAConstituency_ID, ConstituencyDetails) VALUES (@id,@details)", con))
                        {
                            com.Parameters.AddWithValue("@id", ConstituencyID);
                            com.Parameters.AddWithValue("@details", ConstituencyDetails);


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
            AddID.Clear();
            AddConstituencyDetails.Clear();
       
        }

        private void FrmAdminNACon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voteDouDataSet7.NAConstituency' table. You can move, or remove it, as needed.
            this.nAConstituencyTableAdapter1.Fill(this.voteDouDataSet7.NAConstituency);
         

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM NAConstituency where NAConstituency_ID ='" + SearchID.Text + "'";
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
                                EditID.Text = reader.GetValue(0).ToString();
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            SqlConnection con = new SqlConnection(cons);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from NAConstituency", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try 
            {
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                {
                    string s = "Update NAConstituency set NAConstituency_ID ='"
                        + EditID.Text + "', ConstituencyDetails ='" + EditConstituencyDetails.Text +
                        "'where NAConstituency_ID ='" + SearchID.Text + "'";


                    using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                    {

                        SqlDataReader reader = selectCommand.ExecuteReader();
                        MessageBox.Show("Record Updated Successfully");


                    }
                }}
            }
            catch
            {
                 MessageBox.Show("Sorry, You cannot make these changes.");
            }

                SearchID.Clear();
                EditID.Clear();
                EditConstituencyDetails.Clear();


            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try 
            {
                using (SqlConnection connection1 = new SqlConnection(cons))
                {
                    connection1.Open();
                    string s = "Delete FROM NAConstituency where NAConstituency_ID ='" + SearchID.Text + "'";
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
                SearchID.Clear();
                EditID.Clear();
                EditConstituencyDetails.Clear();

               

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            SqlConnection con = new SqlConnection(cons);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from NAConstituency", con);
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void AddConstituencyDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            { e.Handled = true; }
        }

        private void EditConstituencyDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            { e.Handled = true; }
        }

        private void AddID_TextChanged(object sender, EventArgs e)
        {
            
                AddID.MaxLength = 5;

                if (AddID.Text.Length == 0)
                {
                    AddID.Text += "NA";
                    AddID.SelectionStart = AddID.Text.Length;
                }
            

        }

        private void SearchID_TextChanged(object sender, EventArgs e)
        {
            SearchID.MaxLength = 5;

            if (SearchID.Text.Length == 0)
            {
                SearchID.Text += "NA";
                SearchID.SelectionStart = SearchID.Text.Length;
            }
        }

        private void EditID_TextChanged(object sender, EventArgs e)
        {
            EditID.MaxLength = 5;

            if (EditID.Text.Length == 0)
            {
                EditID.Text += "NA";
                EditID.SelectionStart = EditID.Text.Length;
            }
        }
    }
}
