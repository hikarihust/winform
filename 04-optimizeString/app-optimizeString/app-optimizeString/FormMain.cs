using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_optimizeString
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtInput.Text = "    vŨ   @!&*đình   quanG    ";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string str = txtInput.Text;
            if (str.Length > 0)
            {
                txtOutput.Text = ConvertName();
            }
            else
            {
                MessageBox.Show("Dữ liệu không được rỗng", "Thông báo");
            }
        }

        private string ConvertName()
        {
            string str = txtInput.Text;

            if (str.Length > 0)
            {
                if (chkRemoveSpecial.Checked == true)
                {
                    str = Regex.Replace(str, @"\W+", " ");                  // Xóa ký tự đặt biệt
                }

                if (chkRemoveSpace.Checked == true)
                {
                    str = str.Trim();                                       // Xóa khoảng trắng đầu và cuối chuỗi
                    str = Regex.Replace(str, @"\s+", " ");                  // Xóa khoảng trắng không cần thiết
                }

                if (radTextLower.Checked == true)
                {
                    str = str.ToLower();
                }
                else if (radTextUpper.Checked == true)
                {
                    str = str.ToUpper();
                }

                // Xác định kiểu được chọn
                if (radTypeNoAccent.Checked == true)
                {
                    str = RemoveAccent(str);
                }
                else if (radTypeSlug.Checked == true)
                {
                    str = ConvertNameToSlug(str);
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không được rỗng", "Thông báo");
            }

            return str;
        }

        private string RemoveAccent(string str)
        {

            str = Regex.Replace(str, @"(à|ả|ã|á|ạ|ă|ằ|ẳ|ẵ|ắ|ặ|â|ầ|ẩ|ẫ|ấ|ậ)", "a");
            str = Regex.Replace(str, @"(è|ẻ|ẽ|é|ẹ|ê|ề|ể|ễ|ế|ệ)", "e");
            str = Regex.Replace(str, @"(ò|ỏ|õ|ó|ọ|ô|ồ|ổ|ỗ|ố|ộ|ơ|ờ|ở|ỡ|ớ|ợ)", "o");
            str = Regex.Replace(str, @"(ù|ủ|ũ|ú|ụ|ư|ừ|ử|ữ|ứ|ự)", "u");
            str = Regex.Replace(str, @"(ì|ỉ|ĩ|í|ị)", "i");
            str = Regex.Replace(str, @"(ỳ|ỷ|ỹ|ý)", "y");
            str = Regex.Replace(str, @"(đ)", "d");

            str = Regex.Replace(str, @"(À|Ả|Ã|Á|Ạ|Ă|Ằ|Ẳ|Ẵ|Ắ|Ặ|Â|Ầ|Ẩ|Ẫ|Ấ|Ậ)", "A");
            str = Regex.Replace(str, @"(È|Ẻ|Ẽ|É|Ẹ|Ê|Ề|Ể|Ễ|Ế|Ệ)", "E");
            str = Regex.Replace(str, @"(Ò|Ỏ|Õ|Ó|Ọ|Ô|Ồ|Ổ|Ỗ|Ố|Ộ|Ơ|Ờ|Ở|Ỡ|Ớ|Ợ)", "O");
            str = Regex.Replace(str, @"(Ù|Ủ|Ũ|Ú|Ụ|Ư|Ừ|Ử|Ữ|Ứ|Ự)", "U");
            str = Regex.Replace(str, @"(Ì|Ỉ|Ĩ|Í|Ị)", "I");
            str = Regex.Replace(str, @"(Ỳ|Ỷ|Ỹ|Ý)", "Y");
            str = Regex.Replace(str, @"(Đ)", "D");

            return str;
        }

        private string ConvertNameToSlug(string str)
        {
            str = RemoveAccent(str);
            str = Regex.Replace(str, @"\s+", "-");
            return str;
        }
    }
}
