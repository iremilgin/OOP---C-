using Donerci.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donerci.Concrete
{
    internal class DonerUstasi : Kisi
    {
        // Her bir sipariş de Döner'den 200gr,Lavaş dan 1 adet, Domates Dilimlerinden 3 adet, Salatalık Turşusundan 2 adet, Patates Dilimlerinden 10 adet kullanılıyor. Eğer stokta bu kadar ürün yok ise Sipariş hazırlanamıyor.
        public bool SiparisiHazirla(double doner, int lavas, int domates, int salatalik, int patates,int siparisSayisi)
        {
            if(doner>=0.2*siparisSayisi && lavas>=siparisSayisi && domates>=siparisSayisi*3&& patates >= siparisSayisi * 10 && salatalik>=siparisSayisi*2)
            {
                Thread.Sleep(1000 * siparisSayisi);// Bekletiyor
                Console.WriteLine($"Ben {this.AdSoyad} adlı usta olarak bu siparişi hazırladım. Garson bunu götür....");
                
                return true;
            }
            else
            {
                Console.WriteLine("Ya arkadaş malzeme yok bana bu siparişi hazırla diyorsun. Nasıl hazırlayayım?");
                return false;
            }
        }
    }
}
