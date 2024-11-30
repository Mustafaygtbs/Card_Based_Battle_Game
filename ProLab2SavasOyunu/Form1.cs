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

            bilgisayar.KartListesi = kartDagitimService.KartlariDagit(_kartSayisi, bilgisayar.Skor, BaslangicSeviyePuani);
            oyuncu.KartListesi = kartDagitimService.KartlariDagit(_kartSayisi, oyuncu.Skor, BaslangicSeviyePuani);

            oyunController = new OyunController(oyuncu, bilgisayar, _turSayisi);

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
                // kart seçildiğinde yapılacak kontroller
                if (!kullaniciSecilenKartlar.Contains(kart))
                {
                    // tüm kartların kullanılıp kullanılmadığı kontorlü
                    if (oyuncu.TumKartlarKullanildiMi())
                    {
                        
                        oyuncu.KartlariSifirla();

                        OyuncuKartlariniGoster();
                    }

                    //  kullnılıp kullanılmadı kontrolü
                    if (kart.KullanildiMi)
                    {
                        MessageBox.Show("Bu kartı şu anda tekrar kullanamazsınız. Tüm kartları en az bir kez kullanmalısınız.");
                        kartControl.TemizleSecim();
                        return;
                    }

                    if (kullaniciSecilenKartlar.Count < 3)
                    {
                        kullaniciSecilenKartlar.Add(kart);
                        kart.KullanildiMi = true; 
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

                if (kullaniciSecilenKartlar.Contains(kart))
                {
                    kullaniciSecilenKartlar.Remove(kart);
                    kart.KullanildiMi = false; 
                }
            }

            // 3 kart seçince butonu aktif et 
            btnSavasBaslat.Enabled = kullaniciSecilenKartlar.Count == 3;
        }
        private void HerTurSonundaKartEkle()
        {
            // oyuncuya random yeni bir kart 
            var yeniKartOyuncu = kartDagitimService.YeniKartVer(oyuncu.Skor);
            oyuncu.KartEkle(yeniKartOyuncu);

            // bilgisayara random yeni bir kart 
            var yeniKartBilgisayar = kartDagitimService.YeniKartVer(bilgisayar.Skor);
            bilgisayar.KartEkle(yeniKartBilgisayar);

            OyuncuKartlariniGoster();
            BilgisayarKartlariniGoster();
        }

        private void SavasBaslat()
        {
            try
            {
                // pc random 3 kart seçiyor . canın isterse algoritma ekle kolay orta zor diye 
                bilgisayarSecilenKartlar = bilgisayar.KartSec(3);


                SavasAlaniniGoster();

                oyunController.SavasBaslat(kullaniciSecilenKartlar, bilgisayarSecilenKartlar);


                SavasSonrasiGuncelle();

                bool oyuncuDevamEdebilir = OyuncununKartlariniKontrolEt();
                bool bilgisayarDevamEdebilir = BilgisayarinKartlariniKontrolEt();

                if (!oyuncuDevamEdebilir || !bilgisayarDevamEdebilir)
                {
                    OyunBitti();
                    return;
                }

                if (oyunController.GuncelTur > _turSayisi)
                {
                    OyunBitti();
                }
                else
                {
                    TurBilgisiGuncelle();
                //   MessageBox.Show($"Tur {oyunController.GuncelTur - 1} tamamlandı. Bir sonraki tura geçebilirsiniz.");

                    BilgisayarKartlariniGoster();
                    OyuncuKartlariniGoster();

                    btnSavasBaslat.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu:Error code : 3106 {ex.Message}");
            }
        }
        private bool OyuncununKartlariniKontrolEt()
        {
            // Oyuncunun elindeki kart sayısını kontrol ediyoruz
            int mevcutKartSayisi = oyuncu.KartListesi.Count;

            if (mevcutKartSayisi == 0)
            {
                return false;
            }
            else if (mevcutKartSayisi == 1 || mevcutKartSayisi == 2)
            {
                int eklenecekKartSayisi = 3 - mevcutKartSayisi;

                for (int i = 0; i < eklenecekKartSayisi; i++)
                {
                    oyuncu.KartEkle(kartDagitimService.YeniKartVer(oyuncu.Skor));
                }
            }

            return true;
        }
        private bool BilgisayarinKartlariniKontrolEt()
        {
            int mevcutKartSayisi = bilgisayar.KartListesi.Count;

            if (mevcutKartSayisi == 0)
            {

                return false;
            }
            else if (mevcutKartSayisi == 1 || mevcutKartSayisi == 2)
            {
                int eklenecekKartSayisi = 3 - mevcutKartSayisi;

                for (int i = 0; i < eklenecekKartSayisi; i++)
                {
                    bilgisayar.KartEkle(kartDagitimService.YeniKartVer(bilgisayar.Skor));
                }
            }
            return true;
        }


        private void SavasAlaniniGoster()
        {
            flowLayoutPanelKullaniciSecilenKartlar.Controls.Clear();
            foreach (var kart in kullaniciSecilenKartlar)
            {
                var kartControl = new KartControl(kart);
                flowLayoutPanelKullaniciSecilenKartlar.Controls.Add(kartControl);
            }

            flowLayoutPanelBilgisayarSecilenKartlar.Controls.Clear();
            foreach (var kart in bilgisayarSecilenKartlar)
            {
                var kartControl = new KartControl(kart);
                // Eğer bilgisayarın kartlarını gizlemek isterseniz:
                // kartControl.GizleKart();
                flowLayoutPanelBilgisayarSecilenKartlar.Controls.Add(kartControl);
            }
        }

        private void SavasSonrasiGuncelle()
        {
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


            kullaniciSecilenKartlar.Clear();
            bilgisayarSecilenKartlar.Clear();
            TemizleSecimleri();
            OyuncuKartlariniGoster();
            BilgisayarKartlariniGoster();


            flowLayoutPanelKullaniciSecilenKartlar.Controls.Clear();
            flowLayoutPanelBilgisayarSecilenKartlar.Controls.Clear();
            HerTurSonundaKartEkle();
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
                if (oyunController.Kullanici.Skor > oyunController.Bilgisayar.Skor)
                    mesaj = "Oyunu Kullanıcı Kazandı!";
                else if (oyunController.Bilgisayar.Skor > oyunController.Kullanici.Skor)
                    mesaj = "Oyunu Bilgisayar Kazandı!";
                else              
                    mesaj = "Oyun Berabere!";
            }

            string dosyaYolu = "C:\\Users\\Mustafa\\Desktop\\Prolab2\\SavasLoglari.xlsx"; 


            oyunController.LoglariExcelOlarakKaydet(dosyaYolu);

            MessageBox.Show("Savaş sonuçları başarıyla indirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            MessageBox.Show(mesaj);


            this.Close();
        }


        private void BilgisayarKartlariniGoster()
        {
            bilgisayarKartlariFlowPanelA.Controls.Clear();
            foreach (var kart in bilgisayar.KartListesi)
            {
                var kartControl = new KartControl(kart);
                                            
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


                kartControl.KartSecildi += KartSecildi;
                oyuncuKartlariFlowPanel.Controls.Add(kartControl);

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
            lblKullaniciSkor.Text = $"Kullanıcı Seviye Puanı: {oyuncu.Skor}";
            lblBilgisayarSkor.Text = $"Bilgisayar Seviye Puanı: {bilgisayar.Skor}";
        }
        private void TurBilgisiGuncelle()
        {
            lblTurBilgisi.Text = $"Şu anki Tur: {oyunController.GuncelTur}";
        }


    }
}
