﻿using System;
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
    public partial class Eläimet : Form
    {
        public Eläimet()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
