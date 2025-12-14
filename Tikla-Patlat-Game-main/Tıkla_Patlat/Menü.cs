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
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Form1 oyun = new Form1();
            oyun.Show();  
            this.Hide();
        }

        private void Menü_Load(object sender, EventArgs e)
        {

        }
    }
}
