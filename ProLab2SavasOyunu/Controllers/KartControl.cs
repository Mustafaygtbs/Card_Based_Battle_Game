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
        private Label kartTuruLabel;
        private Label puanLabel;
        private Label hasarLabel;
        private Label dayaniklilikLabel;
        private Label seviyePuaniLabel;

        // Event to notify when a card is selected or deselected
        public event EventHandler KartSecildi;

        // Card information
        public SavasAraclari Kart { get; private set; }
        public bool IsSelected { get; set; } = false;

        public KartControl(SavasAraclari kart)
        {
            Kart = kart;
            InitializeComponent();
            KartGuncelle(Kart);
            this.Paint += KartControl_Paint;

            // Set up click events
            this.Click += KartControl_Click;
            AddClickEvent(this.Controls);
        }

        private void AddClickEvent(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                control.Click += KartControl_Click;
                if (control.HasChildren)
                {
                    AddClickEvent(control.Controls);
                }
            }
        }

        private void InitializeComponent()
        {
            this.kartGorsel = new PictureBox();
            this.kartTuruLabel = new Label();
            this.puanLabel = new Label();
            this.hasarLabel = new Label();
            this.dayaniklilikLabel = new Label();
            this.seviyePuaniLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.kartGorsel)).BeginInit();
            this.SuspendLayout();
            // 
            // kartGorsel
            // 
            this.kartGorsel.Location = new Point(0, 0);
            this.kartGorsel.Name = "kartGorsel";
            this.kartGorsel.Size = new Size(120, 160);
            this.kartGorsel.SizeMode = PictureBoxSizeMode.StretchImage;
            this.kartGorsel.TabIndex = 0;
            this.kartGorsel.TabStop = false;
            // 
            // kartTuruLabel
            // 
            this.kartTuruLabel.AutoSize = true;
            this.kartTuruLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.kartTuruLabel.ForeColor = Color.White;
            this.kartTuruLabel.BackColor = Color.FromArgb(128, 0, 0, 0); // Yarı saydam siyah arka plan
            this.kartTuruLabel.Location = new Point(5, 5);
            this.kartTuruLabel.Name = "kartTuruLabel";
            this.kartTuruLabel.Size = new Size(70, 16);
            this.kartTuruLabel.TabIndex = 1;
            this.kartTuruLabel.Text = "Kart Türü";
            // 
            // puanLabel
            // 
            this.puanLabel.AutoSize = true;
            this.puanLabel.Font = new Font("Arial", 8F, FontStyle.Bold);
            this.puanLabel.ForeColor = Color.White;
            this.puanLabel.BackColor = Color.FromArgb(128, 0, 0, 0);
            this.puanLabel.Location = new Point(5, 25);
            this.puanLabel.Name = "puanLabel";
            this.puanLabel.Size = new Size(44, 13);
            this.puanLabel.TabIndex = 2;
            this.puanLabel.Text = "Puan: ";
            // 
            // hasarLabel
            // 
            this.hasarLabel.AutoSize = true;
            this.hasarLabel.Font = new Font("Arial", 8F, FontStyle.Bold);
            this.hasarLabel.ForeColor = Color.White;
            this.hasarLabel.BackColor = Color.FromArgb(128, 0, 0, 0);
            this.hasarLabel.Location = new Point(5, 40);
            this.hasarLabel.Name = "hasarLabel";
            this.hasarLabel.Size = new Size(50, 13);
            this.hasarLabel.TabIndex = 3;
            this.hasarLabel.Text = "Hasar: ";
            // 
            // dayaniklilikLabel
            // 
            this.dayaniklilikLabel.AutoSize = true;
            this.dayaniklilikLabel.Font = new Font("Arial", 8F, FontStyle.Bold);
            this.dayaniklilikLabel.ForeColor = Color.White;
            this.dayaniklilikLabel.BackColor = Color.FromArgb(128, 0, 0, 0);
            this.dayaniklilikLabel.Location = new Point(5, 55);
            this.dayaniklilikLabel.Name = "dayaniklilikLabel";
            this.dayaniklilikLabel.Size = new Size(69, 13);
            this.dayaniklilikLabel.TabIndex = 4;
            this.dayaniklilikLabel.Text = "Dayanıklılık: ";
            // 
            // seviyePuaniLabel
            // 
            this.seviyePuaniLabel.AutoSize = true;
            this.seviyePuaniLabel.Font = new Font("Arial", 8F, FontStyle.Bold);
            this.seviyePuaniLabel.ForeColor = Color.White;
            this.seviyePuaniLabel.BackColor = Color.FromArgb(128, 0, 0, 0);
            this.seviyePuaniLabel.Location = new Point(5, 70);
            this.seviyePuaniLabel.Name = "seviyePuaniLabel";
            this.seviyePuaniLabel.Size = new Size(49, 13);
            this.seviyePuaniLabel.TabIndex = 5;
            this.seviyePuaniLabel.Text = "Seviye: ";
            // 
            // KartControl
            // 
            this.BackColor = Color.Transparent;
            this.Controls.Add(this.kartTuruLabel);
            this.Controls.Add(this.puanLabel);
            this.Controls.Add(this.hasarLabel);
            this.Controls.Add(this.dayaniklilikLabel);
            this.Controls.Add(this.seviyePuaniLabel);
            this.Controls.Add(this.kartGorsel);
            this.Name = "KartControl";
            this.Size = new Size(120, 160);
            this.Margin = new Padding(5);
            ((System.ComponentModel.ISupportInitialize)(this.kartGorsel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Draw rounded corners and border
        private void KartControl_Paint(object sender, PaintEventArgs e)
        {
            int radius = 10;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.DarkSlateGray, 2))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        // Handle card click event
        private void KartControl_Click(object sender, EventArgs e)
        {
            IsSelected = !IsSelected;
            this.BackColor = IsSelected ? Color.FromArgb(128, 0, 255, 0) : Kart.KullanildiMi ? Color.FromArgb(128, 255, 0, 0) : Color.Transparent;

            // Kart seçimi değiştiğinde olayı tetikle
            KartSecildi?.Invoke(this, EventArgs.Empty);
        }

        public void Sec()
        {
            IsSelected = true;
            this.BackColor = Color.FromArgb(128, 0, 255, 0);
            Kart.KullanildiMi = true;
        }

        public void TemizleSecim()
        {
            IsSelected = false;
            // Kartın kullanım durumuna göre arka planı ayarla
            if (Kart.KullanildiMi)
            {
                this.BackColor = Color.FromArgb(128, 255, 0, 0);
            }
            else
            {
                this.BackColor = Color.Transparent;
            }
        }

        public void GizleKart()
        {
            // Hide the card details for the computer's cards
            kartGorsel.Image = null;
            puanLabel.Text = "";
            hasarLabel.Text = "";
            dayaniklilikLabel.Text = "";
            seviyePuaniLabel.Text = "";
            kartTuruLabel.Text = "";
        }

        // Update card information
        public void KartGuncelle(SavasAraclari kart)
        {
            Kart = kart;

            kartGorsel.Image = kart.KartResmi;

            puanLabel.Text = $"Puan: {kart.SeviyePuani}";
            hasarLabel.Text = $"Hasar: {kart.Vurus}";
            dayaniklilikLabel.Text = $"Dayanıklılık: {kart.Dayaniklilik}";
            seviyePuaniLabel.Text = $"Seviye: {kart.SeviyePuani}";
            kartTuruLabel.Text = kart.GetType().Name;

            // Kullanılmış kartların arka planını kırmızı yapalım
            if (kart.KullanildiMi)
            {
                this.BackColor = Color.FromArgb(128, 255, 0, 0); // Yarı saydam kırmızı
            }
            else
            {
                this.BackColor = Color.Transparent; // Varsayılan renk
            }
        }
    }
}
