using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uczesienakolo
{
    interface IPrzychodnia
    {
        void UstawLekarza(string imieNazwisko, string specjalnosc);
        void ZapiszLekarza(string imieNazwisko, int wiek, string choroba);
        string WykonajPorade();
        string WykonajBadanie();
        int CzasOczekiwania();
        void GenerujRaport();
    }
}
