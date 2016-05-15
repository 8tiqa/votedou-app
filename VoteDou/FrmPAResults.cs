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
    public partial class FrmPAResults : Form
    {
        string caller;//flag
        string Party;
        public FrmPAResults(string a)
        {
            InitializeComponent();
            caller = a;
        }

        private void FrmPAResults_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voteDouDataSet11.ElectionSession' table. You can move, or remove it, as needed.
            this.electionSessionTableAdapter2.Fill(this.voteDouDataSet11.ElectionSession);
            // TODO: This line of code loads data into the 'voteDouDataSet11.View_BalochistanResultFinal' table. You can move, or remove it, as needed.
            this.view_BalochistanResultFinalTableAdapter.Fill(this.voteDouDataSet11.View_BalochistanResultFinal);
            // TODO: This line of code loads data into the 'voteDouDataSet11.View_KPKResultFinal' table. You can move, or remove it, as needed.
            this.view_KPKResultFinalTableAdapter.Fill(this.voteDouDataSet11.View_KPKResultFinal);
            // TODO: This line of code loads data into the 'voteDouDataSet11.View_SindhResultFinal' table. You can move, or remove it, as needed.
            this.view_SindhResultFinalTableAdapter.Fill(this.voteDouDataSet11.View_SindhResultFinal);
            // TODO: This line of code loads data into the 'voteDouDataSet11.View_PAConReport' table. You can move, or remove it, as needed.
            this.view_PAConReportTableAdapter.Fill(this.voteDouDataSet11.View_PAConReport);
            // TODO: This line of code loads data into the 'voteDouDataSet11.View_PACandidateResult' table. You can move, or remove it, as needed.
            this.view_PACandidateResultTableAdapter.Fill(this.voteDouDataSet11.View_PACandidateResult);
            // TODO: This line of code loads data into the 'voteDouDataSet11.View_PATurnout' table. You can move, or remove it, as needed.
            this.view_PATurnoutTableAdapter.Fill(this.voteDouDataSet11.View_PATurnout);
            // TODO: This line of code loads data into the 'voteDouDataSet11.View_PunjabResultFinal' table. You can move, or remove it, as needed.
            this.view_PunjabResultFinalTableAdapter.Fill(this.voteDouDataSet11.View_PunjabResultFinal);
            // TODO: This line of code loads data into the 'voteDouDataSet10.ElectionSession' table. You can move, or remove it, as needed.
            this.electionSessionTableAdapter1.Fill(this.voteDouDataSet10.ElectionSession);
            // TODO: This line of code loads data into the 'voteDouDataSet10.SessionPAConstituency' table. You can move, or remove it, as needed.
            this.sessionPAConstituencyTableAdapter1.Fill(this.voteDouDataSet10.SessionPAConstituency);
            // TODO: This line of code loads data into the 'voteDouDataSet10.Party' table. You can move, or remove it, as needed.
            this.partyTableAdapter1.Fill(this.voteDouDataSet10.Party);

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

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnParty_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(cons))
                {
                    con.Open();
                    string sa = "select * from View_PACandidateResult where PartyName ='" + Party + "' AND Session_ID ='" + SessionID.Text + "'";
                    SqlCommand selectCommand = new SqlCommand(sa, con);
                    SqlDataReader reader = selectCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            reader.Close();
                            DataTable dt = new DataTable();
                            string s = "select * from View_PACandidateResult  where PartyName ='" + Party + "' AND Session_ID ='" + SessionID.Text + "'";
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

        private void SearchCons_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string sa = "select * from View_PACandidateResult where Constituency_ID ='" + SearchCon.Text + "' AND Session_ID ='" + SearchSes.Text + "'";
                SqlCommand selectCommand = new SqlCommand(sa, con);
                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        reader.Close();
                        DataTable dt = new DataTable();
                        string s = "select * from View_PACandidateResult where Constituency_ID ='" + SearchCon.Text + "' AND Session_ID ='" + SearchSes.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(s, con);
                        sda.Fill(dt);
                        dataGridView5.DataSource = dt;

                    }
                }
                else
                    MessageBox.Show("The Sessional Constituency does not exist.");
            }
        }

        private void btnSerachSession_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string sa = "select * from View_PAConReport where Session_ID ='" + SearchSession.Text + "'";
                SqlCommand selectCommand = new SqlCommand(sa, con);
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        reader.Close();
                        DataTable dt = new DataTable();
                        string s = "select * from View_PAConReport where Session_ID ='" + SearchSession.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(s, con);
                        sda.Fill(dt);
                        dataGridView7.DataSource = dt;

                    }
                }
                else
                    MessageBox.Show("The Election Session does not exist and hasnt been started.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string sa = "select * from View_PATurnout where Session_ID ='" + SearchID.Text + "'";
                SqlCommand selectCommand = new SqlCommand(sa, con);
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        reader.Close();
                        DataTable dt = new DataTable();
                        string s = "select * from View_PATurnout where Session_ID ='" + SearchID.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(s, con);
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }
                }
                else
                    MessageBox.Show("The Election Session does not exist or hasnt been started.");
            }
        }

        private void comboParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Party = comboParty.SelectedValue.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string sa = "select * from View_PunjabResultFinal where Session_ID ='" + SearchPunjab.Text + "'";
                SqlCommand selectCommand = new SqlCommand(sa, con);
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        reader.Close();
                        DataTable dt = new DataTable();
                        string s = "select * from View_PunjabResultFinal where Session_ID ='" + SearchPunjab.Text + "'";
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
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string sa = "select * from View_SindhResultFinal where Session_ID ='" + SearchSindh.Text + "'";
                SqlCommand selectCommand = new SqlCommand(sa, con);
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        reader.Close();
                        DataTable dt = new DataTable();
                        string s = "select * from View_SindhResultFinal where Session_ID ='" + SearchSindh.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(s, con);
                        sda.Fill(dt);
                        dataGridView11.DataSource = dt;

                    }
                }
                else
                    MessageBox.Show("The Election Session does not exist or hasnt been started.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string sa = "select * from View_KPKResultFinal where Session_ID ='" + SearchKPK.Text + "'";
                SqlCommand selectCommand = new SqlCommand(sa, con);
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        reader.Close();
                        DataTable dt = new DataTable();
                        string s = "select * from View_KPKResultFinal where Session_ID ='" + SearchKPK.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(s, con);
                        sda.Fill(dt);
                        dataGridView13.DataSource = dt;

                    }
                }
                else
                    MessageBox.Show("The Election Session does not exist or hasnt been started.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string sa = "select * from View_BalochistanResultFinal where Session_ID ='" + SearchBalochistan.Text + "'";
                SqlCommand selectCommand = new SqlCommand(sa, con);
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        reader.Close();
                        DataTable dt = new DataTable();
                        string s = "select * from View_BalochistanResultFinal where Session_ID ='" + SearchBalochistan.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(s, con);
                        sda.Fill(dt);
                        dataGridView15.DataSource = dt;

                    }
                }
                else
                    MessageBox.Show("The Election Session does not exist or hasnt been started.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmPATies next = new FrmPATies();
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

        private void SearchPunjab_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void SearchSindh_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void SearchKPK_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void SearchBalochistan_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            { e.Handled = true; }

        }

        private void SearchCon_TextChanged(object sender, EventArgs e)
        {
            SearchCon.MaxLength = 5;

            
        }
    }
}
