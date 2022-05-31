using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
namespace Eläinklinikka
{
    public partial class Kalenteri : Form
    {
        private const string V = ",";
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + Application.StartupPath + "/Eläinklinikka.mdb");
        public Kalenteri()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

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
            Omistajat e1 = new Omistajat();
            this.Hide();
            e1.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HoitoJaLääkkeet e1 = new HoitoJaLääkkeet();
            this.Hide();
            e1.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Lääkärit e1 = new Lääkärit();
            this.Hide();
            e1.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MainWindow e1 = new MainWindow();
            this.Hide();
            e1.ShowDialog();
            this.Close();
        }

        private void gunaTallenna_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Käynnit (Omistajan_nimi, Eläimen_nimi, Varattu_aika )values(" + gunaAjan.Text + "," + gunaEnimi.Text + "," + gunaAika.Text + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Tallennettu...");
        }

        private void gunaPoista_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Delete From Käynnit where Varattu_aika=" + gunaAika.Text + " ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Poistettu...");
        }
    }
}
