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
        static string conString = "Data Source=.\\SQLEXPRESS; Initial Catalog=spotify; Integrated Security=True;TrustServerCertificate=True";
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

            if (textBox1.Text != "")
            {
                panel1.Controls.Clear();
                int l = 0;
                connect.Open();
                SqlCommand cmd = new SqlCommand("Select s.sarki_no, s.sarki_adi, s.sanatci_no, s.kapak_foto, s.sarki_yolu, Sa.sanatci_adi from Sarki s, Sanatci Sa where sarki_adi like '" + this.Text + " a%' and Sa.sanatci_no = s.sanatci_no", connect);
                SqlDataReader reader = cmd.ExecuteReader();
                int a = 0;
                while (reader.Read())
                {
                    Label lbl = new Label();
                    lbl.ForeColor = Color.White;
                    lbl.Location = new Point(88, 51 + l);
                    lbl.Name = "lblDinamik";
                    lbl.BackColor = Color.Transparent;
                    lbl.Text = reader["sarki_adi"].ToString().TrimEnd();
                    panel1.Controls.Add(lbl);

                    Label lbl2 = new Label();
                    lbl2.ForeColor = Color.White;
                    lbl2.Location = new Point(88, 74 + l);
                    lbl2.Name = "lbl2Dinamik";
                    lbl2.BackColor = Color.Transparent;
                    lbl2.Text = reader["sanatci_adi"].ToString().TrimEnd();
                    panel1.Controls.Add(lbl2);

                    PictureBox pcbx = new PictureBox();
                    pcbx.Name = "pcbxDinamik";
                    pcbx.Size = new Size(68, 60);
                    pcbx.Location = new Point(3, 37 + l);
                    pcbx.Image = Image.FromFile(reader["kapak_foto"].ToString().TrimEnd());
                    pcbx.SizeMode = PictureBoxSizeMode.StretchImage;
                    panel1.Controls.Add(pcbx);

                    btn = new Button();
                    btn.Font = new Font(btn.Font.FontFamily, 10);
                    btn.Name = "btn" + a;
                    btn.Text = reader["sarki_adi"].ToString().TrimEnd();
                    btn.Size = new Size(59, 53);
                    btn.Location = new Point(75, 48 + l);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                    btn.Click += Btn_Click;
                    panel1.Controls.Add(btn);
                    l += 100;
                    a++;
                }
                connect.Close();
            }
        }
        public void Btn_Click(object sender, EventArgs e)
        {
            Form8 form8sec = new Form8();
            form8sec.Show();
            this.Hide();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
