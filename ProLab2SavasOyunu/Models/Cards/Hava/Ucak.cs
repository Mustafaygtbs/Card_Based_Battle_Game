using System;
using System.Collections.Generic;
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

        public Ucak() : base() { }
    }
}
