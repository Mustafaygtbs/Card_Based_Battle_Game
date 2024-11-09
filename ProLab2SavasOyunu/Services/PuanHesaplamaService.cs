using ProLab2SavasOyunu.Models.Cards;
using ProLab2SavasOyunu.Models.Oyuncular;

namespace ProLab2SavasOyunu.Services
{
    public class PuanHesaplamaService
    {
        public void SkorHesapla(Oyuncu oyuncu, Oyuncu rakip, SavasAraclari oyuncuKart, SavasAraclari rakipKart)
        {
            // Rakip kartın dayanıklılığı sıfır veya altına düştüyse
            if (rakipKart.Dayaniklilik <= 0)
            {
                int kazanilanPuan = rakipKart.SeviyePuani >= 10 ? rakipKart.SeviyePuani : 10;
                oyuncu.SkorGuncelle(kazanilanPuan);
                oyuncu.SeviyePuaniGuncelle(kazanilanPuan);
            }

            // Oyuncu kartının dayanıklılığı sıfır veya altına düştüyse
            if (oyuncuKart.Dayaniklilik <= 0)
            {
                int kazanilanPuan = oyuncuKart.SeviyePuani >= 10 ? oyuncuKart.SeviyePuani : 10;
                rakip.SkorGuncelle(kazanilanPuan);
                rakip.SeviyePuaniGuncelle(kazanilanPuan);
            }
        }
    }
}
