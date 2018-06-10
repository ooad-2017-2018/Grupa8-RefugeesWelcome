using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoviRefugeesWelcomeProjekat.ViewModel
{
    public interface IKorisnik
    {
            string Request();
    }
        //2. Korisnik klasa-Implementira stvarni interfejs
        public class Korisnik
        {
            public string Request()
            {
                return "Operacija iz Korisnik klase " + " Koristiti paterne u dizajnu\n";
            }
        }
      


}
