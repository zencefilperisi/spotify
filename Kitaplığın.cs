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
    public partial class Kitaplığın : Form
    {
        public Kitaplığın()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            profil profilsec = new profil();
            profilsec.Show();
            this.Hide();
        }
    }
}
