﻿using ProLab2SavasOyunu.Models.Cards;
using ProLab2SavasOyunu.Models.Oyuncular;
using ProLab2SavasOyunu.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProLab2SavasOyunu.Controllers
{
    public class OyunController
    {
        private readonly PuanHesaplamaService puanHesaplamaService;
        private readonly SavasLogger logger;

        public Oyuncu Kullanici { get; private set; }
        public Oyuncu Bilgisayar { get; private set; }
        public int ToplamTurSayisi { get; private set; }
        public int GuncelTur { get; private set; } = 1;

        public OyunController(Oyuncu kullanici, Oyuncu bilgisayar, int toplamTur)
        {
            Kullanici = kullanici;
            Bilgisayar = bilgisayar;
            ToplamTurSayisi = toplamTur;
            puanHesaplamaService = new PuanHesaplamaService();
            logger = new SavasLogger();
        }

        public void SavasBaslat(List<SavasAraclari> kullaniciKartlari, List<SavasAraclari> bilgisayarKartlari)
        {
            if (kullaniciKartlari.Count != 3 || bilgisayarKartlari.Count != 3)
            {
                MessageBox.Show("Kart seçimleri hatalı. 3 kart seçmelisiniz.");
                return;
            }

            List<string> turLoglari = new List<string>();

            for (int i = 0; i < 3; i++)
            {
                var kullaniciKart = kullaniciKartlari[i];
                var bilgisayarKart = bilgisayarKartlari[i];


                int kullaniciHasar = kullaniciKart.SaldiriHesapla(bilgisayarKart);
                bilgisayarKart.DurumGuncelle(kullaniciHasar);


                int bilgisayarHasar = bilgisayarKart.SaldiriHesapla(kullaniciKart);
                kullaniciKart.DurumGuncelle(bilgisayarHasar);


                int kullaniciAvantaj = kullaniciKart.GetVurusAvantaji(bilgisayarKart);

                int bilgisayarAvantaj = bilgisayarKart.GetVurusAvantaji(kullaniciKart);

                string turNumarasi = GuncelTur.ToString();


                if (bilgisayarKart.Dayaniklilik <= 0)
                {
                    puanHesaplamaService.SkorHesapla(Kullanici, Bilgisayar, kullaniciKart, bilgisayarKart);
                }

                if (kullaniciKart.Dayaniklilik <= 0)
                {
                    puanHesaplamaService.SkorHesapla(Bilgisayar, Kullanici, bilgisayarKart, kullaniciKart);
                }


                logger.LogEkle(new SavasLog
                {
                    HamleZamani = DateTime.Now,
                    Tur = turNumarasi,
                    HamleYapan = Kullanici.OyuncuAdi,
                    KullanilanKart = kullaniciKart.AltSinif,
                    Hedef = Bilgisayar.OyuncuAdi,
                    HedefKart = bilgisayarKart.AltSinif,
                    VurulanHasar = kullaniciHasar,
                    Avantaj = kullaniciAvantaj,
                    KazanilanPuan = (bilgisayarKart.Dayaniklilik <= 0) ? 10 : 0
                });

                logger.LogEkle(new SavasLog
                {
                    HamleZamani = DateTime.Now,
                    Tur = turNumarasi,
                    HamleYapan = Bilgisayar.OyuncuAdi,
                    KullanilanKart = bilgisayarKart.AltSinif,
                    Hedef = Kullanici.OyuncuAdi,
                    HedefKart = kullaniciKart.AltSinif,
                    VurulanHasar = bilgisayarHasar,
                    Avantaj = bilgisayarAvantaj,
                    KazanilanPuan = (kullaniciKart.Dayaniklilik <= 0) ? 10 : 0
                });

                if (bilgisayarKart.Dayaniklilik <= 0)
                {
                    turLoglari.Add($"{Bilgisayar.OyuncuAdi}'nın {bilgisayarKart.AltSinif} kartı yok edildi!");
                }
                else
                {
                    turLoglari.Add($"{Bilgisayar.OyuncuAdi}'nın {bilgisayarKart.AltSinif} kartının kalan dayanıklılığı: {bilgisayarKart.Dayaniklilik}");
                }

                if (kullaniciKart.Dayaniklilik <= 0)
                {
                    turLoglari.Add($"{Kullanici.OyuncuAdi}'nın {kullaniciKart.AltSinif} kartı yok edildi!");
                }
                else
                {
                    turLoglari.Add($"{Kullanici.OyuncuAdi}'nın {kullaniciKart.AltSinif} kartının kalan dayanıklılığı: {kullaniciKart.Dayaniklilik}");
                }
            }

            GuncelTur++;


            string turLoguMesaji = $"Tur {GuncelTur - 1} Sonuçları:\n";
            turLoguMesaji += string.Join("\n", turLoglari);
            MessageBox.Show(turLoguMesaji);

          
        }
 
        public void LoglariExcelOlarakKaydet(string dosyaYolu)
        {
            logger.LoglariExcelOlarakKaydet(dosyaYolu);
        }

    }
}
