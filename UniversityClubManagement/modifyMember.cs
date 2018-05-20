using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UniversityClubManagement
{
    public partial class modifyMember : Form
    {
        public modifyMember()
        {
            InitializeComponent();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          

            if (comboBox1.Text == "IT Club")
            {

                con.Open();
               // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("delete from IT where Student_ID='" + textBox2.Text + "'", con);
                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete SuccesFully!!!! :D ");
            }

            else if (comboBox1.Text == "Robotic Club")
            {
                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("delete from robotic where Student_ID='" + textBox2.Text + "'", con);
                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete SuccesFully!!!! :D ");
            }

            else if (comboBox1.Text == "Sports Club")
            {
                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("delete from sports where Student_ID='" + textBox2.Text + "'", con);
                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete SuccesFully!!!! :D ");
            }



            else if (comboBox1.Text == "Cultural Club")
            {
                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("delete from Cultural where Student_ID='" + textBox2.Text + "'", con);
                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete SuccesFully!!!! :D ");
            }

            else
            {
                MessageBox.Show("Select CLub Name");
            }
        }



        void showPicture()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          
          //  con.Open();
          //  SqlCommand cmd = new SqlCommand("select image from customerInfo where account_no='" + label12.Text + "'", con);
         //   SqlDataAdapter da = new SqlDataAdapter(cmd);
          //  DataSet ds = new DataSet();
            //da.Fill(ds);
            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["image"]);
            //    pictureBox1.Image = new Bitmap(ms);
            //}


          //  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");


            if (comboBox1.Text == "IT Club")
            {
               // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          
                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                try
                {
                    SqlCommand sc = new SqlCommand("select image from IT where Student_ID='" + textBox2.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(sc);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["image"]);
                        pictureBox1.Image = new Bitmap(ms);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            else if (comboBox1.Text == "Robotic Club")
            {
                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("select image from robotic where Student_ID='" + textBox2.Text + "'", con);
                try{
                SqlDataAdapter da = new SqlDataAdapter(sc);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["image"]);
                        pictureBox1.Image = new Bitmap(ms);
                    }
                }
                
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (comboBox1.Text == "Sports Club")
            {
                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("select image from sports where Student_ID='" + textBox2.Text + "'", con);
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(sc);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["image"]);
                        pictureBox1.Image = new Bitmap(ms);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



            else if (comboBox1.Text == "Cultural Club")
            {
                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("select image from Cultural where Student_ID='" + textBox2.Text + "'", con);
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(sc);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["image"]);
                        pictureBox1.Image = new Bitmap(ms);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select club");
            }

            else 
            {
                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("select image from others where Student_ID='" + textBox2.Text + "'", con);
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(sc);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["image"]);
                        pictureBox1.Image = new Bitmap(ms);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }





        }


        private void search_Click(object sender, EventArgs e)
        {
            showPicture();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          

            if (comboBox1.Text == "IT Club")
            {

                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("select *from IT where Student_ID='" + textBox2.Text + "'", con);
                try
                {
                    SqlDataReader sdr = sc.ExecuteReader();
                   
                    while(sdr.Read() )
                    {
                        textBox1.Text = sdr["Member_ID"].ToString();
                        textBox3.Text = sdr["Name"].ToString();
                        textBox4.Text = sdr["phone"].ToString();
                        textBox5.Text = sdr["email"].ToString();
                        textBox6.Text = sdr["dept"].ToString();
                        textBox7.Text = sdr["batch"].ToString();
                        textBox8.Text = sdr["join_date"].ToString();
                        richTextBox1.Text = sdr["_address"].ToString();
                     

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
                        textBox1.Text = sdr["Member_ID"].ToString();
                        textBox3.Text = sdr["Name"].ToString();
                        textBox4.Text = sdr["phone"].ToString();
                        textBox5.Text = sdr["email"].ToString();
                        textBox6.Text = sdr["dept"].ToString();
                        textBox7.Text = sdr["batch"].ToString();
                        textBox8.Text = sdr["join_date"].ToString();
                        richTextBox1.Text = sdr["_address"].ToString();

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
                        textBox1.Text = sdr["Member_ID"].ToString();
                        textBox3.Text = sdr["Name"].ToString();
                        textBox4.Text = sdr["phone"].ToString();
                        textBox5.Text = sdr["email"].ToString();
                        textBox6.Text = sdr["dept"].ToString();
                        textBox7.Text = sdr["batch"].ToString();
                        textBox8.Text = sdr["join_date"].ToString();
                        richTextBox1.Text = sdr["_address"].ToString();

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
                        textBox1.Text = sdr["Member_ID"].ToString();
                        textBox3.Text = sdr["Name"].ToString();
                        textBox4.Text = sdr["phone"].ToString();
                        textBox5.Text = sdr["email"].ToString();
                        textBox6.Text = sdr["dept"].ToString();
                        textBox7.Text = sdr["batch"].ToString();
                        textBox8.Text = sdr["join_date"].ToString();
                        richTextBox1.Text = sdr["_address"].ToString();

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
                SqlCommand sc = new SqlCommand("select *from others where Student_ID='" + textBox2.Text + "' and club_name='"+comboBox1.Text+"'", con);
                try
                {
                    SqlDataReader sdr = sc.ExecuteReader();

                    while (sdr.Read())
                    {
                        textBox1.Text = sdr["Member_ID"].ToString();
                        textBox3.Text = sdr["Name"].ToString();
                        textBox4.Text = sdr["phone"].ToString();
                        textBox5.Text = sdr["email"].ToString();
                        textBox6.Text = sdr["dept"].ToString();
                        textBox7.Text = sdr["batch"].ToString();
                        textBox8.Text = sdr["join_date"].ToString();
                        richTextBox1.Text = sdr["_address"].ToString();

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

        private void clear_Click(object sender, EventArgs e)
        {

            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            richTextBox1.Text = " ";


        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
