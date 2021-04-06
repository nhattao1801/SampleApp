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
    public partial class View_Result : Form
    {
        public View_Result()
        {
            InitializeComponent();
        }

        private void btn_details_Click_1(object sender, EventArgs e)
        {
            DetailsResult fm = new DetailsResult();
            this.Visible = false;
            fm.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void File_Opening(object sender, CancelEventArgs e)
        {

        }

        private void themesNormalBigToolStripMenuItem_Click(object sender, EventArgs e)
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
