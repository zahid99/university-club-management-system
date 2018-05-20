using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UniversityClubManagement
{
    public partial class memberMainForm : Form
    {
        public memberMainForm()
        {
            InitializeComponent();
        }

        int x = 0;
        string zh = "Programing contest 2016";
        int tam = 25;


        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void view_Click(object sender, EventArgs e)
        {
            viewForm v = new viewForm();
            v.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            modifyMember m = new modifyMember();
            m.Show();
        }

        private void event_Click(object sender, EventArgs e)
        {
            eventView x = new eventView();
            x.Show();
        }

        private void committee_Click(object sender, EventArgs e)
        {
            viewForm v = new viewForm();
            v.Show();
        }

        private void memberMainForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();

            label3.Top += 1;
            //label2.Top += 2;
            if (label3.Top >= this.Width)
                //  {

                label3.Top = label3.Width * -1;
            // }
            Graphics gra = this.CreateGraphics();
            gra.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            gra.DrawString(zh, new Font("Calibri", tam), new SolidBrush(Color.Red), 870, x);
            //  }
            x += 1;
            if (x >= this.Width)
                x = zh.Length * tam * -1;
        }

        private void cre_Click(object sender, EventArgs e)
        {
            Credit c = new Credit();
            c.Show();
        }

        private void about_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }
    }
}
