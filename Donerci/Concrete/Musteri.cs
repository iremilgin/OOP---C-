using Donerci.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donerci.Concrete
{
    internal class Musteri : Kisi
    {
        public int SiparisVer()
        {
            Thread.Sleep(3000); // Bekletiyor
            Console.WriteLine("Hoşbulduk teşekkür ederiz. Benim siparişim şu olacak : ");
            int durumSayisi = int.Parse(Console.ReadLine());
            return durumSayisi;
        }
        public void DurumuYe()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Elinize sağlık çok güzel olmuş. MMMMMhhhhhh");
        }
        public void IsyanEt()
        {
            Console.WriteLine("Ne biçim bir işletme burası. Bir daha gelmeyeceğim. Sizede 0 vereceğim.");
        }
    }
}
