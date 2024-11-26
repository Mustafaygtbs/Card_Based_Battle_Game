using ProLab2SavasOyunu.Models.Cards;
using ProLab2SavasOyunu.Models.Cards.Deniz;
using ProLab2SavasOyunu.Models.Cards.Hava;
using ProLab2SavasOyunu.Models.Cards.Kara;
using System;
using System.Collections.Generic;

namespace ProLab2SavasOyunu.Services
{
    public class KartDagitimService
    {
        private readonly Random _random = new Random();
        private List<Type> _kartTipleri;

        public KartDagitimService()
        {
            _kartTipleri = new List<Type>();
        }

        private void KartHavuzunuOlustur(int seviyePuani)
        {
            _kartTipleri.Clear();

            
            _kartTipleri.Add(typeof(Ucak));
            _kartTipleri.Add(typeof(Obus));
            _kartTipleri.Add(typeof(Firkateyn));

          
            if (seviyePuani >= 20)
            {
                _kartTipleri.Add(typeof(Siha));
                _kartTipleri.Add(typeof(KFS));
                _kartTipleri.Add(typeof(Sida));
            }
        }

        public List<SavasAraclari> KartlariDagit(int adet, int seviyePuani, int baslangicSeviyePuani)
        {
            KartHavuzunuOlustur(seviyePuani);
            var dagitilanKartlar = new List<SavasAraclari>();

            for (int i = 0; i < adet; i++)
            {
                int index = _random.Next(_kartTipleri.Count);
                var kart = (SavasAraclari)Activator.CreateInstance(_kartTipleri[index], baslangicSeviyePuani);
                dagitilanKartlar.Add(kart);
            }

            return dagitilanKartlar;
        }



        public SavasAraclari YeniKartVer(int seviyePuani)
        {
            KartHavuzunuOlustur(seviyePuani);
            int index = _random.Next(_kartTipleri.Count);
            var kart = (SavasAraclari)Activator.CreateInstance(_kartTipleri[index]);
            return kart;
        }
    }
}
