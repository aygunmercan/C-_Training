using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    static class ImageFileHelper
    {
        public static List<string> FindImageInFolder(string folderPath,bool isLogToFolder=false) //opsiyonel paramaetremiz isLogToFolder ve default değeri false.Bunu illa kullanmak zorunda değiliz.
        {
            if (!Directory.Exists(folderPath)) //yok ise o klasör: ! ile olumsuz yaptık
            {
                throw new FileNotFoundException($"{folderPath} klasörü bulunamadı!");
            }




            var files= Directory.GetFiles(folderPath, "*.JPG", SearchOption.AllDirectories).ToList();

            if (isLogToFolder)
            {
                File.WriteAllLines($"{folderPath}/log.txt",files);
            }


            return files;

        }





    }
}
