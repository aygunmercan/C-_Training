using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Asci
    {
        //Aşçı ne pişirir:Yemek. demek ki yemek diye bir class oluşturmalıyız.
        public void Pisir(Yemek yemek)
        {
            yemek.Hazirla();
            yemek.Pisir();
            yemek.SunumYap();
        }
    }
}
