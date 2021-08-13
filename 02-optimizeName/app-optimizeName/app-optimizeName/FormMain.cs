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

namespace app_optimizeName
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtYourName.Text.Length > 0)
            {
                txtVi.Text = convertNameToVi(txtYourName.Text);
                txtEn.Text = convertNameToEn(txtYourName.Text);
            }
            else
            {
                MessageBox.Show("Dữ liệu không được rỗng", "Thông báo");
            }
        }

        private string convertNameToVi(string str)
        {
            str = Regex.Replace(str, @"\W+", " ");         // Xóa ký tự đặt biệt
            str = str.Trim();                               // Xóa khoảng trắng đầu và cuối chuỗi
            str = Regex.Replace(str, @"\s+", " ");          // Xóa khoảng trắng không cần thiết
            str = str.ToLower();                            // Chuyển toàn bộ chuỗi sang chữ thường
            str = str.Remove(0, 1).Insert(0, Char.ToUpper(str[0]) + "");

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (Char.IsWhiteSpace(str[i]) && !Char.IsWhiteSpace(str[i+1]))
                {
                    str = str.Remove(i + 1, 1).Insert(i + 1, Char.ToUpper(str[i + 1]) + "");
                }
            }

            return str;
        }

        private string convertNameToEn(string str)
        {
            return "convertNameToEn";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
