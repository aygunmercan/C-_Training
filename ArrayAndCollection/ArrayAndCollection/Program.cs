using System;
using System.Collections.Generic;

namespace ArrayAndCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] participants = new string[] { "Aygün", "Merve" };
            //string[] participants = { "Aygün", "Merve" };

            int[] onGunlukHavaDurumu = new int[10];
            onGunlukHavaDurumu[0] = 14;
            onGunlukHavaDurumu[1] = 15;


            //Console.WriteLine(participants[0]);
            //Console.WriteLine(participants[participants.Length - 1]);


            string[] onlar = new string[] { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] birler = new string[] { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            //Console.WriteLine("iki basamaklı bir sayı giriniz:");

            int sayi = int.Parse(Console.ReadLine());
            int onlarBasDeger = sayi / 10;
            int birlerBasDeger = sayi % 10;

            //Console.WriteLine($"{onlar[onlarBasDeger]} {birler[birlerBasDeger]}");

            List<string> products = new List<string>();

            products.Add("Gazete");


        }



    }


}


