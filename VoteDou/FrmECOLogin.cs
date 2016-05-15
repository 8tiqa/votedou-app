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
    public partial class FrmECOLogin : Form
    {
        public FrmECOLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM ECO where ECO_ID ='" + txtECOID.Text + "'";
                using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                {

                    SqlDataReader reader = selectCommand.ExecuteReader();
                    string searchECO_ID = txtECOID.Text;
                    string searchLastname = txtLastName.Text;
                    string searchPassword = txtPassword.Text;

                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (searchECO_ID == reader.GetValue(0).ToString() && searchLastname == reader.GetValue(2).ToString())
                                if (searchPassword == reader.GetValue(5).ToString())
                                {
                                    if (MessageBox.Show("Login Successful") == DialogResult.OK)
                                    {
                                        this.Hide();
                                        FrmECO form1 = new FrmECO();
                                        form1.Show();
                                    }

                                }
                                else
                                {
                                    if(MessageBox.Show("You have entered Wrong Password.")==DialogResult.OK)
                                    txtPassword.Text = "";
                                }
                            else
                            {
                                if (MessageBox.Show("You have entered incorrect Last Name.") == DialogResult.OK)
                                {
                                    txtLastName.Text = "";
                                    txtPassword.Text = "";
                                }
                            }
                        }
                    }
                    else
                    {
                        if(MessageBox.Show("Sorry,The user does not exist.")==DialogResult.OK)
                        {
                            txtECOID.Text = "";
                            txtLastName.Text = "";
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

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
            { e.Handled = true; }
        }

        private void txtECOID_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
