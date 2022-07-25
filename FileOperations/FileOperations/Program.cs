using System;
using System.IO;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Product a = new Product();
            Product b = new Product();

            //Console.WriteLine($"Üretilen toplam product instance'ı:{Product.TotalInstance()}");

            // Console.WriteLine("Bir sayı giriniz:");
            //string deger1 = Console.ReadLine();

            // Console.WriteLine("Bir sayı daha giriniz:");
            //string deger2 = Console.ReadLine();


            //Console.WriteLine($"Çarpım sonucu:{Matematik.Carp(int.Parse(deger1), int.Parse(deger2))} - Toplam sonucu:{Matematik.Topla(int.Parse(deger1), int.Parse(deger2))}");

            //Directory.GetFiles("C:\\Users\\AygunPC\\Desktop\\Belonging", "*.docs");        

            //string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //foreach (var item in Directory.EnumerateFileSystemEntries(directoryPath))
            //{
            //    Console.WriteLine(item);
            //}


            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            try
            {
             
                var images = ImageFileHelper.FindImageInFolder(directoryPath,isLogToFolder:true);

                foreach (var image in images)
                {
                    Console.WriteLine(image);
                }

            }
            catch (Exception)
            {

                throw;
            }

                    
        }

    }
}
