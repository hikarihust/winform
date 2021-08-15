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

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (dtpEnd.Value.Date <= dtpStart.Value.Date)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Thông báo");
            }
            else
            {

                int totalDay = (dtpEnd.Value - dtpStart.Value).Days; // normal (2-6) + weekend (t7 cn)
                int totalDayWeekend = CountWeekEnds(dtpStart.Value, dtpEnd.Value);
                int totalDayNormal = totalDay - totalDayWeekend;

                if (chkWeekend.Checked == false)
                {
                    totalDayWeekend = 0;
                }

                lblTotalDayWeekend.Text = totalDayWeekend + "";
                lblTotalDayNormal.Text = totalDayNormal + "";
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEnd.Value.Date <= dtpStart.Value.Date)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Thông báo");
            }
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

        private static int CountWeekEnds(DateTime startDate, DateTime endDate)
        {
            int weekendCount = 0;

            int totalDay = (endDate - startDate).Days; // normal (2-6) + weekend (t7 cn)

            for (int i = 0; i <= totalDay; i++)
            {
                var tmpDate = startDate.AddDays(i);
                if (tmpDate.DayOfWeek == DayOfWeek.Saturday || tmpDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    weekendCount += 1;
                }
            }

            return weekendCount;
        }
    }
}
