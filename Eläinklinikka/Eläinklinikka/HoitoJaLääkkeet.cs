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
        

        int i = 0;

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            
            HoitoData.Rows.Add();
            HoitoData.Rows[i].Cells[0].Value = EläimenNimi.Text;
            HoitoData.Rows.Add();
            HoitoData.Rows[i].Cells[1].Value = OmistajanNimi.Text;
            HoitoData.Rows.Add();
            HoitoData.Rows[i].Cells[2].Value = LaskunPvmData.ValueType;
            HoitoData.Rows.Add();
            HoitoData.Rows[i].Cells[3].Value = LääkketHoito.Text;
            i++;
        }


        
        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            
            {
                var wb = new XLWorkbook();
                var dataSet = GetDataSet();
                wb.Worksheets.Add(dataSet);
                wb.SaveAs("C:\\Users\\OMISTAJA\\source\\repos\\Elainklinikka12\\Eläinklinikka\\Eläinklinikka\\Eläinklinikka.xlsx");
                MessageBox.Show("Onnistui");
                // Add all DataTables in the DataSet as a worksheets 
            }

            DataSet GetDataSet()
            {
                var ds = new DataSet();
                ds.Tables.Add(GetTable("MaksuTable"));
                return ds;
            }

            DataTable GetTable(String tableName)
            {
                
                DataTable table = new DataTable();
                table.TableName = tableName;
                table.Columns.Add("Eläimen nimi", typeof(string));
                table.Columns.Add("Omistajan nimi", typeof(string));
                table.Columns.Add("Laskun päivämäärä", typeof(DateTime));
                table.Columns.Add("Lääkkeet ja hoito", typeof(string));
                table.Columns.Add("Kokonaissumma", typeof(string));

                table.Rows.Add("hi", "Indocin", DateTime.Now, "h", 2 + "€");

                return table;
            }
        }
    }
    }
    
    
