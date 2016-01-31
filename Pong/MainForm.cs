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
        public int score;
        public int speed_left, speed_top;
        bool left, right;
        bool pause = false;
        bool gameover = true;
        Random rnd = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        #region Constructor
        public void StartGame()
        {
            MainTimer.Enabled = true;
            gameover = false;
            lblPause1.Visible = false;
            lblPause2.Visible = false;
            lblStartE.Visible = false;
            lblGameOverScore.Visible = false;
            lblGameOver.Visible = false;
            score = 0;
            speed_left = 1; 
            speed_top = 5;

            ItemRacket.Top = BackgrowndPanel.Bottom - (BackgrowndPanel.Bottom / 10);    //Set position of racket
            ItemRacket.Left = (BackgrowndPanel.Right - ItemRacket.Width) / 2;
            ItemBall.Top = BackgrowndPanel.Top + (BackgrowndPanel.Bottom / 10);         //Set position of ball
            ItemBall.Left = (BackgrowndPanel.Right - ItemBall.Width) / 2;
        }
        #endregion

        #region Game logic
        private void MainTimer_Tick(object sender, EventArgs e)
        { 
            if (left) if (ItemRacket.Left - 15 >= BackgrowndPanel.Left) ItemRacket.Left -= 15;
            if (right) if (ItemRacket.Right + 15 <= BackgrowndPanel.Right) ItemRacket.Left += 15;

            if (ItemBall.Bottom >= ItemRacket.Top && ItemBall.Left >= ItemRacket.Left - 12 && ItemBall.Right <= ItemRacket.Right + 12)
            {
                if (ItemBall.Left <=(ItemRacket.Left + (ItemRacket.Width / 3)) - 12)    //if ball collision with coners
                {
                    if (speed_left < 13 && speed_left > -13) speed_left -= 2;
                }
                else if(ItemBall.Right >=(ItemRacket.Left + 2 * (ItemRacket.Width / 3)) + 12)
                {
                    if (speed_left < 13 && speed_left > -13) speed_left += 2;
                }                                                                   

                speed_top += 1;
                speed_top = -speed_top;
                score += 1;
                BackgrowndPanel.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            }

            if (ItemBall.Top <= BackgrowndPanel.Top) speed_top = -speed_top;
            if (ItemBall.Left <= 0 || ItemBall.Right >= BackgrowndPanel.Right) speed_left = -speed_left;
            if (ItemBall.Bottom >= BackgrowndPanel.Bottom - 26)
            {
                MainTimer.Enabled = false;
                lblGameOverScore.Text = Convert.ToString(score);
                lblGameOverScore.Visible = true;
                lblGameOver.Visible = true;
            }


            ScoreStrip.Text = Convert.ToString(score);
            ItemBall.Left += speed_left;
            ItemBall.Top += speed_top;
        }

        public void Pause()
        {
            pause = true;
            MainTimer.Enabled = false;
            lblPause1.Visible = true;
            lblPause2.Visible = true;
        }

        public void Resume()
        {
            pause = false;
            MainTimer.Enabled = true;
            lblPause1.Visible = false;
            lblPause2.Visible = false;
        }
        #endregion

        #region Buttons' actions
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
            if (e.KeyCode == Keys.Enter && gameover) StartGame();
            if (e.KeyCode == Keys.Left) left = true;
            if (e.KeyCode == Keys.Right) right = true;
            if (e.KeyCode == Keys.P && !(gameover))
            {
                if (pause) Resume();
                else Pause();
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) left = false;
            if (e.KeyCode == Keys.Right) right = false;
        }
        #endregion

        #region Strip menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void MaincontextMenu_Opened(object sender, EventArgs e)
        {
            if (!gameover) Pause();
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gameover) Resume();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new About()).Show();
        }
        #endregion
    }
}


