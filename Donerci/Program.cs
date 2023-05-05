using Donerci.Concrete;

namespace Donerci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir Dönerci Dükkanımız var. Bu program sabah dükkanı açıp akşam sonlanan bir program olacak.
            // Bu Dükkan sadece Döner Dürüm satıyor. Bu dükkan da bir Garson ve bir Döner Ustası çalışmaktadır.
            // Dükkan da belirli bir kg Döner, belirli adette Lavaş, Domates dilimleri, Salatalık Turşusu Dilimleri ve Patates dilimleri var.
            // Dönerci dükkanı ilk açıldığında bütün ürünlerin ne kadar olduğu belirleniyor.
            // Müşteri kaç tane dürüm istediğini sipariş verir. Garson siparişi alır. Döner Ustası da siparişi hazırlar. Sipariş hazır olduktan sonra Garson bu siparişi Müşteriye götürür.
            // Döner Ustası stoklara bakar ve stoklarda dürüm yapacak kadar malzeme var ise siparişi hazırlar.
            // Garson her aldığı sipariş için 1₺ prim alıyor.
            // Her bir sipariş de Döner'den 200gr,Lavaş dan 1 adet, Domates Dilimlerinden 3 adet, Salatalık Turşusundan 2 adet, Patates Dilimlerinden 10 adet kullanılıyor. Eğer stokta bu kadar ürün yok ise Sipariş hazırlanamıyor.
            // Müşteri, Garson ve Döner Ustasının İsim soy isim, Telefon ve Adres bilgileri var

            // EKSTRA
            // Donerci Dükkanının bir beğeni oranı var.
            // Müşteri bu Dönerci Dükkanına puan verebilir.


            DonerciDukkani donerciDukkani= new DonerciDukkani();
            donerciDukkani.DukkaniAc(100,200,300,100,1000);

            Garson garson = new Garson();
            garson.AdSoyad = "Mahmut Koz";

            DonerUstasi donerUstasi= new DonerUstasi();
            donerUstasi.AdSoyad = "Hüsnü Durmaz";

            Musteri musteri = new Musteri();
            musteri.AdSoyad = "Elif Çalışkan";

            donerciDukkani.Garson = garson;
            donerciDukkani.DonerUstasi= donerUstasi;

            donerciDukkani.MusteriGeldi(musteri);
        }
    }
}