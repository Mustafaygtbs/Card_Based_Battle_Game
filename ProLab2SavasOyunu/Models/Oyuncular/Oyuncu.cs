using ProLab2SavasOyunu.Core.Interfaces;
using ProLab2SavasOyunu.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2SavasOyunu.Models.Oyuncular
{
    public class Oyuncu : IOyuncu
    {
        public int OyuncuID { get; set; }
        public string OyuncuAdi { get; set; }
        public int Skor { get; set; }
        public int SeviyePuani { get; set; }
        public List<SavasAraclari> KartListesi { get; set; }

        public Oyuncu()
        {
            KartListesi = new List<SavasAraclari>();
        }

        public Oyuncu(int oyuncuID, string oyuncuAdi) : this()
        {
            OyuncuID = oyuncuID;
            OyuncuAdi = oyuncuAdi;
            Skor = 0;
            SeviyePuani = 0;
        }

        public void SkorGoster()
        {
            Console.WriteLine($"Oyuncu: {OyuncuAdi}, Skor: {Skor}, Seviye Puanı: {SeviyePuani}");
        }

        public virtual List<SavasAraclari> KartSec()
        {
            // Kullanıcı için override edilmelidir
            throw new NotImplementedException();
        }

        public void KartEkle(SavasAraclari kart)
        {
            KartListesi.Add(kart);
        }

        public void SkorGuncelle(int puan)
        {
            Skor += puan;
        }

        public void SeviyePuaniGuncelle(int puan)
        {
            SeviyePuani += puan;
        }
    }
}
