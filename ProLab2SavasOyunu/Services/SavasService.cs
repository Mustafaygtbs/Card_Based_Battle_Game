using ProLab2SavasOyunu.Core.Interfaces;
using ProLab2SavasOyunu.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2SavasOyunu.Services
{
    public class SavasService : ISavasabilir, IDayanabilir
    {
        public int SaldiriHesapla(SavasAraclari saldiran, SavasAraclari hedef)
        {
            return saldiran.SaldiriHesapla(hedef);
        }

        public void SaldiriUygula(SavasAraclari saldiran, SavasAraclari hedef)
        {
            saldiran.SaldiriUygula(hedef);
        }

        public bool AvantajVarMi(SavasAraclari saldiran, SavasAraclari hedef)
        {
            return saldiran.AvantajVarMi(hedef);
        }

        public int GetVurusAvantaji(SavasAraclari saldiran, SavasAraclari hedef)
        {
            return saldiran.GetVurusAvantaji(hedef);
        }

        public void DurumGuncelle(SavasAraclari kart, int hasar)
        {
            kart.DurumGuncelle(hasar);
        }

        public int SaldiriHesapla(SavasAraclari hedef)
        {
            throw new NotImplementedException();
        }

        public void SaldiriUygula(SavasAraclari hedef)
        {
            throw new NotImplementedException();
        }

        public bool AvantajVarMi(SavasAraclari hedef)
        {
            throw new NotImplementedException();
        }

        public int GetVurusAvantaji(SavasAraclari hedef)
        {
            throw new NotImplementedException();
        }

        public void DurumGuncelle(int hasar)
        {
            throw new NotImplementedException();
        }
    }
}
