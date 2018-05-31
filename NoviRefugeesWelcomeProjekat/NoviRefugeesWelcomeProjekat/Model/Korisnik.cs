using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoviRefugeesWelcomeProjekat.Model
{
    public class Korisnik
    {
        public string id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Korisnik()
        {

        }
        public Korisnik(string u, string p)
        {
            this.Username = u;
            this.Password = p;
        }

    }
}
