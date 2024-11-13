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
            this.savasAlaniFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gbSavasAlani = new System.Windows.Forms.GroupBox();
            this.oyuncuKartlariFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gbOyuncuKartlari = new System.Windows.Forms.GroupBox();
            this.btnSavasBaslat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBilgisayarSeviyePuani = new System.Windows.Forms.Label();
            this.lblKullaniciSeviyePuani = new System.Windows.Forms.Label();
            this.gbBilgisayarKartlari.SuspendLayout();
            this.gbSavasAlani.SuspendLayout();
            this.gbOyuncuKartlari.SuspendLayout();
            this.SuspendLayout();
            // 
            // bilgisayarKartlariFlowPanelA
            // 
            this.bilgisayarKartlariFlowPanelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bilgisayarKartlariFlowPanelA.Location = new System.Drawing.Point(4, 19);
            this.bilgisayarKartlariFlowPanelA.Margin = new System.Windows.Forms.Padding(4);
            this.bilgisayarKartlariFlowPanelA.Name = "bilgisayarKartlariFlowPanelA";
            this.bilgisayarKartlariFlowPanelA.Size = new System.Drawing.Size(2009, 349);
            this.bilgisayarKartlariFlowPanelA.TabIndex = 0;
            // 
            // gbBilgisayarKartlari
            // 
            this.gbBilgisayarKartlari.Controls.Add(this.bilgisayarKartlariFlowPanelA);
            this.gbBilgisayarKartlari.Location = new System.Drawing.Point(139, 33);
            this.gbBilgisayarKartlari.Margin = new System.Windows.Forms.Padding(4);
            this.gbBilgisayarKartlari.Name = "gbBilgisayarKartlari";
            this.gbBilgisayarKartlari.Padding = new System.Windows.Forms.Padding(4);
            this.gbBilgisayarKartlari.Size = new System.Drawing.Size(2017, 372);
            this.gbBilgisayarKartlari.TabIndex = 0;
            this.gbBilgisayarKartlari.TabStop = false;
            this.gbBilgisayarKartlari.Text = "Bilgisayar Kartları";
            // 
            // savasAlaniFlowPanel
            // 
            this.savasAlaniFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savasAlaniFlowPanel.Location = new System.Drawing.Point(4, 19);
            this.savasAlaniFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.savasAlaniFlowPanel.Name = "savasAlaniFlowPanel";
            this.savasAlaniFlowPanel.Size = new System.Drawing.Size(2001, 229);
            this.savasAlaniFlowPanel.TabIndex = 1;
            // 
            // gbSavasAlani
            // 
            this.gbSavasAlani.Controls.Add(this.savasAlaniFlowPanel);
            this.gbSavasAlani.Location = new System.Drawing.Point(16, 394);
            this.gbSavasAlani.Margin = new System.Windows.Forms.Padding(4);
            this.gbSavasAlani.Name = "gbSavasAlani";
            this.gbSavasAlani.Padding = new System.Windows.Forms.Padding(4);
            this.gbSavasAlani.Size = new System.Drawing.Size(2009, 252);
            this.gbSavasAlani.TabIndex = 1;
            this.gbSavasAlani.TabStop = false;
            this.gbSavasAlani.Text = "Seçilen Kartlar";
            // 
            // oyuncuKartlariFlowPanel
            // 
            this.oyuncuKartlariFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oyuncuKartlariFlowPanel.Location = new System.Drawing.Point(4, 19);
            this.oyuncuKartlariFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.oyuncuKartlariFlowPanel.Name = "oyuncuKartlariFlowPanel";
            this.oyuncuKartlariFlowPanel.Size = new System.Drawing.Size(2013, 349);
            this.oyuncuKartlariFlowPanel.TabIndex = 1;
            // 
            // gbOyuncuKartlari
            // 
            this.gbOyuncuKartlari.Controls.Add(this.oyuncuKartlariFlowPanel);
            this.gbOyuncuKartlari.Location = new System.Drawing.Point(16, 654);
            this.gbOyuncuKartlari.Margin = new System.Windows.Forms.Padding(4);
            this.gbOyuncuKartlari.Name = "gbOyuncuKartlari";
            this.gbOyuncuKartlari.Padding = new System.Windows.Forms.Padding(4);
            this.gbOyuncuKartlari.Size = new System.Drawing.Size(2021, 372);
            this.gbOyuncuKartlari.TabIndex = 2;
            this.gbOyuncuKartlari.TabStop = false;
            this.gbOyuncuKartlari.Text = "Oyuncu Kartları";
            // 
            // btnSavasBaslat
            // 
            this.btnSavasBaslat.Location = new System.Drawing.Point(20, 52);
            this.btnSavasBaslat.Name = "btnSavasBaslat";
            this.btnSavasBaslat.Size = new System.Drawing.Size(86, 77);
            this.btnSavasBaslat.TabIndex = 3;
            this.btnSavasBaslat.Text = "Devam";
            this.btnSavasBaslat.UseVisualStyleBackColor = true;
            this.btnSavasBaslat.Click += new System.EventHandler(this.btnSavasBaslat_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bilgisayar Puanları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanıcı puanları";
            // 
            // lblBilgisayarSeviyePuani
            // 
            this.lblBilgisayarSeviyePuani.AutoSize = true;
            this.lblBilgisayarSeviyePuani.Location = new System.Drawing.Point(12, 193);
            this.lblBilgisayarSeviyePuani.Name = "lblBilgisayarSeviyePuani";
            this.lblBilgisayarSeviyePuani.Size = new System.Drawing.Size(27, 16);
            this.lblBilgisayarSeviyePuani.TabIndex = 6;
            this.lblBilgisayarSeviyePuani.Text = "-----";
            // 
            // lblKullaniciSeviyePuani
            // 
            this.lblKullaniciSeviyePuani.AutoSize = true;
            this.lblKullaniciSeviyePuani.Location = new System.Drawing.Point(12, 311);
            this.lblKullaniciSeviyePuani.Name = "lblKullaniciSeviyePuani";
            this.lblKullaniciSeviyePuani.Size = new System.Drawing.Size(35, 16);
            this.lblKullaniciSeviyePuani.TabIndex = 7;
            this.lblKullaniciSeviyePuani.Text = "-------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1040);
            this.Controls.Add(this.lblKullaniciSeviyePuani);
            this.Controls.Add(this.lblBilgisayarSeviyePuani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSavasBaslat);
            this.Controls.Add(this.gbOyuncuKartlari);
            this.Controls.Add(this.gbSavasAlani);
            this.Controls.Add(this.gbBilgisayarKartlari);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbBilgisayarKartlari.ResumeLayout(false);
            this.gbSavasAlani.ResumeLayout(false);
            this.gbOyuncuKartlari.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel bilgisayarKartlariFlowPanelA;
        private System.Windows.Forms.GroupBox gbBilgisayarKartlari;
        private System.Windows.Forms.FlowLayoutPanel savasAlaniFlowPanel;
        private System.Windows.Forms.GroupBox gbSavasAlani;
        private System.Windows.Forms.FlowLayoutPanel oyuncuKartlariFlowPanel;
        private System.Windows.Forms.GroupBox gbOyuncuKartlari;
        private System.Windows.Forms.Button btnSavasBaslat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBilgisayarSeviyePuani;
        private System.Windows.Forms.Label lblKullaniciSeviyePuani;
    }
}

