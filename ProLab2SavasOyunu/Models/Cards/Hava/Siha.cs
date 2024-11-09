using ProLab2SavasOyunu.Core.Enums;
using ProLab2SavasOyunu.Properties;
using System;
using System.Drawing;
using System.IO;

namespace ProLab2SavasOyunu.Models.Cards.Hava
{
    public class Siha : HavaAraclari
    {
        public override int Dayaniklilik { get; set; } = 15;
        public override int Vurus { get; set; } = 10;
        public override string AltSinif => "Siha";
        public override int KaraVurusAvantaji => 10;
        public int DenizVurusAvantaji => 10;

        public override Image KartResmi
        {
            get
            {
                using (var ms = new MemoryStream(Resources.kızılelma))
                {
                    return Image.FromStream(ms);
                }
            }
        }
        public Siha() : base() { }
        public Siha(int seviyePuani = 0) : base(seviyePuani) { }

        public override void DurumGuncelle(int hasar)
        {
            Dayaniklilik -= hasar;
            if (Dayaniklilik <= 0)
            {
                Dayaniklilik = 0; // Dayanıklılık sıfırın altına düşemez
                Console.WriteLine($"{AltSinif} aracı devre dışı kaldı!");
            }
        }   
        public override int GetVurusAvantaji(SavasAraclari hedef)
        {
            if (hedef.Sinif == KartTipi.Kara)
            {
                return KaraVurusAvantaji; 
            }
            else if (hedef.Sinif == KartTipi.Deniz)
            {
                return DenizVurusAvantaji; 
            }
            return 0;
        }
    }
}
