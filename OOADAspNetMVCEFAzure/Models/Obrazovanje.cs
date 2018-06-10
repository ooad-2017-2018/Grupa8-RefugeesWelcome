using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOADAspNetMVCEFAzure.Models
{
    public class Obrazovanje
    {
        public string ObrazovanjeId { get; set; }
        public string ObrazovnaInstitucija { get; set; }
        public string DokazZvanja { get; set; }
        public string ObrazovniZahtjev { get; set; }
        public string ProcesiranjeZahtjeva { get; set; }
        //veza
        public virtual ICollection<Izbjeglica> Izbjeglica { get; set; }
    }
}