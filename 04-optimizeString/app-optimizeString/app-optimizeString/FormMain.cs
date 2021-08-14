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
            }
            else
            {
                MessageBox.Show("Dữ liệu không được rỗng", "Thông báo");
            }

            return str;
        }
    }
}
