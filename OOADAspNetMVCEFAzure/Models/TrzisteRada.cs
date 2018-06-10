using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOADAspNetMVCEFAzure.Models
{
    public class TrzisteRada
    {
        public string TrzisteRadaId { get; set; }
        public string DokazOObrazovanju { get; set; }
        public string InstitucijaZaposljavanja { get; set; }
        public string ZahtjevZaPosao { get; set; }
        public string OdobrenjeZahtjeva { get; set; }
        //veza
        public virtual ICollection<Izbjeglica> Izbjeglica { get; set; }
    }
}