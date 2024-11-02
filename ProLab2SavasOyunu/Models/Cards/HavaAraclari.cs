using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2SavasOyunu.Models.Cards
{
    public abstract class HavaAraclari : SavasAraclari
    {
        public override string Sinif => "Hava";
        public abstract string AltSinif { get; }
        public abstract int KaraVurusAvantaji { get; }

        public HavaAraclari() : base() { }

        public override void DurumGuncelle(int hasar)
        {
            // Hava aracına özel güncelleme işlemleri
        }
    }
}
