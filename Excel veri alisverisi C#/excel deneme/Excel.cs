using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using _Range = Microsoft.Office.Interop.Excel.Range;

namespace excel_deneme
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;


        public Excel(string path, int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = excel.Worksheets[Sheet];
        }
        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            Object valor = ((_Range)ws.Cells[i, j]).Value2;
            if (valor != null)
            {
                return System.Convert.ToString(valor); 
            }
            else
            {
                return "";
            }
        }

        public void WriteCell(int i, int j,string s)
        {
            i++;
            j++;

            ws.Cells[i, j] = s;
            wb.Save();
        }


        public void closeWb()
        {
            wb.Close();
        }
    }
}
