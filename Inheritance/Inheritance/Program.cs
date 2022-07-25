using System;

namespace Inheritance
{
    class Program
    {
        //bazı nesnelerin tanımı genelden özele doğru gider.

        static void Main(string[] args)
        {
            Asci asci = new Asci();
            Yemek yemek = new Yemek() { PismeSüresi = 150 };
            SebzeYemek sebzeYemek = new SebzeYemek();
            EtYemek etYemek = new EtYemek() { EtTipi = "Koyun eti" };
            Pirasa pirasa = new Pirasa() { PismeSüresi = 200 };
            Kebap kebap = new Kebap() { LavasAdedi=4,PismeSüresi=300,SoganOlsunMu=true};
            Kurufasulye kurufasulye = new Kurufasulye();

            asci.Pisir(sebzeYemek);
            // asci.Pisir(etYemek);
            asci.Pisir(kurufasulye);
            //asci.Pisir(kebap);
        }
    }
}
