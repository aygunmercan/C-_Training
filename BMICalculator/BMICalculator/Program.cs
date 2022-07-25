using System;

namespace BMICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("kilonuzu giriniz:");
                int weight = int.Parse(Console.ReadLine());

                Console.WriteLine("boyunuzu nokta kullanarak giriniz:");
                double height = double.Parse(Console.ReadLine());

                double bmi = weight / (height * height);

                if (double.IsFinite(bmi) && bmi>0)  //&&:and operatifi, ilk önerme false ise 2. ye bakmaz iki and.tek and ikisine de bakar
                {
                    Console.WriteLine($"BMI değeriniz: {bmi}");

                    if (bmi<18.5)
                    {
                        Console.WriteLine("Çok zayıfsınız!");
                    }
                    else if (bmi<=24.9)
                    {
                        Console.WriteLine("Normalsiniz!");
                    }
                    else if (bmi<=29.9)
                    {
                        Console.WriteLine("Biraz kilolusunuz!");
                    }
                    else
                    {
                        Console.WriteLine("Obezsiniz!");
                    }



                }

                else
                {
                    Console.WriteLine("Boy sıfırdan farklı olmalı!");
                }


            }
            catch (System.FormatException)
            {

                Console.WriteLine("Lütfen sayısal değer giriniz!"); ;
            }

            catch (System.DivideByZeroException)
            {

                Console.WriteLine("Sıfır giremezsiniz!"); ;
            }

            catch(Exception ex)
            {
                if(ex is DivideByZeroException)
                {
                    Console.WriteLine("Exception tipine göre ayarlama yapıyoruz!");
                }
            }


        }
    }
}
