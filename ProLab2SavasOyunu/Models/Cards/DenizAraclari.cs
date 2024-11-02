using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2SavasOyunu.Models.Cards
{
    public abstract class DenizAraclari : SavasAraclari
    {
        public override string Sinif => "Deniz";
        public abstract string AltSinif { get; }
        public abstract int HavaVurusAvantaji { get; }

        public DenizAraclari() : base() { }

        public override void DurumGuncelle(int hasar)
        {
            // Deniz aracına özel güncelleme işlemleri
        }
    }
}
