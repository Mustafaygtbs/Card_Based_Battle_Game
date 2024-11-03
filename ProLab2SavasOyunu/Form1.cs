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
        private Oyuncu bilgisayar;
        private Oyuncu oyuncu;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Örnek kart listeleri oluşturuluyor
            bilgisayar = new Oyuncu(1, "Bilgisayar");
            oyuncu = new Oyuncu(2, "Kullanıcı");

            // Bilgisayar ve oyuncuya kartlar dağıtılıyor
            KartDagitimService kartDagitimService = new KartDagitimService();
            bilgisayar.KartListesi = kartDagitimService.KartlariDagit(6); 
            oyuncu.KartListesi = kartDagitimService.KartlariDagit(6);

            // Kartları FlowPanel'lere ekleyelim
            BilgisayarKartlariniGoster();
            OyuncuKartlariniGoster();
        }

        private void InitializeCustomComponents()
        {
            // Bilgisayar Kartları Flow Panel (Üstte)
            bilgisayarKartlariFlowPanelA = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 200, // Bilgisayar kartları için uygun yükseklik
                BackColor = Color.LightGray,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoScroll = true
            };
            this.Controls.Add(bilgisayarKartlariFlowPanelA);

            // Savaş Alanı Flow Panel (Ortada)
            savasAlaniFlowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill, // Ortadaki alanı tamamen kaplayacak
                BackColor = Color.DarkGray,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoScroll = true
            };
            this.Controls.Add(savasAlaniFlowPanel);

            // Oyuncu Kartları Flow Panel (Altta)
            oyuncuKartlariFlowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 120, // Oyuncu kartları için uygun yükseklik
                BackColor = Color.LightGray,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoScroll = true
            };
            this.Controls.Add(oyuncuKartlariFlowPanel);
        }

        // Bilgisayarın kartlarını göster
        private void BilgisayarKartlariniGoster()
        {
            bilgisayarKartlariFlowPanelA.Controls.Clear();
            foreach (var kart in bilgisayar.KartListesi)
            {
                var kartControl = new KartControl(kart);
                bilgisayarKartlariFlowPanelA.Controls.Add(kartControl);
            }
        }

        // Oyuncunun kartlarını göster
        private void OyuncuKartlariniGoster()
        {
            oyuncuKartlariFlowPanel.Controls.Clear();
            foreach (var kart in oyuncu.KartListesi)
            {
                var kartControl = new KartControl(kart);
                oyuncuKartlariFlowPanel.Controls.Add(kartControl);
            }
        }

        // Savaş alanına seçilen kartları göster
        public void SavasAlaninaKartEkle(SavasAraclari oyuncuKart, SavasAraclari bilgisayarKart)
        {
            savasAlaniFlowPanel.Controls.Clear();
            var oyuncuKartControl = new KartControl(oyuncuKart);
            var bilgisayarKartControl = new KartControl(bilgisayarKart);
            savasAlaniFlowPanel.Controls.Add(oyuncuKartControl);
            savasAlaniFlowPanel.Controls.Add(bilgisayarKartControl);
        }
    }
}
