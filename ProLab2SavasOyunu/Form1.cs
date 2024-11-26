using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ProLab2SavasOyunu.Controllers;
using ProLab2SavasOyunu.Models.Cards;
using ProLab2SavasOyunu.Models.Oyuncular;
using ProLab2SavasOyunu.Services;

namespace ProLab2SavasOyunu
{
    public partial class Form1 : Form
    {
        private int _kartSayisi;
        private int _turSayisi;
        private int BaslangicSeviyePuani;
        private Oyuncu bilgisayar;
        private Oyuncu oyuncu;
        private KartDagitimService kartDagitimService;
        private OyunController oyunController;
        private List<SavasAraclari> kullaniciSecilenKartlar;
        private List<SavasAraclari> bilgisayarSecilenKartlar;

        public Form1(int kartSayisi, int turSayisi, int baslangicSeviyePuani)
        {
            InitializeComponent();
            _kartSayisi = kartSayisi;
            _turSayisi = turSayisi;
            BaslangicSeviyePuani = baslangicSeviyePuani;
            kartDagitimService = new KartDagitimService();
            kullaniciSecilenKartlar = new List<SavasAraclari>();
            bilgisayarSecilenKartlar = new List<SavasAraclari>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            bilgisayar = new Oyuncu(1, "Bilgisayar");
            oyuncu = new Oyuncu(2, "Kullanıcı");

            // Kartlar dağıtılıyor
            bilgisayar.KartListesi = kartDagitimService.KartlariDagit(_kartSayisi, bilgisayar.SeviyePuani, BaslangicSeviyePuani);
            oyuncu.KartListesi = kartDagitimService.KartlariDagit(_kartSayisi, oyuncu.SeviyePuani, BaslangicSeviyePuani);

            // OyunController oluşturuluyor
            oyunController = new OyunController(oyuncu, bilgisayar, _turSayisi);

            MessageBox.Show("Oyun başladı!");

            BilgisayarKartlariniGoster();
            OyuncuKartlariniGoster();
            GuncelleSeviyePuanlari();


            btnSavasBaslat.Enabled = false;
        }

        private void KartSecildi(object sender, EventArgs e)
        {
            var kartControl = sender as KartControl;
            if (kartControl == null)
                return;

            var kart = kartControl.Kart;

            if (kartControl.IsSelected)
            {
                // Kart seçildiğinde kontrol edilecek kısım
                if (!kullaniciSecilenKartlar.Contains(kart))
                {
                    // Önce, tüm kartların kullanılıp kullanılmadığını kontrol edelim
                    if (oyuncu.TumKartlarKullanildiMi())
                    {
                        // Tüm kartlar kullanıldıysa, kartları sıfırla ve tekrar kullanılabilir hale getir
                        oyuncu.KartlariSifirla();

                        // Arayüzü güncelle
                        OyuncuKartlariniGoster();
                    }

                    // Kartın daha önce kullanılıp kullanılmadığını kontrol edelim
                    if (kart.KullanildiMi)
                    {
                        MessageBox.Show("Bu kartı şu anda tekrar kullanamazsınız. Tüm kartları en az bir kez kullanmalısınız.");
                        kartControl.TemizleSecim();
                        return;
                    }

                    if (kullaniciSecilenKartlar.Count < 3)
                    {
                        kullaniciSecilenKartlar.Add(kart);
                        kart.KullanildiMi = true; // Kartın kullanıldığını işaretle
                    }
                    else
                    {
                        MessageBox.Show("En fazla 3 kart seçebilirsiniz!");
                        kartControl.TemizleSecim();
                        return;
                    }
                }
            }
            else
            {
                // Kart seçimi kaldırıldı
                if (kullaniciSecilenKartlar.Contains(kart))
                {
                    kullaniciSecilenKartlar.Remove(kart);
                    kart.KullanildiMi = false; // Kartın kullanımını geri al
                }
            }

            // 3 kart seçildiğinde savaşı başlat butonunu aktif ediyoruz
            btnSavasBaslat.Enabled = kullaniciSecilenKartlar.Count == 3;
        }






        private void SavasBaslat()
        {
            try
            {
                // Bilgisayarın rastgele 3 kart seçmesi
                bilgisayarSecilenKartlar = bilgisayar.KartSec(3);

                // Seçilen kartları savaş alanında göster
                SavasAlaniniGoster();

                // OyunController üzerinden savaş başlat
                oyunController.SavasBaslat(kullaniciSecilenKartlar, bilgisayarSecilenKartlar);

                // Savaş sonrasında güncellemeler
                SavasSonrasiGuncelle();

                // Oyuncunun ve bilgisayarın elindeki kart sayısını kontrol ediyoruz
                bool oyuncuDevamEdebilir = OyuncununKartlariniKontrolEt();
                bool bilgisayarDevamEdebilir = BilgisayarinKartlariniKontrolEt();

                if (!oyuncuDevamEdebilir || !bilgisayarDevamEdebilir)
                {
                    // Eğer herhangi bir oyuncunun kartı kalmadıysa, oyun biter
                    OyunBitti();
                    return;
                }

                // Tur sayısını kontrol et
                if (oyunController.GuncelTur > _turSayisi)
                {
                    OyunBitti();
                }
                else
                {
                    MessageBox.Show($"Tur {oyunController.GuncelTur - 1} tamamlandı. Bir sonraki tura geçebilirsiniz.");

                    // Arayüzü güncelliyoruz
                    BilgisayarKartlariniGoster();
                    OyuncuKartlariniGoster();

                    btnSavasBaslat.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private bool OyuncununKartlariniKontrolEt()
        {
            // Oyuncunun elindeki kart sayısını kontrol ediyoruz
            int mevcutKartSayisi = oyuncu.KartListesi.Count;

            if (mevcutKartSayisi == 0)
            {
                // Oyuncunun kartı kalmadı, oyun biter
                return false;
            }
            else if (mevcutKartSayisi == 1 || mevcutKartSayisi == 2)
            {
                int eklenecekKartSayisi = 3 - mevcutKartSayisi;

                for (int i = 0; i < eklenecekKartSayisi; i++)
                {
                    oyuncu.KartEkle(kartDagitimService.YeniKartVer(oyuncu.SeviyePuani));
                }
            }

            // Oyuncunun kartı var, oyun devam edebilir
            return true;
        }

        private bool BilgisayarinKartlariniKontrolEt()
        {
            // Bilgisayarın elindeki kart sayısını kontrol ediyoruz
            int mevcutKartSayisi = bilgisayar.KartListesi.Count;

            if (mevcutKartSayisi == 0)
            {
                // Bilgisayarın kartı kalmadı, oyun biter
                return false;
            }
            else if (mevcutKartSayisi == 1 || mevcutKartSayisi == 2)
            {
                int eklenecekKartSayisi = 3 - mevcutKartSayisi;

                for (int i = 0; i < eklenecekKartSayisi; i++)
                {
                    bilgisayar.KartEkle(kartDagitimService.YeniKartVer(bilgisayar.SeviyePuani));
                }
            }

            // Bilgisayarın kartı var, oyun devam edebilir
            return true;
        }


        private void SavasAlaniniGoster()
        {
            // Kullanıcının seçtiği kartları göster
            flowLayoutPanelKullaniciSecilenKartlar.Controls.Clear();
            foreach (var kart in kullaniciSecilenKartlar)
            {
                var kartControl = new KartControl(kart)
                {
                    Size = new Size(120, 160)
                };
                flowLayoutPanelKullaniciSecilenKartlar.Controls.Add(kartControl);
            }

            // Bilgisayarın seçtiği kartları göster
            flowLayoutPanelBilgisayarSecilenKartlar.Controls.Clear();
            foreach (var kart in bilgisayarSecilenKartlar)
            {
                var kartControl = new KartControl(kart)
                {
                    Size = new Size(120, 160)
                };
                // Eğer bilgisayarın kartlarını gizlemek isterseniz:
                // kartControl.GizleKart();
                flowLayoutPanelBilgisayarSecilenKartlar.Controls.Add(kartControl);
            }
        }





        private void SavasSonrasiGuncelle()
        {
            // Kullanıcı ve bilgisayar kartlarını güncelle
            foreach (var kart in kullaniciSecilenKartlar)
            {
                kart.KullanildiMi = true;
                if (kart.Dayaniklilik <= 0)
                {
                    oyuncu.KartListesi.Remove(kart);
                }
            }

            foreach (var kart in bilgisayarSecilenKartlar)
            {
                kart.KullanildiMi = true;
                if (kart.Dayaniklilik <= 0)
                {
                    bilgisayar.KartListesi.Remove(kart);
                }
            }

            // Seçilen kartları temizle ve arayüzü güncelle
            kullaniciSecilenKartlar.Clear();
            bilgisayarSecilenKartlar.Clear();
            TemizleSecimleri();
            OyuncuKartlariniGoster();
            BilgisayarKartlariniGoster();

            // Savaş alanını temizle
            flowLayoutPanelKullaniciSecilenKartlar.Controls.Clear();
            flowLayoutPanelBilgisayarSecilenKartlar.Controls.Clear();
            GuncelleSeviyePuanlari();
        }


        private void TemizleSecimleri()
        {
            foreach (var control in oyuncuKartlariFlowPanel.Controls)
            {
                if (control is KartControl kartControl)
                {
                    kartControl.TemizleSecim();
                }
            }
        }

        private void OyunBitti()
        {
            string mesaj;

            if (oyuncu.KartListesi.Count == 0 && bilgisayar.KartListesi.Count > 0)
            {
                mesaj = "Oyuncunun kartları bitti, oyun sona erdi. Bilgisayar kazandı!";
            }
            else if (bilgisayar.KartListesi.Count == 0 && oyuncu.KartListesi.Count > 0)
            {
                mesaj = "Bilgisayarın kartları bitti, oyun sona erdi. Oyuncu kazandı!";
            }
            else if (bilgisayar.KartListesi.Count == 0 && oyuncu.KartListesi.Count == 0)
            {
                mesaj = "Her iki oyuncunun da kartları bitti, oyun berabere!";
            }
            else
            {
                // Oyun normal tur sayısına ulaştıysa
                if (oyunController.Kullanici.Skor > oyunController.Bilgisayar.Skor)
                    mesaj = "Oyunu Kullanıcı Kazandı!";
                else if (oyunController.Bilgisayar.Skor > oyunController.Kullanici.Skor)
                    mesaj = "Oyunu Bilgisayar Kazandı!";
                else
                    mesaj = "Oyun Berabere!";
            }

            // Savaş loglarını gösteriyoruz
            oyunController.LoglariGoster();

            // Sonucu gösteriyoruz
            MessageBox.Show(mesaj);

            // Uygulamayı kapatıyoruz
            this.Close();
        }


        private void BilgisayarKartlariniGoster()
        {
            bilgisayarKartlariFlowPanelA.Controls.Clear();
            foreach (var kart in bilgisayar.KartListesi)
            {
                var kartControl = new KartControl(kart);
                                            
                // Bilgisayarın kartlarını gizliyoruz
                kartControl.GizleKart();
                bilgisayarKartlariFlowPanelA.Controls.Add(kartControl);
            }
        }

        private void OyuncuKartlariniGoster()
        {
            oyuncuKartlariFlowPanel.Controls.Clear();
            foreach (var kart in oyuncu.KartListesi)
            {
                var kartControl = new KartControl(kart);

                // Kart seçildiğinde olayı yakalıyoruz
                kartControl.KartSecildi += KartSecildi;
                oyuncuKartlariFlowPanel.Controls.Add(kartControl);

                // Kartın görselini güncelle
                kartControl.KartGuncelle(kart);
            }
        }




        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSavasBaslat_Click_1(object sender, EventArgs e)
        {
            if (kullaniciSecilenKartlar.Count != 3)
            {
                MessageBox.Show("Lütfen 3 kart seçin.");
                return;
            }

            SavasBaslat();
        }
        private void GuncelleSeviyePuanlari()
        {
            lblKullaniciSeviyePuani.Text = $"Kullanıcı Seviye Puanı: {oyuncu.Skor}";
            lblBilgisayarSeviyePuani.Text = $"Bilgisayar Seviye Puanı: {bilgisayar.Skor}";
        }


    }
}
