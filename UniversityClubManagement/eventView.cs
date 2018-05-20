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

            getEventTitle();
        }

        int x = 0;
        
       // string zh = "Programing contest 2016";
        
        int tam = 20;




        void getEventTitle()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from viewevent where club='" + comboBox1.Text + "'", con);
                     
            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {
                
                    label2.Text  = sdr["title"].ToString();

                }

            }
            catch
            {
                MessageBox.Show("Error from database");
                con.Close();
              
            }
            

           

        }



        void showRow()
        {

            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);

            SqlDataAdapter sa = new SqlDataAdapter("select * from viewevents", cn1);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            //dataGridView1.DataSource = data1;
            // cn1.Close();
            dataGridView1.Rows.Clear();
            foreach (DataRow item in data1.Rows)
            {

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();

                // dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
            }
        }



        private void eventView_Load(object sender, EventArgs e)
        {
            getEventTitle();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select distinct clubname from addclub", con);
           // try
            {
                SqlDataReader dr = sc.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["clubname"]);
                  //  MessageBox.Show("New Club Added");

                }
                dr.Close();
                dr.Dispose();
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            getEventTitle();


            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);


            //cn1.Open();

            //con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select * from event where club='"+comboBox1.Text+"'", cn1);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            //dataGridView1.DataSource = data1;
            // cn1.Close();
            dataGridView1.Rows.Clear();

            try
            {

           // }

                foreach (DataRow item in data1.Rows)
                {


                    //foreach (DataRow item int data1.Rows)


                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                }
                // dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            /*
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          
           // if (comboBox1.Text == "IT Club")
          //  {
               // membercount();
                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from viewevent where club= '"+comboBox1.Text+"'", con);
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

            */







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
            string zh = label2.Text;
          
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
