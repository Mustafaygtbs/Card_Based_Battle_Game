using ProLab2SavasOyunu.Core.Enums;
using ProLab2SavasOyunu.Properties;
using System;
using System.Drawing;
using System.IO;

namespace ProLab2SavasOyunu.Models.Cards.Deniz
{
    public class Sida : DenizAraclari
    {
        public override int Dayaniklilik { get; set; } = 15;
        public override int Vurus { get; set; } = 10;
        public override string AltSinif => "Sida";
        public override int HavaVurusAvantaji => 10;
        public int KaraVurusAvantaji => 10;

        public override Image KartResmi
        {
            get
            {
                using (var ms = new MemoryStream(Resources.sida2))
                {
                    return Image.FromStream(ms);
                }
            }
        }
        public Sida() : base() { }
        public Sida(int seviyePuani = 0) : base(seviyePuani) { }
      

        public override void DurumGuncelle(int hasar)
        {
            Dayaniklilik -= hasar;
            if (Dayaniklilik <= 0)
            {
                Dayaniklilik = 0; 
                Console.WriteLine($"{AltSinif} aracı devre dışı kaldı!");
            }
        }

     

        public override int GetVurusAvantaji(SavasAraclari hedef)
        {
            if (hedef.Sinif == KartTipi.Kara)
            {
                return KaraVurusAvantaji; 
            }
            else if (hedef.Sinif == KartTipi.Hava)
            {
                return HavaVurusAvantaji; 
            }
            return 0;
        }
    }
}
