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
        private int guncelTur = 1; 
        private Oyuncu bilgisayar;
        private Oyuncu oyuncu;

        public Form1(int kartSayisi, int turSayisi)
        {
            InitializeComponent();
            _kartSayisi = kartSayisi;
            _turSayisi = turSayisi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Örnek kart listeleri oluşturuluyor
            bilgisayar = new Oyuncu(1, "Bilgisayar");
            oyuncu = new Oyuncu(2, "Kullanıcı");

            // Bilgisayar ve oyuncuya kartlar dağıtılıyor
            KartDagitimService kartDagitimService = new KartDagitimService();
            bilgisayar.KartListesi = kartDagitimService.KartlariDagit(_kartSayisi, bilgisayar.Skor);
            oyuncu.KartListesi = kartDagitimService.KartlariDagit(_kartSayisi, oyuncu.Skor);

            BilgisayarKartlariniGoster();
            OyuncuKartlariniGoster();
        }

        // Yeni bir tur başlatan fonksiyon
        private void YeniTurBaslat()
        {
            if (guncelTur <= _turSayisi)
            {
                MessageBox.Show($"Tur {guncelTur} başlıyor!");
                // Savaş işlemlerini başlatmak için gerekli fonksiyonları burada çağırabilirsiniz.
                guncelTur++;
            }
            else
            {
                OyunBitti();
            }
        }

        private void OyunBitti()
        {
            MessageBox.Show("Oyun Bitti! Skorları değerlendirin.");
            // Oyun bittiğinde yapılacak diğer işlemler
        }

        private void BilgisayarKartlariniGoster()
        {
            bilgisayarKartlariFlowPanelA.Controls.Clear();
            foreach (var kart in bilgisayar.KartListesi)
            {
                var kartControl = new KartControl(kart)
                {
                    Size = new Size(180, 150)
                };
                bilgisayarKartlariFlowPanelA.Controls.Add(kartControl);
            }
        }

        private void OyuncuKartlariniGoster()
        {
            oyuncuKartlariFlowPanel.Controls.Clear();
            foreach (var kart in oyuncu.KartListesi)
            {
                var kartControl = new KartControl(kart)
                {
                    Size = new Size(180, 150)
                };
                oyuncuKartlariFlowPanel.Controls.Add(kartControl);
            }
        }

        public void SavasAlaninaKartEkle(SavasAraclari oyuncuKart, SavasAraclari bilgisayarKart)
        {
            savasAlaniFlowPanel.Controls.Clear();
            var oyuncuKartControl = new KartControl(oyuncuKart)
            {
                Size = new Size(180, 150)
            };
            var bilgisayarKartControl = new KartControl(bilgisayarKart)
            {
                Size = new Size(180, 150)
            };
            savasAlaniFlowPanel.Controls.Add(oyuncuKartControl);
            savasAlaniFlowPanel.Controls.Add(bilgisayarKartControl);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
