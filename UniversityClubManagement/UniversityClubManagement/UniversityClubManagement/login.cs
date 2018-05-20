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
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            /* 
             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          
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
            if(user=="Admin")

            {
               MainForm mf = new MainForm();
             mf.Show();
               Hide();
            }
            else if (user=="Member")
            {
                memberMainForm m = new memberMainForm();
                m.Show();
                Hide();
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
    }
}
