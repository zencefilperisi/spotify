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

        private void button11_Click(object sender, EventArgs e)
        {
            profil profilsec = new profil();
            profilsec.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            daylist daylistsec = new daylist();
            daylistsec.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            birdaha birdahasec = new birdaha();
            birdahasec.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            eskifavoriler eski = new eskifavoriler();
            eski.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Ara arabuton = new Ara();
            arabuton.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Kitaplığın kitaplık = new Kitaplığın();
            kitaplık.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
