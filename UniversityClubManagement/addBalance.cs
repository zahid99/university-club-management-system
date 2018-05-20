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
    public partial class addBalance : Form
    {
        public addBalance()
        {
            InitializeComponent();

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

        private void save_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text.ToString();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            //SqlCommand sc = new SqlCommand("insert into balance(date,clubName,title,amount) values('" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "') ", con);

            SqlCommand sc = new SqlCommand("insert into bal(date,title,clubName,amount) values('"+dateTimePicker1.Text+"','" + textBox1.Text + "','" + comboBox1.Text + "','"+textBox2.Text+"') ", con);
           

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

        private void del_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text.ToString();


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            //SqlCommand sc = new SqlCommand("insert into balance(date,clubName,title,amount) values('" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "') ", con);

            SqlCommand sc = new SqlCommand("delete frob bal where title='"+textBox1.Text+"' ", con);


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

        private void addBalance_Load(object sender, EventArgs e)
        {
           
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
