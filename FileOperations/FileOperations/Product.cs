using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    //bir methodun static olması onun instance'dan değil class'tan erişebiliyor olmasıdır. Yani burda direk Product class'tan erişim sağladık.
    public class Product
    {
        private static int instanceCount;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public Product()
        {
            instanceCount++;
        }


        public static int TotalInstance()
        {
            return instanceCount;
        }




    }
}
