using System;
using System.Collections.Generic;

namespace BuiltInInterfaces
{
   class Program
    {
        static void Main(string[] args)
        {
            //List<Student> students = new List<Student>();   
            StudentService studentService = new StudentService();
            studentService.AddRange(new Student { Id = 1, Name = "Türkay", Age = 42, LastName = "Ürkmez", Score = 75 },
                new Student { Id = 2, Name = "Aygün", Age = 24, LastName = "Mercan", Score = 92 },
                new Student { Id = 3, Name = "İnci", Age = 30, LastName = "Karagülle", Score = 59 },
                new Student { Id = 4, Name = "Özge", Age = 16, LastName = "Bulut", Score = 65 });


            studentService.Sort();

            foreach (var student in studentService) //kullanıcıya bişeyler göstermek(dönerek)  program.cs'nin sorumluluğundadır.
            {
                Console.WriteLine($"{student.Name} {student.LastName} {student.Age} {student.Score}");
            }



        }

    }
}
