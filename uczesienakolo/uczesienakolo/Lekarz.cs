using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uczesienakolo
{
    class Lekarz : Osoba
    {
        private string specjalnosc;
        public Lekarz (string imieNazwisko, string specjalnosc) : base(imieNazwisko)
        {
            this.imieNazwisko = imieNazwisko;
            this.specjalnosc = specjalnosc;
        }
    }
}
