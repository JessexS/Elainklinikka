using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

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
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + Application.StartupPath + "/Eläniklinikka.mdb";
            OleDbConnection dbcon = new OleDbConnection(constr);
            OleDbCommand cmd = dbcon.CreateCommand();
            dbcon.Open();
            cmd.CommandText = "INSERT INTO Udata (Uname, Pword, Pnumber) Values('" + Uname.Text + "','" + Pword.Text + "','" + Pnumber.Text + "')";
            cmd.Connection = dbcon;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully");
            dbcon.Close();
        }
    }
}
