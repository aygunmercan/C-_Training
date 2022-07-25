using System;

namespace AbstractAndInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Abstract : herhangi bir fiziksel nesne oluşturmayan (instance'ı olamaz, new ile bir şey üretemezsin abstract classtan)
             * bütün kendisinden miras alanları yöneten bir yapıdır abstract.
             * Abstract: instance alınamayan sadece miras alınan sınıf.
             */

            WordDocument wordDocument = new WordDocument();
            PdfDocument pdfDocument = new PdfDocument();
            PowerPointDocument powerPointDocument = new PowerPointDocument();   
            ExcelDocument excelDocument = new ExcelDocument();

            PrintComponent printComponent = new PrintComponent();
            printComponent.PrintDocument(wordDocument);
            //printComponent.PrintDocument(excelDocument); //pdf ve powerpoint için yapamaz çünkü onların çıktı alma yetenekleri yok.


                        
        }
    }

    
}
