using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Eläinklinikka
{
    //class Excel
    //{
    //    string patha = "";
    //    _Application excel = new _Excel.Application();
    //    Workbook wb;
    //    Worksheet ws;

    //    public Excel()
    //    {

    //    }

    //    public Excel(string path, int Sheet)
    //    {
    //        this.patha = path;
    //        wb = excel.Workbooks.Open(path);
    //        ws = wb.Worksheets[Sheet];
    //    }

    //    public string ReadCell(int i, int j)
    //    {
    //        i++;
    //        j++;
    //        if (ws.Cells[i, j].Value2 != null)
    //            return ws.Cells[i, j].Value2;

    //        else
    //            return "";
    //    }

    //    public void WriteToCell(int i, int j, string s)
    //    {
    //        i++;
    //        j++;
    //        ws.Cells[i, j].Value2 = s;
    //    }

    //    public void Save()
    //    {
    //        wb.Save();
    //    }

    //    public void SaveAs(string path)
    //    {
    //        wb.SaveAs(path);
    //    }

    //    public void Close()
    //    {
    //        wb.Close();
    //    }

    //    public void SelectWorksheet(int SheetNumber)
    //    {
    //        this.ws = wb.Worksheets[SheetNumber];
    //    }

    //    public void DeleteWorksheet(int Sheetnumber)
    //    {
    //        wb.Worksheets[Sheetnumber].Delete();
    //    }

    //    public void CreateNewFile()
    //    {
    //        this.wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
    //        this.ws = wb.Worksheets[1];
    //    }

    //    public void CreateNewSheet()
    //    {
    //        Worksheet temptsheet = wb.Worksheets.Add(After: ws);
    //    }

    //    public string[,] ReadRange(int starti, int starty, int endi, int endy)
    //    {
    //        //Read range in excel
    //        Range range = (Range)ws.Range[ws.Cells[starti, starty], ws.Cells[endi, endy]];
    //        object[,] holder = range.Value2;
    //        string[,] returnstring = new string[endi - starti, endy - starty];
    //        for(int p = 1; p <= endi - starti; p++)
    //        {
    //            for (int q = 1; q <= endy - starty; q++)
    //            {
    //                returnstring[p - 1, q - 1] = holder[p, q].ToString();
    //            }
    //        }
    //        return returnstring;
    //    }

    //    public void WriteRange(int starti, int starty, int endi, int endy, string[,] writestring)
    //    {
    //        Range range = (Range)ws.Range[ws.Cells[starti, starty], ws.Cells[endi, endy]];
    //        range wt
        //}
    }

