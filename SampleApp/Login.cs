using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class Login : Form
    {

        CultureInfo culture;
        private string cultureName;

        public Login()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to close the application?");
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

        private void mn_lang_Click(object sender, EventArgs e)
        {
            if (item_eng.Checked)
                SetLanguage("en-US");
            else if (item_japanese.Checked)
                SetLanguage("jp_Japan");

        }

        private void SetLanguage(string v)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("WinFormsMultiLingual.Lang.MyResource", typeof(Login).Assembly);

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
