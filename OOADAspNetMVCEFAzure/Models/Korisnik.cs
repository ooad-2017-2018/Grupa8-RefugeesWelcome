using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOADAspNetMVCEFAzure.Models
{
    public class Korisnik
    {
        public string KorisnikId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        //veza
        public virtual ICollection<Izbjeglica> Izbjeglica { get; set; }
    }
}