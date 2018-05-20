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
    public partial class modify : Form
    {
        public modify()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void view_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            if (comboBox1.Text == "IT Club")
            {
                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from IT", con);
                DataTable data1 = new DataTable();
                sa.Fill(data1);
                dataGridView1.DataSource = data1;
                con.Close();
            }


            else if (comboBox1.Text == "Sports Club")
            {
                // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WorkSpace\Visual Studio\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");

                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from sports", con);
                DataTable data1 = new DataTable();
                sa.Fill(data1);
                dataGridView1.DataSource = data1;
                con.Close();
            }

            else if (comboBox1.Text == "Robotic Club")
            {
                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from robotic", con);
                DataTable data1 = new DataTable();
                sa.Fill(data1);
                dataGridView1.DataSource = data1;
                con.Close();
            }

            else if (comboBox1.Text == "Cultural Club")
            {
                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from cultural", con);
                DataTable data1 = new DataTable();
                sa.Fill(data1);
                dataGridView1.DataSource = data1;
                con.Close();
            }

            else
            {
                con.Open();
                SqlDataAdapter sa = new SqlDataAdapter("select *from others where club_name='"+comboBox1.Text+"'", con);
                DataTable data1 = new DataTable();
                sa.Fill(data1);
                dataGridView1.DataSource = data1;
                con.Close();
               // MessageBox.Show("LuL");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            /*
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();*/
          //  richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
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
            richTextBox1.Text = "";
        }

        private void test_click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select count(Student_ID) from IT");

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3]);
            }
            MessageBox.Show(sum.ToString());
        }

        private void remove_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you Delete Member ?",
          "Delete", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          

                if (comboBox1.Text == "IT Club")
                {

                    con.Open();
                    // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                    SqlCommand sc = new SqlCommand("delete from IT where Student_ID='" + textBox2.Text + "'", con);
                    sc.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete SuccesFully.");
                }

                else if (comboBox1.Text == "Robotic Club")
                {
                    con.Open();
                    // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                    SqlCommand sc = new SqlCommand("delete from robotic where Student_ID='" + textBox2.Text + "'", con);
                    sc.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete SuccesFully. ");
                }

                else if (comboBox1.Text == "Sports Club")
                {
                    con.Open();
                    // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                    SqlCommand sc = new SqlCommand("delete from sports where Student_ID='" + textBox2.Text + "'", con);
                    sc.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete SuccesFully. ");
                }



                else if (comboBox1.Text == "Cultural Club")
                {
                    con.Open();
                    // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                    SqlCommand sc = new SqlCommand("delete from Cultural where Student_ID='" + textBox2.Text + "'", con);
                    sc.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete SuccesFully. ");
                }
                else if (comboBox1.Text == "Select")
                {

                    MessageBox.Show("please select club");
                }

                else
                {

                    con.Open();
                    // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                    SqlCommand sc = new SqlCommand("delete from others where Student_ID='" + textBox2.Text + "'", con);
                    sc.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete SuccesFully. ");


                }
            }

            else if (dialog == DialogResult.No)
            {

            }
        }

        private void search_Click(object sender, EventArgs e)
        {
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
                        textBox1.Text = sdr["Member_ID"].ToString();
                        textBox3.Text = sdr["Name"].ToString();
                        textBox4.Text = sdr["phone"].ToString();
                        textBox5.Text = sdr["email"].ToString();
                        textBox6.Text = sdr["dept"].ToString();
                        textBox7.Text = sdr["batch"].ToString();
                        // textBox8.Text = sdr["join_date"].ToString();
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
                        // textBox8.Text = sdr["join_date"].ToString();
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
                        // textBox8.Text = sdr["join_date"].ToString();
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
                        // textBox8.Text = sdr["join_date"].ToString();
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
                //MessageBox.Show("SElect Club");

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
                        // textBox8.Text = sdr["join_date"].ToString();
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

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
          

            if (comboBox1.Text == "IT Club")
            {
                // con.Open();
                if (textBox1.Text != "" || textBox2.Text != " ")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update IT set phone='" + textBox4.Text + "',email='" + textBox5.Text + "',_address='" + richTextBox1.Text + "' where Student_ID='" + textBox2.Text + "' or Member_ID='" + textBox1.Text + "'", con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Member Information update SuccenfullY ");
                    }

                    catch
                    {
                        MessageBox.Show("ErrOr");
                    }

                }

            }

            else if (comboBox1.Text == "Sports Club")
            {
                if (textBox1.Text != "" || textBox2.Text != " ")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update sports set phone='" + textBox4.Text + "',email='" + textBox5.Text + "',_address='" + richTextBox1.Text + "' where Student_ID='" + textBox2.Text + "' or Member_ID='" + textBox1.Text + "'", con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Member Information update SuccesfullY ");
                    }

                    catch
                    {
                        MessageBox.Show("ErrOr");
                    }

                }



            }

            else if (comboBox1.Text == "Robotic Club")
            {
                if (textBox1.Text != "" || textBox2.Text != " ")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update robotic set phone='" + textBox4.Text + "',email='" + textBox5.Text + "',_address='" + richTextBox1.Text + "' where Student_ID='" + textBox2.Text + "' or Member_ID='" + textBox1.Text + "'", con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Member Information update  SuccesfullY ");
                    }

                    catch
                    {
                        MessageBox.Show("ErrOr");
                    }

                }


            }

            else if (comboBox1.Text == " Cultural Club")
            {
                if (textBox1.Text != "" || textBox2.Text != " ")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update cultural set phone='" + textBox4.Text + "',email='" + textBox5.Text + "',_address='" + richTextBox1.Text + "' where Student_ID='" + textBox2.Text + "' or Member_ID='" + textBox1.Text + "'", con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Member Information Update SuccesfullY ");
                    }

                    catch
                    {
                        MessageBox.Show("ErrOr");
                    }
                }


            }

            else
            {
                if (textBox1.Text != "" && textBox2.Text != " " && comboBox1.Text!=" ")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update others set phone='" + textBox4.Text + "',email='" + textBox5.Text + "',_address='" + richTextBox1.Text + "' where Student_ID='" + textBox2.Text + "' and Member_ID='" + textBox1.Text + "' and club_name='"+comboBox1.Text+"'", con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Member Information Update SuccesfullY ");
                    }

                    catch
                    {
                        MessageBox.Show("ErrOr");
                    }
                }

            }
        }

        private void modify_Load(object sender, EventArgs e)
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
    }
}
