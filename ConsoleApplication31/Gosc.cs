using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Gosc:IComparable<Gosc>
    {
        private string imie;
        private string nazwisko;

        public Gosc(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public override string ToString()
        {
            return "Imię i nazwisko: " + imie + " " + nazwisko;
        }
    
        public int CompareTo(Gosc other)
        {
 	        return this.nazwisko.CompareTo(other.nazwisko);
        }
    }
}
