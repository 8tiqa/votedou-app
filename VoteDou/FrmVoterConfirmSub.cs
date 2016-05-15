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
    public partial class FrmVoterConfirmSub : Form
    {
        string NAVote, PAVote;
        public FrmVoterConfirmSub(string a, string b)
        {
            InitializeComponent();
            NAVote = a;
            PAVote = b;
        }

        private void FrmVoterConfirmSub_Load(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM View_NACandList where Candidate_ID ='" + NAVote + "'";
                SqlCommand selectCommand = new SqlCommand(s, connection1);
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        AddNA.Text = reader.GetValue(1).ToString();
                    }
                }
                reader.Close();

                string sa = "Select * FROM View_PACandList where Candidate_ID ='" + PAVote + "'";
                SqlCommand selectCommanda = new SqlCommand(sa, connection1);
                SqlDataReader readera = selectCommanda.ExecuteReader();
                if (readera.HasRows)
                {
                    if (readera.Read())
                    {
                        AddPA.Text = readera.GetValue(1).ToString();
                    }
                }
                readera.Close();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLoginRoles next = new FrmLoginRoles();
            next.Show();
        }
    }
}
