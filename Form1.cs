using Microsoft.Data.SqlClient;
namespace spotify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //static string constring = "Data Source=hatice\\SQLEXPRESS; Initial Catalog=spotify; Integrated Security=TRUE";
        //SqlConnection connect = new SqlConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5sec = new Form5();
            form5sec.Show();
            this.Hide();
        }
    }
}