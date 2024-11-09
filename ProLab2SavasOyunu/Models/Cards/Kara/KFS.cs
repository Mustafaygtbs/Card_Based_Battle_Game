using ProLab2SavasOyunu.Core.Enums;
using ProLab2SavasOyunu.Properties;
using System;
using System.Drawing;
using System.IO;

namespace ProLab2SavasOyunu.Models.Cards.Kara
{
    public class KFS : KaraAraclari
    {
        public override int Dayaniklilik { get; set; } = 10;
        public override int Vurus { get; set; } = 10;
        public override string AltSinif => "KFS";
        public override int DenizVurusAvantaji => 10;
        public  int HavaVurusAvantaji => 20;

        public override Image KartResmi
        {
            get
            {
                using (var ms = new MemoryStream(Resources.kfs1))
                {
                    return Image.FromStream(ms);
                }
            }
        }
        public KFS() : base() { }
        public KFS(int seviyePuani = 0) : base(seviyePuani) { }

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

            if (hedef.Sinif == KartTipi.Deniz)
            {
                return DenizVurusAvantaji;
            }
            else if (hedef.Sinif == KartTipi.Hava)
            {
                return HavaVurusAvantaji;
            }
            return 0;
        }
    }
}
