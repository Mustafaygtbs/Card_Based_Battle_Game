﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2SavasOyunu.Models.Cards.Kara
{
    public class Obus : KaraAraclari
    {
        public override int Dayaniklilik { get; set; } = 20;
        public override int Vurus { get; set; } = 10;
        public override string AltSinif => "Obus";
        public override int DenizVurusAvantaji => 5;

        public Obus() : base() { }

        public override bool AvantajVarMi(SavasAraclari hedef)
        {
            throw new NotImplementedException();
        }

        public override int GetVurusAvantaji(SavasAraclari hedef)
        {
            throw new NotImplementedException();
        }
    }
}
