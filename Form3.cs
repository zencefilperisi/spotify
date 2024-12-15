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

        SqlConnection connection = new SqlConnection("Data Source=hatice\\SQLEXPRESS; Initial Catalog=spotify; Integrated Security=True;TrustServerCertificate=True");
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

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
