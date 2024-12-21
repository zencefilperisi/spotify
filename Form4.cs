using Microsoft.Data.SqlClient;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=.\\SQLEXPRESS; Initial Catalog=spotify; Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connect = new SqlConnection(conString);

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(textBox1.Text))
             {
                MessageBox.Show("Lütfen doğum tarihinizi girin!", "Uyarı");
                return;
             }

             if (textBox1.Text.Length < 4)
             {
                MessageBox.Show("Doğum yılınız 4 haneli olmalı!", "Uyarı");
                return;
             }

            int tarih = Convert.ToInt32(textBox1.Text);
            if (tarih >= 2007)
            {
                label3.Visible = true;
                return;
            }

            if (connect.State == System.Data.ConnectionState.Closed)
             {
                connect.Open();
             }

            string kayit = "insert into kullanici_giris_ekrani (dogum_tarihi) values (@dogumtarihi)";
            SqlCommand komut = new SqlCommand(kayit, connect);

            komut.Parameters.AddWithValue("@dogumtarihi", textBox1.Text);
            komut.ExecuteNonQuery();

            connect.Close();

            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form3sec = new Form3();
            form3sec.Show();
            this.Hide();
        }

        
    }
}
