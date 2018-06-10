using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoviRefugeesWelcomeProjekat.Model
{
    public class Zdravstvo
    {
        public List<Karton> Kartoni { get; set; }
        public List<Izbjeglica> Izbjeglice { get; set; }
        public string ZdravstvenaUstanova { get; set; }
        public string Osiguranje { get;  }
        public string Zahtjev { get; set; }
        public string OdobrenjeZahtjeva { get; set;  }

        public Zdravstvo(string z, string o, string zahtjev, string oz)
        {
            Kartoni = new List<Karton>();
            ZdravstvenaUstanova = z;
            Osiguranje = o;
            Zahtjev = zahtjev;
            OdobrenjeZahtjeva = oz;
        }
    }
}
