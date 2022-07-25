using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Yemek
    {
        public double Fiyat { get; set; }
        public int PismeSüresi { get; set; }
        public List<string> Malzemeleri { get; set; }

        public void Hazirla()
        {
            Console.WriteLine("Yemek hazırlanıyor...");
        }

        public void  Pisir()
        {
            Console.WriteLine($"{this.GetType().Name}, {PismeSüresi} saniyede pişti...");
        }


        /*Polymorphism:Base classtaki bir üyenin derived class içinde de olmasını fakat bambaşka bir biçimde çalışmasıdır. başına virtual yazılır
        kalıtımda bazı genetik aktarımlar oluyordu. Polymorphism'de ise bu aktarımlar esnasında bazı 
         metotların amaçlarını değiştirmesidir.*/

        public virtual void SunumYap() //virtual polymorphisim için gerekli!
        {
            Console.WriteLine($"{this.GetType().Name}, normal bir biçimde sunuldu.");
        }




    }



    public class SebzeYemek : Yemek
    {
        public bool ZeytinYagliMi { get; set; }
        public bool SogukMu { get; set; }

    }

    //Eğer pırasa nesnesine özel bir property (get;set) veya metot yoksa; o zaman pırasa nesnesine de gerek yoktur.
    public class Pirasa : SebzeYemek
    {
        public int HavucAdedi { get; set; }
        public bool LimonOlsunMu { get; set; }
    }

    public class Kurufasulye: Yemek
    {
        public override void SunumYap() //override yazarak üstteki base classtaki yapıyı ezdik. Bu yapıyı ezmemizi sağlayan da üstte yazmış olduğumuz 'virtual' dur.
        {
            Console.WriteLine($"{this.GetType().Name}, pilav ile sunuldu.");
        }
    }



}
