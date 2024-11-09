using ProLab2SavasOyunu.Core.Enums;
using ProLab2SavasOyunu.Properties;
using System;
using System.Drawing;
using System.IO;

namespace ProLab2SavasOyunu.Models.Cards.Deniz
{
    public class Firkateyn : DenizAraclari
    {
        public override int Dayaniklilik { get; set; } = 25;
        public override int Vurus { get; set; } = 10;
        public override string AltSinif => "Firkateyn";
        public override int HavaVurusAvantaji => 5;

        public override Image KartResmi
        {
            get
            {
                using (var ms = new MemoryStream(Resources.gemi1))
                {
                    return Image.FromStream(ms);
                }
            }
        }
        public Firkateyn() : base() { }

        public Firkateyn(int seviyePuani = 0) : base(seviyePuani) { }

        public override void DurumGuncelle(int hasar)
        {
            Dayaniklilik -= hasar;
            if (Dayaniklilik <= 0)
            {
                Dayaniklilik = 0; // Dayanıklılık sıfırın altına düşmez
                Console.WriteLine($"{AltSinif} aracı devre dışı kaldı!");
            }
        }

        public override int GetVurusAvantaji(SavasAraclari hedef)
        {
            
            return hedef.Sinif == KartTipi.Hava ? HavaVurusAvantaji : 0;
        }
    }
}
