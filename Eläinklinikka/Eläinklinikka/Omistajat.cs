using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Eläinklinikka
{
    public partial class Omistajat : Form
    {
        private const string V = ",";
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + Application.StartupPath + "/Eläinklinikka.mdb");
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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
            Kalenteri e1 = new Kalenteri();
            this.Hide();
            e1.ShowDialog();
            this.Close();
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
            OleDbCommand cmd = new OleDbCommand("Insert into Omistaja (Omistajan_nimi, Sähköposti, Eläimen_nimi, Osoite, Puhelin)values(" + gunaOnimi.Text + "," + gunaSposti.Text + "," + gunaOeläin.Text + "," + gunaOsoite.Text + V + gunaPnume.Text + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Tallennettu...");

            fillgrid(); 
        }
        void fillgrid()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Omistaja order by Omistajan_nimi", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void gunaPäivitä_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Update Omistaja set Omistajan_nimi='" + gunaOnimi.Text + "', Eläimen_nimi='" + gunaOeläin.Text + "', Osoite='" + gunaOsoite.Text + "', Sähköposti='" + gunaSposti.Text + "', Puhelin='" + gunaPnume.Text + " where Omistajan_nimi '" + gunaOnimi.Text + " ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Päivitetty...");

            fillgrid();
        }

        private void gunaPoista_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Delete From Omistaja where Omistajan_nimi=" + gunaOnimi.Text + " ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Poistettu...");

            fillgrid();

        }
    }
}
