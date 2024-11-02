using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2SavasOyunu.Models.Cards.Hava
{
    public class Siha : HavaAraclari
    {
        public override int Dayaniklilik { get; set; } = 15;
        public override int Vurus { get; set; } = 10;
        public override string AltSinif => "Siha";
        public override int KaraVurusAvantaji => 10;
        public int DenizVurusAvantaji => 10;

        public Siha() : base() { }

        public override void DurumGuncelle(int hasar)
        {
            // Siha'ya özel durum güncelleme işlemleri
        }
    }
}
