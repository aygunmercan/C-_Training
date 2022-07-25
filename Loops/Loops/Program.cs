using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool uygulamaDevamEtsinMi=true;

            while (uygulamaDevamEtsinMi)
            {
                Console.WriteLine("bir sayı giriniz:");
                int num1=int.Parse(Console.ReadLine());
                Console.WriteLine("bir sayı daha giriniz");
                int num2=int.Parse(Console.ReadLine());

                int carpim = num1 * num2;
                Console.WriteLine($"Çarpım Sonucu:{carpim}");

                Console.WriteLine("Bir işlem daha yapmak ister misiniz?(E/H)");
                uygulamaDevamEtsinMi = Console.ReadLine() == "E";
            }


        }
    }
}
