using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInInterfaces
{
    public class StudentService: IEnumerable<Student> //for each ile dönebilmeyi sağlayan interface.
    {
        private List<Student> students = new List<Student>();

        public void AddRange(params Student[] studentItems)
        {
            students.AddRange(studentItems);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            //throw new NotImplementedException("Henüz nasıl öğrenci döndüreceğimizi yazmadık!");
            foreach (var student in students)
            {
                yield return student;  
            }
            /*yield return: daha sonra dönmek için return et demek. program cs içerisindeki for each'te student dönerken her birisi için
             * buraya gelecek, birisini döndürecek ve döngüden çıkacak; sonra program.cs'ye gelecek ordan 2. yi alacak burda 2. yi döndürecek.
             * Yani burdaki for each'in bitmesine gerek kalmadan teker teker döndürme sağlayacak. Önceki döndürdüğünü unutmadan student serviste 
             * dönüşünü tamamlayıp 2. ye geçecek ve böyle devam edecek.
            */

        }

        public void Sort()
        {
            //students.Sort(); içerisinde yazan muhtemelen böyle bir kod:
            //IComparable comparable = (IComparable)students[0];
            //comparable.CompareTo();
             students.Sort();    
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
