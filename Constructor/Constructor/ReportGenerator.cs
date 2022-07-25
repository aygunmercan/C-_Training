using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class ReportGenerator
    {
        //Amaç: Bir excel dosyasından veri çekerek rapor oluşturulacak bir nesne inşa edilecektir.

        public string ExcelFilePath { get; set; }

        public ReportGenerator()
        {

        }

        public ReportGenerator(string filePath) //constructor oluşturduk, excel pathi olmasa süreç çalışmayacağı kesin olmalı. Bu bağımlılık artık
        {
            ExcelFilePath = filePath;
        }

        public void Generate()
        {

        }
    }
}
