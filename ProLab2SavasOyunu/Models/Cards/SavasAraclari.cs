using ProLab2SavasOyunu.Core.Enums;
using ProLab2SavasOyunu.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2SavasOyunu.Models.Cards
{
    public abstract class SavasAraclari : ISavasabilir, IDayanabilir
    {
        public int SeviyePuani { get; protected set; } = 0;
        public abstract int Dayaniklilik { get; set; }
        public abstract int Vurus { get; set; }
        public abstract KartTipi Sinif { get; }
        public abstract string AltSinif { get; }

        public SavasAraclari() { }

        public void KartPuaniGoster()
        {
            Console.WriteLine($"Seviye Puanı: {SeviyePuani}, Dayanıklılık: {Dayaniklilik}, Vuruş: {Vurus}, Sınıf: {Sinif}, Alt Sınıf: {AltSinif}");
        }

        public abstract void DurumGuncelle(int hasar);

        public virtual int SaldiriHesapla(SavasAraclari hedef)
        {
            int saldiriGucu = Vurus;
            if (AvantajVarMi(hedef))
            {
                saldiriGucu += GetVurusAvantaji(hedef);
            }
            return saldiriGucu;
        }

        public abstract bool AvantajVarMi(SavasAraclari hedef);

        public abstract int GetVurusAvantaji(SavasAraclari hedef);

        public void SaldiriUygula(SavasAraclari hedef)
        {
            int hasar = SaldiriHesapla(hedef);
            hedef.DurumGuncelle(hasar);
        }
    }
}
