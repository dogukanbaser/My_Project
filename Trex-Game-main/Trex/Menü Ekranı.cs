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
    public partial class Menü_Ekranı : Form
    {
        public Menü_Ekranı()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            Form1 oyun = new Form1();
            oyun.Show();  // form2 göster diyoruz
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
