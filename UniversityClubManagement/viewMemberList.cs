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
    public partial class viewMemberList : Form
    {
        public viewMemberList()
        {
            InitializeComponent();

            showClubList();
        }

        DataTable data1 = new DataTable();


        void showClubList()
        {


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


          string membercount()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();

          
            string qry = "select count(Student_ID) from IT";
            SqlCommand sc = new SqlCommand(qry, con);
            int a = 0 + (Int32)sc.ExecuteScalar();
            string reg ="Total IT Club Member: "+ a.ToString();
            label1.Text = reg;
          //  MessageBox.Show(reg);
            return reg;        
           

        }



        string memberRobotic()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
         

            string qry = "select count(Student_ID) from robotic";
            SqlCommand sc = new SqlCommand(qry, con);
            int a = 0 + (Int32)sc.ExecuteScalar();
            string reg = "Total Robotic Club Member: " + a.ToString();
            label1.Text = reg;
            //  MessageBox.Show(reg);
            return reg;


        }

        string memberSports()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            string qry = "select count(Student_ID) from sports";
            SqlCommand sc = new SqlCommand(qry, con);
            int a = 0 + (Int32)sc.ExecuteScalar();
            string reg = "Total Sports Club Member: " + a.ToString();
            label1.Text = reg;
            //  MessageBox.Show(reg);
            return reg;


        }


        string memberCultural()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            string qry = "select count(Student_ID) from Cultural";
            SqlCommand sc = new SqlCommand(qry, con);
            int a = 0 + (Int32)sc.ExecuteScalar();

            string reg = "Total Cultural Club Member: " + a.ToString();
            label1.Text = reg;
            //  MessageBox.Show(reg);
            return reg;


        }



        string memberOther()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            string qry = "select count(Student_ID) from others where club_name='"+comboBox1.Text+"'";
            SqlCommand sc = new SqlCommand(qry, con);
            int a = 0 + (Int32)sc.ExecuteScalar();

            string clubName = comboBox1.Text;
            string reg = "Total "+ clubName+" Club Member: " + a.ToString();
            label1.Text = reg;
            //  MessageBox.Show(reg);
            return reg;


        }



        private void view_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          
            if (comboBox1.Text == "IT Club")
            {
                membercount();
                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from IT", con);
               DataTable data1 = new DataTable();

                try
                {
                    sa.Fill(data1);
                    dataGridView1.DataSource = data1;
                }
                catch
                {
                    MessageBox.Show("DAta Error");
                    con.Close();
                }
            }


            else if (comboBox1.Text == "Sports Club")
            {
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          
                cn.Open();
                memberSports();
                SqlDataAdapter sa = new SqlDataAdapter("select *from Sports", cn);
                DataTable data1 = new DataTable();
                try
                {
                    sa.Fill(data1);
                    dataGridView1.DataSource = data1;
                }
                catch
                {
                    MessageBox.Show("DAta Error");
                    cn.Close();
                }
            }

            else if (comboBox1.Text == "Robotic Club")
            {
                con.Open();
                memberRobotic();
                SqlDataAdapter sa = new SqlDataAdapter("select *from Robotic", con);
                DataTable data1 = new DataTable();
                try
                {
                    sa.Fill(data1);
                    dataGridView1.DataSource = data1;
                }
                catch
                {
                    MessageBox.Show("DAta Error");
                    con.Close();
                }
            }

            else if (comboBox1.Text == "Cultural Club")
            {
                con.Open();
                memberCultural();
                SqlDataAdapter sa = new SqlDataAdapter("select *from Cultural", con);
                DataTable data1 = new DataTable();
                try
                {
                    sa.Fill(data1);
                    dataGridView1.DataSource = data1;
                }
                catch
                {
                    MessageBox.Show("DAta Error");
                    con.Close();
                }
            }

            else
            {
                // MessageBox.Show("LuL");
                memberOther();

                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from others where club_name='" + comboBox1.Text + "'", con);
                DataTable data1 = new DataTable();
                try
                {
                    sa.Fill(data1);
                    dataGridView1.DataSource = data1;
                }
                catch
                {
                    MessageBox.Show("DAta Error");
                    con.Close();
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         //   DataView dv = new DataView(data1);
          //  dv.RowFilter = string.Format("Name LIKE '%{0}%'", textBox1.Text);
          //  dataGridView1.DataSource = dv;
        }
    }
}
