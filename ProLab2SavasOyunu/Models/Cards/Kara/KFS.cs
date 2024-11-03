using ProLab2SavasOyunu.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        public override Image KartResmi
        {
            get
            {
                using (var ms = new MemoryStream(Resources.Ucak))
                {
                    return Image.FromStream(ms);
                }
            }
        }

        public KFS() : base() { }

        public override void DurumGuncelle(int hasar)
        {
            // KFS'ye özel durum güncelleme işlemleri
        }

        public override bool AvantajVarMi(SavasAraclari hedef)
        {
            throw new NotImplementedException();
        }

        public override int GetVurusAvantaji(SavasAraclari hedef)
        {
            throw new NotImplementedException();
        }
    }
}
