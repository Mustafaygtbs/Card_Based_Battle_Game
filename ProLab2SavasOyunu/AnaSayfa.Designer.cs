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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kartSayisiComboBox = new System.Windows.Forms.ComboBox();
            this.turSayisiComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(179, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamlar Babayiğitler Yiğit Meydanına Hoş Geldiniz ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(288, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lütfen Oyun Ayarlarını Seçiniz";
            // 
            // kartSayisiComboBox
            // 
            this.kartSayisiComboBox.FormattingEnabled = true;
            this.kartSayisiComboBox.Location = new System.Drawing.Point(201, 200);
            this.kartSayisiComboBox.Name = "kartSayisiComboBox";
            this.kartSayisiComboBox.Size = new System.Drawing.Size(94, 21);
            this.kartSayisiComboBox.TabIndex = 2;
            // 
            // turSayisiComboBox
            // 
            this.turSayisiComboBox.FormattingEnabled = true;
            this.turSayisiComboBox.Location = new System.Drawing.Point(472, 200);
            this.turSayisiComboBox.Name = "turSayisiComboBox";
            this.turSayisiComboBox.Size = new System.Drawing.Size(121, 21);
            this.turSayisiComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(201, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kart Sayısı (Kişi Başı)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(468, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Oyun Kaç Tur Sürmeli";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.turSayisiComboBox);
            this.Controls.Add(this.kartSayisiComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
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
    }
}