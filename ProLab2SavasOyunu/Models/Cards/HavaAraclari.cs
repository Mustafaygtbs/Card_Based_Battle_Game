using ProLab2SavasOyunu.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2SavasOyunu.Models.Cards
{
    public abstract class HavaAraclari : SavasAraclari
    {
        public override KartTipi Sinif => KartTipi.Hava;
        public abstract override string AltSinif { get; }
        public abstract int KaraVurusAvantaji { get; }
        public HavaAraclari(int seviyePuani = 0) : base(seviyePuani) { }

        public override void DurumGuncelle(int hasar)
        {
            // Hava aracına özel güncelleme işlemleri
        }
    }
}
