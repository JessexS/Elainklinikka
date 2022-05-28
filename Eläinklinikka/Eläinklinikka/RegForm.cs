using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Eläinklinikka
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + Application.StartupPath + "/Eläinklinikka.mdb";
            OleDbConnection dbcon = new OleDbConnection(constr);
            OleDbCommand cmd = dbcon.CreateCommand();
            dbcon.Open();
            cmd.CommandText = "INSERT INTO Udata ( Uname, Pword, Pnumber ) Values ('" + Uname.Text + "','" + Pword.Text + "','" + Pnumber.Text + "')";
            cmd.Connection = dbcon;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Käyttäjä rekisteröity!");
            dbcon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainWindow w1 = new MainWindow();
            this.Hide();
            w1.ShowDialog();
            this.Close();
        }
    }
}
