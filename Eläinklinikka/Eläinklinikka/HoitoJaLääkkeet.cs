using System;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Data;
using System.IO;
using Excel;
using System.Linq;
using IronXL;

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

        public void gunaAdvenceButton5_Click(object sender, EventArgs e) // Tallenna btn
        {
            
        }

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e) //3 btn
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void gunaAdvenceButton2_Click(object sender, EventArgs e) // Päivitä btn
        {
            
        }

        // GridView päivitys setup
        public void ExcelFileReader(string path)
        {
            var stream = File.Open(path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            var result = reader.AsDataSet();
            var tables = result.Tables.Cast<DataTable>();
            foreach (DataTable table in tables)
            {
                dataGridView1.DataSource = table;
            }
        }
        // Setup end

        int i = 1;

        public void gunaAdvenceButton1_Click(object sender, EventArgs e) // Lisää btn
        {
            // Excel tekstin päivitys 
            UpdateExcel("Sheet1", i, 1, EläimenNimi.Text);
            UpdateExcel("Sheet1", i, 2, OmistajanNimi.Text);
            UpdateExcel("Sheet1", i, 3, LaskunPäivä.Text);
            UpdateExcel("Sheet1", i, 4, LääkketHoito.Text);
            UpdateExcel("Sheet1", i, 5, Kokonaissumma.Text);
        }

        private void UpdateExcel(string sheetName, int row, int col, string data)
        {
            Microsoft.Office.Interop.Excel.Application oXL = null;
            Microsoft.Office.Interop.Excel._Workbook oWB = null;
            Microsoft.Office.Interop.Excel._Worksheet oSheet = null;

            try
            {
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oWB = oXL.Workbooks.Open("C:\\Users\\OMISTAJA\\source\\repos\\Elainklinikka12\\Eläinklinikka\\Eläinklinikka\\bin\\Debug\\EläinklinikkaData.xlsx");
                oSheet = String.IsNullOrEmpty(sheetName) ? (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet : (Microsoft.Office.Interop.Excel._Worksheet)oWB.Worksheets[sheetName];

                oSheet.Cells[row, col] = data;

                oWB.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (oWB != null)
                    oWB.Close();

                // GridView päivitys
                string file = "C:\\Users\\OMISTAJA\\source\\repos\\Elainklinikka12\\Eläinklinikka\\Eläinklinikka\\bin\\Debug\\EläinklinikkaData.xlsx";
                string path = file;
                ExcelFileReader(path);
                // End
            }
        }

        private void gunaAdvenceButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click_2(object sender, EventArgs e)
        {
            
        }
    }
    }
    
    
