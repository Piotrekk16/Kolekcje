using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Pokoj
    {
        private int nrPokoju;
        private double cenaZaDzien;

        public Pokoj(int nr, double cena)
        {
            this.nrPokoju = nr;
            this.cenaZaDzien = cena;
        }

        public override string ToString()
        {
            return "Pokój: " + nrPokoju + ", cena za dzień: " + cenaZaDzien;
        }

        public int CompareTo(Pokoj other)
        {
            return this.nrPokoju.CompareTo(other.nrPokoju);
        }

    }
}
