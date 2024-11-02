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
        private List<SavasAraclari> _havaKartlari;
        private List<SavasAraclari> _karaKartlari;
        private List<SavasAraclari> _denizKartlari;

        public KartDagitimService()
        {
            _random = new Random();
            KartHavuzunuOlustur();
        }

        private void KartHavuzunuOlustur()
        {
            _havaKartlari = new List<SavasAraclari> { new Ucak(), new Ucak(), new Ucak(), new Ucak(), new Ucak(), new Ucak() };
            _karaKartlari = new List<SavasAraclari> { new Obus(), new Obus(), new Obus(), new Obus(), new Obus(), new Obus() };
            _denizKartlari = new List<SavasAraclari> { new Firkateyn(), new Firkateyn(), new Firkateyn(), new Firkateyn(), new Firkateyn(), new Firkateyn() };
        }

        public List<SavasAraclari> KartlariDagit(int adet)
        {
            var dagitilacakKartlar = new List<SavasAraclari>();

            // Her kategoriden belirtilen sayıda kart seçiliyor
            dagitilacakKartlar.AddRange(RastgeleKartSec(_havaKartlari, adet));
            dagitilacakKartlar.AddRange(RastgeleKartSec(_karaKartlari, adet));
            dagitilacakKartlar.AddRange(RastgeleKartSec(_denizKartlari, adet));

            return dagitilacakKartlar;
        }


        private List<SavasAraclari> RastgeleKartSec(List<SavasAraclari> kartListesi, int adet)
        {
            var secilenKartlar = new List<SavasAraclari>();
            for (int i = 0; i < adet; i++)
            {
                if (kartListesi.Count == 0)
                    break;

                int index = _random.Next(kartListesi.Count);
                secilenKartlar.Add(kartListesi[index]);
                kartListesi.RemoveAt(index);
            }
            return secilenKartlar;
        }

        public void YeniKartEkle(int oyuncuSeviyesi)
        {
            if (oyuncuSeviyesi >= 20)
            {
                _havaKartlari.Add(new Siha());
                _karaKartlari.Add(new KFS());
                _denizKartlari.Add(new Sida());
            }
        }
    }
}
