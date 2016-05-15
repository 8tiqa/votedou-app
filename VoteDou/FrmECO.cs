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
    public partial class FrmECO : Form
    {
        public FrmECO()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
            else
                return;
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

        private void viiViewElectionSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmECOView next = new FrmECOView();
            next.Show();
        }

        private void viiiViewVotersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void viewCandidatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void allVotersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmECOView next = new FrmECOView();
            next.Show();
        }

        private void participatingVotersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmECOView next = new FrmECOView();
            next.Show();
        }

        private void nAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmECOView next = new FrmECOView();
            next.Show();
        }

        private void provincialAssemblToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmECOView next = new FrmECOView();
            next.Show();
        }

        private void allCandidatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmECOView next = new FrmECOView();
            next.Show();
        }

        private void nationalAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmECOView next = new FrmECOView();
            next.Show();
        }

        private void provincialAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmECOView next = new FrmECOView();
            next.Show();
        }

        private void aboutVoteDouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageAboutProg next = new PageAboutProg("ECO");
            next.ShowDialog();
        }

        private void aboutTheDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageAboutDev next = new PageAboutDev("ECO");
            next.ShowDialog();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageContactUs next = new PageContactUs("ECO");
            next.ShowDialog();
        }

        private void viewPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmECOView next = new FrmECOView();
            next.Show();
        }

        private void turnoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "ECO";
            this.Hide();
            FrmPAResults next = new FrmPAResults(caller);
            next.Show();
        }

        private void partyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "ECO";
            this.Hide();
            FrmPAResults next = new FrmPAResults(caller);
            next.Show();
        }

        private void constituencyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "ECO";
            this.Hide();
            FrmPAResults next = new FrmPAResults(caller);
            next.Show();
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "ECO";
            this.Hide();
            FrmPAResults next = new FrmPAResults(caller);
            next.Show();
        }

        private void turnoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string caller = "ECO";
            this.Hide();
            FrmNAResults next = new FrmNAResults(caller);
            next.Show();
        }

        private void partyReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string caller = "ECO";
            this.Hide();
            FrmNAResults next = new FrmNAResults(caller);
            next.Show();
        }

        private void constituencyReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string caller = "ECO";
            this.Hide();
            FrmNAResults next = new FrmNAResults(caller);
            next.Show();
        }

        private void resultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string caller = "ECO";
            this.Hide();
            FrmNAResults next = new FrmNAResults(caller);
            next.Show();
        }

        private void FrmECO_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void finalResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "ECO";
            this.Hide();
            FrmNAResults next = new FrmNAResults(caller);
            next.Show();
        }

        private void punjabAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "ECO";
            this.Hide();
            FrmPAResults next = new FrmPAResults(caller);
            next.Show();
        }

        private void sindhAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "ECO";
            this.Hide();
            FrmPAResults next = new FrmPAResults(caller);
            next.Show();
        }

        private void kPKAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "ECO";
            this.Hide();
            FrmPAResults next = new FrmPAResults(caller);
            next.Show();
        }

        private void balochistanAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "ECO";
            this.Hide();
            FrmPAResults next = new FrmPAResults(caller);
            next.Show();
        }

       

       
       

        

        

       
    }
}
