using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupled
{
    /* Tightly coupled : sadece o şeye bağlı olarak çalışabilme: Bilgisayarım şarj aleti ile şarj edilebilir sadece.(Dependecy)
     * Loosely coupled: başka şeyler yardımıyla da çalışabilme: Kumanda başka çeşit piller yardımıyla da çalışabilir.
     * */
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IDepartment Department { get; set; } //yüksek bağlılık yerine düşük bağlılık kullanmamızı sağlayan şey interfacedir. Bu interface in 2. özelliğidir.



    }

    /*Burası Tightly coupled oldu çünkü tek bir departmana baplı kıldık çalışanı. Başka departman geldiğinde burası çalışmaz.
    Bunu loosely coupled yapabilmeliyiz.*/
    public class Department :IDepartment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public List<Employee> Employees { get; set; }

        public Employee Manager { get; set; }
        public double Budget { get; set; }

    }


    public interface IDepartment 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Budget { get; set; }

    }



    public class AutonomicDepartment : IDepartment
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double Budget { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double IDepartment.Budget { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
