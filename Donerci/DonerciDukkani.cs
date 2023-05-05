using Donerci.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Donerci
{
    internal class DonerciDukkani
    {
        public DonerciDukkani()
        {
            Garson = new Garson();
            DonerUstasi = new DonerUstasi();
        }
        public Garson Garson { get; set; }
        public DonerUstasi DonerUstasi { get; set; }

        public double DonerKG { get; set; }
        public int Lavas { get; set; }
        public int Domates { get; set; }
        public int Salatalik { get; set; }
        public int Patates { get; set; }
        bool dukkanAcikMi;

        public void DukkaniAc(double donerKG, int lavas, int domates, int salatalik, int patates)
        {
            this.DonerKG = donerKG;
            this.Lavas = lavas;
            this.Domates = domates;
            this.Salatalik = salatalik;
            this.Patates = patates;
            this.dukkanAcikMi = true;
        }

        public void MusteriGeldi(Musteri musteri)
        {
            if (this.dukkanAcikMi)
            {
                int siparis = Garson.SiparisAl(musteri);
                bool siparisHazirMi = DonerUstasi.SiparisiHazirla(this.DonerKG, this.Lavas, this.Domates, this.Salatalik, this.Patates, siparis);
                if (siparisHazirMi)
                {
                   
                    Garson.SiparisiGotur(musteri);
                }
                else
                {
                    Garson.OzurDile(musteri);
                }
            }
            else Console.WriteLine("Daha dükkan açılmadı kardeş git saat 10 da gel. Tipini beğenirsem sana bir dürüm ayarlarım.");
        }

        public void DukkaniKapat()
        {
            this.dukkanAcikMi = false;
        }

    }
}
