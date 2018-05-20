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
    public partial class eventUpdate : Form
    {
        public eventUpdate()
        {
            InitializeComponent();
        }

        private void eventUpdate_Load(object sender, EventArgs e)
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

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\Visual Studio\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");

            con.Open();
            // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
            SqlCommand sc = new SqlCommand("select *from event where date='" + dateTimePicker1.Text+ "' and club='"+comboBox1.Text+"'", con);
            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {

                    textBox1.Text = sdr["title"].ToString();
                    richTextBox1.Text = sdr["details"].ToString();


                }

            }
            catch
            {
                MessageBox.Show("error from database");
                con.Close();
            }
        }

        private void updat_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();

            SqlCommand sc = new SqlCommand("delete from event where date='" + dateTimePicker1.Text + "' and club='" + comboBox1.Text + "'", con);

            try
            {
                sc.ExecuteNonQuery();
                /// dateTimePicker1.Text = " ";
                /// comboBox1.Text = " ";


                MessageBox.Show("  delete Successfully .");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to delete on database");
                con.Close();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
