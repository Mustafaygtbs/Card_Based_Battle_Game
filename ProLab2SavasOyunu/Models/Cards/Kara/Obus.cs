using ProLab2SavasOyunu.Core.Enums;
using ProLab2SavasOyunu.Properties;
using System;
using System.Drawing;
using System.IO;

namespace ProLab2SavasOyunu.Models.Cards.Kara
{
    public class Obus : KaraAraclari
    {
        public override int Dayaniklilik { get; set; } = 20;
        public override int Vurus { get; set; } = 10;
        public override string AltSinif => "Obus";
        public override int DenizVurusAvantaji => 5;

        public override Image KartResmi
        {
            get
            {
                using (var ms = new MemoryStream(Resources.tank))
                {
                    return Image.FromStream(ms);
                }
            }
        }
        public Obus() : base() { }

        public Obus(int seviyePuani = 0) : base(seviyePuani) { }

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
            return hedef.Sinif == KartTipi.Deniz ? DenizVurusAvantaji : 0;
        }
    }
}
