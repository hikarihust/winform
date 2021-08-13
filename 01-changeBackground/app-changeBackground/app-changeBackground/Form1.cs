using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_changeBackground
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lblTitle.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            lblTitle.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            changeLabelTitleBackground(Color.Green);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            changeLabelTitleBackground(Color.Blue);
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            changeLabelTitleBackground(Color.Yellow);
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            changeLabelTitleBackground(Color.Red);
        }

        public void changeLabelTitleBackground(Color color)
        {
            lblTitle.BackColor = color;
            Random rnd = new Random();
            lblTitle.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }
    }
}
