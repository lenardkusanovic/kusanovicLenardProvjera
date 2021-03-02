using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardProvjera
{

    class Osoba
    {
        string ime;
        string prezime;
        int oib;
        string datum;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int Oib { get => oib; set => oib = value; }
        public string Datum { get => datum; set => datum = value; }

        public Osoba(string Ime, string Prezime, int Oib, string Datum)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.Oib = Oib;
            this.Datum = Datum;

        }
        public override string ToString()
        {
            return ime + " " + prezime + " " + oib + " " + datum + "\n";
        }

    }
}
