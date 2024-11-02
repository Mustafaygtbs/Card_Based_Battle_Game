using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2SavasOyunu.Models.Cards
{
    public abstract class KaraAraclari : SavasAraclari
    {
        public override string Sinif => "Kara";
        public abstract string AltSinif { get; }
        public abstract int DenizVurusAvantaji { get; }

        public KaraAraclari() : base() { }

        public override void DurumGuncelle(int hasar)
        {
            // Kara aracına özel güncelleme işlemleri
        }
    }
}
