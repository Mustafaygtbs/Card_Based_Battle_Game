using ProLab2SavasOyunu.Models.Cards;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProLab2SavasOyunu.Controllers
{
    public class KartControl : UserControl
    {
        private PictureBox kartGorsel;
        private Label puanLabel;              // Sol üst köşe
        private Label hasarLabel;             // Sağ üst köşe
        private Label dayaniklilikLabel;      // Sol alt köşe
        private Label seviyePuaniLabel;       // Sağ alt köşe

        public KartControl(SavasAraclari kart)
        {
            InitializeComponent();
            KartGuncelle(kart);              // Kartın bilgilerini günceller
        }

        private void InitializeComponent()
        {
            this.kartGorsel = new System.Windows.Forms.PictureBox();
            this.puanLabel = new System.Windows.Forms.Label();
            this.hasarLabel = new System.Windows.Forms.Label();
            this.dayaniklilikLabel = new System.Windows.Forms.Label();
            this.seviyePuaniLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kartGorsel)).BeginInit();
            this.SuspendLayout();
            // 
            // kartGorsel
            // 
            this.kartGorsel.Location = new System.Drawing.Point(31, 30);
            this.kartGorsel.Name = "kartGorsel";
            this.kartGorsel.Size = new System.Drawing.Size(90, 90);
            this.kartGorsel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kartGorsel.TabIndex = 0;
            this.kartGorsel.TabStop = false;
            // 
            // puanLabel
            // 
            this.puanLabel.AutoSize = true;
            this.puanLabel.Location = new System.Drawing.Point(5, 5);
            this.puanLabel.Name = "puanLabel";
            this.puanLabel.Size = new System.Drawing.Size(44, 16);
            this.puanLabel.TabIndex = 1;
            this.puanLabel.Text = "Puan: ";
            // 
            // hasarLabel
            // 
            this.hasarLabel.AutoSize = true;
            this.hasarLabel.Location = new System.Drawing.Point(115, 5);
            this.hasarLabel.Name = "hasarLabel";
            this.hasarLabel.Size = new System.Drawing.Size(50, 16);
            this.hasarLabel.TabIndex = 2;
            this.hasarLabel.Text = "Hasar: ";
            // 
            // dayaniklilikLabel
            // 
            this.dayaniklilikLabel.AutoSize = true;
            this.dayaniklilikLabel.Location = new System.Drawing.Point(5, 130);
            this.dayaniklilikLabel.Name = "dayaniklilikLabel";
            this.dayaniklilikLabel.Size = new System.Drawing.Size(82, 16);
            this.dayaniklilikLabel.TabIndex = 3;
            this.dayaniklilikLabel.Text = "Dayanıklılık: ";
            // 
            // seviyePuaniLabel
            // 
            this.seviyePuaniLabel.AutoSize = true;
            this.seviyePuaniLabel.Location = new System.Drawing.Point(115, 130);
            this.seviyePuaniLabel.Name = "seviyePuaniLabel";
            this.seviyePuaniLabel.Size = new System.Drawing.Size(55, 16);
            this.seviyePuaniLabel.TabIndex = 4;
            this.seviyePuaniLabel.Text = "Seviye: ";
            // 
            // KartControl
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.kartGorsel);
            this.Controls.Add(this.puanLabel);
            this.Controls.Add(this.hasarLabel);
            this.Controls.Add(this.dayaniklilikLabel);
            this.Controls.Add(this.seviyePuaniLabel);
            this.Name = "KartControl";
            this.Size = new System.Drawing.Size(191, 182);
            this.Load += new System.EventHandler(this.KartControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kartGorsel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Kart verilerini güncelleyerek kontrolü dinamik hale getirme
        public void KartGuncelle(SavasAraclari kart)
        {
            // Kart görselini ayarla
            kartGorsel.Image = kart.KartResmi;

            // Kart bilgilerini güncelle
            puanLabel.Text = $"Puan: {kart.SeviyePuani}";
            hasarLabel.Text = $"Hasar: {kart.Vurus}";
            dayaniklilikLabel.Text = $"Dayanıklılık: {kart.Dayaniklilik}";
            seviyePuaniLabel.Text = $"Seviye: {kart.SeviyePuani}";
        }

        private void KartControl_Load(object sender, EventArgs e)
        {

        }
    }
}
