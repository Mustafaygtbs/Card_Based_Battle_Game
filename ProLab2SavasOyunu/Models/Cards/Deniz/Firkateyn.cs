using ProLab2SavasOyunu.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
