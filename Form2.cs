using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spotify
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=.\\SQLEXPRESS; Initial Catalog=spotify; Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connect = new SqlConnection(conString);
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Lütfen e-posta adresinizi girin.", "Uyarı");
                    return;
                }

            connect.Open();

                string kayit = "insert into kullanici_giris_ekrani (e_mail) values(@mail)";
                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@mail", textBox1.Text);
                komut.ExecuteNonQuery();

                connect.Close();
                Form3 form3 = new Form3();  // Go to Form3 for additional registration steps
                form3.Show();
                this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
