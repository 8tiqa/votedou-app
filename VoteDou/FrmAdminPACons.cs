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
    public partial class FrmAdminPACons : Form
    {
        public FrmAdminPACons()
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

        private void aboutVoteDouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageAboutProg next = new PageAboutProg();
            next.ShowDialog();
        }

        private void aboutTheDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageAboutDev next = new PageAboutDev();
            next.ShowDialog();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageContactUs next = new PageContactUs();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string ConstituencyID = AddID.Text.ToString();
            string ConstituencyDetails = AddConstituencyDetails.Text.ToString();
            string Session = AddSession.Text.ToString();
            string Eligible = AddEligible.Text.ToString();

            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();

                using (SqlCommand com = new SqlCommand("INSERT INTO PAConstituency (PAConstituency_ID, ConstituencyDetails, Session_ID, Number_of_Eligible_Voters) VALUES (@id,@details,@session,@eligible)", con))
                {
                    com.Parameters.AddWithValue("@id", ConstituencyID);
                    com.Parameters.AddWithValue("@details", ConstituencyDetails);
                    com.Parameters.AddWithValue("@session", Session);
                    com.Parameters.AddWithValue("@eligible", Eligible);
                    com.ExecuteNonQuery();

                    btnClear_Click(null, null);
                    MessageBox.Show("Record Entered", "Congratulations!", MessageBoxButtons.OK);



                }
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AddID.Clear();
            AddConstituencyDetails.Clear();
            AddSession.Clear();
            AddEligible.Clear();
        }

        private void FrmAdminPACons_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voteDouDataSet.PAConstituency' table. You can move, or remove it, as needed.
            this.pAConstituencyTableAdapter.Fill(this.voteDouDataSet.PAConstituency);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM PAConstituency where PAConstituency_ID ='" + SearchID.Text + "'";
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
                                EditSession.Text = reader.GetValue(2).ToString();
                                EditEligible.Text = reader.GetValue(3).ToString();

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
            SqlDataAdapter sda = new SqlDataAdapter("select * from PAConstituency", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
                using (SqlConnection connection1 = new SqlConnection(cons))
                {
                    connection1.Open();
                    {
                        string s = "Update PAConstituency set PAConstituency_ID ='" + EditID.Text + "', ConstituencyDetails ='" + EditConstituencyDetails.Text +
                        "', Session_ID ='" + EditSession.Text + "', Number_of_Eligible_Voters ='" + EditEligible.Text +
                        "'where PAConstituency_ID ='" + SearchID.Text + "'";

                        using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                        {

                            SqlDataReader reader = selectCommand.ExecuteReader();
                            MessageBox.Show("Product Updated Successfully");


                        }

                        SearchID.Clear();
                        EditID.Clear();
                        EditConstituencyDetails.Clear();
                        EditSession.Clear();
                        EditEligible.Clear();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            SqlConnection con = new SqlConnection(cons);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from PAConstituency", con);
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }
    }
}
