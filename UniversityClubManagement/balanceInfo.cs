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

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
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

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
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

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
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

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
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

        int c()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
           // {
               
                string quy = "select sum(amount) from bal where clubName='" + comboBox1.Text + "' ";

                SqlCommand sc = new SqlCommand(quy, con);

                try
                {
                    int a = 0 + (Int32)sc.ExecuteScalar();
                    //string z = " Total :" + a.ToString();
                    //label2.Text = z;
                    // MessageBox.Show(z);
                    return a;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return 0;

                
          //  }
            /*
            {

                string q = "select sum(cost) from acc where clubName='" + comboBox1.Text + "' ";

               SqlCommand s = new SqlCommand(quy, con);

                int b = 0 + (Int32)s.ExecuteScalar();
                

                string x = " Total :" + b.ToString();
                //label2.Text = z;
                MessageBox.Show(x);
                return x;
            }
            //int total = a + b;
            */

        }



        int d()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
          
            string quy = "select sum(cost) from acc where clubName='" + comboBox1.Text + "' ";

            SqlCommand sc = new SqlCommand(quy, con);
            try
            {
                int b = 0 + (Int32)sc.ExecuteScalar();
                string x = " Total :" + b.ToString();

                return b;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
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
            
        }

        private void balanceInfo_Load(object sender, EventArgs e)
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

        private void collection_Click(object sender, EventArgs e)
        {
            int net = c() - d();
            string n = net.ToString();
         //   MessageBox.Show(n);
            label3.Text ="Net Balance :" +n;
           
        }




    }
}
