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
    public partial class modifyMember : Form
    {
        public modifyMember()
        {
            InitializeComponent();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\Visual Studio\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");


            if (comboBox1.Text == "IT Club")
            {

                con.Open();
               // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("delete from IT where Student_ID='" + textBox2.Text + "'", con);
                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete SuccesFully!!!! :D ");
            }

            else if (comboBox1.Text == "Robotic Club")
            {
                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("delete from robotic where Student_ID='" + textBox2.Text + "'", con);
                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete SuccesFully!!!! :D ");
            }

            else if (comboBox1.Text == "Sports Club")
            {
                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("delete from sports where Student_ID='" + textBox2.Text + "'", con);
                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete SuccesFully!!!! :D ");
            }



            else if (comboBox1.Text == "Cultural Club")
            {
                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("delete from Cultural where Student_ID='" + textBox2.Text + "'", con);
                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete SuccesFully!!!! :D ");
            }

            else
            {
                MessageBox.Show("Select CLub Name");
            }
        }

        

        private void search_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          

            if (comboBox1.Text == "IT Club")
            {

                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("select *from IT where Student_ID='" + textBox2.Text + "'", con);
                try
                {
                    SqlDataReader sdr = sc.ExecuteReader();
                   
                    while(sdr.Read() )
                    {
                        textBox1.Text = sdr["Member_ID"].ToString();
                        textBox3.Text = sdr["Name"].ToString();
                        textBox4.Text = sdr["phone"].ToString();
                        textBox5.Text = sdr["email"].ToString();
                        textBox6.Text = sdr["dept"].ToString();
                        textBox7.Text = sdr["batch"].ToString();
                        textBox8.Text = sdr["join_date"].ToString();
                        richTextBox1.Text = sdr["_address"].ToString();

                    }

                }
                catch
                {
                    MessageBox.Show("error from database");
                    con.Close();
                }
            }
        }
    }
}
