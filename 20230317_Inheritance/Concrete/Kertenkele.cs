using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230317_Inheritance
{
    internal class Kertenkele : Surungen,IAyak
    {
        public int KosuMesafesi { get; set; }
        public int KosuHızı { get; set; }
        public int AyakSayisi { get; set; }
    }
}
