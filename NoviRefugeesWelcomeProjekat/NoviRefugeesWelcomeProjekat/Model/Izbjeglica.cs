using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoviRefugeesWelcomeProjekat.Model
{
    public abstract class Izbjeglica
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string JMBG { get; set; }
        public string Spol { get; set; }
        public DateTime DatumPrijema { get; set; }


        public Izbjeglica(string ime, string prezime, DateTime dr, string jmbg, string spol, DateTime dp)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumPrijema = dp;
            this.DatumRodjenja = dr;
            this.JMBG = jmbg;
            this.Spol = spol;

        }
    }
}
