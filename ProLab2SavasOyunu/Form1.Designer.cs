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
            this.gbBilgisayarKartlari = new System.Windows.Forms.GroupBox();
            this.gbSavasAlani = new System.Windows.Forms.GroupBox();
            this.gbOyuncuKartlari = new System.Windows.Forms.GroupBox();
            this.bilgisayarKartlariFlowPanelA = new System.Windows.Forms.FlowLayoutPanel();
            this.savasAlaniFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.oyuncuKartlariFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gbBilgisayarKartlari.SuspendLayout();
            this.gbSavasAlani.SuspendLayout();
            this.gbOyuncuKartlari.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBilgisayarKartlari
            // 
            this.gbBilgisayarKartlari.Controls.Add(this.bilgisayarKartlariFlowPanelA);
            this.gbBilgisayarKartlari.Location = new System.Drawing.Point(12, 12);
            this.gbBilgisayarKartlari.Name = "gbBilgisayarKartlari";
            this.gbBilgisayarKartlari.Size = new System.Drawing.Size(1513, 302);
            this.gbBilgisayarKartlari.TabIndex = 0;
            this.gbBilgisayarKartlari.TabStop = false;
            this.gbBilgisayarKartlari.Text = "groupBox1";
            // 
            // gbSavasAlani
            // 
            this.gbSavasAlani.Controls.Add(this.savasAlaniFlowPanel);
            this.gbSavasAlani.Location = new System.Drawing.Point(12, 320);
            this.gbSavasAlani.Name = "gbSavasAlani";
            this.gbSavasAlani.Size = new System.Drawing.Size(1507, 205);
            this.gbSavasAlani.TabIndex = 1;
            this.gbSavasAlani.TabStop = false;
            this.gbSavasAlani.Text = "groupBox2";
            // 
            // gbOyuncuKartlari
            // 
            this.gbOyuncuKartlari.Controls.Add(this.oyuncuKartlariFlowPanel);
            this.gbOyuncuKartlari.Location = new System.Drawing.Point(12, 531);
            this.gbOyuncuKartlari.Name = "gbOyuncuKartlari";
            this.gbOyuncuKartlari.Size = new System.Drawing.Size(1516, 302);
            this.gbOyuncuKartlari.TabIndex = 2;
            this.gbOyuncuKartlari.TabStop = false;
            this.gbOyuncuKartlari.Text = "groupBox3";
            // 
            // bilgisayarKartlariFlowPanelA
            // 
            this.bilgisayarKartlariFlowPanelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bilgisayarKartlariFlowPanelA.Location = new System.Drawing.Point(3, 16);
            this.bilgisayarKartlariFlowPanelA.Name = "bilgisayarKartlariFlowPanelA";
            this.bilgisayarKartlariFlowPanelA.Size = new System.Drawing.Size(1507, 283);
            this.bilgisayarKartlariFlowPanelA.TabIndex = 0;
            // 
            // savasAlaniFlowPanel
            // 
            this.savasAlaniFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savasAlaniFlowPanel.Location = new System.Drawing.Point(3, 16);
            this.savasAlaniFlowPanel.Name = "savasAlaniFlowPanel";
            this.savasAlaniFlowPanel.Size = new System.Drawing.Size(1501, 186);
            this.savasAlaniFlowPanel.TabIndex = 1;
            // 
            // oyuncuKartlariFlowPanel
            // 
            this.oyuncuKartlariFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oyuncuKartlariFlowPanel.Location = new System.Drawing.Point(3, 16);
            this.oyuncuKartlariFlowPanel.Name = "oyuncuKartlariFlowPanel";
            this.oyuncuKartlariFlowPanel.Size = new System.Drawing.Size(1510, 283);
            this.oyuncuKartlariFlowPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.gbOyuncuKartlari);
            this.Controls.Add(this.gbSavasAlani);
            this.Controls.Add(this.gbBilgisayarKartlari);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbBilgisayarKartlari.ResumeLayout(false);
            this.gbSavasAlani.ResumeLayout(false);
            this.gbOyuncuKartlari.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBilgisayarKartlari;
        private System.Windows.Forms.FlowLayoutPanel bilgisayarKartlariFlowPanelA;
        private System.Windows.Forms.GroupBox gbSavasAlani;
        private System.Windows.Forms.FlowLayoutPanel savasAlaniFlowPanel;
        private System.Windows.Forms.GroupBox gbOyuncuKartlari;
        private System.Windows.Forms.FlowLayoutPanel oyuncuKartlariFlowPanel;
    }
}

