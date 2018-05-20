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
    public partial class committeeInfo : Form
    {
        public committeeInfo()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("insert into committee(Member_ID,club_name,Student_ID,position) values('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "') ", con);
            try
            {
                sc.ExecuteNonQuery();
                textBox1.Text = " ";
                comboBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
             
             

                MessageBox.Show("Successfully Saved.");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                con.Close();
            }


        }

        private void delete_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();

            SqlCommand sc = new SqlCommand("delete from committee where club_name='" + comboBox1.Text + "' and Student_ID='" + textBox1.Text + "'", con);

            try
            {
                sc.ExecuteNonQuery();
               
                comboBox1.Text = " ";


                MessageBox.Show("  delete Successfully .");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                con.Close();
            }
        }
    }
}
