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
        private List<SavasAraclari> KullanilanKartlar { get; set; }
        private readonly Random _random;

        public Oyuncu()
        {
            KartListesi = new List<SavasAraclari>();
            KullanilanKartlar = new List<SavasAraclari>();
            _random = new Random();
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

        public List<SavasAraclari> KartSec()
        {
            var secilenKartlar = new List<SavasAraclari>();

            if (OyuncuAdi == "Bilgisayar")
            {
                // Bilgisayar için rastgele kart seçimi
                while (secilenKartlar.Count < 3)
                {
                    var kart = KartListesi[_random.Next(KartListesi.Count)];
                    if (!KullanilanKartlar.Contains(kart))
                    {
                        secilenKartlar.Add(kart);
                        KullanilanKartlar.Add(kart);
                    }

                    // Tüm kartlar kullanıldıysa liste temizlenir
                    if (KullanilanKartlar.Count == KartListesi.Count)
                        KullanilanKartlar.Clear();
                }
            }
            else
            {
                // Kullanıcı için manuel kart seçimi
                Console.WriteLine("Lütfen kullanmak istediğiniz 3 kartın indekslerini seçin:");
                for (int i = 0; i < KartListesi.Count; i++)
                {
                    Console.WriteLine($"{i}: {KartListesi[i].GetType().Name}");
                }

                // Kullanıcının üç kart seçmesini sağlamak
                while (secilenKartlar.Count < 3)
                {
                    int index;
                    bool gecerliGiris = int.TryParse(Console.ReadLine(), out index) && index >= 0 && index < KartListesi.Count;

                    if (gecerliGiris && !secilenKartlar.Contains(KartListesi[index]))
                    {
                        secilenKartlar.Add(KartListesi[index]);
                        KullanilanKartlar.Add(KartListesi[index]);
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim veya zaten seçilmiş kart. Tekrar deneyin.");
                    }

                    // Tüm kartlar kullanıldıysa liste temizlenir
                    if (KullanilanKartlar.Count == KartListesi.Count)
                        KullanilanKartlar.Clear();
                }
            }

            return secilenKartlar;
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
