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
    public partial class eventInfo : Form
    {
        public eventInfo()
        {
            InitializeComponent();
        }



        void events()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          
            con.Open();

          /// SqlCommand sc = new SqlCommand("insert into viewevent(date,club,title) values('" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "') ", con);
           
            SqlCommand cmd = new SqlCommand("update viewevent set date='" + dateTimePicker1.Text + "',title='" + textBox1.Text+ "' where club='" + comboBox1.Text + "'", con);

            try
            {

              // sc.ExecuteNonQuery();
               cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Event Information update SuccenfullY ");
            }

            catch
            {
                MessageBox.Show("ErrOr");
            }


        }


        void eventUpdate()
        {


        }




        private void add_Click(object sender, EventArgs e)
        {
            events();

            string dat = dateTimePicker1.Text.ToString();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("insert into event(date,club,title,details) values('" +dat+ "','" + comboBox1.Text + "','"+textBox1.Text+"','" + richTextBox1.Text + "') ", con);
            try
            {
                sc.ExecuteNonQuery();
                dat = " ";
                comboBox1.Text = " ";
                textBox1.Text = " ";
                richTextBox1.Text = " ";



                MessageBox.Show("Successfully Saved.");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                con.Close();
            }
        }

        private void del_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();

            SqlCommand sc = new SqlCommand("delete from event where date='" + dateTimePicker1.Text + "' and club='" + comboBox1.Text + "'",con);

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

        private void eventInfo_Load(object sender, EventArgs e)
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

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
