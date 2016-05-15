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
    public partial class FrmAdminVoter : Form
    {
        public FrmAdminVoter()
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

        private void label10_Click(object sender, EventArgs e)
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
            
         
            if (AddFirstName.Text.Length < 1 || AddLastName.Text.Length < 1 ||
               AddCNIC.Text.Length < 1 || AddFatherName.Text.Length < 1 ||
                AddContact.Text.Length < 1 ||
                AddAddress.Text.Length < 1)
            {
                MessageBox.Show("Empty Field");
            }
            else
            {

                string firstname = AddFirstName.Text.ToString();
                string lastname = AddLastName.Text.ToString();
                string cnic = AddCNIC.Text.ToString();
                string fathername = AddFatherName.Text.ToString();
                string contact = AddContact.Text.ToString();
               
                string address = AddAddress.Text.ToString();


                string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
                try
                {
                    using (SqlConnection con = new SqlConnection(cons))
                    {
                        con.Open();
                        using (SqlCommand com = new SqlCommand("INSERT INTO Voter(CNIC,FirstName,LastName,Contact#,FatherName,DateOfBirth,Address) VALUES (@CNIC,@FirstName,@LastName,@Contact,@FatherName,convert(datetime,@DateOfBirth,103),@Address)", con))
                        {
                            com.Parameters.AddWithValue("@FirstName", firstname);
                            com.Parameters.AddWithValue("@LastName", lastname);
                            com.Parameters.AddWithValue("@CNIC", cnic);
                            com.Parameters.AddWithValue("@Contact", contact);
                            com.Parameters.AddWithValue("@FatherName", fathername);
                            com.Parameters.AddWithValue("@DateOfBirth", SqlDbType.DateTime).Value = AddDOB.Value;
                            com.Parameters.AddWithValue("@Address", address);


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
            AddFirstName.Clear();
            AddLastName.Clear();
            AddCNIC.Clear();
            AddFatherName.Clear();
            AddContact.Clear();
          
            AddAddress.Clear();
        }

        private void FrmAdminVoter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voteDouDataSet.Voter' table. You can move, or remove it, as needed.
            this.voterTableAdapter.Fill(this.voteDouDataSet.Voter);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM Voter where CNIC ='" + SearchCNIC.Text + "'";
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
                                EditFirstName.Text = reader.GetValue(1).ToString();
                                EditLastName.Text = reader.GetValue(2).ToString();
                                EditContact.Text = reader.GetValue(3).ToString();
                                EditFatherName.Text = reader.GetValue(4).ToString();
                                
                                EditAddress.Text = reader.GetValue(6).ToString();
                                
                                //DATETIMEPICKER LOAD
                                DateTime DOB = (DateTime)reader.GetValue(5);
                                EditDOB.Value = DOB;

                               
                                
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
            SqlDataAdapter sda = new SqlDataAdapter("select * from Voter", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = EditFirstName.Text.ToString();
                string lastname = EditLastName.Text.ToString();
                string cnic = EditCNIC.Text.ToString();
                string fathername = EditFatherName.Text.ToString();
                string contact = EditContact.Text.ToString();
                string address = EditAddress.Text.ToString();
                string SearchCNICC = SearchCNIC.Text.ToString();

                string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
                using (SqlConnection connection1 = new SqlConnection(cons))
                {
                    connection1.Open();

                    string s = "Update Voter set CNIC = @CNIC, FirstName = @FirstName, LastName = @LastName, Contact# = @Contact, FatherName = @FatherName, DateOfBirth = convert(datetime,@DateOfBirth,103), Address = @Address where CNIC = @searchnic";

                    using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                    {

                        selectCommand.Parameters.AddWithValue("@FirstName", firstname);
                        selectCommand.Parameters.AddWithValue("@LastName", lastname);
                        selectCommand.Parameters.AddWithValue("@CNIC", cnic);
                        selectCommand.Parameters.AddWithValue("@Contact", contact);
                        selectCommand.Parameters.AddWithValue("@FatherName", fathername);
                        selectCommand.Parameters.AddWithValue("@DateOfBirth", SqlDbType.DateTime).Value = EditDOB.Value;
                        selectCommand.Parameters.AddWithValue("@Address", address);
                        selectCommand.Parameters.AddWithValue("@searchnic", SearchCNICC);


                        selectCommand.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");


                    }

                }

            }
            catch
            {
                MessageBox.Show("Sorry, You cannot make these changes.");
            }
            
            
                EditCNIC.Clear();
                EditFirstName.Clear();
                EditLastName.Clear();
                EditContact.Clear();
                EditFatherName.Clear();
               
                EditAddress.Clear();
                SearchCNIC.Clear();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try
            {
                using (SqlConnection connection1 = new SqlConnection(cons))
                {
                    connection1.Open();
                    string s = "Delete FROM Voter where CNIC ='" + SearchCNIC.Text + "'";
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
                EditCNIC.Clear();
                EditFirstName.Clear();
                EditLastName.Clear();
                EditContact.Clear();
                EditFatherName.Clear();
              
                EditAddress.Clear();
                SearchCNIC.Clear();


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            SqlConnection con = new SqlConnection(cons);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Voter", con);
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void AddFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            { e.Handled = true; }
        }

        private void AddLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            { e.Handled = true; }
        }

        private void AddFatherName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void EditFatherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            { e.Handled = true; }
        }

        private void AddContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void EditContact_KeyPress(object sender, KeyPressEventArgs e)
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
