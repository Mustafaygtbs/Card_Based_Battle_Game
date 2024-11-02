using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2SavasOyunu.Models.Cards.Kara
{
    public class KFS : KaraAraclari
    {
        public override int Dayaniklilik { get; set; } = 10;
        public override int Vurus { get; set; } = 10;
        public override string AltSinif => "KFS";
        public override int DenizVurusAvantaji => 5;
        public int HavaVurusAvantaji => 10;

        public KFS() : base() { }

        public override void DurumGuncelle(int hasar)
        {
            // KFS'ye özel durum güncelleme işlemleri
        }
    }
}
