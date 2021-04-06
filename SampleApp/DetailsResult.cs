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
