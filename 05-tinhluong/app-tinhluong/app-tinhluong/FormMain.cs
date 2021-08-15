using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_tinhluong
{
    public partial class frmMain : Form
    {
        private const int SALARY_NORMAL_DAY = 50000;
        private const int SALARY_WEEKEND_DAY = 100000;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            lblSalaryNormalDay.Text = Helper.FormatNumber(SALARY_NORMAL_DAY);
            lblSalaryWeekendDay.Text = Helper.FormatNumber(SALARY_WEEKEND_DAY);

            dtpStart.Value = DateTime.Now.AddDays(-1);
            dtpEnd.Value = DateTime.Now.AddDays(1);

            lblTotalSalaryNormal.Text = "0đ";
            lblTotalSalaryWeekend.Text = "0đ";
            lblTotalSalary.Text = "0đ";
            lblTotalDayNormal.Text = "0";
            lblTotalDayWeekend.Text = "0";
        }
    }
}
