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
    public partial class FrmAdminSession : Form
    {
        string type;
        public FrmAdminSession()
        {
            DoubleBuffered = true;
            InitializeComponent();
            DoubleBuffered = true;
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
             
            string year = AddYear.Text.ToString();
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(cons))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand("INSERT INTO ElectionSession (Session_ID,Year,Election_Type) VALUES (NEXT VALUE FOR Session_ID_Sequence,@year,@type)", con))
                    {

                        com.Parameters.AddWithValue("@year", year);
                        com.Parameters.AddWithValue("@type", type);

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
           
            AddYear.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM ElectionSession where Session_ID ='" + SearchID.Text + "'";
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
                                EditYear.Text = reader.GetValue(1).ToString();
                                EditType.Text = reader.GetValue(2).ToString();
                                
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

        private void FrmAdminSession_Load(object sender, EventArgs e)
        {
            // Bind combobox to dictionary
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("1", "General");
            test.Add("2", "By-Election");
           
            comboElection.DataSource = new BindingSource(test, null);
            comboElection.DisplayMember = "Value";
            comboElection.ValueMember = "Key";

           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            if (EditType.Text == "By-Election" || EditType.Text == "General")
            try 
            {
                using (SqlConnection connection1 = new SqlConnection(cons))
                {
                    connection1.Open();

                    string s = "Update ElectionSession set Session_ID ='" + EditID.Text +
                        "', Year ='" + EditYear.Text + "', Election_Type ='" + EditType.Text +
                    "'where Session_ID ='" + SearchID.Text + "'";

                    using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                    {

                        SqlDataReader reader = selectCommand.ExecuteReader();
                        MessageBox.Show("Record Updated Successfully");
                        SearchID.Clear();
                        EditID.Clear();
                        EditYear.Clear();
                        EditType.Clear();


                    }
                }
            }
                catch
            {
                    MessageBox.Show("Sorry, You cannot make these changes.");
            }

            else
            {
                MessageBox.Show("The Election Type can either be 'By-Election' or 'General'");
            }
            
              
                

            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            SqlConnection con = new SqlConnection(cons);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from ElectionSession", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            SqlConnection con = new SqlConnection(cons);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from ElectionSession", con);
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try 
            {
                using (SqlConnection connection1 = new SqlConnection(cons))
                {
                    connection1.Open();
                    string s = "Delete FROM ElectionSession where Session_ID ='" + SearchID.Text + "'";
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
                EditYear.Clear();
                


            
        }

        private void AddYear_TextChanged(object sender, EventArgs e)
        {
            AddYear.MaxLength = 4;
            
        }

        private void AddYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void EditYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void EditYear_TextChanged(object sender, EventArgs e)
        {
            EditYear.MaxLength = 4;
        }

        private void SearchID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void EditID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void comboElection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get combobox selection (in handler)
           type = ((KeyValuePair<string, string>)comboElection.SelectedItem).Value;
        }

    }
}
