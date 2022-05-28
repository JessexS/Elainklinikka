using System;
using System.Windows.Forms;
using ClosedXML;
using ClosedXML.Excel;
using System.Data;

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
            Omistajat e1 = new Omistajat();
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

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void create()
        {
            var wb = new XLWorkbook();
            var dataSet = GetDataSet();
            wb.Worksheets.Add(dataSet);
            wb.SaveAs("Eläinklinikka.xlsx");
            // Add all DataTables in the DataSet as a worksheets 
        }

        private DataSet GetDataSet()
        {
            var ds = new DataSet();
            ds.Tables.Add(GetTable("MaksuTable"));
            return ds;
        }

        private DataTable GetTable(String tableName)
        {
            DataTable table = new DataTable();
            table.TableName = tableName;
            table.Columns.Add("Eläimen nimi", typeof(string));
            table.Columns.Add("Omistajan nimi", typeof(string));
            table.Columns.Add("Laskun päivämäärä", typeof(DateTime));
            table.Columns.Add("Lääkkeet ja hoito", typeof(string));
            table.Columns.Add("Kokonaissumma", typeof(int), "€");

            table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
            return table;
        }
    }
    }
