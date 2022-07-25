using System;

namespace LooselyCoupled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department it = new Department() { Name = "Bilgi İşlem", Budget = 750000 };


            Employee employee = new Employee() { Name = "Aygün",Department = it };
            
            

            Console.WriteLine($"Çalışanın departmanının bütçesi:{employee.Department.Budget}"); //Bir özellik üzerinden başka bir özelliğe ulaştık.
            //bu yüksek bağlılık.
        }
    }
}
