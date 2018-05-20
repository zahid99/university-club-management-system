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
    public partial class viewbalance : Form
    {
        public viewbalance()
        {
            InitializeComponent();
        }
        int x = 0;
        string zh = "MD ZAHID HASAN";
        int tam = 15;

        public void viewbalance_Load(object sender, EventArgs e)
        {

        }

        public void balance_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            label1.Left += 5;
            if (label1.Left >= this.Width)
            {
                label1.Left = label1.Width * -1;
            }
            Graphics gra = this.CreateGraphics();
            gra.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            gra.DrawString(zh, new Font("Calibri", tam), new SolidBrush(Color.Red), x, 70);
            x += 10;
            if (x >= this.Width)
                x = zh.Length * tam * -1;
        }
    }
}
