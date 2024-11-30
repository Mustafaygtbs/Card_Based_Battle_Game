namespace ProLab2SavasOyunu
{
    partial class AnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kartSayisiComboBox = new System.Windows.Forms.ComboBox();
            this.turSayisiComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBaslangicSeviyePuani = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(535, 365);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(925, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mustafa Yiğitbaşı Ve Süleyman Emre Ünverenin Kart Oyununa Hoş Geldiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(821, 420);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lütfen Oyun Ayarlarını Seçiniz";
            // 
            // kartSayisiComboBox
            // 
            this.kartSayisiComboBox.Location = new System.Drawing.Point(616, 548);
            this.kartSayisiComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.kartSayisiComboBox.Name = "kartSayisiComboBox";
            this.kartSayisiComboBox.Size = new System.Drawing.Size(124, 24);
            this.kartSayisiComboBox.TabIndex = 2;
            this.kartSayisiComboBox.SelectedIndexChanged += new System.EventHandler(this.kartSayisiComboBox_SelectedIndexChanged);
            // 
            // turSayisiComboBox
            // 
            this.turSayisiComboBox.FormattingEnabled = true;
            this.turSayisiComboBox.Location = new System.Drawing.Point(971, 548);
            this.turSayisiComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.turSayisiComboBox.Name = "turSayisiComboBox";
            this.turSayisiComboBox.Size = new System.Drawing.Size(160, 24);
            this.turSayisiComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(616, 500);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kart Sayısı (Kişi Başı)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(967, 500);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Oyun Kaç Tur Sürmeli";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(971, 622);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 80);
            this.button1.TabIndex = 6;
            this.button1.Text = "Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1243, 500);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Başlangıç Seviye Puanı";
            // 
            // txtBaslangicSeviyePuani
            // 
            this.txtBaslangicSeviyePuani.Location = new System.Drawing.Point(1260, 550);
            this.txtBaslangicSeviyePuani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBaslangicSeviyePuani.Name = "txtBaslangicSeviyePuani";
            this.txtBaslangicSeviyePuani.Size = new System.Drawing.Size(145, 22);
            this.txtBaslangicSeviyePuani.TabIndex = 8;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1955, 844);
            this.Controls.Add(this.txtBaslangicSeviyePuani);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.turSayisiComboBox);
            this.Controls.Add(this.kartSayisiComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaSayfa_FormClosing);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kartSayisiComboBox;
        private System.Windows.Forms.ComboBox turSayisiComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBaslangicSeviyePuani;
    }
}