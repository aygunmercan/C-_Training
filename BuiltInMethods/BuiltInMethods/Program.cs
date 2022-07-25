using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BuiltInMethods
{
    internal class Program
    {
        private static bool cevap2;

        //void methodu geriye bir değer döndürmez sadece iş yapar, sıralamak gibi mesela.
        static void Main(string[] args)
        {
            do
            {



                Random rastgeleNumberGenerator = new Random();
                int number = rastgeleNumberGenerator.Next(0, 10);

                List<string> cities = new List<string> { "Adana", "Istanbul", "Eskişehir" };
                Console.WriteLine("Lütfen bir şehir ismi giriniz:");
                string strSehirName = Console.ReadLine();

                Console.WriteLine("Sonuç:" + (cities.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(strSehirName.ToLower())) ? strSehirName + " koleksiyonda var" : strSehirName + " koleksiyonda yok!"));

                Console.WriteLine("devam etmek ister misiniz");
                string cevap = Console.ReadLine();
                bool cevap2 = false;

                if (cevap.ToLower() == "evet")
                {
                    cevap2 = true;
                }
                else
                {
                    cevap2 = false;
                }

            } while (cevap2);

            //string pattern = "**********";
            //int index = 1;
            //foreach (var i in Enumerable.Range(1, pattern.Length+1))
            //{                
            //    Console.WriteLine(pattern.Substring(0, pattern.Length-index));
            //    index++;    
            //}


            //foreach (var i in Enumerable.Range(1, 10))
            //{
            //System.Threading.Thread.Sleep(1000);// 1 saniye delay koyar.
            //    Console.WriteLine(pattern.Substring(0,i));

            //}

            Console.WriteLine("Bir sayı giriniz:");
            string password= Console.ReadLine();

            bool sayiMi = false;
            bool harfMİ = false;
            bool buyukHarfMi=false;
            bool kucukHarfMi = false;
            bool alfaNumerikDegilMi=false;

            foreach (var character in password)
            {
                if (char.IsDigit(character))
                {
                    sayiMi = true;
                }
                else if (char.IsLetter(character))
                {
                    harfMİ = true;
                    if (char.IsLower(character))
                    {
                        kucukHarfMi=true;
                    }
                    else
                    {
                        buyukHarfMi=(true); 
                    }
                }
                else
                {
                    alfaNumerikDegilMi = true;
                }


            }

            if (sayiMi&& !harfMİ && !alfaNumerikDegilMi)
            {
                Console.WriteLine("Zayıf");
            }
            else if (sayiMi&&harfMİ&&buyukHarfMi&&kucukHarfMi&&!alfaNumerikDegilMi)
            {
                Console.WriteLine("Orta");
            }
            else if (sayiMi&&harfMİ&&alfaNumerikDegilMi)
            {
                Console.WriteLine("Güçlü");
            }



        }
    }
}
