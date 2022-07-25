using System;

namespace Constructor
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CamasirMakinesi/*tip*/ arcelik/*instance*/ = new CamasirMakinesi/*constructor*/();
            Console.WriteLine(arcelik.Renk);
            
            CamasirMakinesi samsung=new CamasirMakinesi("Siyah"); //constructor overload

            CamasirMakinesi electrolux = new CamasirMakinesi { CalismaHizi = 1200, Renk = "Mavi",EnerjiTuketimi="A++" };
            Console.WriteLine($"{electrolux.Renk} {electrolux.CalismaHizi} ve {electrolux.EnerjiTuketimi}");

            ReportGenerator reportGenerator = new ReportGenerator("C:\\deneme.xlsx");
            reportGenerator.Generate();




        }
    }
}
