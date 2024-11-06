using System;
using System.Windows.Forms;

namespace ProLab2SavasOyunu
{
    public partial class AnaSayfa : Form
    {
        public int KartSayisi { get; private set; } = 6;  // Default kart sayısı
        public int TurSayisi { get; private set; } = 5;   // Default tur sayısı

        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            // Kart Sayısı ComboBox ayarları
            kartSayisiComboBox.Items.AddRange(new object[] { 2, 4, 6, 8, 10 });
            kartSayisiComboBox.SelectedItem = KartSayisi; // Default değer 6

            // Tur Sayısı ComboBox ayarları
            turSayisiComboBox.Items.AddRange(new object[] { 3, 5, 7, 10 });
            turSayisiComboBox.SelectedItem = TurSayisi; // Default değer 5
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
             KartSayisi = (int)kartSayisiComboBox.SelectedItem;
            TurSayisi = (int)turSayisiComboBox.SelectedItem;
            Form1 oyunFormu = new Form1(KartSayisi, TurSayisi);
            oyunFormu.Show();
            this.Hide();
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
