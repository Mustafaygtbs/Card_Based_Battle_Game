﻿using ProLab2SavasOyunu.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProLab2SavasOyunu.Models.Oyuncular
{
    public class Oyuncu
    {
        public int OyuncuID { get; set; }
        public string OyuncuAdi { get; set; }
        public int Skor { get;  set; }
        public List<SavasAraclari> KartListesi { get; set; }
        private List<Guid> KullanilanKartlar { get; set; }

        private readonly Random _random;

        public Oyuncu()
        {
            KartListesi = new List<SavasAraclari>();
            KullanilanKartlar = new List<Guid>();
            _random = new Random();
        }

        public Oyuncu(int oyuncuID, string oyuncuAdi) : this()
        {
            OyuncuID = oyuncuID;
            OyuncuAdi = oyuncuAdi;
            Skor = 0;
        }

        public List<SavasAraclari> KartSec(int adet)
        {
            var secilenKartlar = new List<SavasAraclari>();

            var kullanilabilirKartlar = KullanilmayanKartlariGetir();


            if (kullanilabilirKartlar.Count < adet)
            {
                KartlariSifirla();
                kullanilabilirKartlar = KullanilmayanKartlariGetir();
            }

            while (secilenKartlar.Count < adet && kullanilabilirKartlar.Count > 0)
            {
                int index = _random.Next(kullanilabilirKartlar.Count);
                var kart = kullanilabilirKartlar[index];

                secilenKartlar.Add(kart);
                kart.KullanildiMi = true;
                kullanilabilirKartlar.RemoveAt(index);
            }

            return secilenKartlar;
        }

        public List<SavasAraclari> KullanilmayanKartlariGetir()
        {
            return KartListesi.Where(k => !k.KullanildiMi).ToList();
        }
        public bool TumKartlarKullanildiMi()
        {
            return KartListesi.All(k => k.KullanildiMi);
        }

        public void KartlariSifirla()
        {
            foreach (var kart in KartListesi)
            {
                kart.KullanildiMi = false;
            }
        }

        public void KartEkle(SavasAraclari kart)
        {
            KartListesi.Add(kart);
        }

        public void SkorGuncelle(int puanArtisi)
        {
            Skor += puanArtisi;
        }
    }
}
