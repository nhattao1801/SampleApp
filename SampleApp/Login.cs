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

        private void button1_Click(object sender, EventArgs e)
        {

            View_Result fm = new View_Result();
            if (this.txt_username.Text == "admin" && this.txt_password.Text == "123")
            {
                fm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //acc
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //pass
        {

        }
    }
}
