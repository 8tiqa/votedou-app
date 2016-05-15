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
    public partial class FrmPATies : Form
    {
        public FrmPATies()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmPATies_Load(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection con = new SqlConnection(cons))
            {
                con.Open();
                string sa = "select Constituency_ID from View_PA_Ties where  Number_Of_Winner>1;";
                SqlCommand selectCommand = new SqlCommand(sa, con);
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    DataTable dt = new DataTable();
                    string s = "select Constituency_ID from View_PA_Ties where  Number_Of_Winner>1;";
                    SqlDataAdapter sda = new SqlDataAdapter(s, con);
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;

                }

            }
        }
    }
}
