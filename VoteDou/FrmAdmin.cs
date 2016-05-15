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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            DoubleBuffered = true;
            InitializeComponent();
            DoubleBuffered = true;
            
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to exit?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
            else
                return;
        
        }

        private void aboutTheProductToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void createANewSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminSession next = new FrmAdminSession();
            next.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminSession next = new FrmAdminSession();
            next.Show();
        }

        private void viewSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminSession next = new FrmAdminSession();
            next.Show();
        }

        private void voterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminVoter next = new FrmAdminVoter();
            next.Show();
        }

        private void voterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminVoter next = new FrmAdminVoter();
            next.Show();
        }

        private void voterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminVoter next = new FrmAdminVoter();
            next.Show();
        }

        private void participatingVoterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Hide();
           FrmParticipating_Voters next = new FrmParticipating_Voters();
           next.Show();
            
        }

        private void participatingVoterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmParticipating_Voters next = new FrmParticipating_Voters();
            next.Show();
        }

        private void participatingVoterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmParticipating_Voters next = new FrmParticipating_Voters();
            next.Show();
        }

        private void createNewConstituencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminNACon next = new FrmAdminNACon();
            next.Show();
        }

        private void editConstituencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminNACon next = new FrmAdminNACon();
            next.Show();
        }

        private void viewConstituencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminNACon next = new FrmAdminNACon();
            next.Show();
        }

        private void createNewConstituencyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminPACon next = new FrmAdminPACon();
            next.Show();
        }

        private void editConstituencyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminPACon next = new FrmAdminPACon();
            next.Show();
        }

        private void viewConstituencyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminPACon next = new FrmAdminPACon();
            next.Show();
        }

        private void candidateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminCandidate next = new FrmAdminCandidate();
            next.Show();
        }

        private void candidateToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminCandidate next = new FrmAdminCandidate();
            next.Show();
        }

        private void candidateToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminCandidate next = new FrmAdminCandidate();
            next.Show();
        }

        private void nACandidateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminNACand next = new FrmAdminNACand();
            next.Show();
        }

        private void nACandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminNACand next = new FrmAdminNACand();
            next.Show();
        }

        private void nAContestingCandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminNACand next = new FrmAdminNACand();
            next.Show();
        }

        private void pAContestingCandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminPACand next = new FrmAdminPACand();
            next.Show();
        }

        private void pACandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminPACand next = new FrmAdminPACand();
            next.Show();
        }

        private void pACandidateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminPACand next = new FrmAdminPACand();
            next.Show();
        }

        private void addNewAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminAdmin next = new FrmAdminAdmin();
            next.Show();
        }

        private void editAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminAdmin next = new FrmAdminAdmin();
            next.Show();
        }

        private void viewAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminAdmin next = new FrmAdminAdmin();
            next.Show();
        }

        private void addPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminParty next = new FrmAdminParty();
            next.Show();
        }

        private void editPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminParty next = new FrmAdminParty();
            next.Show();
        }

        private void viewPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminParty next = new FrmAdminParty();
            next.Show();
        }

        private void nAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminSessionNAConstituency next = new FrmAdminSessionNAConstituency();
            next.Show();
        }

        private void pAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminSessionPAConstituency next = new FrmAdminSessionPAConstituency();
            next.Show();
        }

        private void addConstituenciesInASessionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void turnoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "Admin";
            this.Hide();
            FrmPAResults next = new FrmPAResults(caller);
            next.Show();
        }

        private void partyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "Admin";
            this.Hide();
            FrmPAResults next = new FrmPAResults(caller);
            next.Show();
        }

        private void constituencyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "Admin";
            this.Hide();
            FrmPAResults next = new FrmPAResults(caller);
            next.Show();
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "Admin";
            this.Hide();
            FrmPAResults next = new FrmPAResults(caller);
            next.Show();
        }

        private void turnoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string caller = "Admin";
            this.Hide();
            FrmNAResults next = new FrmNAResults(caller);
            next.Show();
        }

        private void partyReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string caller = "Admin";
            this.Hide();
            FrmNAResults next = new FrmNAResults(caller);
            next.Show();
        }

        private void constituencyReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string caller = "Admin";
            this.Hide();
            FrmNAResults next = new FrmNAResults(caller);
            next.Show();
        }

        private void resultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string caller = "Admin";
            this.Hide();
            FrmNAResults next = new FrmNAResults(caller);
            next.Show();
        }

        private void addEditECOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminECO next = new FrmAdminECO();
            next.Show();
        }

        private void finalResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "Admin";
            this.Hide();
            FrmNAResults next = new FrmNAResults(caller);
            next.Show();
        }

        private void punjabAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "Admin";
            this.Hide();
            FrmPAResults next = new FrmPAResults(caller);
            next.Show();
        }

        private void sindhAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "Admin";
            this.Hide();
            FrmPAResults next = new FrmPAResults(caller);
            next.Show();
        }

        private void kPKAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "Admin";
            this.Hide();
            FrmPAResults next = new FrmPAResults(caller);
            next.Show();
        }

        private void balochistanAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caller = "Admin";
            this.Hide();
            FrmPAResults next = new FrmPAResults(caller);
            next.Show();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStart next = new FrmStart();
            next.Show();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        /*private void extendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStop next = new FrmStop();
            next.Show();
        }*/

        private void endTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStop next = new FrmStop();
            next.Show();
        }

        private void bothStartEndTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStart next = new FrmStart();
            next.Show();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmhelp next = new Frmhelp();
            next.Show();
        }


       

        

      
    }
}
