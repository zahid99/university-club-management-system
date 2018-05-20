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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0;
        string zh = "Inter university programing contest";
        int tam = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top += 2;
            //label2.Top += 2;
            if (label1.Top >= this.Width)

                label1.Top = label1.Width * -1;

            Graphics gra = this.CreateGraphics();
            gra.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            gra.DrawString(zh, new Font("Calibri", tam), new SolidBrush(Color.Red), x, 70);

            x += 5;
            if (x >= this.Width)
                x = zh.Length * tam * -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
  this.Refresh();

            label2.Top += 2;
            //label2.Top += 2;
            if (label2.Top >= this.Width)
                
                label2.Top = label2.Width * -1;
            
            Graphics gra = this.CreateGraphics();
            gra.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            gra.DrawString(zh, new Font("Calibri", tam), new SolidBrush(Color.Red), x, 70);
            
            x += 5;
            if (x >= this.Width)
                x = zh.Length * tam * -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\Visual Studio\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select distinct clubname from addclub", con);
            try
            {
                SqlDataReader dr = sc.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["clubname"]);

                }
                dr.Close();
                dr.Dispose();
            }

            catch
            {
                MessageBox.Show(":V :V :V");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }

