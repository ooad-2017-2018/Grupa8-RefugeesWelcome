using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOADAspNetMVCEFAzure.Models
{
    public class Zdravstvo
    {
        public string ZdravstvoId { get; set; }
        public string ZdravstvenaUstanova { get; set; }
        public string Osiguranje { get; set; }
        public string Zahtjev { get; set; }
        public string OdobrenjeZahtjeva { get; set; }
        //veza
        public virtual ICollection<Izbjeglica> Izbjeglica { get; set; }
    }
}