using ProLab2SavasOyunu.Models.Cards;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProLab2SavasOyunu.Controllers
{
    public class KartControl : UserControl
    {
        private PictureBox kartGorsel;
        private Label kartTuruLabel;         // Kart türünü gösterecek olan label
        private Label puanLabel;             // Sol üst köşe
        private Label hasarLabel;            // Sağ üst köşe
        private Label dayaniklilikLabel;     // Sol alt köşe
        private Label seviyePuaniLabel;      // Sağ alt köşe

        public KartControl(SavasAraclari kart)
        {
            InitializeComponent();
            KartGuncelle(kart);              // Kartın bilgilerini günceller
            this.Paint += KartControl_Paint;  // Paint olayını ekliyoruz
        }

        private void InitializeComponent()
        {
            this.kartGorsel = new System.Windows.Forms.PictureBox();
            this.kartTuruLabel = new System.Windows.Forms.Label();
            this.puanLabel = new System.Windows.Forms.Label();
            this.hasarLabel = new System.Windows.Forms.Label();
            this.dayaniklilikLabel = new System.Windows.Forms.Label();
            this.seviyePuaniLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kartGorsel)).BeginInit();
            this.SuspendLayout();
            // 
            // kartGorsel
            // 
            this.kartGorsel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kartGorsel.Location = new System.Drawing.Point(0, 0);
            this.kartGorsel.Name = "kartGorsel";
            this.kartGorsel.Size = new System.Drawing.Size(180, 150);
            this.kartGorsel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kartGorsel.TabIndex = 0;
            this.kartGorsel.TabStop = false;
            this.kartGorsel.Click += new System.EventHandler(this.kartGorsel_Click);
            // 
            // kartTuruLabel
            // 
            this.kartTuruLabel.AutoSize = true;
            this.kartTuruLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.kartTuruLabel.Location = new System.Drawing.Point(60, 25);
            this.kartTuruLabel.Name = "kartTuruLabel";
            this.kartTuruLabel.Size = new System.Drawing.Size(0, 16);
            this.kartTuruLabel.TabIndex = 5;
            // 
            // puanLabel
            // 
            this.puanLabel.AutoSize = true;
            this.puanLabel.Location = new System.Drawing.Point(5, 5);
            this.puanLabel.Name = "puanLabel";
            this.puanLabel.Size = new System.Drawing.Size(38, 13);
            this.puanLabel.TabIndex = 1;
            this.puanLabel.Text = "Puan: ";
            // 
            // hasarLabel
            // 
            this.hasarLabel.AutoSize = true;
            this.hasarLabel.Location = new System.Drawing.Point(115, 5);
            this.hasarLabel.Name = "hasarLabel";
            this.hasarLabel.Size = new System.Drawing.Size(41, 13);
            this.hasarLabel.TabIndex = 2;
            this.hasarLabel.Text = "Hasar: ";
            // 
            // dayaniklilikLabel
            // 
            this.dayaniklilikLabel.AutoSize = true;
            this.dayaniklilikLabel.Location = new System.Drawing.Point(5, 124);
            this.dayaniklilikLabel.Name = "dayaniklilikLabel";
            this.dayaniklilikLabel.Size = new System.Drawing.Size(66, 13);
            this.dayaniklilikLabel.TabIndex = 3;
            this.dayaniklilikLabel.Text = "Dayanıklılık: ";
            // 
            // seviyePuaniLabel
            // 
            this.seviyePuaniLabel.AutoSize = true;
            this.seviyePuaniLabel.Location = new System.Drawing.Point(125, 124);
            this.seviyePuaniLabel.Name = "seviyePuaniLabel";
            this.seviyePuaniLabel.Size = new System.Drawing.Size(45, 13);
            this.seviyePuaniLabel.TabIndex = 4;
            this.seviyePuaniLabel.Text = "Seviye: ";
            // 
            // KartControl
            // 
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.kartTuruLabel);
            this.Controls.Add(this.puanLabel);
            this.Controls.Add(this.hasarLabel);
            this.Controls.Add(this.dayaniklilikLabel);
            this.Controls.Add(this.seviyePuaniLabel);
            this.Controls.Add(this.kartGorsel);
            this.Name = "KartControl";
            this.Size = new System.Drawing.Size(180, 150);
            ((System.ComponentModel.ISupportInitialize)(this.kartGorsel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void KartControl_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20; // Köşe yuvarlaklık değeri

            // Yuvarlak kenarlı bir dikdörtgen çizmek için GraphicsPath kullanıyoruz
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            // Kontrolün `Region` özelliğini yuvarlak kenarlı dikdörtgen yapıyoruz
            this.Region = new Region(path);

            // Çizim efektleri için AntiAliasing
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Kartın kenar çerçevesini çiziyoruz
            using (Pen pen = new Pen(Color.DarkSlateGray, 3))
            {
                e.Graphics.DrawPath(pen, path);
            }
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

            // Kart türünü gösteren label
            kartTuruLabel.Text = kart.GetType().Name;
        }

        private void KartControl_Load(object sender, EventArgs e)
        {
        }

        private void kartGorsel_Click(object sender, EventArgs e)
        {

        }
    }
}
