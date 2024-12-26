using Microsoft.Data.SqlClient;
using System.Media;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlDataAdapter adaptor = new SqlDataAdapter();
        int sayac;
        SoundPlayer ses = new SoundPlayer();
        private void Form8_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=spotify; Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            adaptor = new SqlDataAdapter("select sarki_sozu from Sarki", baglanti);
            DataTable tablo = new DataTable();
            adaptor.Fill(tablo);

            baglanti.Close();

            baglanti.Open();
            SqlCommand baglanti1=new SqlCommand("select 'sarki_suresi' = (select sarki_sozu from Sarki where sarki_yolu='"+this.Text);

            if(this.Text== "§1")
            {
                pictureBox1.ImageLocation = this.Text + "C:\\Users\\User\\Desktop\\spotify\\S_opeth.jpg";
                richTextBox1.Text = tablo.Rows[0]["sarki_sozu"].ToString();
                baglanti.Close();
            }
            if(this.Text== "§4")
            {
                pictureBox1.ImageLocation = this.Text + "C:\\Users\\User\\Desktop\\spotify\\S_opeth.jpg";
                richTextBox1.Text = tablo.Rows[1]["sarki_sozu"].ToString();
                baglanti.Close();
            }
            if(this.Text=="To Bid You Farewell")
            {
                pictureBox1.ImageLocation = this.Text + "C:\\Users\\User\\Desktop\\spotify\\opeth_toBidYouFarewell.jpg";
                richTextBox1.Text = tablo.Rows[2]["sarki_sozu"].ToString();
                baglanti.Close();
            }
        }
    }
}
