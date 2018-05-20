using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace UniversityClubManagement
{
    public partial class emailSystem : Form
    {


        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        public emailSystem()
        {
            InitializeComponent();

            showClubName();
        }


        
           




        private void send_Click(object sender, EventArgs e)
        {
            //login = new NetworkCredential(textBox4.Text, textBox6.Text);
            //client = new SmtpClient(textBox8.Text);
            //client.Port = Convert.ToInt32(textBox7.Text);
            //client.EnableSsl = checkBox1.Checked;
            //client.Credentials = login;
            //msg=new
            // msg = new MailMessage{From(textBox4.Text + textBox8.Text.Replace("smtp.", "@"), "Lucy", Encoder.UTF8) };

            // textBox7= "578";
            MailMessage mail = new MailMessage(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text);
            SmtpClient client = new SmtpClient(textBox8.Text);
            client.Port = 578;
            client.Credentials = new System.Net.NetworkCredential(textBox4.Text, textBox6.Text);
            client.EnableSsl = true;
            //try
            //{
            client.Send(mail);
            MessageBox.Show("Mail Send", "Success", MessageBoxButtons.OK);
            //}
            //catch
            //{
            //    MessageBox.Show("error");
            //}
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\Visual Studio\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");


            if (comboBox1.Text == "IT Club")
            {

                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("select *from IT where Student_ID='" + textBox9.Text + "'", con);
                try
                {
                    SqlDataReader sdr = sc.ExecuteReader();

                    while (sdr.Read())
                    {
                       
                        textBox1.Text = sdr["email"].ToString();
                 

                    }

                }
                catch
                {
                    MessageBox.Show("error from database");
                    con.Close();
                }
            }


            else if (comboBox1.Text == "Sports Club")
            {

                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("select *from sports where Student_ID='" + textBox9.Text + "'", con);
                try
                {
                    SqlDataReader sdr = sc.ExecuteReader();

                    while (sdr.Read())
                    {
                 
                        textBox1.Text = sdr["email"].ToString();
                   
                    }

                }
                catch
                {
                    MessageBox.Show("error from database");
                    con.Close();
                }
            }


            else if (comboBox1.Text == "Robotic Club")
            {

                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("select *from robotic where Student_ID='" + textBox9.Text + "'", con);
                try
                {
                    SqlDataReader sdr = sc.ExecuteReader();

                    while (sdr.Read())
                    {
                       
                        textBox1.Text = sdr["email"].ToString();
              
                    }

                }
                catch
                {
                    MessageBox.Show("error from database");
                    con.Close();
                }
            }


            else if (comboBox1.Text == "Cultural Club")
            {

                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("select *from Cultural where Student_ID='" + textBox9.Text + "'", con);
                try
                {
                    SqlDataReader sdr = sc.ExecuteReader();

                    while (sdr.Read())
                    {
                      
                        textBox1.Text = sdr["email"].ToString();
                       
                    }

                }
                catch
                {
                    MessageBox.Show("error from database");
                    con.Close();
                }
            }

            else
            {

                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("select *from others where Student_ID='" + textBox9.Text + "' and club_name='" + comboBox1.Text + "'", con);
                try
                {
                    SqlDataReader sdr = sc.ExecuteReader();

                    while (sdr.Read())
                    {
                        
                        textBox1.Text = sdr["email"].ToString();
                       
                      

                    }

                }
                catch
                {
                    MessageBox.Show("error from database");
                    con.Close();
                }
            }



        }

        private void modifyMember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\Visual Studio\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
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



        void showClubName()
        {
              SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\Visual Studio\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            }

        }
    }

