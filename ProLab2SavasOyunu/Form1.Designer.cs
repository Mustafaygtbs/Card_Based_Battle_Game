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
            this.oyuncuKartlariFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSavasBaslat = new System.Windows.Forms.Button();
            this.lblBilgisayarSkor = new System.Windows.Forms.Label();
            this.lblKullaniciSkor = new System.Windows.Forms.Label();
            this.flowLayoutPanelKullaniciSecilenKartlar = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelBilgisayarSecilenKartlar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTurBilgisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bilgisayarKartlariFlowPanelA
            // 
            this.bilgisayarKartlariFlowPanelA.AutoScroll = true;
            this.bilgisayarKartlariFlowPanelA.Location = new System.Drawing.Point(470, 557);
            this.bilgisayarKartlariFlowPanelA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bilgisayarKartlariFlowPanelA.Name = "bilgisayarKartlariFlowPanelA";
            this.bilgisayarKartlariFlowPanelA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bilgisayarKartlariFlowPanelA.Size = new System.Drawing.Size(1143, 426);
            this.bilgisayarKartlariFlowPanelA.TabIndex = 0;
            // 
            // oyuncuKartlariFlowPanel
            // 
            this.oyuncuKartlariFlowPanel.AutoScroll = true;
            this.oyuncuKartlariFlowPanel.Location = new System.Drawing.Point(470, 11);
            this.oyuncuKartlariFlowPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oyuncuKartlariFlowPanel.Name = "oyuncuKartlariFlowPanel";
            this.oyuncuKartlariFlowPanel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oyuncuKartlariFlowPanel.Size = new System.Drawing.Size(1143, 452);
            this.oyuncuKartlariFlowPanel.TabIndex = 1;
            // 
            // btnSavasBaslat
            // 
            this.btnSavasBaslat.BackColor = System.Drawing.Color.LightCoral;
            this.btnSavasBaslat.Location = new System.Drawing.Point(983, 475);
            this.btnSavasBaslat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavasBaslat.Name = "btnSavasBaslat";
            this.btnSavasBaslat.Size = new System.Drawing.Size(239, 78);
            this.btnSavasBaslat.TabIndex = 3;
            this.btnSavasBaslat.Text = "Devam";
            this.btnSavasBaslat.UseVisualStyleBackColor = false;
            this.btnSavasBaslat.Click += new System.EventHandler(this.btnSavasBaslat_Click_1);
            // 
            // lblBilgisayarSkor
            // 
            this.lblBilgisayarSkor.AutoSize = true;
            this.lblBilgisayarSkor.Location = new System.Drawing.Point(1487, 506);
            this.lblBilgisayarSkor.Name = "lblBilgisayarSkor";
            this.lblBilgisayarSkor.Size = new System.Drawing.Size(27, 16);
            this.lblBilgisayarSkor.TabIndex = 6;
            this.lblBilgisayarSkor.Text = "-----";
            // 
            // lblKullaniciSkor
            // 
            this.lblKullaniciSkor.AutoSize = true;
            this.lblKullaniciSkor.Location = new System.Drawing.Point(375, 506);
            this.lblKullaniciSkor.Name = "lblKullaniciSkor";
            this.lblKullaniciSkor.Size = new System.Drawing.Size(35, 16);
            this.lblKullaniciSkor.TabIndex = 7;
            this.lblKullaniciSkor.Text = "-------";
            // 
            // flowLayoutPanelKullaniciSecilenKartlar
            // 
            this.flowLayoutPanelKullaniciSecilenKartlar.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelKullaniciSecilenKartlar.Name = "flowLayoutPanelKullaniciSecilenKartlar";
            this.flowLayoutPanelKullaniciSecilenKartlar.Size = new System.Drawing.Size(293, 710);
            this.flowLayoutPanelKullaniciSecilenKartlar.TabIndex = 0;
            // 
            // flowLayoutPanelBilgisayarSecilenKartlar
            // 
            this.flowLayoutPanelBilgisayarSecilenKartlar.Location = new System.Drawing.Point(1684, 273);
            this.flowLayoutPanelBilgisayarSecilenKartlar.Name = "flowLayoutPanelBilgisayarSecilenKartlar";
            this.flowLayoutPanelBilgisayarSecilenKartlar.Size = new System.Drawing.Size(293, 710);
            this.flowLayoutPanelBilgisayarSecilenKartlar.TabIndex = 0;
            // 
            // lblTurBilgisi
            // 
            this.lblTurBilgisi.AutoSize = true;
            this.lblTurBilgisi.Location = new System.Drawing.Point(751, 506);
            this.lblTurBilgisi.Name = "lblTurBilgisi";
            this.lblTurBilgisi.Size = new System.Drawing.Size(87, 16);
            this.lblTurBilgisi.TabIndex = 8;
            this.lblTurBilgisi.Text = "Şu anki Tur: 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.lblTurBilgisi);
            this.Controls.Add(this.bilgisayarKartlariFlowPanelA);
            this.Controls.Add(this.flowLayoutPanelBilgisayarSecilenKartlar);
            this.Controls.Add(this.flowLayoutPanelKullaniciSecilenKartlar);
            this.Controls.Add(this.oyuncuKartlariFlowPanel);
            this.Controls.Add(this.lblKullaniciSkor);
            this.Controls.Add(this.lblBilgisayarSkor);
            this.Controls.Add(this.btnSavasBaslat);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel bilgisayarKartlariFlowPanelA;
        private System.Windows.Forms.FlowLayoutPanel oyuncuKartlariFlowPanel;
        private System.Windows.Forms.Button btnSavasBaslat;
        private System.Windows.Forms.Label lblBilgisayarSkor;
        private System.Windows.Forms.Label lblKullaniciSkor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKullaniciSecilenKartlar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBilgisayarSecilenKartlar;
        private System.Windows.Forms.Label lblTurBilgisi;
    }
}

