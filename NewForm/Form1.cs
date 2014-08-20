using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace NewForm
{
    public partial class Form1 : Form
    {
        private Microsoft.Office.Interop.Excel.Application xlApp;
        Workbooks workbooks;
        Worksheet ws;
        Sheets sheets;
        int row;
        int jum;

        public Form1()
        {
            InitializeComponent();
            row = 1;
            jum = 0;
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlApp.Visible = true;
            workbooks = xlApp.Workbooks;
            string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(directory, "hehe.xlsx");
            var workbook = workbooks.Open(path);
            sheets = workbook.Worksheets;
            ws = sheets[1];
            increaseRow();
        }

        ~Form1()
        {
            Marshal.ReleaseComObject(ws);
            Marshal.ReleaseComObject(sheets);
            Marshal.ReleaseComObject(workbooks);
            Marshal.ReleaseComObject(xlApp);
            xlApp = null;
        }

        private void nick_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            jum++;
            string num = "A" + row;
            string num2 = "B" + row;
            string num3 = "C" + row;
            string num4 = "D" + row;
            string num5 = "E" + row;
            string num6 = "F" + row;
            // Select the Excel cells, in the range c1 to c7 in the worksheet.
            Range aRange = ws.get_Range(num);
            Range bRange = ws.get_Range(num2);
            Range cRange = ws.get_Range(num3);
            Range dRange = ws.get_Range(num4);
            Range eRange = ws.get_Range(num5);
            Range fRange = ws.get_Range(num6);
            // Change the value
            aRange.Value2 = jum;
            bRange.Value2 = this.nama.Text;
            cRange.Value2 = this.panggilan.Text;
            dRange.Value2 = this.nim.Text;
            eRange.Value2 = this.FS.Text;
            fRange.Value2 = "'" + this.nohp.Text;
            // Clear textboxes
            nama.Clear();
            panggilan.Clear();
            nim.Clear();
            FS.Clear();
            nohp.Clear();
            row++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void increaseRow()
        {
            string num = "A" + row;
            Range aRange = ws.get_Range(num);
            while (aRange.Value2 != null)
            {
                row++;
                num = "A" + row;
                aRange = ws.get_Range(num);
            }
            if (row != 2)
            {
                jum = row - 2;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
