using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spotify
{
    public partial class Form5 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=spotify; Integrated Security=True;TrustServerCertificate=True");

        bool isThere;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string e_mail = txt_eposta.Text;
            string kullanici_adi = txt_eposta.Text;
            string parola = txt_parola.Text;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from kullanici_giris_ekrani", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if ((kullanici_adi) == reader["kullanici_adi"].ToString().TrimEnd() || e_mail == reader["e_mail"].ToString().TrimEnd() && parola == reader["parola"].ToString().TrimEnd())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }
            }
            connection.Close();
            if (isThere)
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("kullanıcı adınız veya şifrenizi yanlış girdiniz.", "Hata");
            }
        }
    }
}
