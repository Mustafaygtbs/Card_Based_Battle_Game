using ProLab2SavasOyunu.Models.Cards.Deniz;
using ProLab2SavasOyunu.Models.Cards.Hava;
using ProLab2SavasOyunu.Models.Cards.Kara;
using ProLab2SavasOyunu.Models.Cards;
using System;
using System.Collections.Generic;

namespace ProLab2SavasOyunu.Services
{
    public class KartDagitimService
    {
        private readonly Random _random;
        private List<SavasAraclari> _kartHavuzu;

        public KartDagitimService()
        {
            _random = new Random();
            _kartHavuzu = new List<SavasAraclari>(); 
        }

        private void KartHavuzunuOlustur(int oyuncuSeviyesi)
        {
            // Seviye bazlı kart havuzunu oluşturuyoruz.
            _kartHavuzu.Clear(); // Kart havuzunu her çağrıda temizliyoruz.

            if (oyuncuSeviyesi >= 20)
            {
                // Oyuncunun seviyesi 20 veya daha fazlaysa güçlü kartları da ekliyoruz
                _kartHavuzu.AddRange(new List<SavasAraclari>
                {
                    new Ucak(), new Ucak(), new Ucak(),
                    new Obus(), new Obus(), new Obus(),
                    new Firkateyn(), new Firkateyn(), new Firkateyn(),
                    new Siha(), new KFS(), new Sida()
                });
            }
            else
            {
                // Seviye 20'den düşükse sadece temel kartlar havuza eklenir
                _kartHavuzu.AddRange(new List<SavasAraclari>
                {
                    new Ucak(), new Ucak(), new Ucak(),
                    new Obus(), new Obus(), new Obus(),
                    new Firkateyn(), new Firkateyn(), new Firkateyn()
                });
            }
        }

        public List<SavasAraclari> KartlariDagit(int adet, int oyuncuSeviyesi)
        {
            // Seviye bazlı kart havuzunu oluşturuyoruz.
            KartHavuzunuOlustur(oyuncuSeviyesi);

            var dagitilacakKartlar = new List<SavasAraclari>();

            // Kullanıcının belirttiği sayı kadar rastgele kart seçiyoruz
            for (int i = 0; i < adet && _kartHavuzu.Count > 0; i++)
            {
                int index = _random.Next(_kartHavuzu.Count);
                dagitilacakKartlar.Add(_kartHavuzu[index]);
                _kartHavuzu.RemoveAt(index); 
            }

            return dagitilacakKartlar;
        }

        public void YeniKartEkle(int oyuncuSeviyesi)
        {
            if (oyuncuSeviyesi >= 20)
            {
                
                _kartHavuzu.Add(new Siha());
                _kartHavuzu.Add(new KFS());
                _kartHavuzu.Add(new Sida());
            }
        }
    }
}
