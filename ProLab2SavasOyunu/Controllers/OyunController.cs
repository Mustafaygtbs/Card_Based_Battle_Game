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
                int kullaniciHasar = kullaniciKart.SaldiriHesapla(bilgisayarKart);
                int bilgisayarHasar = bilgisayarKart.SaldiriHesapla(kullaniciKart);

                bilgisayarKart.DurumGuncelle(kullaniciHasar);
                kullaniciKart.DurumGuncelle(bilgisayarHasar);

                // Puan hesaplama
                puanHesaplamaService.SkorHesapla(Kullanici, Bilgisayar, kullaniciKart, bilgisayarKart);

                // Vuruş avantajlarını hesapla
                int kullaniciAvantaj = kullaniciKart.GetVurusAvantaji(bilgisayarKart);
                int bilgisayarAvantaj = bilgisayarKart.GetVurusAvantaji(kullaniciKart);

                // Loglama
                string turNumarasi = (GuncelTur).ToString();

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
                    KazanilanPuan = kullaniciKart.Dayaniklilik <= 0 ? 10 : 0
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
                    KazanilanPuan = bilgisayarKart.Dayaniklilik <= 0 ? 10 : 0
                });

                // Kartların durumunu kontrol et ve logla
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

            // Tur loglarını ekranda gösterme
            string turLoguMesaji = $"Tur {GuncelTur - 1} Sonuçları:\n";
            turLoguMesaji += string.Join("\n", turLoglari);
            MessageBox.Show(turLoguMesaji);

            if (GuncelTur > ToplamTurSayisi)
            {
                OyunSonucu();
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

            // Sonucu gösteriyoruz
            MessageBox.Show(mesaj);

            // Logları yeni bir formda gösteriyoruz
            LogForm logForm = new LogForm(tumLoglar);
            logForm.ShowDialog();
           

           
        }



        public void LoglariGoster()
        {
            logger.LoglariYazdir();
        }
    }
}
