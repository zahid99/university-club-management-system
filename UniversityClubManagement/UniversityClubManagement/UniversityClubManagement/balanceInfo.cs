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
    public partial class balanceInfo : Form
    {
        public balanceInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        string membercountIT()
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();

            
            string qry = "select count(Student_ID) from IT";
            SqlCommand sc = new SqlCommand(qry, con);
            int a = 0 + (Int32)sc.ExecuteScalar();
            a = a * 100;
           // string reg = "Total Balance IT Club  : " + a.ToString();              
           // label3.Text = reg +" Tk.";
             // MessageBox.Show(reg+" TK");
           // return reg;


            ///sum                             

            string query = "SELECT SUM (cost) FROM acc";

          
            SqlCommand command = new SqlCommand(query, con);
            {
                object result = command.ExecuteScalar();
                string z = Convert.ToString(result); ;
              //  MessageBox.Show(z);
               // return z;


                //int x = Convert.ToInt32(reg);
                int y = Convert.ToInt32(z);
                int total = a - y;
                string balance = total.ToString();
                label3.Text = "Total Balance IT Club  : " + total + " Tk.";
                return balance;
            }
           


        }



        string memberRobotic()
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();


            string qry = "select count(Student_ID) from robotic";
            SqlCommand sc = new SqlCommand(qry, con);
            int a = 0 + (Int32)sc.ExecuteScalar();
            a = a * 100;
            string reg = "Total balance Robotic Club : " + a.ToString();
            label3.Text = reg + " Tk.";
             // MessageBox.Show(reg+" TK");
            return reg;


        }

        string memberSports()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            string qry = "select count(Student_ID) from sports";
            SqlCommand sc = new SqlCommand(qry, con);
            int a = 0 + (Int32)sc.ExecuteScalar();
            a = a * 100;
            string reg = "Total Balance Sports Club cst: " + a.ToString();
            label3.Text = reg + " Tk.";                     
             // MessageBox.Show(reg+" TK");
            return reg;


        }

        string membercultural()
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            string z = comboBox1.Text;
            string qry = "select count(Student_ID) from  cultural";
            SqlCommand sc = new SqlCommand(qry, con);
            int a = 0 + (Int32)sc.ExecuteScalar();
            a = a * 100;
            string reg = "Total cultural Club cst: " + a.ToString();

            label3.Text = reg + " Tk.";
            //MessageBox.Show(reg+" TK.");
            return reg;


        }

        private void show_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "IT Club")
            {

               // viewbalance vf = new viewbalance();
               // vf.Show();
                membercountIT();

                
            }
            else if (comboBox1.Text == "Sports Club")
            {
                memberSports();
            }
            else if (comboBox1.Text == "RoboticClub")
            {
                memberRobotic();
            }
            else if (comboBox1.Text == "Cultural Club")
            {
                membercultural();
            }
            else
            {
                MessageBox.Show("select club name");
            }
        }

        private void zh_Click(object sender, EventArgs e)
        {
            viewbalance v = new viewbalance();
            v.Show();
        }




    }
}
