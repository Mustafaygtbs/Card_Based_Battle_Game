using ProLab2SavasOyunu.Core.Interfaces;
using ProLab2SavasOyunu.Models.Oyuncular;
using ProLab2SavasOyunu.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2SavasOyunu.Controllers
{
    public class OyunController
    {
        private readonly SavasService _savasService;
        private readonly KartDagitimService _kartDagitimService;
        private readonly PuanHesaplamaService _puanHesaplamaService;
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
            _kullanici.KartListesi = _kartDagitimService.KartlariDagit(6);
            _bilgisayar.KartListesi = _kartDagitimService.KartlariDagit(6);

            // Oyun döngüsü
            while (_guncelHamle < _toplamHamleSayisi && !OyunBittiMi())
            {
                _guncelHamle++;
                Console.WriteLine($"Hamle {_guncelHamle}");

                // Kart seçimleri
                var kullaniciKartlari = _kullanici.KartSec();
                var bilgisayarKartlari = _bilgisayar.KartSec();

                // Savaş
                _puanHesaplamaService.SkorHesapla(_kullanici, _bilgisayar, kullaniciKartlari, bilgisayarKartlari);

                // Yeni kart dağıtımı
                _kartDagitimService.YeniKartEkle(_kullanici.SeviyePuani);
                _kartDagitimService.YeniKartEkle(_bilgisayar.SeviyePuani);

                _kullanici.KartEkle(_kartDagitimService.KartlariDagit(1)[0]);
                _bilgisayar.KartEkle(_kartDagitimService.KartlariDagit(1)[0]);

                // Skorları göster
                _kullanici.SkorGoster();
                _bilgisayar.SkorGoster();
            }

            // Oyun sonucu
            OyunSonucu();
        }

        private bool OyunBittiMi()
        {
            return _kullanici.KartListesi.Count == 0 || _bilgisayar.KartListesi.Count == 0;
        }

        private void OyunSonucu()
        {
            if (_kullanici.Skor > _bilgisayar.Skor)
                Console.WriteLine("Oyunu Kullanıcı Kazandı!");
            else if (_bilgisayar.Skor > _kullanici.Skor)
                Console.WriteLine("Oyunu Bilgisayar Kazandı!");
            else
                Console.WriteLine("Oyun Berabere!");
        }
    }
}
