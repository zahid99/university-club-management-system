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
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("insert into acc(date,clubName,title,cost) values('" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "') ", con);
            try
            {
                sc.ExecuteNonQuery();
                textBox1.Text = " ";
                comboBox1.Text = " ";
                textBox2.Text = " ";
               // textBox3.Text = " ";



                MessageBox.Show("Successfully Saved.");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                con.Close();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void account_Load(object sender, EventArgs e)
        {

        }
    }
}
