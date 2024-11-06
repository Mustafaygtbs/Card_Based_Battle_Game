using ProLab2SavasOyunu.Core.Interfaces;
using ProLab2SavasOyunu.Models.Oyuncular;
using ProLab2SavasOyunu.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab2SavasOyunu.Controllers
{
    public class OyunController
    {
        private readonly SavasService _savasService;
        private readonly KartDagitimService _kartDagitimService;
        private readonly PuanHesaplamaService _puanHesaplamaService;
        private readonly SavasLogger _logger = new SavasLogger();  // Loglayıcı örneği
        private Oyuncu _kullanici;
        private Oyuncu _bilgisayar;
        private int _toplamHamleSayisi = 5;
        private int _guncelHamle = 0;

        public OyunController()
        {
            _savasService = new SavasService();
            _kartDagitimService = new KartDagitimService();
            _puanHesaplamaService = new PuanHesaplamaService();
        }

        public void OyunBaslat()
        {
            // Oyuncuları oluştur
            _kullanici = new Oyuncu(1, "Kullanıcı");
            _bilgisayar = new Oyuncu(2, "Bilgisayar");

            // Başlangıç kartlarını dağıt
            _kullanici.KartListesi = _kartDagitimService.KartlariDagit(6,_bilgisayar.SeviyePuani);
            _bilgisayar.KartListesi = _kartDagitimService.KartlariDagit(6,_kullanici.SeviyePuani);

            // Oyun döngüsü
            while (_guncelHamle < _toplamHamleSayisi && !OyunBittiMi())
            {
                _guncelHamle++;
                Console.WriteLine($"Hamle {_guncelHamle}");

                // Kart seçimleri
                var kullaniciKartlari = _kullanici.KartSec();
                var bilgisayarKartlari = _bilgisayar.KartSec();

                // Savaş ve log ekleme
                for (int i = 0; i < kullaniciKartlari.Count; i++)
                {
                    var kart1 = kullaniciKartlari[i];
                    var kart2 = bilgisayarKartlari[i];

                    int saldiri1 = _savasService.SaldiriHesapla(kart1, kart2);
                    int saldiri2 = _savasService.SaldiriHesapla(kart2, kart1);

                    _savasService.SaldiriUygula(kart1, kart2);
                    _savasService.SaldiriUygula(kart2, kart1);

                    // Kullanıcının saldırı logu
                    _logger.LogEkle(new SavasLog
                    {
                        HamleYapan = _kullanici.OyuncuAdi,
                        Hedef = _bilgisayar.OyuncuAdi,
                        VurulanHasar = saldiri1,
                        KazanilanPuan = kart1.Dayaniklilik <= 0 ? 10 : 0,
                        HamleZamani = DateTime.Now
                    });

                    // Bilgisayarın saldırı logu
                    _logger.LogEkle(new SavasLog
                    {
                        HamleYapan = _bilgisayar.OyuncuAdi,
                        Hedef = _kullanici.OyuncuAdi,
                        VurulanHasar = saldiri2,
                        KazanilanPuan = kart2.Dayaniklilik <= 0 ? 10 : 0,
                        HamleZamani = DateTime.Now
                    });
                }

                // Yeni kart dağıtımı
                _kartDagitimService.YeniKartEkle(_kullanici.SeviyePuani);
                _kartDagitimService.YeniKartEkle(_bilgisayar.SeviyePuani);

                _kullanici.KartEkle(_kartDagitimService.KartlariDagit(1,_kullanici.SeviyePuani)[0]);
                _bilgisayar.KartEkle(_kartDagitimService.KartlariDagit(1,_bilgisayar.SeviyePuani)[0]);

                // Skorları göster
                _kullanici.SkorGoster();
                _bilgisayar.SkorGoster();
            }

            // Oyun sonucu ve logları yazdırma
            OyunSonucu();
            _logger.LoglariYazdir(); // Savaş sonunda tüm logları yazdır
        }

        private bool OyunBittiMi()
        {
            return _kullanici.KartListesi.Count == 0 || _bilgisayar.KartListesi.Count == 0;
        }

        private void OyunSonucu()
        {
            if (_kullanici.Skor > _bilgisayar.Skor)
                MessageBox.Show("Oyunu Kullanıcı Kazandı!");
            else if (_bilgisayar.Skor > _kullanici.Skor)
                MessageBox.Show("Oyunu Bilgisayar Kazandı!");
            else
                MessageBox.Show("Oyun Berabere!");
        }
    }
}
