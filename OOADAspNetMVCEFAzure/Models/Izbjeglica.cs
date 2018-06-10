using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOADAspNetMVCEFAzure.Models
{
    public class Izbjeglica
    {
        public string IzbjeglicaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string JMBG { get; set; }
        public string Spol { get; set; }
        public DateTime DatumPrijema { get; set; }
        //veze
        public virtual Korisnik Korisnik { get; set; }
        public virtual Obrazovanje Obrazovanje { get; set; }
        public virtual PravnaProcedura PravnaProcedura { get; set; }
        public virtual TrzisteRada TrzisteRada { get; set; }
        public virtual Zdravstvo Zdravstvo { get; set; }
    }
}