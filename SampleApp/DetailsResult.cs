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
    public partial class DetailsResult : Form
    {
        public DetailsResult()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            View_Result fm = new View_Result();
            this.Visible = false;
            fm.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void item_color_Click(object sender, EventArgs e)
        {

        }

        private void cl_pink_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(230, 230, 250);

        }

        private void cl_blue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(173, 216, 230);
        }

    }
}
