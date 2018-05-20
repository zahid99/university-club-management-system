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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
       

        private void add_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          
            con.Open();
            SqlCommand sda = new SqlCommand("insert into login(username,password) values('" + textBox1.Text + "','" + textBox2.Text + "') ", con);
            //SqlDataAdapter sda = new SqlDataAdapter("insert into login(username,password) values('" + textBox1.Text + "','" + textBox2.Text + "') ", con);
             
            try
            {
                   sda.ExecuteNonQuery();
                   textBox1.Text = " ";
                   textBox2.Text = " ";
               // con.Close();
                MessageBox.Show("Add succesfully");
            }
            catch
            {
                
                MessageBox.Show("Data error");
                con.Close();
                
            }

        }

        private void change_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          
           // con.Open();
          

            
         
            
            if (textBox1.Text != "" & textBox2.Text!=" ")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update login set password='" + textBox3.Text + "' where userName='"+textBox1.Text+"' and password='"+textBox2.Text+"'",con);

                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password Change SuccenfullY ");
                }

                catch
                {
                    MessageBox.Show("ErrOr");
                }
            
            }
            else
            {
                MessageBox.Show("Enter User Name and Password");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
