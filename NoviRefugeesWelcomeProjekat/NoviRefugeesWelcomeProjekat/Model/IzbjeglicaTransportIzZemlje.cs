using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoviRefugeesWelcomeProjekat.Model
{
    public class IzbjeglicaTransportIzZemlje : Izbjeglica
    {
        public string ImeZemlje { get; set; }
        public DateTime DatumPolaska { get; set; }
        public IzbjeglicaTransportIzZemlje(DateTime d, string zemlja, string ime, string prezime, DateTime dr, string jmbg, string spol, DateTime dp) :
            base(ime, prezime, dr, jmbg, spol, dp)
        {
            this.ImeZemlje = zemlja;
            this.DatumPolaska = d;
        }
    }
}
