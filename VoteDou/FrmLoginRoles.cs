using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VoteDou
{
    public partial class FrmLoginRoles : Form
    {
        public FrmLoginRoles()
        {
            InitializeComponent();
        }

        private void btnVoter_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmVoterLogin form1 = new FrmVoterLogin();
            form1.Show();
        }

        private void btnECO_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmECOLogin form1 = new FrmECOLogin();
            form1.Show();
        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminLogin form1 = new FrmAdminLogin();
            form1.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        
    }
}
