using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egg-Save
{
    public partial class Form1 : Form
    {

        bool goleft; 
        bool goright; 

        int speed = 8; 
        int score = 0; 
        int missed = 0; 

        Random rndY = new Random(); 
        Random rndX = new Random(); 

        PictureBox splash = new PictureBox();




        public Form1()
        {
            InitializeComponent();

            reset();

        }

        private void gameTick(object sender, EventArgs e)
        {

            label1.Text = "Kurtarılan : " + score; 
            label2.Text = "Kaçan : " + missed; 

            
            if (goleft == true && chicken.Left > 0)
            {
                
                chicken.Left -= 12;
                
                chicken.Image = Properties.Resources.chicken_normal2;
            }
            
            if (goright == true && chicken.Left + chicken.Width < this.ClientSize.Width)
            {
                
                chicken.Left += 12;
                
                chicken.Image = Properties.Resources.chicken_normal;
            }


            
            foreach (Control X in this.Controls)
            {
                
                if (X is PictureBox && (string)X.Tag == "eggs")

                {
                    
                    X.Top += speed;

                   
                    if (X.Top + X.Height > this.ClientSize.Height)
                    {
                        
                        splash.Image = Properties.Resources.splash; 
                        splash.Location = X.Location; 
                        splash.Height = 59; 
                        splash.Width = 60; 
                        splash.BackColor = System.Drawing.Color.Transparent; 

                        this.Controls.Add(splash); 

                        X.Top = rndY.Next(80, 300) * -1; 
                        X.Left = rndX.Next(5, this.ClientSize.Width - X.Width); 
                        missed++; 
                        chicken.Image = Properties.Resources.chicken_hurt; 
                    }

                    
                    if (X.Bounds.IntersectsWith(chicken.Bounds))
                    {
                        X.Top = rndY.Next(100, 300) * -1; 
                        X.Left = rndX.Next(5, this.ClientSize.Width - X.Width); 
                        score++; 
                    }

                    
                    if (score >= 20)
                    {
                        speed = 16; 
                    }

                    
                    if (missed > 5)
                    {
                        gameTimer.Stop(); 
                        
                        MessageBox.Show("Kaybettin!! İyi yumurtaları kırıdın." + "\r\n" + "Tamam tuşuna bas ve yeniden oyna");
                        
                        reset();
                    }

                }
            }

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                
                goright = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                
                goright = false;
            }

        }

        private void reset()
        {

            
            foreach (Control X in this.Controls)
            {
               
                if (X is PictureBox && (string)X.Tag == "eggs")
                {
                    
                    X.Top = rndY.Next(80, 300) * -1; 
                    X.Left = rndX.Next(5, this.ClientSize.Width - X.Width); 
                }
            }

            chicken.Left = this.ClientSize.Width / 2; 
            chicken.Image = Properties.Resources.chicken_normal2; 

            score = 0; 
            missed = 0; 
            speed = 8; 

            goleft = false; 
            goright = false; 
            gameTimer.Start(); 

        }


    }
}
