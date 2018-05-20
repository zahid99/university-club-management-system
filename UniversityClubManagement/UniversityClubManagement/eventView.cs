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
    public partial class eventView : Form
    {
        public eventView()
        {
            InitializeComponent();
        }

        int x = 0;
        string zh = "Programing contest 2016";
        int tam = 20;
        private void eventView_Load(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          
           // if (comboBox1.Text == "IT Club")
          //  {
               // membercount();
                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from event where club= '"+comboBox1.Text+"'", con);
                DataTable data1 = new DataTable();
                try
                {

                    // }
                    sa.Fill(data1);
                    dataGridView1.DataSource = data1;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show(" No Data");
                }
          //  }
            /*

            else if (comboBox1.Text == "Sports Club")
            {
                // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\Visual Studio\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");

                con.Open();
               // memberSports();
                SqlDataAdapter sa = new SqlDataAdapter("select *from Sports", con);
                DataTable data1 = new DataTable();
                sa.Fill(data1);
                dataGridView1.DataSource = data1;
                con.Close();
            }

            else if (comboBox1.Text == "Robotic Club")
            {
                con.Open();
               // memberRobotic();
                SqlDataAdapter sa = new SqlDataAdapter("select *from Robotic", con);
                DataTable data1 = new DataTable();
                sa.Fill(data1);
                dataGridView1.DataSource = data1;
                con.Close();
            }

            else if (comboBox1.Text == "Cultural Club")
            {
                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from Cultural", con);
                DataTable data1 = new DataTable();
                sa.Fill(data1);
                dataGridView1.DataSource = data1;
                con.Close();
            }

            else
            {
                MessageBox.Show("LuL");
            }*/
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
            gra.DrawString(zh, new Font("Calibri", tam), new SolidBrush(Color.Red), 670, x);
            //  }
            x += 1;
            if (x >= this.Width)
                x = zh.Length * tam * -1;

        }
    }
}
