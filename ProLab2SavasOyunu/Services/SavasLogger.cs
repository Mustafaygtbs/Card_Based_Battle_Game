using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

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

        public void LoglariExcelOlarakKaydet(string dosyaYolu)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; 

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Savaş Logları");

                worksheet.Cells[1, 1].Value = "Hamle Zamanı";
                worksheet.Cells[1, 2].Value = "Tur";
                worksheet.Cells[1, 3].Value = "Hamle Yapan";
                worksheet.Cells[1, 4].Value = "Kullanılan Kart";
                worksheet.Cells[1, 5].Value = "Hedef";
                worksheet.Cells[1, 6].Value = "Hedef Kart";
                worksheet.Cells[1, 7].Value = "Vurulan Hasar";
                worksheet.Cells[1, 8].Value = "Avantaj";
                worksheet.Cells[1, 9].Value = "Kazanılan Puan";
                int row = 2;
                foreach (var log in _loglar)
                {
                    worksheet.Cells[row, 1].Value = log.HamleZamani.ToString("g");
                    worksheet.Cells[row, 2].Value = log.Tur;
                    worksheet.Cells[row, 3].Value = log.HamleYapan;
                    worksheet.Cells[row, 4].Value = log.KullanilanKart;
                    worksheet.Cells[row, 5].Value = log.Hedef;
                    worksheet.Cells[row, 6].Value = log.HedefKart;
                    worksheet.Cells[row, 7].Value = log.VurulanHasar;
                    worksheet.Cells[row, 8].Value = log.Avantaj;
                    worksheet.Cells[row, 9].Value = log.KazanilanPuan;
                    row++;
                }
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                FileInfo fi = new FileInfo(dosyaYolu);
                package.SaveAs(fi);
            }
        }

        }
}
