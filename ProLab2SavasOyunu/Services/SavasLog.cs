using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2SavasOyunu.Services
{
    public class SavasLog
    {
        public string HamleYapan { get; set; }   
        public string Hedef { get; set; }         
        public int VurulanHasar { get; set; }     
        public int KazanilanPuan { get; set; }    
        public DateTime HamleZamani { get; set; } 

        public override string ToString()
        {
            return $"{HamleZamani:G}: {HamleYapan} -> {Hedef}, Hasar: {VurulanHasar}, Puan: {KazanilanPuan}";
        }
    }
}
