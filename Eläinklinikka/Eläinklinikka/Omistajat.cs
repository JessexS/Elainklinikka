using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eläinklinikka
{
    public partial class Omistajat : Form
    {
        public Omistajat()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Eläimet e1 = new Eläimet();
            this.Hide();
            e1.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HoitoJaLääkkeet h1 = new HoitoJaLääkkeet();
            this.Hide();
            h1.ShowDialog();
            this.Close();
        }
    }
}
