using System;
using System.Linq;
//buraya bunları altta yazarken ctrl . yaparsan da getirtebilirsin.

namespace MethodDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kare,daire,üçgen,dikdörtegen alanı hesaplama için overload yapabiliriz.
            var squareArea = getArea(10, "kare");
            var rectangleArea=getArea(5, 10, "dikdörtgen");

            //Console.WriteLine($"Karenin alanı:{squareArea}; Dikdörtgenin alanı:{rectangleArea}");

            var squareAlternatif = getAlternatifArea(5);
            var circleAlternatif = getAlternatifArea(8,sekil:"daire");
            var triangleAlternatif = getAlternatifArea(10, 4, "üçgen");

            int modResult = 0;
            var divideResult=divide(19,4,out modResult);
            //Console.WriteLine($"Bölüm sonucu:{divideResult};Kalan:{modResult}");



            Console.WriteLine("Bir sayı giriniz:");
            string inputValue=Console.ReadLine();
            double aNumber = 0;

            if (double.TryParse(inputValue,out aNumber))
            {
                sample(ref aNumber);  //bunun sonucu 144
                Console.WriteLine($"Main methodundaki aNumber değeri:{aNumber}"); //bunun sonucu ise 12 geldi.Bu şekilde değerleri kaybetmek istemiyorsak sample metdouna ref yazısını ekliyorz.

            }

            string[] names = { "Feyza", "Hasan", "İnci" };
            Array.Resize(ref names, 4);
            names[3] = "Türkay";
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            int total = sum(13, 9, 122, -3);
            Console.WriteLine($"Array içesindeki değerlerin toplamı:{total}");
            Console.WriteLine($"Girilen değerlerin ortalaması:{ortalamaAl(1,2,3)}");

        }


        static double getArea(double unitLength1,string sekil)
        {
            double result = 0.0;
            switch (sekil)
            {
                case "kare":
                    result = Math.Pow(unitLength1,2);   
                    break;
                case "daire":
                    result=Math.PI*Math.Pow(unitLength1,2);  //pi.r^2 yaptık.
                    break;

                default:
                    Console.WriteLine("Kare ya da daire olmalı");

                    break;
            }


            return result;

        }


        static double getArea(double unitLength1, double unitLength2,string sekil)
        {
            double result = 0.0;
            switch (sekil)
            {
                case "üçgen":
                    result = unitLength1 * unitLength2 / 2;
                    break;
                case "dikdörtgen":
                    result = unitLength1 * unitLength2;
                    break;

                default:
                    Console.WriteLine("Üçgen ya da dikdörtgen olmalı");

                    break;
            }

            return result;

        }

        //eğer 2. parametrenin(unitLength2) isteğe bağlı, doldurulmak zorunda olmasaydı nasıl tasarım yapardık? Altta...

        static double getAlternatifArea(double unitLength1, double unitLength2=1,string sekil="kare")  //eğer 2. param. yazılmazsa default 1 olacak;3. param yazılmazsa kare kabul edecek.
        {
            double result = 0.0;
            switch (sekil)
            {
                case "kare":
                    result = Math.Pow(unitLength1, 2);
                    break;
                case "daire":
                    result = Math.PI * Math.Pow(unitLength1, 2);  //pi.r^2 yaptık.
                    break;
                case "üçgen":
                    result = unitLength1 * unitLength2 / 2;
                    break;
                case "dikdörtgen":
                    result = unitLength1 * unitLength2;
                    break;

                default:
                    Console.WriteLine("Kare,dikdörtgen,üçgen veya daire olmalı");
                    break;
            }

            return result;

        }


        static int divide(int x, int y, out int modulo)   // out a mecbur kaldığımızda kullanırız. Burda kalanı da istediğimiz için onu out ile çıakrdık.
        { 
            modulo = x % y;
            return x / y;
        }

        //static void sample(double number)
        //{
        //    number = Math.Pow(number, 2);
        //    Console.WriteLine($"Sample methodundaki değer:{number}");
        //} ref olmadan önceki hali

        static void sample(ref double number)
        {
            number = Math.Pow(number, 2);
            Console.WriteLine($"Sample methodundaki değer:{number}");
        }

        //ref ve out bellekte ekstra yer kaplar, alternatifleri vardır, gerekmedikçe kullanılmaz!!!!!

        static int sum (params int[] numbers) //eğer başka parametren varsa metot içine yazacağın, param olanı en sona yazmalısın!!
        {
            return numbers.ToList().Sum(); //params bize ne sağlar?: Mainde tekrardan bir tane daha array tanımlamamıza gerek kalmaz, direk bu metot parametresi olarak yazabilmemizi sağlar.
        }

        static double ortalamaAl(params double[] values)
        {
            return values.Average();
        }


    }
}
