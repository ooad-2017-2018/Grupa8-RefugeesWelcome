using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOADAspNetMVCEFAzure.Models
{
    public class PravnaProcedura
    {
        public string PravnaProceduraId { get; set; }
        public string Zahtjev { get; set; }
        public string OdobrenjeZahtjeva { get; set; }
        //veza
        public virtual ICollection<Izbjeglica> Izbjeglica { get; set; }
    }
}