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
    public partial class HoitoJaLääkkeet : Form
    {
        public HoitoJaLääkkeet()
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Omistajat o1 = new Omistajat();
            this.Hide();
            o1.ShowDialog();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MainWindow w1 = new MainWindow();
            this.Hide();
            w1.ShowDialog();
            this.Close();
        }
    }
}
