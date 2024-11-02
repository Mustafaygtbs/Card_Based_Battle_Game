using ProLab2SavasOyunu.Models.Cards.Deniz;
using ProLab2SavasOyunu.Models.Cards.Hava;
using ProLab2SavasOyunu.Models.Cards.Kara;
using ProLab2SavasOyunu.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            KartHavuzunuOlustur();
        }

        private void KartHavuzunuOlustur()
        {
            // Başlangıç kartları
            _kartHavuzu.AddRange(new SavasAraclari[]
            {
                new Ucak(), new Ucak(), new Ucak(),
                new Obus(), new Obus(), new Obus(),
                new Firkateyn(), new Firkateyn(), new Firkateyn()
            });
        }

        public List<SavasAraclari> KartlariDagit(int adet)
        {
            var dagitilacakKartlar = new List<SavasAraclari>();
            for (int i = 0; i < adet; i++)
            {
                if (_kartHavuzu.Count == 0)
                    break;

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
                _kartHavuzu.AddRange(new SavasAraclari[]
                {
                    new Siha(), new KFS(), new Sida()
                });
            }
        }
    }
}
