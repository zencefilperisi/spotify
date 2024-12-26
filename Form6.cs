using System;
using Microsoft.Data.SqlClient;
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
    public partial class Form6 : Form
    {
        static string conString = "Data Source=.\\SQLEXPRESS; Initial Catalog=spotify; Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connect = new SqlConnection(conString);

        public Form6()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4sec = new Form4();
            form4sec.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertGender("Kadın");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InsertGender("Erkek");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InsertGender("Diğer");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InsertGender("Belirtilmemiş");
        }

        private void InsertGender(string gender)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

                // First, find the most recent record with NULL cinsiyet
                string findQuery = @"UPDATE kullanici_giris_ekrani 
                                   SET cinsiyet = @cinsiyet 
                                   WHERE id = (
                                       SELECT TOP 1 id 
                                       FROM kullanici_giris_ekrani 
                                       WHERE cinsiyet IS NULL 
                                       ORDER BY id DESC
                                   )";

                SqlCommand komut = new SqlCommand(findQuery, connect);
                komut.Parameters.AddWithValue("@cinsiyet", gender);
                int affected = komut.ExecuteNonQuery();

                connect.Close();

                if (affected > 0)
                {
                    Form7 form7sec = new Form7();
                    form7sec.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kayıt güncellenemedi. Lütfen tekrar deneyin.", "Uyarı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata");
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }
    }
}

