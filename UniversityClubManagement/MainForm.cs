using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UniversityClubManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoForm inf=new infoForm();
            inf.Show();
        }

        private void modifyMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modify mf = new modify();
            mf.Show();

        }

        private void viewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewMemberList vas = new viewMemberList();
            vas.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyMember vas = new modifyMember();
            vas.Show();
        }

        

        private void toolStripMenuIChangePassword_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.Show();
        }

        private void AddUsertoolStripMenuAddUser_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void aDDCommitteeMEmberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            committeeInfo cf = new committeeInfo();
            cf.Show();
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventInfo ef = new eventInfo();
            ef.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modify mf = new modify();
            mf.Show();
        }

        private void addEventsCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            account ac = new account();
            ac.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm vf = new viewForm();
            vf.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewForm v = new viewForm();
            v.Show();
        }

        private void viewRemainingBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balanceInfo bf = new balanceInfo();
            bf.Show();
        }

        private void iTClubToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventUpdate ef = new eventUpdate();
            ef.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void viewEventToolStripMenuItem_Click(object sender, EventArgs e)
        {

            eventView v = new eventView();
            v.Show();
        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eventToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          //  viewEvent v = new viewEvent();
         //   v.Show();
        }

        private void addNewClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addClub a = new addClub();
            a.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBalance a = new addBalance();
            a.Show();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credit a = new Credit();
            a.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            account a = new account();
            a.Show();
        }

        private void sendMAilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emailSystem m = new emailSystem();
            m.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addAdvisor ad = new addAdvisor();
            ad.Show();
        }
    }
}
