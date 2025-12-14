using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brick_Crash_Game
{
    public partial class Form1 : Form
    {

        bool goLeft;
        bool goRight;
        bool isGameOver;

        int score;
        int ballx;
        int bally;
        int playerspeed;

        Random rand = new Random();

        /*
        PictureBox[] blockArray;
        */

        public Form1()
        {
            InitializeComponent();

            setupGame();

        }


        private void setupGame()
        {
            
            isGameOver = false;
            

            score = 0;
            ballx = 5;
            bally = 5;
            playerspeed = 15;
            txtskor.Text = "Skor: " + score;

            gameTimer.Start();


            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "blocks")
                {

                    x.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                }

            }


        }



        private void gameOver(string massage)
        {


            isGameOver = true;
            gameTimer.Stop();

            txtskor.Text = "Skor: " + score + "  " + massage;


        }

        /*
        private void PlaceBlocks()
        {

            blockArray = new PictureBox[15];

            int a = 0;
            int top = 50;
            int left = 100;


            for (int i = 0; i < blockArray.Length; i++)
            {

                blockArray[i] = new PictureBox();
                blockArray[i].Height = 32;
                blockArray[i].Width = 100;
                blockArray[i].Tag = "blocks";
                blockArray[i].BackColor = Color.White;


                if (a == 0)
                {

                    top = top + 50;
                    left = 100;

                    a = 0;

                }

                if (a < 5)
                {

                    a++;
                    blockArray[i].Left = left;
                    blockArray[i].Top = top;

                    this.Controls.Add(blockArray[i]);

                    left = left + 130;

                }



            }

            setupGame();



        }


        private void removeBlock()
        {

            foreach(PictureBox x in blockArray)
            {

                this.Controls.Remove(x);

            }

        }
        
        */

        private void Oyunzamanıolayı(object sender, EventArgs e)
        {

            txtskor.Text = "Skor: " + score;

            if(goLeft == true && player.Left > 0)
            {

                player.Left -= playerspeed;

            }

            if(goRight == true && player.Left < 470)
            {

                player.Left += playerspeed;

            }

            ball.Left += ballx;
            ball.Top += bally;

            if(ball.Left < 0 || ball.Left > 570)
            {

                ballx = -ballx;

            }

            if(ball.Top < 0)
            {

                bally = -bally;

            }

            if(ball.Bounds.IntersectsWith(player.Bounds))
            {

                bally = rand.Next(5, 12) * -1;

                if(ballx < 0)
                {

                    ballx = rand.Next(5, 12) * -1;

                }

                else
                {

                    ballx = rand.Next(5, 12);

                }

            }

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "blocks")
                {

                    if(ball.Bounds.IntersectsWith(x.Bounds))
                    {

                        score += 1;

                        bally = -bally;

                        this.Controls.Remove(x);

                    }

                }

            }


            if(score == 15)
            {

                gameOver(" Kazandın !! Enter tuşuna bas ve yeniden oyna");

            }

            if(ball.Top > 450 )
            {

                gameOver(" Kaybettin !!Enter tuşuna bas ve yeniden oyna");

            }



        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Left)
            {

                goLeft = true;

            }

            if(e.KeyCode == Keys.Right)
            {

                goRight = true;

            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {

                goLeft = false;

            }

            if (e.KeyCode == Keys.Right)
            {

                goRight = false;

            }

            if(e.KeyCode == Keys.Enter && isGameOver == true )
            {


                Form1 oyun = new Form1();
                    oyun.Show();  // form2 göster diyoruz
                    this.Hide();

                

                setupGame();

                /*
                removeBlock();
                PlaceBlocks();
                */
            }

        }
    }
}
