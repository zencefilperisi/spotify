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
    public partial class Form3 : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=spotify; Integrated Security=True;TrustServerCertificate=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Lütfen parola girin.", "Uyarı");
                    return;
                }

                if (textBox1.Text.Length < 10)
                {
                    MessageBox.Show("Parola en az 10 karakter olmalıdır.", "Uyarı");
                    return;
                }

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                string update = "UPDATE kullanici_giris_ekrani SET parola = @parola WHERE parola IS NULL";
                SqlCommand cmd = new SqlCommand(update, connection);

                cmd.Parameters.AddWithValue("@parola", textBox1.Text);
                int affected = cmd.ExecuteNonQuery();   // insert, update, delete olaylarından sonra etkilenen satır sayısını int tipinde döndürür

                connection.Close();

                if (affected > 0)
                {
                    MessageBox.Show("Kayıt başarılı!", "Bilgi");
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kayıt işlemi başarısız. Lütfen tekrar deneyin.", "Hata");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt hatası: " + hata.Message, "Hata");
            }
        }
    }
}
