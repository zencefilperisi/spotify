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
using System.IO;

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
            baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=spotify; Integrated Security=True; TrustServerCertificate=True");
            LoadSongDetails();
        }

        private void LoadSongDetails()
        {
            try
            {
                if (string.IsNullOrEmpty(this.Text))
                {
                    MessageBox.Show("No song name provided!");
                    return;
                }

                baglanti.Open();
                adaptor = new SqlDataAdapter(
                    "SELECT s.sarki_sozu, s.kapak_foto, sa.sanatci_adi " +
                    "FROM Sarki s " +
                    "INNER JOIN sanatci sa ON s.sanatci_no = sa.sanatci_no " +
                    "WHERE s.sarki_adi = @sarki_adi", baglanti);

                adaptor.SelectCommand.Parameters.AddWithValue("@sarki_adi", this.Text);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);

                if (tablo.Rows.Count > 0)
                {
                    string kapakFoto = tablo.Rows[0]["kapak_foto"]?.ToString();
                    if (!string.IsNullOrEmpty(kapakFoto) && File.Exists(kapakFoto))
                    {
                        pictureBox1.ImageLocation = kapakFoto;
                    }
                    else
                    {
                        // Fallback to hardcoded paths if database path doesn't exist
                        if (this.Text == "§1" || this.Text == "§4")
                        {
                            pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\spotify\\S_opeth.jpg";
                        }
                        else if (this.Text == "To Bid You Farewell")
                        {
                            pictureBox1.ImageLocation = "C:\\Users\\User\\Desktop\\spotify\\opeth_toBidYouFarewell.jpg";
                        }
                    }

                    richTextBox1.Text = tablo.Rows[0]["sarki_sozu"]?.ToString() ?? "No lyrics available";
                    string artistName = tablo.Rows[0]["sanatci_adi"]?.ToString();
                    this.Text = $"{this.Text} - {artistName}";  // Show artist name in form title
                }
                else
                {
                    MessageBox.Show($"Could not find details for song: {this.Text}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading song details: {ex.Message}");
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSongDetails();
        }
    }
}