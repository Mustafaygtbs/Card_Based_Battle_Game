﻿using ProLab2SavasOyunu.Models.Cards;
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
            this.kartGorsel.Location = new System.Drawing.Point(2, -1);
            this.kartGorsel.Name = "kartGorsel";
            this.kartGorsel.Size = new System.Drawing.Size(120, 160);
            this.kartGorsel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kartGorsel.TabIndex = 0;
            this.kartGorsel.TabStop = false;
     //       this.kartGorsel.Click += new System.EventHandler(this.kartGorsel_Click);
            // 
            // kartTuruLabel
            // 
            this.kartTuruLabel.AutoSize = true;
            this.kartTuruLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kartTuruLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.kartTuruLabel.ForeColor = System.Drawing.Color.White;
            this.kartTuruLabel.Location = new System.Drawing.Point(5, 5);
            this.kartTuruLabel.Name = "kartTuruLabel";
            this.kartTuruLabel.Size = new System.Drawing.Size(85, 19);
            this.kartTuruLabel.TabIndex = 1;
            this.kartTuruLabel.Text = "Kart Türü";
            // 
            // puanLabel
            // 
            this.puanLabel.AutoSize = true;
            this.puanLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.puanLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.puanLabel.ForeColor = System.Drawing.Color.White;
            this.puanLabel.Location = new System.Drawing.Point(5, 25);
            this.puanLabel.Name = "puanLabel";
            this.puanLabel.Size = new System.Drawing.Size(50, 16);
            this.puanLabel.TabIndex = 2;
            this.puanLabel.Text = "Puan: ";
            // 
            // hasarLabel
            // 
            this.hasarLabel.AutoSize = true;
            this.hasarLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hasarLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.hasarLabel.ForeColor = System.Drawing.Color.White;
            this.hasarLabel.Location = new System.Drawing.Point(5, 40);
            this.hasarLabel.Name = "hasarLabel";
            this.hasarLabel.Size = new System.Drawing.Size(55, 16);
            this.hasarLabel.TabIndex = 3;
            this.hasarLabel.Text = "Hasar: ";
            // 
            // dayaniklilikLabel
            // 
            this.dayaniklilikLabel.AutoSize = true;
            this.dayaniklilikLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dayaniklilikLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.dayaniklilikLabel.ForeColor = System.Drawing.Color.White;
            this.dayaniklilikLabel.Location = new System.Drawing.Point(5, 55);
            this.dayaniklilikLabel.Name = "dayaniklilikLabel";
            this.dayaniklilikLabel.Size = new System.Drawing.Size(93, 16);
            this.dayaniklilikLabel.TabIndex = 4;
            this.dayaniklilikLabel.Text = "Dayanıklılık: ";
            // 
            // seviyePuaniLabel
            // 
            this.seviyePuaniLabel.AutoSize = true;
            this.seviyePuaniLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seviyePuaniLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.seviyePuaniLabel.ForeColor = System.Drawing.Color.White;
            this.seviyePuaniLabel.Location = new System.Drawing.Point(5, 70);
            this.seviyePuaniLabel.Name = "seviyePuaniLabel";
            this.seviyePuaniLabel.Size = new System.Drawing.Size(62, 16);
            this.seviyePuaniLabel.TabIndex = 5;
            this.seviyePuaniLabel.Text = "Seviye: ";
            // 
            // KartControl
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.kartTuruLabel);
            this.Controls.Add(this.puanLabel);
            this.Controls.Add(this.hasarLabel);
            this.Controls.Add(this.dayaniklilikLabel);
            this.Controls.Add(this.seviyePuaniLabel);
            this.Controls.Add(this.kartGorsel);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "KartControl";
            this.Size = new System.Drawing.Size(120, 160);
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
