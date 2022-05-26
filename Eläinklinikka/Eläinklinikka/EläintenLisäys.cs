using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
        
namespace Eläinklinikka
{
    public partial class EläintenLisäys : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\peura\source\repos\Elainklinikka\Eläinklinikka\Eläinklinikka\Eläinklinikka\Eläinklinikka.mdb");
        public EläintenLisäys()
        {
            InitializeComponent();
        }

        private void btnLisää_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Eläin (EläimenID, Eläimen_nimi, Omistajan_nimi, Syntymäpäivä, Laji, Tila, Varattu_aika)values('"+txtID.Text+"',"+txtNimi.txt
                +"',"+txtOnimi.Text+"',"+txtSynty.Text+"',"+txtLaji+"',"+txtTila.Text+"',"+txtAika.Text+")", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Lisätty..");

            fillgrid();

        }
        void fillgrid()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * From Eläin Order By EläimenID",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();    
        }

        private void btnPäivitä_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Update Eläin Set EläimenID='" + txtID.Text + "', Eläimen_nimi='" + txtNimi.Text + "', Omistajan_nimi='" + txtOnimi.Text + "', Syntymäpäivä='" + txtSynty.Text + "', Laji='" + txtLaji.Text + "', Tila='" + txtTila.Text + "', Varattu_aika='" + txtAika.Text" ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Päivitetty..");
            
            fillgrid();
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Delete From Eläin where EläimenID=" + txtID.Text + " ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Poistettu..");


            fillgrid();
        }
    }
}
