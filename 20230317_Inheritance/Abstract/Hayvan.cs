using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230317_Inheritance
{
    internal abstract class Hayvan
    {
        public double Boy { get; set; }
        public double Kilo { get; set; }
        public List<string> Yiyecekler { get; set; }
        public string Cinsiyet { get; set; }
        public short Yas { get; set; }
    }
}
