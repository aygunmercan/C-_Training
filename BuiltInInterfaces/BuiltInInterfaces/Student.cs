using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInInterfaces
{
    public class Student:IComparable<Student>//IComparable<Student> yazıp implement dediğimizde aşağı CompareTo methodunu oluşturdu. if leri yazdık.
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }

        public int CompareTo(object obj)
        {
            return Age.CompareTo(obj);
        }

        public int CompareTo(Student other) //bir durumu karşılaştırmanın 3 ihtimali vardır. 2 takım birbirini yener, yenilir,berabere kalır.
        {
            if (this.Age>other.Age)
            {
                return 1;
            }
            else if (this.Age < other.Age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
