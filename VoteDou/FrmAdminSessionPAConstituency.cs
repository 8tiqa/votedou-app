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
    public partial class FrmAdminSessionPAConstituency : Form
    {
        string Con_id, Session_id;
        public FrmAdminSessionPAConstituency()
        {
            InitializeComponent();
        }

        private void FrmAdminSessionPAConstituency_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voteDouDataSet7.SessionPAConstituency' table. You can move, or remove it, as needed.
            this.sessionPAConstituencyTableAdapter1.Fill(this.voteDouDataSet7.SessionPAConstituency);
            // TODO: This line of code loads data into the 'voteDouDataSet7.PAConstituency' table. You can move, or remove it, as needed.
            this.pAConstituencyTableAdapter1.Fill(this.voteDouDataSet7.PAConstituency);
            

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
            if (AddID.Text.Length < 1 || AddSession.Text.Length < 1)
            {
                MessageBox.Show("Empty Field");
            }
            else
            {
                string ConstituencyID = AddID.Text.ToString();
                string SessionID = AddSession.Text.ToString();



                string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
                try
                {
                    using (SqlConnection con = new SqlConnection(cons))
                    {
                        con.Open();

                        using (SqlCommand com = new SqlCommand("INSERT INTO SessionPAConstituency (PAConstituency_ID, Session_ID) VALUES (@id,@session)", con))
                        {
                            com.Parameters.AddWithValue("@id", ConstituencyID);
                            com.Parameters.AddWithValue("@session", SessionID);

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
            AddSession.Clear();
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM SessionPAConstituency where PAConstituency_ID ='" + EditID.Text +
                    "' AND Session_ID ='" + EditSession.Text + "'";
                using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                {

                    SqlDataReader reader = selectCommand.ExecuteReader();
                   


                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Record Found!");
                            Con_id = reader.GetValue(0).ToString();
                            Session_id = reader.GetValue(1).ToString();

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
            SqlDataAdapter sda = new SqlDataAdapter("select * from SessionPAConstituency", con);
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
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
                        string s = "Update SessionPAConstituency set PAConstituency_ID ='" + EditID.Text +
                         "', Session_ID ='" + EditSession.Text +
                         "'where PAConstituency_ID ='" + Con_id +
                        "' AND Session_ID ='" + Session_id + "'";

                        using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                        {

                            SqlDataReader reader = selectCommand.ExecuteReader();
                            MessageBox.Show("Record Updated Successfully");


                        }


                    }
                }
            }

            catch
            {
                MessageBox.Show("Sorry, You cannot make these changes.");
                btnClear_Click(null, null);
            }
            EditID.Clear();
            EditSession.Clear();

           
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try
            {
                using (SqlConnection connection1 = new SqlConnection(cons))
                {
                    connection1.Open();
                    string s = "Delete FROM SessionPAConstituency where PAConstituency_ID ='" + Con_id +
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
                EditID.Clear();
                EditSession.Clear();


            
        }

        private void AddSession_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void EditSession_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void AddID_TextChanged(object sender, EventArgs e)
        {
            AddID.MaxLength = 5;

        }

        private void EditID_TextChanged(object sender, EventArgs e)
        {
            EditID.MaxLength = 5;

        }
    }
}
