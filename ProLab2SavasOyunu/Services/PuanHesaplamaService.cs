using ProLab2SavasOyunu.Core.Interfaces;
using ProLab2SavasOyunu.Models.Cards;
using ProLab2SavasOyunu.Models.Oyuncular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2SavasOyunu.Services
{
    public class PuanHesaplamaService
    {
        public void SkorHesapla(Oyuncu oyuncu1, Oyuncu oyuncu2,
            List<SavasAraclari> seciliKartlar1, List<SavasAraclari> seciliKartlar2)
        {
            for (int i = 0; i < seciliKartlar1.Count; i++)
            {
                var kart1 = seciliKartlar1[i];
                var kart2 = seciliKartlar2[i];

                int saldiri1 = kart1.SaldiriHesapla(kart2);
                int saldiri2 = kart2.SaldiriHesapla(kart1);

                UygulaSaldiri(kart1, kart2, saldiri2, oyuncu2);
                UygulaSaldiri(kart2, kart1, saldiri1, oyuncu1);
            }
        }

        private void UygulaSaldiri(SavasAraclari saldiran, SavasAraclari hedef,
            int saldiriDegeri, Oyuncu saldiriYapan)
        {
            hedef.DurumGuncelle(saldiriDegeri);

            if (hedef.Dayaniklilik <= 0)
            {
                int kazanilanPuan = Math.Max(10, hedef.SeviyePuani);
                saldiriYapan.SkorGuncelle(kazanilanPuan);
                saldiriYapan.SeviyePuaniGuncelle(kazanilanPuan);
            }
        }
    }
}
