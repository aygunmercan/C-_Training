using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVSObject
{
    public class Employee
    {
        /*Telefonun bir sürü özelliği vardır: ekran,hafıza vb. Burdaki prop olarak belirttiğimiz her şey özellik.
         Aynı zamanda telefonun işlevleri de vardır: İnternete girme, sosyal medyaya girme vs.*/

        //public olanlar büyük harfle başlar, private olanlar küçük harfle başlar.

        private string name;
        //public string LastName;
        private int age; //mesela mainde age e -9 yazamasın diye bunu burda public değil private yapıyoruz ki -9 gibi bişey atayamasın


        //Bir employee ... yapar /Bir employee ile ... yapılır.
        public void SetAge(int valueAge)
        {
            if (valueAge<18)
            {
                throw new ArgumentException("Yaş 18'den küçük olamaz!");
            }
            age = valueAge;

        }


        public int GetAge() //private bir özellik olduğu için Age, onu Mainde çağırmayı sağlayan metot yazdık.
        {
            return age;
        }

        public string Name
        {
            get{ return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("ad boş olamaz!");
                }
                name = value;
            }
        }

        public string LastName { get; set; }
        public string Departman { get; set; }
        public double HourlyPayments { get; set; }
        public int WorkingHours { get; set; }

        public double Salary 
        {
            get //döndürülen değer ; set ise istenilen-girilen değer.
            {
                return HourlyPayments * WorkingHours;
            }
        }


        public string TCIdentityNo { get; set; }
        public bool IsMarried { get => IsMarried; set => IsMarried = value; }

        //private bool isMarried; bunu üstteki gibi public yapmak istiyorsan:
        //üstüne tıkla-> quick action->encapsulate field 2 tıkla.

        
    }
}
