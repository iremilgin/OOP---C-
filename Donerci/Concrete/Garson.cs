using Donerci.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donerci.Concrete
{
    internal class Garson : Kisi
    {
        public int Prim { get; private set; }
        public int SiparisAl(Musteri musteri)
        {
            Console.WriteLine($"Hoşgeldiniz sayın {musteri.AdSoyad}. Ben garsonunuz {this.AdSoyad}. Ne arzu ederdiniz?");
            int siparisSayisi = musteri.SiparisVer();
            Thread.Sleep(2000); // Bekletiyor
            Console.WriteLine("Tamamdır efendim siparişinizi aldım.");
            this.Prim++;
            return siparisSayisi;
        }
        public void SiparisiGotur(Musteri musteri)
        {
            Thread.Sleep(3000);
            Console.WriteLine($"Buyrun sayın {musteri.AdSoyad}.Afiyet olsun");
            musteri.DurumuYe();
        }

        public void OzurDile(Musteri musteri)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Efendim çok çok özür {musteri.AdSoyad} dileriz. Maalesef siparişiniz hazırlayacak kadar malzememiz yok");
            musteri.IsyanEt();
        }
    }
}

