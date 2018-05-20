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
    public partial class viewForm : Form
    {
        public viewForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void view_advisor_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");

            if (comboBox1.Text == "IT Club")
            {
                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from advisor where ClubName='IT'", con);
                DataTable data1 = new DataTable();

                try
                {
                    sa.Fill(data1);
                    dataGridView1.DataSource = data1;
                    
                }
                catch
                {
                    MessageBox.Show("Data error");
                    con.Close();
                }
            }


            else if (comboBox1.Text == "Sports Club")
            {
                // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\Visual Studio\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");

                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from advisor where ClubName='Sports'", con);
                DataTable data1 = new DataTable();
                try
                {
                    sa.Fill(data1);
                    dataGridView1.DataSource = data1;

                }
                catch
                {
                    MessageBox.Show("Data error");
                    con.Close();
                }
            }

            else if (comboBox1.Text == "Robotic Club")
            {
                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from advisor ClubName='Robotic'", con);
                DataTable data1 = new DataTable();
                try
                {
                    sa.Fill(data1);
                    dataGridView1.DataSource = data1;

                }
                catch
                {
                    MessageBox.Show("Data error");
                    con.Close();
                }
            }

            else if (comboBox1.Text == "Cultural Club")
            {
                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from advisor where Clubname='Cultural'", con);
                DataTable data1 = new DataTable();
                try
                {
                    sa.Fill(data1);
                    dataGridView1.DataSource = data1;

                }
                catch
                {
                    MessageBox.Show("Data error");
                    con.Close();
                }
            }

            else
            {
                MessageBox.Show("Please Select Club Name.");
            }
        }

        private void view_committee_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");

            if (comboBox1.Text == "IT Club")
            {
                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from committee,IT where committee.Student_ID=IT.Student_ID", con);
                DataTable data1 = new DataTable();
                try
                {
                    sa.Fill(data1);
                    dataGridView1.DataSource = data1;

                }
                catch
                {
                    MessageBox.Show("Data error");
                    con.Close();
                }
            }


            else if (comboBox1.Text == "Sports Club")
            {
                // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\Visual Studio\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");

                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from advisor where ClubName='Sports'", con);
                DataTable data1 = new DataTable();
                try
                {
                    sa.Fill(data1);
                    dataGridView1.DataSource = data1;

                }
                catch
                {
                    MessageBox.Show("Data error");
                    con.Close();
                }
            }

            else if (comboBox1.Text == "Robotic Club")
            {
                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from advisor ClubName='Robotic'", con);
                DataTable data1 = new DataTable();
                try
                {
                    sa.Fill(data1);
                    dataGridView1.DataSource = data1;

                }
                catch
                {
                    MessageBox.Show("Data error");
                    con.Close();
                }
            }

            else if (comboBox1.Text == "Cultural Club")
            {
                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from advisor where Clubname='Cultural'", con);
                DataTable data1 = new DataTable();
                try
                {
                    sa.Fill(data1);
                    dataGridView1.DataSource = data1;

                }
                catch
                {
                    MessageBox.Show("Data error");
                    con.Close();
                }
            }

            else
            {
                MessageBox.Show("Please Select Club Name.");
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void add_user_load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\Visual Studio\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            label1.Text = membercount();

        }

        string membercount()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
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

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
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

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            string qry = "select count(Student_ID) from sports";
            SqlCommand sc = new SqlCommand(qry, con);
            int a = 0 + (Int32)sc.ExecuteScalar();
            string reg = "Total Sports Club Member: " + a.ToString();
            label1.Text = reg;
            //  MessageBox.Show(reg);
            return reg;


        }






        private void viewForm_Load(object sender, EventArgs e)
        {

        }

        private void view_member_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          
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
                // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\Visual Studio\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");

                con.Open();
                memberSports();
                SqlDataAdapter sa = new SqlDataAdapter("select *from Sports", con);
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

                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from others where club_name='"+comboBox1.Text+"'", con);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select distinct clubname from addclub", con);
            try
            {
                SqlDataReader dr = sc.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["clubname"]);
                    MessageBox.Show("New Club Added");

                }
                dr.Close();
                dr.Dispose();
            }

            catch
            {
                MessageBox.Show(":V :V :V");
            }
        }
    }
}
