using ProLab2SavasOyunu.Models.Cards;
using ProLab2SavasOyunu.Models.Oyuncular;

namespace ProLab2SavasOyunu.Services
{
    public class PuanHesaplamaService
    {    
            public void SkorHesapla(Oyuncu eleyenOyuncu, SavasAraclari eleyenKart)
            {
                eleyenOyuncu.SkorGuncelle(10);

                eleyenKart.SeviyePuaniGuncelle(10);
            }    
    }
}
