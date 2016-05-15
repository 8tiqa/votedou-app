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
    public partial class FrmNAResults : Form
    {
        string caller;//flag
        string Party;
        public FrmNAResults(string a)
        {
            InitializeComponent();
            caller = a;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (caller == "Admin")
            {
                this.Hide();
                FrmAdmin next = new FrmAdmin();
                next.ShowDialog();
            }
            else if (caller == "ECO")
            {
                this.Hide();
                FrmECO next = new FrmECO();
                next.ShowDialog();
            }
        }

        private void FrmNAResults_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voteDouDataSet11.View_NAResultFinal' table. You can move, or remove it, as needed.
            this.view_NAResultFinalTableAdapter.Fill(this.voteDouDataSet11.View_NAResultFinal);
            // TODO: This line of code loads data into the 'voteDouDataSet10.View_NAConReport' table. You can move, or remove it, as needed.
            this.view_NAConReportTableAdapter.Fill(this.voteDouDataSet10.View_NAConReport);
            // TODO: This line of code loads data into the 'voteDouDataSet10.ElectionSession' table. You can move, or remove it, as needed.
            this.electionSessionTableAdapter2.Fill(this.voteDouDataSet10.ElectionSession);
            // TODO: This line of code loads data into the 'voteDouDataSet10.SessionNAConstituency' table. You can move, or remove it, as needed.
            this.sessionNAConstituencyTableAdapter1.Fill(this.voteDouDataSet10.SessionNAConstituency);
            // TODO: This line of code loads data into the 'voteDouDataSet10.View_NACandidateResult' table. You can move, or remove it, as needed.
            this.view_NACandidateResultTableAdapter.Fill(this.voteDouDataSet10.View_NACandidateResult);
            // TODO: This line of code loads data into the 'voteDouDataSet10.Party' table. You can move, or remove it, as needed.
            this.partyTableAdapter1.Fill(this.voteDouDataSet10.Party);
            // TODO: This line of code loads data into the 'voteDouDataSet10.View_Turnout' table. You can move, or remove it, as needed.
            this.view_TurnoutTableAdapter1.Fill(this.voteDouDataSet10.View_Turnout);
            // TODO: This line of code loads data into the 'voteDouDataSet9.ElectionSession' table. You can move, or remove it, as needed.
            this.electionSessionTableAdapter1.Fill(this.voteDouDataSet9.ElectionSession);
            // TODO: This line of code loads data into the 'voteDouDataSet9.View_Turnout' table. You can move, or remove it, as needed.
            this.view_TurnoutTableAdapter.Fill(this.voteDouDataSet9.View_Turnout);
            
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("Select * from Party", con))
                {
                    SqlDataReader rad = com.ExecuteReader();
                    DataTable dtab = new DataTable();
                    dtab.Columns.Add("PartyName", typeof(string));
                    dtab.Load(rad);

                    comboParty.ValueMember = "PartyName";
                    comboParty.DisplayMember = "PartyName";
                    comboParty.DataSource = dtab;

                   
                }
            }

            
           
              

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
            PageAboutProg next = new PageAboutProg(caller);
            next.ShowDialog();
        }

        private void aboutTheDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageAboutDev next = new PageAboutDev(caller);
            next.ShowDialog();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageContactUs next = new PageContactUs(caller);
            next.ShowDialog();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string sa = "select * from View_Turnout where Session_ID ='" + SearchID.Text + "'";
                SqlCommand selectCommand = new SqlCommand(sa, con);
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        reader.Close();
                        DataTable dt = new DataTable();
                        string s = "select * from View_Turnout where Session_ID ='" + SearchID.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(s, con);
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;
                        
                    }
                }
                else
                    MessageBox.Show("The Election Session does not exist or hasnt been started.");
                }
        }

        private void SearchCons_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string sa = "select * from View_NACandidateResult where Constituency_ID ='" + SearchCon.Text + "' AND Session_ID ='"+SearchSes.Text +"'";
                SqlCommand selectCommand = new SqlCommand(sa, con);
                SqlDataReader reader = selectCommand.ExecuteReader();
                
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        reader.Close();
                        DataTable dt = new DataTable();
                        string s = "select * from View_NACandidateResult where Constituency_ID ='" + SearchCon.Text + "' AND Session_ID ='" + SearchSes.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(s, con);
                        sda.Fill(dt);
                        dataGridView5.DataSource = dt;

                    }
                }
                else
                    MessageBox.Show("The Sessional Constituency does not exist.");
            }
        }

        private void SearchID_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboTurnout_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnSerachSession_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string sa = "select * from View_NAConReport where Session_ID ='" + SearchSession.Text + "'";
                SqlCommand selectCommand = new SqlCommand(sa, con);
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        reader.Close();
                        DataTable dt = new DataTable();
                        string s = "select * from View_NAConReport where Session_ID ='" + SearchSession.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(s, con);
                        sda.Fill(dt);
                        dataGridView7.DataSource = dt;

                    }
                }
                else
                    MessageBox.Show("The Election Session does not exist and hasnt been started.");
            }
        }

        private void btnParty_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(cons))
                {
                    con.Open();
                    string sa = "select * from View_NACandidateResult where PartyName ='" + Party + "' AND Session_ID ='" + SessionID.Text + "'";
                    SqlCommand selectCommand = new SqlCommand(sa, con);
                    SqlDataReader reader = selectCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            reader.Close();
                            DataTable dt = new DataTable();
                            string s = "select * from View_NACandidateResult  where PartyName ='" + Party + "' AND Session_ID ='" + SessionID.Text + "'";
                            SqlDataAdapter sda = new SqlDataAdapter(s, con);
                            sda.Fill(dt);
                            dataGridView3.DataSource = dt;

                        }
                    }
                    else
                        MessageBox.Show("The Party did not take part in the Election Session or The Session has not started.");
                }
            }
            catch
            {
                MessageBox.Show("The Party did not take part in the Election Session or The Session has not started.");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void comboParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Party = comboParty.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string sa = "select * from View_NAResultFinal where Session_ID ='" + TxtSession.Text + "'";
                SqlCommand selectCommand = new SqlCommand(sa, con);
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        reader.Close();
                        DataTable dt = new DataTable();
                        string s = "select * from View_NAResultFinal where Session_ID ='" + TxtSession.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(s, con);
                        sda.Fill(dt);
                        dataGridView10.DataSource = dt;

                    }
                }
                else
                    MessageBox.Show("The Election Session does not exist or hasnt been started.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmNATies next = new FrmNATies();
            next.Show();
        }

        private void SearchID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void SessionID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void SearchSes_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void SearchSession_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void TxtSession_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void SearchCon_TextChanged(object sender, EventArgs e)
        {
            SearchCon.MaxLength = 5;

            if (SearchCon.Text.Length == 0)
            {
                SearchCon.Text += "NA";
                SearchCon.SelectionStart = SearchCon.Text.Length;
            }
            
        }
    }
}
