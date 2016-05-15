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
    public partial class FrmVoterLogin : Form
    {
        public FrmVoterLogin()
        {
            InitializeComponent();
          
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM View_ParticipatingVoters where CNIC ='" + txtCNIC.Text + "'AND Session_ID='" + txtSession.Text + "'";

                using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                {

                    SqlDataReader reader = selectCommand.ExecuteReader();
                    string searchCNIC = txtCNIC.Text;
                    string searchPassword = txtPassword.Text;
                    string searchSession = txtSession.Text;
                    
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                          if(searchPassword == reader.GetValue(2).ToString())
                          {
                              DateTime? start = (DateTime?)reader.GetValue(3);
                              DateTime? end = (DateTime?)reader.GetValue(4);
                              DateTime currentDate = DateTime.Now;
                              int startcom = currentDate.CompareTo(start);
                              int endcom= currentDate.CompareTo(end);
                              
                              if (startcom>0 && endcom<0)
                              {
                                  if (reader.GetValue(5).ToString() == "0")
                                  {
                                      if (MessageBox.Show("Login Successful") == DialogResult.OK)
                                      {
                                          this.Hide();
                                          FrmVoter form1 = new FrmVoter(searchCNIC, searchSession);
                                          form1.Show();
                                      }
                                  }
                                  else if (reader.GetValue(5).ToString() == "1")
                                  {
                                      if (MessageBox.Show("You have already casted a vote.") == DialogResult.OK)
                                      {
                                          this.Hide();
                                          FrmLoginRoles form1 = new FrmLoginRoles();
                                          form1.Show();
                                      }
                                  }
                              }
                              else
                              {
                                    MessageBox.Show("The Election Session has timed out or has not begun.");
                              }

                          }
                                else
                                {
                                    if (MessageBox.Show("You have entered Wrong Password.") == DialogResult.OK)
                                        txtPassword.Text = "";
                                }
                            
                         }
                    }
                    else
                    {
                        if (MessageBox.Show("Sorry,The user does not exist.") == DialogResult.OK)
                        {
                            txtCNIC.Text = "";
                            txtSession.Text = "";
                            txtPassword.Text = "";
                        }
                    }


                }
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLoginRoles form1 = new FrmLoginRoles();
            form1.Show();
        }

        private void txtSession_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void txtCNIC_TextChanged(object sender, EventArgs e)
        {
            txtCNIC.MaxLength = 15;
            if (txtCNIC.Text.Length == 5)
            {
                txtCNIC.Text += "-";
                txtCNIC.SelectionStart = txtCNIC.Text.Length;
            }
            else if (txtCNIC.Text.Length == 13)
            {
                txtCNIC.Text += "-";
                txtCNIC.SelectionStart = txtCNIC.Text.Length;
            }
        }
    }
}
