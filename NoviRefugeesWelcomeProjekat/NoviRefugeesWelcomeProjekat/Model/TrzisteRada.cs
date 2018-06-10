using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoviRefugeesWelcomeProjekat.Model
{
     public class TrzisteRada
    {
        public List<Izbjeglica> izbjeglice;
        public string DokazOObrazovanju { get; set; }
        public string InstitucijaZaposljavanja { get; set; }
        public string ZahtjevZaPosao { get; set; }
        public string OdobrenjeZahtjeva { get; set; }
        
        public TrzisteRada(string doo, string iz, string zp, string oz)
        {
            izbjeglice = new List<Izbjeglica>();
            this.DokazOObrazovanju = doo;
            this.InstitucijaZaposljavanja = iz;
            this.ZahtjevZaPosao = zp;
            this.OdobrenjeZahtjeva = oz;
        }

  
    }
}
