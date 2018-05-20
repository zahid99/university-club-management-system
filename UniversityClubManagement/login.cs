using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//

namespace UniversityClubManagement
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        string user;
          private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to exit Program?",
            "EXIT", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {

            }
           
        }

        private void login_Click(object sender, EventArgs e)
        {
           /* SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\Visual Studio\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where userName='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MainForm mf = new MainForm();
                mf.Show();
                Hide();
            }
            else
                MessageBox.Show("User Name OR Password Incorrect"); */

            //if ( != " " && textBox2.Text != " ")
           
            //if(user=="Admin")

            {

               
             //  MainForm mf = new MainForm();
             //mf.Show();
             //  Hide();

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          
               con.Open();
               SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where userName='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
               DataTable dt = new DataTable();
               sda.Fill(dt);
               if (dt.Rows[0][0].ToString() == "1")
               {
                   MainForm mf = new MainForm();
                   mf.Show();
                   Hide();
               }
               else
                   MessageBox.Show("User Name OR Password Incorrect");

            }

            
            //else if (user=="Member")
            //{

            //    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          
            //    con.Open();
            //    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where userName='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            //    if (dt.Rows[0][0].ToString() == "1")
            //    {
            //        memberMainForm m = new memberMainForm();
            //        m.Show();
            //        Hide();

            //    }
            //    else
            //        MessageBox.Show("User Name OR Password Incorrect");
            //}


            //else
            //{
            //    MessageBox.Show("Select User Type");
            //}


        }

        private void log_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          

           
                if (user == "Admin")
                {
                    if (textBox1.Text != " ") { 
              
                   
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where userName='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MainForm mf = new MainForm();
                        mf.Show();
                        Hide();
                    }
                    else
                        MessageBox.Show("User Name OR Password Incorrect");

                }
                    else
                    {
                        MessageBox.Show("user Name");
                    }
        }

            
            else if (user == "Member")
            {            
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where userName='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    memberMainForm m = new memberMainForm();
                    m.Show();
                    Hide();

                }
                else
                    MessageBox.Show("User Name OR Password Incorrect");
            }
            else
            {
                MessageBox.Show("Select User Type");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            user = "Admin";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            user = "Member";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            this.label5.Text = d.ToString();
        }

        private void memberlogin_Click(object sender, EventArgs e)
        {
            memberMainFormNxt m = new memberMainFormNxt();
            m.Show();
            this.Hide();
        }

       
    }
}
