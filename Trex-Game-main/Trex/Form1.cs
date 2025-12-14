using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trex_Game
{
    public partial class Form1 : Form
    {

        bool jumping = false;
        int jumpSpeed = 12;
        int force = 12;
        int score = 0;
        int engelhızı = 10;
        Random rand = new Random();
        int pozition;
        bool isGameOver = false;




        public Form1()
        {
            InitializeComponent();

            GameReset();

        }

        private void oyunsüresiolayı(object sender, EventArgs e)
        {

            trex.Top += jumpSpeed;

            txtSkor.Text = "Skor: " + score;

            if(jumping == true && force < 0)
            {

                jumping = false;

            }

            if(jumping == true)
            {

                jumpSpeed = -12;
                force -= 1;

            }

            else
            {

                jumpSpeed = 12;

            }

            if(trex.Top > 295 && jumping == false)
            {

                force = 12;
                trex.Top = 295;
                jumpSpeed = 0;

            }

            foreach(Control x in this.Controls)
            {

                if(x is PictureBox && (string)x.Tag == "engel")
                {

                    x.Left -= engelhızı;

                    if(x.Left < -100)
                    {

                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);

                        score++;

                    }

                    if(trex.Bounds.IntersectsWith(x.Bounds))
                    {

                        gametimer.Stop();
                        trex.Image = Properties.Resources.dead;
                        txtSkor.Text += " Lütfen R tuşuna basın ve yeniden oynayın!!";
                        isGameOver = true;

                    }





                }

            }

            if(score < 10)
            {

                engelhızı = 15;

            }

            if (score < 20)
            {

                engelhızı = 20;

            }


        }

        private void keyisup(object sender, KeyEventArgs e)
        {

            if ( jumping == true)
            {

                jumping = false;

            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {

                GameReset();

            }

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Space && jumping == false)
            {

              jumping = true;

            }

        }

        private void GameReset()
        {

          force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            engelhızı = 10;
            txtSkor.Text = "Skor: " + score;
            trex.Image = Properties.Resources.running;
            isGameOver = false;
            trex.Top = 367;





            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "engel")
                {
                    pozition = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

                    x.Left = pozition;
                 }


            }

            gametimer.Start();



        }

    }
}
