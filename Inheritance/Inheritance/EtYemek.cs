using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class EtYemek :Yemek
    {
        public string EtTipi { get; set; }
        public bool SoganOlsunMu { get; set; }
    }

    public class Kebap : EtYemek
    {
        public int LavasAdedi { get; set; }
    }
}
