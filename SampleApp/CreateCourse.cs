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
    public partial class CreateCourse : Form
    {
        public CreateCourse()
        {
            InitializeComponent();
        }



        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("You must saved before closing?", "OK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                /*e.Cancel = true;*/
            }
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