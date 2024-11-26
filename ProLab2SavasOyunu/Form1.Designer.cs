namespace ProLab2SavasOyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.bilgisayarKartlariFlowPanelA = new System.Windows.Forms.FlowLayoutPanel();
            this.gbBilgisayarKartlari = new System.Windows.Forms.GroupBox();
            this.oyuncuKartlariFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gbOyuncuKartlari = new System.Windows.Forms.GroupBox();
            this.btnSavasBaslat = new System.Windows.Forms.Button();
            this.lblBilgisayarSeviyePuani = new System.Windows.Forms.Label();
            this.lblKullaniciSeviyePuani = new System.Windows.Forms.Label();
            this.flowLayoutPanelKullaniciSecilenKartlar = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelBilgisayarSecilenKartlar = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbBilgisayarKartlari.SuspendLayout();
            this.gbOyuncuKartlari.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bilgisayarKartlariFlowPanelA
            // 
            this.bilgisayarKartlariFlowPanelA.AutoScroll = true;
            this.bilgisayarKartlariFlowPanelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bilgisayarKartlariFlowPanelA.Location = new System.Drawing.Point(4, 19);
            this.bilgisayarKartlariFlowPanelA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bilgisayarKartlariFlowPanelA.Name = "bilgisayarKartlariFlowPanelA";
            this.bilgisayarKartlariFlowPanelA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bilgisayarKartlariFlowPanelA.Size = new System.Drawing.Size(412, 733);
            this.bilgisayarKartlariFlowPanelA.TabIndex = 0;
            // 
            // gbBilgisayarKartlari
            // 
            this.gbBilgisayarKartlari.Controls.Add(this.bilgisayarKartlariFlowPanelA);
            this.gbBilgisayarKartlari.Location = new System.Drawing.Point(1627, 67);
            this.gbBilgisayarKartlari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBilgisayarKartlari.Name = "gbBilgisayarKartlari";
            this.gbBilgisayarKartlari.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBilgisayarKartlari.Size = new System.Drawing.Size(420, 756);
            this.gbBilgisayarKartlari.TabIndex = 0;
            this.gbBilgisayarKartlari.TabStop = false;
            this.gbBilgisayarKartlari.Text = "Bilgisayar Kartları";
            // 
            // oyuncuKartlariFlowPanel
            // 
            this.oyuncuKartlariFlowPanel.AutoScroll = true;
            this.oyuncuKartlariFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oyuncuKartlariFlowPanel.Location = new System.Drawing.Point(4, 19);
            this.oyuncuKartlariFlowPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oyuncuKartlariFlowPanel.Name = "oyuncuKartlariFlowPanel";
            this.oyuncuKartlariFlowPanel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oyuncuKartlariFlowPanel.Size = new System.Drawing.Size(395, 852);
            this.oyuncuKartlariFlowPanel.TabIndex = 1;
            // 
            // gbOyuncuKartlari
            // 
            this.gbOyuncuKartlari.Controls.Add(this.oyuncuKartlariFlowPanel);
            this.gbOyuncuKartlari.Location = new System.Drawing.Point(71, 22);
            this.gbOyuncuKartlari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOyuncuKartlari.Name = "gbOyuncuKartlari";
            this.gbOyuncuKartlari.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOyuncuKartlari.Size = new System.Drawing.Size(403, 875);
            this.gbOyuncuKartlari.TabIndex = 2;
            this.gbOyuncuKartlari.TabStop = false;
            this.gbOyuncuKartlari.Text = "Oyuncu Kartları";
            // 
            // btnSavasBaslat
            // 
            this.btnSavasBaslat.Location = new System.Drawing.Point(904, 353);
            this.btnSavasBaslat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavasBaslat.Name = "btnSavasBaslat";
            this.btnSavasBaslat.Size = new System.Drawing.Size(85, 78);
            this.btnSavasBaslat.TabIndex = 3;
            this.btnSavasBaslat.Text = "Devam";
            this.btnSavasBaslat.UseVisualStyleBackColor = true;
            this.btnSavasBaslat.Click += new System.EventHandler(this.btnSavasBaslat_Click_1);
            // 
            // lblBilgisayarSeviyePuani
            // 
            this.lblBilgisayarSeviyePuani.AutoSize = true;
            this.lblBilgisayarSeviyePuani.Location = new System.Drawing.Point(896, 494);
            this.lblBilgisayarSeviyePuani.Name = "lblBilgisayarSeviyePuani";
            this.lblBilgisayarSeviyePuani.Size = new System.Drawing.Size(27, 16);
            this.lblBilgisayarSeviyePuani.TabIndex = 6;
            this.lblBilgisayarSeviyePuani.Text = "-----";
            // 
            // lblKullaniciSeviyePuani
            // 
            this.lblKullaniciSeviyePuani.AutoSize = true;
            this.lblKullaniciSeviyePuani.Location = new System.Drawing.Point(896, 612);
            this.lblKullaniciSeviyePuani.Name = "lblKullaniciSeviyePuani";
            this.lblKullaniciSeviyePuani.Size = new System.Drawing.Size(35, 16);
            this.lblKullaniciSeviyePuani.TabIndex = 7;
            this.lblKullaniciSeviyePuani.Text = "-------";
            // 
            // flowLayoutPanelKullaniciSecilenKartlar
            // 
            this.flowLayoutPanelKullaniciSecilenKartlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelKullaniciSecilenKartlar.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanelKullaniciSecilenKartlar.Name = "flowLayoutPanelKullaniciSecilenKartlar";
            this.flowLayoutPanelKullaniciSecilenKartlar.Size = new System.Drawing.Size(303, 774);
            this.flowLayoutPanelKullaniciSecilenKartlar.TabIndex = 0;
            // 
            // flowLayoutPanelBilgisayarSecilenKartlar
            // 
            this.flowLayoutPanelBilgisayarSecilenKartlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBilgisayarSecilenKartlar.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanelBilgisayarSecilenKartlar.Name = "flowLayoutPanelBilgisayarSecilenKartlar";
            this.flowLayoutPanelBilgisayarSecilenKartlar.Size = new System.Drawing.Size(323, 749);
            this.flowLayoutPanelBilgisayarSecilenKartlar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanelKullaniciSecilenKartlar);
            this.groupBox1.Location = new System.Drawing.Point(542, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 795);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcının Seçilen Kartları";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanelBilgisayarSecilenKartlar);
            this.groupBox2.Location = new System.Drawing.Point(1233, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 770);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgisayarın Seçilen Kartları";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2404, 1100);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblKullaniciSeviyePuani);
            this.Controls.Add(this.lblBilgisayarSeviyePuani);
            this.Controls.Add(this.btnSavasBaslat);
            this.Controls.Add(this.gbOyuncuKartlari);
            this.Controls.Add(this.gbBilgisayarKartlari);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbBilgisayarKartlari.ResumeLayout(false);
            this.gbOyuncuKartlari.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel bilgisayarKartlariFlowPanelA;
        private System.Windows.Forms.GroupBox gbBilgisayarKartlari;
        private System.Windows.Forms.FlowLayoutPanel oyuncuKartlariFlowPanel;
        private System.Windows.Forms.GroupBox gbOyuncuKartlari;
        private System.Windows.Forms.Button btnSavasBaslat;
        private System.Windows.Forms.Label lblBilgisayarSeviyePuani;
        private System.Windows.Forms.Label lblKullaniciSeviyePuani;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKullaniciSecilenKartlar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBilgisayarSecilenKartlar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

