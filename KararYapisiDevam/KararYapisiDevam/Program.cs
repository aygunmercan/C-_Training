using System;

namespace KararYapisiDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today=DateTime.Now;
            
            if (today.Month==5 && today.Day==16)
            {
                Console.WriteLine("Bugün Aygün'ün doğum günü!");
               
            }


            Console.WriteLine("Bir ay ismi giriniz:(Örnek format:Ocak)");
            string ay=Console.ReadLine();

            if (ay=="Aralık"|| ay == "Ocak"||ay == "Şubat")
            {
                Console.WriteLine("Kış");
            }
            else if (ay == "Aralık" || ay == "Ocak" || ay == "Şubat")
            {
                Console.WriteLine("İlkbahar");
            }


            Console.WriteLine( "Trafik lambası rengini seçiniz: K/Y/S");
            String secim=Console.ReadLine();

            switch (secim)
            {
                case "K":
                    Console.WriteLine("Dur");
                    break;

                case "S":
                    Console.WriteLine("Hazırlan");
                    break;

                case "Y":
                    Console.WriteLine("Geç");
                    break;

                default:
                    break;
            }


            switch (ay) //caseler birleşebilir.
            {
                case "Ocak":
                case "Subat":
                case "Mart":
                    Console.WriteLine("Kış");
                    break;
                default:
                    break;
            }


        }
    }
}
