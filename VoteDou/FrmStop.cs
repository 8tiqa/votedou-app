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
    public partial class FrmStop : Form
    {
        string ID;
        string updated;
        public FrmStop()
        {
            InitializeComponent();
            updated = "0";
        }

        private void FrmStop_Load(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection = new SqlConnection(cons))
            {
                connection.Open();
                string q = "Select * FROM ElectionSession";

                SqlCommand selectCommandtwo = new SqlCommand(q, connection);


                SqlDataReader rad = selectCommandtwo.ExecuteReader();

                DataTable dtab = new DataTable();
                dtab.Columns.Add("Session_ID", typeof(string));
                dtab.Load(rad);

                comboID.ValueMember = "Session_ID";
                comboID.DisplayMember = "Session_ID";
                comboID.DataSource = dtab;


                rad.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
            using (SqlConnection connection1 = new SqlConnection(cons))
            {
                connection1.Open();
                string s = "Select * FROM ElectionSession where Session_ID ='" + ID + "'";
                using (SqlCommand selectCommand = new SqlCommand(s, connection1))
                {

                    SqlDataReader reader = selectCommand.ExecuteReader();



                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            if (ID == reader.GetValue(0).ToString())
                            {

                                EditYear.Text = reader.GetValue(1).ToString();
                                EditType.Text = reader.GetValue(2).ToString();
                                EditStart.Text = reader.GetValue(3).ToString();

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string cons = VoteDou.Properties.Settings.Default.VoteDouConnectionString;
                try
                { using (SqlConnection con = new SqlConnection(cons))
                    {
                        con.Open();
                        using (SqlCommand com = new SqlCommand("Update ElectionSession set End_DateTime = @end where Session_ID =@ID", con))
                        {
                            com.Parameters.AddWithValue("@ID", ID);
                            com.Parameters.AddWithValue("@end", SqlDbType.DateTime).Value = EditEnd.Value;


                            com.ExecuteNonQuery();

                            
                            MessageBox.Show("You have successfully updated the Session.", "Congratulations!", MessageBoxButtons.OK);
                            updated = "1";


                         }
                    }
                }

                catch
                {
                    MessageBox.Show("Invalid Data Entry!");
                   
                }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (updated == "0")
            {
                var result = MessageBox.Show("You have not updated the record. Do you still want to exit?", "Close", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    this.Hide();
            }
            else
            {
                this.Hide();
            }
        }

        private void comboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = comboID.SelectedValue.ToString();
        }
    }
}
