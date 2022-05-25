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
<<<<<<<< HEAD:Eläinklinikka/Eläinklinikka/LogForm.cs
    public partial class LogForm : Form
    {
        public LogForm()
========
    public partial class Eläimet : Form
    {
        public Eläimet()
>>>>>>>> d5438fe73e810b5a1ad5ed6fc969756016e10717:Eläinklinikka/Eläinklinikka/Eläimet.cs
        {
            InitializeComponent();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }

<<<<<<<< HEAD:Eläinklinikka/Eläinklinikka/LogForm.cs
        private void button2_Click(object sender, EventArgs e)
        {
            MainWindow m1 = new MainWindow();
            m1.ShowDialog(); // Avaa Main Windowin
            this.Hide();
========
        private void label2_Click(object sender, EventArgs e)
        {

>>>>>>>> d5438fe73e810b5a1ad5ed6fc969756016e10717:Eläinklinikka/Eläinklinikka/Eläimet.cs
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MainWindow w1 = new MainWindow();
            this.Hide();
            w1.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Omistajat o1 = new Omistajat();
            this.Hide();
            o1.ShowDialog();
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
