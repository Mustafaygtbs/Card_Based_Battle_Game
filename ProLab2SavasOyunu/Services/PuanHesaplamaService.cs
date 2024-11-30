using ProLab2SavasOyunu.Models.Cards;
using ProLab2SavasOyunu.Models.Oyuncular;
using System;

namespace ProLab2SavasOyunu.Services
{
    public class PuanHesaplamaService
    {
        public void SkorHesapla(Oyuncu eleyenOyuncu, Oyuncu elenenOyuncu, SavasAraclari eleyenKart, SavasAraclari elenenKart)
        {
            if (elenenKart.Dayaniklilik <= 0)
            {
                int kazanilanSeviyePuani = Math.Max(elenenKart.SeviyePuani, 10); 
                eleyenKart.SeviyePuaniGuncelle(kazanilanSeviyePuani); 
                eleyenOyuncu.SkorGuncelle(kazanilanSeviyePuani); 
                if (elenenOyuncu.Skor < 10)
                {
                    elenenOyuncu.Skor = 10;
                }

                elenenKart.ElenmisMi = true; 
            }
        }
    }
}
