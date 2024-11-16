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
            this.bilgisayarKartlariFlowPanelA.AutoScroll = true;
            this.bilgisayarKartlariFlowPanelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bilgisayarKartlariFlowPanelA.Location = new System.Drawing.Point(3, 16);
            this.bilgisayarKartlariFlowPanelA.Margin = new System.Windows.Forms.Padding(5);
            this.bilgisayarKartlariFlowPanelA.Name = "bilgisayarKartlariFlowPanelA";
            this.bilgisayarKartlariFlowPanelA.Padding = new System.Windows.Forms.Padding(5);
            this.bilgisayarKartlariFlowPanelA.Size = new System.Drawing.Size(814, 283);
            this.bilgisayarKartlariFlowPanelA.TabIndex = 0;
            // 
            // gbBilgisayarKartlari
            // 
            this.gbBilgisayarKartlari.Controls.Add(this.bilgisayarKartlariFlowPanelA);
            this.gbBilgisayarKartlari.Location = new System.Drawing.Point(202, 26);
            this.gbBilgisayarKartlari.Name = "gbBilgisayarKartlari";
            this.gbBilgisayarKartlari.Size = new System.Drawing.Size(820, 302);
            this.gbBilgisayarKartlari.TabIndex = 0;
            this.gbBilgisayarKartlari.TabStop = false;
            this.gbBilgisayarKartlari.Text = "Bilgisayar Kartları";
            // 
            // savasAlaniFlowPanel
            // 
            this.savasAlaniFlowPanel.AutoScroll = true;
            this.savasAlaniFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savasAlaniFlowPanel.Location = new System.Drawing.Point(3, 16);
            this.savasAlaniFlowPanel.Margin = new System.Windows.Forms.Padding(5);
            this.savasAlaniFlowPanel.Name = "savasAlaniFlowPanel";
            this.savasAlaniFlowPanel.Padding = new System.Windows.Forms.Padding(5);
            this.savasAlaniFlowPanel.Size = new System.Drawing.Size(1501, 186);
            this.savasAlaniFlowPanel.TabIndex = 1;
            // 
            // gbSavasAlani
            // 
            this.gbSavasAlani.Controls.Add(this.savasAlaniFlowPanel);
            this.gbSavasAlani.Location = new System.Drawing.Point(12, 320);
            this.gbSavasAlani.Name = "gbSavasAlani";
            this.gbSavasAlani.Size = new System.Drawing.Size(1507, 205);
            this.gbSavasAlani.TabIndex = 1;
            this.gbSavasAlani.TabStop = false;
            this.gbSavasAlani.Text = "Seçilen Kartlar";
            // 
            // oyuncuKartlariFlowPanel
            // 
            this.oyuncuKartlariFlowPanel.AutoScroll = true;
            this.oyuncuKartlariFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oyuncuKartlariFlowPanel.Location = new System.Drawing.Point(3, 16);
            this.oyuncuKartlariFlowPanel.Margin = new System.Windows.Forms.Padding(5);
            this.oyuncuKartlariFlowPanel.Name = "oyuncuKartlariFlowPanel";
            this.oyuncuKartlariFlowPanel.Padding = new System.Windows.Forms.Padding(5);
            this.oyuncuKartlariFlowPanel.Size = new System.Drawing.Size(1510, 283);
            this.oyuncuKartlariFlowPanel.TabIndex = 1;
            // 
            // gbOyuncuKartlari
            // 
            this.gbOyuncuKartlari.Controls.Add(this.oyuncuKartlariFlowPanel);
            this.gbOyuncuKartlari.Location = new System.Drawing.Point(12, 531);
            this.gbOyuncuKartlari.Name = "gbOyuncuKartlari";
            this.gbOyuncuKartlari.Size = new System.Drawing.Size(1516, 302);
            this.gbOyuncuKartlari.TabIndex = 2;
            this.gbOyuncuKartlari.TabStop = false;
            this.gbOyuncuKartlari.Text = "Oyuncu Kartları";
            // 
            // btnSavasBaslat
            // 
            this.btnSavasBaslat.Location = new System.Drawing.Point(15, 42);
            this.btnSavasBaslat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSavasBaslat.Name = "btnSavasBaslat";
            this.btnSavasBaslat.Size = new System.Drawing.Size(64, 63);
            this.btnSavasBaslat.TabIndex = 3;
            this.btnSavasBaslat.Text = "Devam";
            this.btnSavasBaslat.UseVisualStyleBackColor = true;
            this.btnSavasBaslat.Click += new System.EventHandler(this.btnSavasBaslat_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bilgisayar Puanları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanıcı puanları";
            // 
            // lblBilgisayarSeviyePuani
            // 
            this.lblBilgisayarSeviyePuani.AutoSize = true;
            this.lblBilgisayarSeviyePuani.Location = new System.Drawing.Point(9, 157);
            this.lblBilgisayarSeviyePuani.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBilgisayarSeviyePuani.Name = "lblBilgisayarSeviyePuani";
            this.lblBilgisayarSeviyePuani.Size = new System.Drawing.Size(22, 13);
            this.lblBilgisayarSeviyePuani.TabIndex = 6;
            this.lblBilgisayarSeviyePuani.Text = "-----";
            // 
            // lblKullaniciSeviyePuani
            // 
            this.lblKullaniciSeviyePuani.AutoSize = true;
            this.lblKullaniciSeviyePuani.Location = new System.Drawing.Point(9, 253);
            this.lblKullaniciSeviyePuani.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKullaniciSeviyePuani.Name = "lblKullaniciSeviyePuani";
            this.lblKullaniciSeviyePuani.Size = new System.Drawing.Size(28, 13);
            this.lblKullaniciSeviyePuani.TabIndex = 7;
            this.lblKullaniciSeviyePuani.Text = "-------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.lblKullaniciSeviyePuani);
            this.Controls.Add(this.lblBilgisayarSeviyePuani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSavasBaslat);
            this.Controls.Add(this.gbOyuncuKartlari);
            this.Controls.Add(this.gbSavasAlani);
            this.Controls.Add(this.gbBilgisayarKartlari);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

