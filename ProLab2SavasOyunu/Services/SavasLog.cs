using System;

namespace ProLab2SavasOyunu.Services
{
    public class SavasLog
    {
        public DateTime HamleZamani { get; set; }
        public string Tur { get; set; }
        public string HamleYapan { get; set; }
        public string KullanilanKart { get; set; }
        public string Hedef { get; set; }
        public string HedefKart { get; set; }
        public int VurulanHasar { get; set; }
        public int Avantaj { get; set; }
        public int KazanilanPuan { get; set; }

        public override string ToString()
        {
            return $"{HamleZamani:G} | Tur: {Tur} | {HamleYapan} ({KullanilanKart}) -> {Hedef} ({HedefKart}), Hasar: {VurulanHasar}, Avantaj: {Avantaj}, Puan: {KazanilanPuan}";
        }
    }


}
