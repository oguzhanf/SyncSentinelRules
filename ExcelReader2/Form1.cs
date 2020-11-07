using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelReader2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"D:\sentinelrules.xlsx";

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Open(path);
            Worksheet excelSheet = (Worksheet)wb.Sheets[3];

            //Read the first cell
            string test = ((Microsoft.Office.Interop.Excel.Range)excelSheet.Cells[1,1]).Value;
            for (int i = 1; i < 170; i++)
            {
                string guid = Guid.NewGuid().ToString();
                FileStream fileStream = new FileStream(@"d:\" + guid + ".yaml", FileMode.CreateNew, FileAccess.ReadWrite);
                
                StreamWriter sw = new StreamWriter(fileStream);
                sw.WriteLine("id: " + guid);
                sw.WriteLine("name: " + excelSheet.Cells[i, 1].Value2());
                sw.WriteLine("description: Automatically added.");
                sw.WriteLine("severity: Medium");
                sw.WriteLine("requiredDataConnectors: ");
                sw.WriteLine("queryFrequency: 4h");
                sw.WriteLine("queryPeriod: 14d");
                sw.WriteLine("triggerOperator: gt");
                sw.WriteLine("triggerThreshold: 0");
                sw.WriteLine("tactics: ");
                sw.WriteLine("relevantTechniques: ");
                sw.WriteLine("query: |");
                sw.WriteLine(excelSheet.Cells[i, 2].Value2());
                
                sw.Close();
                fileStream.Close();
            }
            wb.Close();
        }
    }
}




//id: 0914adab - 90b5 - 47a3 - a79f - 7cdcac843aa7
//name: Azure Key Vault access TimeSeries anomaly
//description: 
//severity: Low
//requiredDataConnectors:
//queryFrequency: 1h
//queryPeriod: 14d
//triggerOperator: gt
//triggerThreshold: 0
//tactics:
//relevantTechniques:
//query: 
