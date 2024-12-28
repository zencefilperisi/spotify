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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=.\\SQLEXPRESS; Initial Catalog=spotify; Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connect = new SqlConnection(conString);

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            string kayit = "UPDATE kullanici_giris_ekrani SET profil_ismi = @profilismi WHERE profil_ismi is NULL";
            SqlCommand komut = new SqlCommand(kayit, connect);

            komut.Parameters.AddWithValue("@profilismi", textBox1.Text);
            komut.ExecuteNonQuery();

            connect.Close();

            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6sec = new Form6();
            form6sec.Show();
            this.Hide();
        }

    }
}
