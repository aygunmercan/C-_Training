using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class CamasirMakinesi
    {
        public string Renk { get; set; }
        public int CalismaHizi { get; set; }
        public string EnerjiTuketimi { get; set; }


        public CamasirMakinesi() //crop yazdık: Çamaşır makinesinin zihnimdeki varsayılan rengi mesela
        {
            Renk = "Beyaz";
            CalismaHizi = 8000;
        }

        public CamasirMakinesi(string renk) //constructor overload yaptık. eğer illa default beyaz olmasın benim dediğim renk olsun dersen bunu da kullanabilirsin.
        {
            Renk = renk;
        }

    }
}



