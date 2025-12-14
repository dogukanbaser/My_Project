using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tıkla_Patlat
{
    public partial class Form1 : Form
    {


        

        bool isGameOver;
        readonly Random rand = new Random();
        readonly List<PictureBox> items = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
        }

        
            private void MakePictureBox()
        {

            PictureBox newPic = new PictureBox
            {
                Height = 30,
                Width = 30,
                BackColor = Color.Maroon
            };



            int x = rand.Next(10, this.ClientSize.Width - newPic.Width);
            int y = rand.Next(10, this.ClientSize.Height - newPic.Height);
            newPic.Location = new Point(x, y);

            newPic.Click += NewPic_Click;

            items.Add(newPic );

            this.Controls.Add(newPic );


            }


        


        private void NewPic_Click(object sender, EventArgs e)
        {



            PictureBox temPic = sender as PictureBox;

            items.Remove(temPic);

            this.Controls.Remove(temPic);

            lblItemCount.Text = "Kare: " + items.Count();

            
            


        }

        private void TimerEvent(object sender, EventArgs e)
        {
            MakePictureBox();

            lblItemCount.Text = "Kare: " + items.Count();


            if (items.Count == 1)
            {


                MakePictureBox();

            }

            if (items.Count == 2)
            {


                MakePictureBox();

            }

            if (items.Count == 3)
            {


                MakePictureBox();

            }

            if (items.Count == 5)
            {


                MakePictureBox();

            }


            if (items.Count == 4)
            {


                MakePictureBox();

            }



            if ( items.Count == 10 )
            {

                
                GameOver();
               
            }


        }

        private void Kesisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {

                Menü oyun = new Menü();
                oyun.Show();
                this.Hide();





            }


          


        }

        

        private void GameOver()
        {
            

            isGameOver = true;
            GameTimer.Stop();
            lblItemCount.Text += Environment.NewLine + "Oyun Bitti!!" + Environment.NewLine + "Enter tuşuna bas ve Menüye dön ";

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
