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
    public partial class infoForm : Form
    {
        public infoForm()
        {
            InitializeComponent();
        }

        string gender;

        private void infoForm_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

            string date = dateTimePicker1.Text.ToString();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          

            if (comboBox1.Text == "IT Club")
            {
                // con.Open();
                textBox1.Text = "IT";
                con.Open();
                SqlCommand sc = new SqlCommand("insert into IT (Member_ID,Student_ID,Name,phone,email,join_date,dept,batch,gender,_address) values( '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + date + "','" + textBox6.Text + "','" + textBox7.Text + "','" + gender + "','" + richTextBox1.Text + "' )", con);

                try
                {
                    sc.ExecuteNonQuery();
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                    textBox3.Text = " ";
                    textBox4.Text = " ";
                    textBox5.Text = " ";
                    date          = " ";
                    textBox6.Text = " ";
                    textBox7.Text = " ";
                    gender        = " ";
                    richTextBox1.Text = "";

                    MessageBox.Show("Successfully Saved.");
                }
                catch
                {
                    //Error when save data

                    MessageBox.Show("Error to save on database");
                    con.Close();
                }
                
            }



            else if (comboBox1.Text == "Sports Club")
            {

                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          
                //MessageBox.Show("Lul");
                cn.Open();
                SqlCommand sc = new SqlCommand("insert into sports (Member_ID,Student_ID,Name,phone,email,join_date,dept,batch,gender,_address) values( '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + date + "','" + textBox6.Text + "','" + textBox7.Text + "','" + gender + "','" + richTextBox1.Text + "' )", cn);
                try
                {
                    sc.ExecuteNonQuery();
               
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                    textBox3.Text = " ";
                    textBox4.Text = " ";
                    textBox5.Text = " ";
                    date = " ";
                    textBox6.Text = " ";
                    textBox7.Text = " ";
                    gender = " ";
                    richTextBox1.Text = "";

                    MessageBox.Show("Successfully Saved.");
                }
                catch
                {
                    //Error when save data

                    MessageBox.Show("Error to save on database");
                    cn.Close();
                }
                
            }



            else if (comboBox1.Text == "Cultural Club")
            {
                con.Open();
                SqlCommand sc = new SqlCommand("insert into Cultural (Member_ID,Student_ID,Name,phone,email,join_date,dept,batch,gender,_address) values( '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + date + "','" + textBox6.Text + "','" + textBox7.Text + "','" + gender + "','" + richTextBox1.Text + "')", con);
                try
                {
                    sc.ExecuteNonQuery();
                   
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                    textBox3.Text = " ";
                    textBox4.Text = " ";
                    textBox5.Text = " ";
                    date = " ";
                    textBox6.Text = " ";
                    textBox7.Text = " ";
                    gender = " ";
                    richTextBox1.Text = "";

                    MessageBox.Show("Successfully Saved.");
                }
                catch
                {
                    //Error when save data

                    MessageBox.Show("Error to save on database");
                    con.Close();
                }

            }



            else if (comboBox1.Text == "Robotic Club")
            {
                con.Open();
                SqlCommand sc = new SqlCommand("insert into robotic (Member_ID,Student_ID,Name,phone,email,join_date,dept,batch,gender,_address) values( '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + date + "','" + textBox6.Text + "','" + textBox7.Text + "','" + gender + "','" + richTextBox1.Text + "')", con);
                try
                {
                    sc.ExecuteNonQuery();
                  //.  sc.ExecuteNonQuery();
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                    textBox3.Text = " ";
                    textBox4.Text = " ";
                    textBox5.Text = " ";
                    date = " ";
                    textBox6.Text = " ";
                    textBox7.Text = " ";
                    gender = " ";
                    richTextBox1.Text = "";

                    MessageBox.Show("Successfully Saved.");
                }
                catch
                {
                    //Error when save data

                    MessageBox.Show("Error to save on database");
                    con.Close();
                }
            }


            else
            {
               // MessageBox.Show("Select Club Name.");

                con.Open();
                SqlCommand sc = new SqlCommand("insert into others (Member_ID,club_name,Student_ID,name,phone,email,join_date,dept,batch,gender,_address) values( '" + textBox1.Text + "','"+comboBox1.Text+"','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + date + "','" + textBox6.Text + "','" + textBox7.Text + "','" + gender + "','" + richTextBox1.Text + "')", con);
                try
                {
                    sc.ExecuteNonQuery();
                    //.  sc.ExecuteNonQuery();
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                    textBox3.Text = " ";
                    textBox4.Text = " ";
                    textBox5.Text = " ";
                    date = " ";
                    textBox6.Text = " ";
                    textBox7.Text = " ";
                    gender = " ";
                    richTextBox1.Text = "";

                    MessageBox.Show("Successfully Saved.");
                }
                catch
                {
                    //Error when save data

                    MessageBox.Show("Error to save on database");
                    con.Close();
                }
            }

            


        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addClub_Click(object sender, EventArgs e)
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
