﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uczesienakolo
{
    class Pacjent : Osoba
    {
        private int wiek;
        private string choroba;
        public Pacjent(string imieNazwisko,int wiek,string choroba) : base(imieNazwisko)
        {
            this.imieNazwisko = imieNazwisko;
            this.wiek = wiek;
            this.choroba = choroba;
        }
        public override string ToString()
        {
            return "Pacjent, imię i nazwisko:" + imieNazwisko + "wiek" + wiek + "choroba:" + choroba;
        }

    }
}
