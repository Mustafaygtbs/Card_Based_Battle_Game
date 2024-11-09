using ProLab2SavasOyunu.Core.Enums;

using System;
using System.Drawing;

namespace ProLab2SavasOyunu.Models.Cards
{
    public abstract class SavasAraclari 
    {
        public Guid Id { get; }  // Benzersiz kart kimliği
        public int SeviyePuani { get; set; }
        public abstract int Dayaniklilik { get; set; }
        public abstract int Vurus { get; set; }
        public abstract KartTipi Sinif { get; }
        public abstract string AltSinif { get; }
        public abstract Image KartResmi { get; }
        public bool KullanildiMi { get; set; }  // Kartın kullanılıp kullanılmadığını takip eder

        public SavasAraclari(int seviyePuani = 0)
        {
            Id = Guid.NewGuid();  // Her kart için benzersiz bir ID oluşturulur
            SeviyePuani = seviyePuani;
            KullanildiMi = false;
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
