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

        private void item_color_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog(); //Khởi tạo đối tượng ColorDialog 
            dlg.ShowDialog(); //Hiển thị hộp thoại

            if (dlg.ShowDialog() == DialogResult.OK) //Nếu nhấp vào nút OK trên hộp thoại
            {
                string str = null; //Khai báo biến str
                str = dlg.Color.Name; //Trả lại tên của màu đã lựa chọn
                MessageBox.Show(str); //Hiển thị lên MessageBox
            }
        }

    }
}
