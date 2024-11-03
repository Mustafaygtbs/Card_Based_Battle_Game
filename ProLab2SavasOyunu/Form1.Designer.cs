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
            this.oyuncuKartlariFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.KullaniciOyunAlani = new System.Windows.Forms.Panel();
            this.savasAlaniFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SavasAlani = new System.Windows.Forms.Panel();
            this.bilgisayarKartlariFlowPanelA = new System.Windows.Forms.FlowLayoutPanel();
            this.KullaniciOyunAlani.SuspendLayout();
            this.SavasAlani.SuspendLayout();
            this.SuspendLayout();
            // 
            // oyuncuKartlariFlowPanel
            // 
            this.oyuncuKartlariFlowPanel.Location = new System.Drawing.Point(236, 62);
            this.oyuncuKartlariFlowPanel.Name = "oyuncuKartlariFlowPanel";
            this.oyuncuKartlariFlowPanel.Size = new System.Drawing.Size(1049, 145);
            this.oyuncuKartlariFlowPanel.TabIndex = 0;
            // 
            // KullaniciOyunAlani
            // 
            this.KullaniciOyunAlani.Controls.Add(this.oyuncuKartlariFlowPanel);
            this.KullaniciOyunAlani.Location = new System.Drawing.Point(12, 552);
            this.KullaniciOyunAlani.Name = "KullaniciOyunAlani";
            this.KullaniciOyunAlani.Size = new System.Drawing.Size(1262, 256);
            this.KullaniciOyunAlani.TabIndex = 2;
            // 
            // savasAlaniFlowPanel
            // 
            this.savasAlaniFlowPanel.Location = new System.Drawing.Point(403, 44);
            this.savasAlaniFlowPanel.Name = "savasAlaniFlowPanel";
            this.savasAlaniFlowPanel.Size = new System.Drawing.Size(801, 85);
            this.savasAlaniFlowPanel.TabIndex = 0;
            // 
            // SavasAlani
            // 
            this.SavasAlani.Controls.Add(this.savasAlaniFlowPanel);
            this.SavasAlani.Location = new System.Drawing.Point(12, 285);
            this.SavasAlani.Name = "SavasAlani";
            this.SavasAlani.Size = new System.Drawing.Size(1262, 261);
            this.SavasAlani.TabIndex = 1;
            // 
            // bilgisayarKartlariFlowPanelA
            // 
            this.bilgisayarKartlariFlowPanelA.Location = new System.Drawing.Point(12, 12);
            this.bilgisayarKartlariFlowPanelA.Name = "bilgisayarKartlariFlowPanelA";
            this.bilgisayarKartlariFlowPanelA.Size = new System.Drawing.Size(1262, 267);
            this.bilgisayarKartlariFlowPanelA.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.bilgisayarKartlariFlowPanelA);
            this.Controls.Add(this.KullaniciOyunAlani);
            this.Controls.Add(this.SavasAlani);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KullaniciOyunAlani.ResumeLayout(false);
            this.SavasAlani.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel oyuncuKartlariFlowPanel;
        private System.Windows.Forms.Panel KullaniciOyunAlani;
        private System.Windows.Forms.FlowLayoutPanel savasAlaniFlowPanel;
        private System.Windows.Forms.Panel SavasAlani;
        private System.Windows.Forms.FlowLayoutPanel bilgisayarKartlariFlowPanelA;
    }
}

