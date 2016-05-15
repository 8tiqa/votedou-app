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
    public partial class PageAboutDev : Form
    {
        string caller;//caller
        public PageAboutDev(string a)
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

        private void aboutTheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageAboutProg next = new PageAboutProg(caller);
            next.ShowDialog();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageContactUs next = new PageContactUs(caller);
            next.ShowDialog();
        }
    }
}
