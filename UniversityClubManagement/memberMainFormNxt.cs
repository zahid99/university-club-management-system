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
    public partial class memberMainFormNxt : Form
    {
        public memberMainFormNxt()
        {
            InitializeComponent();

            textBox2.PasswordChar = '*';
        }


        int x = 0;

       //  string zh = "Programing contest 2016";

        int tam = 20;


        private void memberMainFormNxt_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void event_Click(object sender, EventArgs e)
        {
            eventView ev = new eventView();
            ev.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        void getEventTitle()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from viewevent where club='IT Club'", con);


            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {
                    string itclub = sdr["title"].ToString();
                    //if (itclub == "IT Club")
                    //{

                        label6.Text = sdr["date"].ToString();
                        label4.Text = sdr["title"].ToString();
                        label5.Text = sdr["club"].ToString();

                    //}

                }

            }
            catch
            {
                MessageBox.Show("error from database");
                con.Close();

            }




        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string zh = label4.Text;

            this.Refresh();

            label5.Top += 1;
            //label2.Top += 2;
            if (label5.Top >= this.Width)
                //  {

                label5.Top = label5.Width * -1;
            // }
            Graphics gra = this.CreateGraphics();
            gra.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            gra.DrawString(zh, new Font("Calibri", tam), new SolidBrush(Color.Red), 670, x);
            //  }
            x += 2;
            if (x >= this.Width)
                x = zh.Length * tam * -1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from memLogin where userName='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
               MessageBox.Show("Login SuccesfullY");
               memberMenu m = new memberMenu();
               m.Show();

            }
            else
                MessageBox.Show("User Name OR Password Incorrect");
        }

        private void createAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            memberLoginAccount ma = new memberLoginAccount();
            ma.Show();
        }

        private void committeeList_Click(object sender, EventArgs e)
        {
            viewForm v = new viewForm();
            v.Show();
        }

        private void advisorList_Click(object sender, EventArgs e)
        {
            viewForm v = new viewForm();
            v.Show();
        }
    }
}
