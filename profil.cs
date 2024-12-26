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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace spotify
{
    public partial class profil : Form
    {
        public profil()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=.\\SQLEXPRESS; Initial Catalog=spotify; Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connect = new SqlConnection(conString);

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Show();
            this.Hide();
        }
        private void profil_Load(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand cmd = new SqlCommand("Select * from kullanici_giris_ekrani", connect);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label1.Text = reader["profil_ismi"].ToString().TrimEnd();
            }
            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
