using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UniversityClubManagement
{
    public partial class memberMenu : Form
    {
        public memberMenu()
        {
            InitializeComponent();
        }

        private void memberList_Click(object sender, EventArgs e)
        {
            viewMemberList m = new viewMemberList();
            m.Show();
        }
    }
}
