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
    public partial class viewEvent : Form
    {
        public viewEvent()
        {
            InitializeComponent();
        }
        int x = 0;
        string zh = "Programing contest 2016";
        int tam = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
           
            label1.Top += 2;
            //label2.Top += 2;
            if ( label1.Top>=this.Width)
          //  {
                label1.Top = label1.Width * -1;
            label2.Top = label2.Width * -1;
                // }
                Graphics gra = this.CreateGraphics();
                gra.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                gra.DrawString(zh, new Font("Calibri", tam), new SolidBrush(Color.Red), 70, x);
          //  }
            x += 5;
            if (x >= this.Width)
                x = zh.Length * tam * -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewEvent_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Refresh();

            label2.Top += 2;
            //label2.Top += 2;
            if (label2.Top >= this.Width)
                //  {
              //  label1.Top = label1.Width * -1;
            label2.Top = label2.Width * -1;
            // }
            Graphics gra = this.CreateGraphics();
            gra.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            gra.DrawString(zh, new Font("Calibri", tam), new SolidBrush(Color.Red), x, 70);
            //  }
            x += 5;
            if (x >= this.Width)
                x = zh.Length * tam * -1;
        }

        private void b1_Click(object sender, EventArgs e)
        {
           
            Form1 f = new Form1();
            f.Show();
        }
    }
}
