using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void normalSmallToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void languagesJapaneseEnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            View_Result fm = new View_Result();
            if (this.txt_username.Text == "admin" && this.txt_password.Text == "123")
            {
                fm.Show();
            }
            else
            {
                MessageBox.Show("Password is wrong!!!");
            }
        }
    }
}
