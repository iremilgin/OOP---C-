using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230317_Inheritance
{
    internal class Penguen : Kus,IYuzebilen
    {
        public int YuzmeSuresi { get; set; }
        public int YuzmeMesafesi { get; set; }
        public int NefesTutmaSuresi { get; set; }
    }
}
