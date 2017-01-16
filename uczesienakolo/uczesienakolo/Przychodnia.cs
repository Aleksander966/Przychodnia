using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uczesienakolo
{
    class Przychodnia
    {
        private Lekarz lekarz;
        private Stack<Pacjent> pacjenci = new Stack<Pacjent>();
        
        public void UstawLekarza(string imieN, string specjalnosc)
        {
            lekarz = new Lekarz(imieN, specjalnosc);
        }
        public void ZapiszLekarza(string imieN, int wiek, string choroba)
        {
            pacjenci.Push(new Pacjent(imieN, wiek, choroba));
        }
        public string WykonajPorade()
        {
            Pacjent pacj = pacjenci.Pop();
            return "Wykonano porade! " + pacj.ToString();
        }
        public string WykonajBadanie()
        {
            Pacjent temp = pacjenci.Peek();
            return "Wykonano badanie! " + temp.ToString();
        }
        public int CzasOczekiwania()
        {
            int count = pacjenci.Count;
            int result = (int)Math.Truncate((decimal)count / 5);
            return result;
        }
        public override string ToString()
        {
            string pacj = "";
            pacj += lekarz.ToString() + "\nPacjenci oczekujący: \n";
            foreach (Object obj in pacjenci)
            {
                pacj += obj.ToString() + ",\n";
            }
            pacj += Convert.ToString(CzasOczekiwania());
            return pacj;
        }
         public bool CzyLekarz()
        {
            return (this.lekarz != null) ? true : false;
        }

    }
}
