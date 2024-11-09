using ProLab2SavasOyunu.Models.Cards;
using ProLab2SavasOyunu.Models.Oyuncular;
using ProLab2SavasOyunu.Services;
using System;
using System.Collections.Generic;
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

            // Tur loglarını tutmak için
            List<string> turLoglari = new List<string>();

            // Her iki oyuncunun seçtiği kartları sırasıyla karşılaştırıyoruz
            for (int i = 0; i < 3; i++)
            {
                var kullaniciKart = kullaniciKartlari[i];
                var bilgisayarKart = bilgisayarKartlari[i];

                // Karşılıklı saldırılar
                kullaniciKart.SaldiriUygula(bilgisayarKart);
                bilgisayarKart.SaldiriUygula(kullaniciKart);

                // Puan hesaplama
                puanHesaplamaService.SkorHesapla(Kullanici, Bilgisayar, kullaniciKart, bilgisayarKart);

                // Loglama
                string kullaniciLog = $"{Kullanici.OyuncuAdi} {kullaniciKart.AltSinif} ile {Bilgisayar.OyuncuAdi} {bilgisayarKart.AltSinif} kartına saldırdı. Vurulan Hasar: {kullaniciKart.Vurus}";
                string bilgisayarLog = $"{Bilgisayar.OyuncuAdi} {bilgisayarKart.AltSinif} ile {Kullanici.OyuncuAdi} {kullaniciKart.AltSinif} kartına saldırdı. Vurulan Hasar: {bilgisayarKart.Vurus}";

                turLoglari.Add(kullaniciLog);
                turLoglari.Add(bilgisayarLog);

                // Logger'a ekleme
                logger.LogEkle(new SavasLog
                {
                    HamleYapan = Kullanici.OyuncuAdi,
                    Hedef = Bilgisayar.OyuncuAdi,
                    VurulanHasar = kullaniciKart.Vurus,
                    KazanilanPuan = kullaniciKart.Dayaniklilik <= 0 ? 10 : 0,
                    HamleZamani = DateTime.Now
                });

                logger.LogEkle(new SavasLog
                {
                    HamleYapan = Bilgisayar.OyuncuAdi,
                    Hedef = Kullanici.OyuncuAdi,
                    VurulanHasar = bilgisayarKart.Vurus,
                    KazanilanPuan = bilgisayarKart.Dayaniklilik <= 0 ? 10 : 0,
                    HamleZamani = DateTime.Now
                });
            }

            GuncelTur++;

            // Tur loglarını ekranda gösterme
            string turLoguMesaji = $"Tur {GuncelTur - 1} Sonuçları:\n";
            turLoguMesaji += string.Join("\n", turLoglari);
            MessageBox.Show(turLoguMesaji);

            if (GuncelTur > ToplamTurSayisi)
            {
                OyunSonucu();
            }
            else
            {
                // Bir sonraki tura geçebilirsiniz mesajını kaldırıyoruz çünkü tur loglarını zaten gösterdik
            }
        }


        private void OyunSonucu()
        {
            string mesaj;
            if (Kullanici.Skor > Bilgisayar.Skor)
                mesaj = "Oyunu Kullanıcı Kazandı!";
            else if (Bilgisayar.Skor > Kullanici.Skor)
                mesaj = "Oyunu Bilgisayar Kazandı!";
            else
                mesaj = "Oyun Berabere!";

            // Tüm logları alıyoruz
            List<SavasLog> tumLoglar = logger.LoglariAl();

            // Logları formatlıyoruz
            string tumLogMesaji = "Savaş Logları:\n";
            foreach (var log in tumLoglar)
            {
                tumLogMesaji += $"{log.HamleZamani}: {log.HamleYapan} -> {log.Hedef}, Hasar: {log.VurulanHasar}, Kazanılan Puan: {log.KazanilanPuan}\n";
            }

            // Sonucu ve logları gösteriyoruz
            MessageBox.Show($"{mesaj}\n\n{tumLogMesaji}");
        }


        public void LoglariGoster()
        {
            logger.LoglariYazdir();
        }
    }
}
