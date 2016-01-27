using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class MainForm : Form
    {

        public int score = 0;
        public int speed_left = 1, speed_top = 5;
        public MainForm()
        {
            InitializeComponent();
            MainTimer.Enabled = true;

            /*Few features
            this.TopMost = true;    //Bring form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds   //make it fullscreen
            */

            ItemRacket.Top = BackgrowndPanel.Bottom - (BackgrowndPanel.Bottom / 10);  //Set position of racket
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        { 
            if (ItemBall.Bottom >= ItemRacket.Top && ItemBall.Left >= ItemRacket.Left && ItemBall.Right <= ItemRacket.Right)
            {
                if (ItemBall.Left <= (ItemRacket.Left + (ItemRacket.Width / 3)))    //if ball collision with coners
                {
                    if (speed_left < 13 && speed_left > -13) speed_left -= 2;
                }
                else if(ItemBall.Right >= (ItemRacket.Left + 2 * (ItemRacket.Width / 3)))
                {
                    if (speed_left < 13 && speed_left > -13) speed_left += 2;
                }                                                                   

                speed_top += 1;
                speed_top = -speed_top;
                score += 1;
            }

            if (ItemBall.Top <= BackgrowndPanel.Top) speed_top = -speed_top;
            if (ItemBall.Left <= 0 || ItemBall.Right >= BackgrowndPanel.Right) speed_left = -speed_left;
            if (ItemBall.Bottom >= BackgrowndPanel.Bottom - 26) MainTimer.Enabled = false;


            ScoreStrip.Text = Convert.ToString(score);
            ItemBall.Left += speed_left;
            ItemBall.Top += speed_top;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
            if (e.KeyCode == Keys.Left) ItemRacket.Left -= 15;
            if (e.KeyCode == Keys.Right) ItemRacket.Left += 15;
        }
    }
}
