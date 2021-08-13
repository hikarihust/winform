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
            return "convertNameToVi";
        }

        private string convertNameToEn(string str)
        {
            return "convertNameToEn";
        }
    }
}
