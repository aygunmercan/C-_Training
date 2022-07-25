using System;

namespace ClassVSObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee/*idea*/ developer1/*nesne*/ = new Employee/*constructor bu:classtan instance almayı sağlayan şey*/();
            developer1.Name = "Kübra";
            developer1.SetAge(19);
            developer1.HourlyPayments = 8000;
            developer1.WorkingHours = 40;
            Console.WriteLine(developer1.Salary);

            Console.WriteLine(developer1.GetAge());

            //Employee developer2 = developer1;
            //developer2.Name = "Rüstem";
            //developer2.SetAge(11);

            ////Console.WriteLine(developer2.Name); //Rüstem yazar.
            ////Console.WriteLine(developer1.Name); //Rüstem yazar.

            //Employee accountant1 = new Employee(); 
            


        }
    }




}


