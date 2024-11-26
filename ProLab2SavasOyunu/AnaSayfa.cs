using System;
using System.Windows.Forms;

namespace ProLab2SavasOyunu
{
    public partial class AnaSayfa : Form
    {
        public int KartSayisi { get; private set; } = 6;  
        public int TurSayisi { get; private set; } = 5;   

        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            // Kart Sayısı ComboBox ayarları
            kartSayisiComboBox.Items.AddRange(new object[] { 1,2,3,4,5,6,7,8,9,18 });
            kartSayisiComboBox.SelectedItem = KartSayisi; 

            // Tur Sayısı ComboBox ayarları
            turSayisiComboBox.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11 });
            turSayisiComboBox.SelectedItem = TurSayisi;

            txtBaslangicSeviyePuani.Text = "0";

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
             KartSayisi = (int)kartSayisiComboBox.SelectedItem;
            TurSayisi = (int)turSayisiComboBox.SelectedItem;
            int baslangicSeviyePuani = Convert.ToInt32(txtBaslangicSeviyePuani.Text);
            Form1 oyunFormu = new Form1(KartSayisi, TurSayisi, baslangicSeviyePuani);
            oyunFormu.Show();
            this.Hide();
            
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kartSayisiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
