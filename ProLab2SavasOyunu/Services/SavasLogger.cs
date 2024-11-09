using System;
using System.Collections.Generic;

namespace ProLab2SavasOyunu.Services
{
    public class SavasLogger
    {
        private readonly List<SavasLog> _loglar = new List<SavasLog>();

        public void LogEkle(SavasLog log)
        {
            _loglar.Add(log);
        }

        public void LoglariYazdir()
        {
            
            foreach (var log in _loglar)
            {
                Console.WriteLine(log);
            }
        }
        public List<SavasLog> LoglariAl()
        {
            return _loglar;
        }

        public List<SavasLog> GetirLoglar()
        {
            return _loglar;
        }

        public void LoglariTemizle()
        {
            _loglar.Clear();
        }
    }
}
