using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230317_Inheritance
{
    internal class Kartal : Kus,IAyak
    {
        public int MaxUcusMesafesi { get; set; }
        public int MaxUcusHizi { get; set; }
        public int AyakSayisi { get; set; }
    }
}
