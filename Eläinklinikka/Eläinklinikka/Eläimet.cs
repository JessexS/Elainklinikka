using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Eläinklinikka
{
    public partial class Eläimet : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + Application.StartupPath + "/Eläinklinikka.mdb");
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Lääkärit l1 = new Lääkärit();
            this.Hide();
            l1.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Kalenteri k1 = new Kalenteri();
            this.Hide();
            k1.ShowDialog();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MainWindow m1 = new MainWindow();
            this.Hide();
            m1.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaTallenna_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Eläin ( Eläimen_nimi, Omistajan_nimi, Syntymäpäivä, Laji, Tila, Sairaudet, Lääkkeet ) Values(" + gunaNimi.Text + "," + gunaTila.Text + ",'" + gunaAika.Text + "," + gunaLaji.Text + "," + gunaTila.Text + ")", con);
            cmd.ExecuteNonQuery();
            //cmd = new OleDbCommand("Insert into Hoito (Sairaudet, Lääkkeet)Values('" + gunaSairaudet.Text + "','" + gunaLääkitys.Text + ")", con);
            //cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Tallennettu...");

            fillgrid();
        }

        void fillgrid()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select Eläimen_nimi, Omistajan_nimi, Syntymäpäivä, Laji, Tila from Eläin order by Eläimen_nimi", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}