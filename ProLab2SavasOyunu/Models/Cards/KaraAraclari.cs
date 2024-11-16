using ProLab2SavasOyunu.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2SavasOyunu.Models.Cards
{
    public abstract class KaraAraclari : SavasAraclari
    {
        public override KartTipi Sinif => KartTipi.Kara;
        public abstract override string AltSinif { get; }
        public abstract int DenizVurusAvantaji { get; }
        public KaraAraclari(int seviyePuani = 0) : base(seviyePuani) { }

        public override void DurumGuncelle(int hasar)
        {
           
        }
    }
}
