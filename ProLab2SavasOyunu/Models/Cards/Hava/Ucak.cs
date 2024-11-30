using ProLab2SavasOyunu.Core.Enums;
using ProLab2SavasOyunu.Properties;
using System;
using System.Drawing;
using System.IO;

namespace ProLab2SavasOyunu.Models.Cards.Hava
{
    public class Ucak : HavaAraclari
    {
        public override int Dayaniklilik { get; set; } = 20;
        public override int Vurus { get; set; } = 10;
        public override string AltSinif => "Ucak";
        public override int KaraVurusAvantaji => 10;

        public override Image KartResmi
        {
            get
            {
                using (var ms = new MemoryStream(Resources.ucak2))
                {
                    return Image.FromStream(ms);
                }
            }
        }
        public Ucak() : base() { }

        public Ucak(int seviyePuani = 0) : base(seviyePuani) { }

        public override void DurumGuncelle(int hasar)
        {
            Dayaniklilik -= hasar;
            if (Dayaniklilik <= 0)
            {
                Dayaniklilik = 0;
                ElenmisMi = true;
                Console.WriteLine($"{AltSinif} aracı devre dışı kaldı!");
            }
        }

        public override int GetVurusAvantaji(SavasAraclari hedef)
        {
            
            return hedef.Sinif == KartTipi.Kara ? KaraVurusAvantaji : 0;
        }
    }
}
