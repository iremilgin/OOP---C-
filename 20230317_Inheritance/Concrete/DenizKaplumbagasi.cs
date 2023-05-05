using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230317_Inheritance
{
    internal class DenizKaplumbagasi : Surungen,IYuzebilen,IAyak
    {
        public int GidebildigiDerinlik { get; set; }
        public double KabukGenisligi { get; set; }
        public double KabukBoyu { get; set; }
        public int YuzmeMesafesi { get ; set ; }
        public int NefesTutmaSuresi { get; set; }
        public int AyakSayisi { get; set; }
    }
}
