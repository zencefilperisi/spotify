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
    public partial class Ara : Form
    {
        static string conString = "Data Source=.\\SQLEXPRESS; Initial Catalog=spotify; Integrated Security=True; TrustServerCertificate=True; Encrypt=False";
        SqlConnection connect = new SqlConnection(conString);

        Button btn;
        public Ara()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            profil profilsec = new profil();
            profilsec.Show();
            this.Hide();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    panel1.Controls.Clear();
                    int l = 0;

                    // Make sure connection is closed before opening
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                    connect.Open();

                    SqlCommand cmd = new SqlCommand(
                        "SELECT s.sarki_no, s.sarki_adi, s.sanatci_no, s.kapak_foto, s.sarki_yolu, Sa.sanatci_adi " +
                        "FROM [dbo].[sarki] s " +
                        "INNER JOIN [dbo].[sanatci] Sa ON Sa.sanatci_no = s.sanatci_no " +
                        "WHERE s.sarki_adi LIKE @searchTerm OR Sa.sanatci_adi LIKE @searchTerm", connect);

                    cmd.Parameters.AddWithValue("@searchTerm", "%" + textBox1.Text + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int a = 0;
                        while (reader != null && reader.Read())
                        {
                            var sarki_adi = reader["sarki_adi"]?.ToString()?.TrimEnd() ?? "";
                            var sanatci_adi = reader["sanatci_adi"]?.ToString()?.TrimEnd() ?? "";
                            var kapak_foto = reader["kapak_foto"]?.ToString()?.TrimEnd() ?? "";

                            Label lbl = new Label();
                            lbl.ForeColor = Color.White;
                            lbl.Location = new Point(88, 51 + l);
                            lbl.Name = "lblDinamik";
                            lbl.BackColor = Color.Transparent;
                            lbl.Text = sarki_adi;
                            panel1.Controls.Add(lbl);

                            Label lbl2 = new Label();
                            lbl2.ForeColor = Color.White;
                            lbl2.Location = new Point(88, 74 + l);
                            lbl2.Name = "lbl2Dinamik";
                            lbl2.BackColor = Color.Transparent;
                            lbl2.Text = sanatci_adi;
                            panel1.Controls.Add(lbl2);

                            PictureBox pcbx = new PictureBox();
                            pcbx.Name = "pcbxDinamik";
                            pcbx.Size = new Size(68, 60);
                            pcbx.Location = new Point(3, 37 + l);
                            if (File.Exists(kapak_foto))
                            {
                                pcbx.Image = Image.FromFile(kapak_foto);
                            }
                            pcbx.SizeMode = PictureBoxSizeMode.StretchImage;
                            panel1.Controls.Add(pcbx);

                            btn = new Button();
                            btn.Font = new Font(btn.Font.FontFamily, 10);
                            btn.Name = "btn" + a;
                            btn.Text = sarki_adi;
                            btn.Size = new Size(300, 80);
                            btn.Location = new Point(75, 37 + l);
                            btn.FlatStyle = FlatStyle.Flat;
                            btn.FlatAppearance.BorderSize = 0;
                            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                            btn.BackColor = Color.Transparent;
                            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
                            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
                            btn.Cursor = Cursors.Hand;

                            btn.Click += Btn_Click;
                            panel1.Controls.Add(btn);
                            btn.BringToFront();
                            lbl.BringToFront();
                            lbl2.BringToFront();

                            l += 100;
                            a++;
                        }
                    }
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }
        public void Btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Form8 form8sec = new Form8();
            form8sec.Text = clickedButton.Text;
            form8sec.Show();
            this.Hide();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
