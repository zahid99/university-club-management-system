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
    public partial class memberLoginAccount : Form
    {
        public memberLoginAccount()
        {
            InitializeComponent();
        }



        //for check

        int checkId()
        {

            int get;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");


            if (comboBox1.Text == "IT Club")
            {

                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("select *from IT where Student_ID='" + textBox2.Text + "'", con);
                try
                {
                    SqlDataReader sdr = sc.ExecuteReader();

                    while (sdr.Read())
                    {
                        string givenid = textBox2.Text;

                        string sid = sdr["Student_ID"].ToString();
                        if (givenid == sid)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
              

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
                SqlCommand sc = new SqlCommand("select *from sports where Student_ID='" + textBox2.Text + "'", con);
                try
                {
                    SqlDataReader sdr = sc.ExecuteReader();

                    while (sdr.Read())
                    {
                        string givenid = textBox2.Text;

                        string sid = sdr["Student_ID"].ToString();
                        if (givenid == sid)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }

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
                SqlCommand sc = new SqlCommand("select *from robotic where Student_ID='" + textBox2.Text + "'", con);
                try
                {
                    SqlDataReader sdr = sc.ExecuteReader();

                    while (sdr.Read())
                    {
                        string givenid = textBox2.Text;

                        string sid = sdr["Student_ID"].ToString();
                        if (givenid == sid)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }

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
                SqlCommand sc = new SqlCommand("select *from Cultural where Student_ID='" + textBox2.Text + "'", con);
                try
                {
                    SqlDataReader sdr = sc.ExecuteReader();

                    while (sdr.Read())
                    {
                        string givenid = textBox2.Text;

                        string sid = sdr["Student_ID"].ToString();
                        if (givenid == sid)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }

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
                SqlCommand sc = new SqlCommand("select *from others where Student_ID='" + textBox2.Text + "' and club_name='" + comboBox1.Text + "'", con);
                try
                {
                    SqlDataReader sdr = sc.ExecuteReader();

                    while (sdr.Read())
                    {
                        string givenid = textBox2.Text;

                        string sid = sdr["Student_ID"].ToString();
                        if (givenid == sid)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }

                    }

                }
                catch
                {
                    MessageBox.Show("error from database");
                    con.Close();
                }
            }

            return 0;

        }






        private void save_Click(object sender, EventArgs e)
        {

            int x = checkId();
            if (x == 1)
            {
                MessageBox.Show("You are mem,ber");

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
                con.Open();
                SqlCommand sc = new SqlCommand("insert into memLogin(sid,userName,password) values('" + textBox2.Text + "','" + textBox1.Text+ "','" + textBox3.Text + "') ", con);
                try
                {
                    sc.ExecuteNonQuery();
                    textBox1.Text = " ";
                    comboBox1.Text = " ";
                    textBox2.Text = " ";
                    // textBox3.Text = " ";



                    MessageBox.Show("Successfully Saved.");
                }
                catch(Exception ex)
                {
                    //Error when save data

                    MessageBox.Show(ex.Message);
                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("You are not a member");
            }


        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
