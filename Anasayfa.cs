using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spotify
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.LimeGreen;
            button2.ForeColor = Color.Black;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            liste1 liste1 = new liste1();
            liste1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            liste2 liste2 = new liste2();
            liste2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            liste3 liste3 = new liste3();
            liste3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            liste4 liste4 = new liste4();
            liste4.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            liste5 liste5 = new liste5();
            liste5.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            liste6 liste6 = new liste6();
            liste6.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            liste7 liste7 = new liste7();
            liste7.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            liste8 liste8 = new liste8();
            liste8.Show();
            this.Hide();
        }
    }
}
