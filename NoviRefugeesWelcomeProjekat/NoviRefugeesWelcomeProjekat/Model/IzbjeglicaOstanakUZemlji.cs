using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoviRefugeesWelcomeProjekat.Model
{
    public class IzbjeglicaOstanakUZemlji : Izbjeglica
    {      
        public IzbjeglicaOstanakUZemlji(string ime, string prezime, DateTime dr, string jmbg, string spol, DateTime dp) :
            base(ime, prezime, dr, jmbg, spol, dp)
        {

        }
    }
}
