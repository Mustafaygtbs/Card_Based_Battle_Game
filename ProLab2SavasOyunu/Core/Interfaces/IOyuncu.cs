using ProLab2SavasOyunu.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2SavasOyunu.Core.Interfaces
{
    public interface IOyuncu
    {
        int OyuncuID { get; set; }
        string OyuncuAdi { get; set; }
        int Skor { get; set; }
        int SeviyePuani { get; set; }
        List<SavasAraclari> KartListesi { get; set; }

        void SkorGoster();
        List<SavasAraclari> KartSec();
        void KartEkle(SavasAraclari kart);
        void SkorGuncelle(int puan);
        void SeviyePuaniGuncelle(int puan);
    }
}
