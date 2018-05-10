using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoviRefugeesWelcomeProjekat.Model
{
    public class Obrazovanje
    {
        public List<Izbjeglica> izbjeglice;
        public string ObrazovnaInstitucija { get; set; }
        public string DokazZvanja { get; set; }
        public string ObrazovniZahtjev { get; set; }
        public string ProcesiranjeZahtjeva { get; set; }
        
        public Obrazovanje(string oi, string dz, string oz, string pz)
        {
            izbjeglice = new List<Izbjeglica>();
            this.ObrazovnaInstitucija = oi;
            this.DokazZvanja = dz;
            this.ObrazovniZahtjev = oz;
            this.ProcesiranjeZahtjeva = pz;
        }

    }
}
