using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office;
using Models;

namespace SMDB.Common
{
    class PrintStudents
    {
        public void ExecutePrint(StudentExt objStudent)
        {
            //defind a Excel
            Application excelApp = new Application();
            //2.get CurretnDirectory
            string excelBookPath = Environment.CurrentDirectory + "\\StudentInfo.xls";
            //3.add a workBook
            excelApp.Workbooks.Add(excelBookPath);
            //get firstSheet


        


        }
    }
}
