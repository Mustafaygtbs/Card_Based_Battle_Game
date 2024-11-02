using ProLab2SavasOyunu.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2SavasOyunu.Core.Interfaces
{
    public interface ISavasabilir
    {
        int SaldiriHesapla(SavasAraclari hedef);
        void SaldiriUygula(SavasAraclari hedef);
        bool AvantajVarMi(SavasAraclari hedef);
        int GetVurusAvantaji(SavasAraclari hedef);
    }
}
