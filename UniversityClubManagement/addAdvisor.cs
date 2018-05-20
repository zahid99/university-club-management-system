using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UniversityClubManagement
{
    public partial class addAdvisor : Form
    {
        public addAdvisor()
        {
            InitializeComponent();
        }
        string imgLoc = " ";


        void addClub()
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


        private void addAdvisor_Load(object sender, EventArgs e)
        {
            addClub();
        }

        private void save_Click(object sender, EventArgs e)
        {

            Byte[] imageBt = null;
            FileStream fstream = new FileStream(this.textBox2.Text, FileMode.Open, FileAccess.Read);
            //  FileStream fstream2 = new FileStream(this.textBox16.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);
  

          
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\UniversityClubManagement\UniversityClubManagement\club.mdf;Integrated Security=True");

            con.Open();
            SqlCommand sc = new SqlCommand("insert into a (Name,ClubName,department,designation,image) values( '"+comboBox1.Text+"','" + textBox3.Text + "','" + comboBox2.Text + "','"+textBox1.Text+"',@img)", con);

            try
            {
                sc.Parameters.Add(new SqlParameter("@img", imageBt));
               
                sc.ExecuteNonQuery();
             

                MessageBox.Show("Successfully Saved.");
            }
            catch(Exception ex)
            {
                //Error when save data

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|ALL Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                textBox2.Text = picPath;
                pictureBox1.ImageLocation = picPath;
            }
        }
    }
}
