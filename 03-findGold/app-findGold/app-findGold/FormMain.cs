using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_findGold
{
    public partial class FormMain : Form
    {
        private string[] pictures = { "boom", "gold" };
        private int score = 0;
        private const int SCORE_CLICK_BOOM = 5;
        private const int SCORE_CLICK_GOLD = 10;

        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox currentPictureBox = sender as PictureBox;

            Random random = new Random();
            var randomIndex = random.Next(0, pictures.Length); // 0 - 1

            if (pictures[randomIndex].Equals("boom"))
            {
                currentPictureBox.Image = Properties.Resources.boom;
                score -= SCORE_CLICK_BOOM;
            }
            else if (pictures[randomIndex].Equals("gold"))
            {
                currentPictureBox.Image = Properties.Resources.gold;
                score += SCORE_CLICK_GOLD;
            }

            currentPictureBox.Enabled = false;
            lblScore.Text = score + "";
        }
    }
}
