using ProLab2SavasOyunu.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    using (var ms = new MemoryStream(Resources.Ucak)) 
                    {
                        return Image.FromStream(ms);
                    }
                }
            }

        

        public  Ucak() : base() { }

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
