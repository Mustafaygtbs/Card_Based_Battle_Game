using ProLab2SavasOyunu.Models.Cards;
using ProLab2SavasOyunu.Models.Oyuncular;

namespace ProLab2SavasOyunu.Services
{
    public class PuanHesaplamaService
    {
        public void SkorHesapla(Oyuncu oyuncu, Oyuncu rakip, SavasAraclari oyuncuKart, SavasAraclari rakipKart)
        {
            if (rakipKart.Dayaniklilik <= 0 && !rakipKart.ElenmisMi)
            {
                int kazanilanSeviyePuani = rakipKart.SeviyePuani >= 10 ? rakipKart.SeviyePuani : 10;
                oyuncuKart.SeviyePuaniGuncelle(kazanilanSeviyePuani);

                // Skor otomatik olarak hesaplandığı için SkorGuncelle metodunu çağırmaya gerek yok

                rakipKart.ElenmisMi = true;
            }

            if (oyuncuKart.Dayaniklilik <= 0 && !oyuncuKart.ElenmisMi)
            {
                int kazanilanSeviyePuani = oyuncuKart.SeviyePuani >= 10 ? oyuncuKart.SeviyePuani : 10;
                rakipKart.SeviyePuaniGuncelle(kazanilanSeviyePuani);

                // Skor otomatik olarak hesaplandığı için SkorGuncelle metodunu çağırmaya gerek yok

                oyuncuKart.ElenmisMi = true;
            }
        }



    }
}
