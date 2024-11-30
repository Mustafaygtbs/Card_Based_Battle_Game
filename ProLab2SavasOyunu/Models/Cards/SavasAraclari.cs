using ProLab2SavasOyunu.Core.Enums;

using System;
using System.Drawing;

namespace ProLab2SavasOyunu.Models.Cards
{
    public abstract class SavasAraclari 
    {
        public Guid Id { get; }  
        public int SeviyePuani { get; private set; }
        public abstract int Dayaniklilik { get; set; }
        public abstract int Vurus { get; set; }
        public abstract KartTipi Sinif { get; }
        public abstract string AltSinif { get; }
        public abstract Image KartResmi { get; }
        public bool KullanildiMi { get; set; }
        public bool ElenmisMi { get; set; }

        public SavasAraclari(int seviyePuani = 0)
        {
            Id = Guid.NewGuid();  
            SeviyePuani = seviyePuani;
            KullanildiMi = false;
            ElenmisMi = false;
        }
        public void SeviyePuaniGuncelle(int puanArtisi)
        {
            SeviyePuani += puanArtisi;
        }



        public void KartPuaniGoster()
        {
            Console.WriteLine($"Dayanıklılık: {Dayaniklilik}, Seviye Puanı: {SeviyePuani}");
        }

        public abstract void DurumGuncelle(int hasar);

        public virtual int SaldiriHesapla(SavasAraclari hedef)
        {
            int saldiriGucu = Vurus;
            int avantaj = GetVurusAvantaji(hedef);
            saldiriGucu += avantaj;
            return saldiriGucu;
        }

        public abstract int GetVurusAvantaji(SavasAraclari hedef);

        public void SaldiriUygula(SavasAraclari hedef)
        {
            int hasar = SaldiriHesapla(hedef);
            hedef.DurumGuncelle(hasar);
        }
    }
}
