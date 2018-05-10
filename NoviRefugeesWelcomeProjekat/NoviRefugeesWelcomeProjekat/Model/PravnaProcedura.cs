using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoviRefugeesWelcomeProjekat.Model
{
    public class PravnaProcedura
    {
        public List<Izbjeglica> izbjeglice;
        public const int MaxBrojIzbjeglica = 100000;
        public const int TrenutanBrojIzbjeglica = 0;
        public string Zahtjev { get; set; }
        public string OdobrenjeZahtjeva { get; set; }
        
        public PravnaProcedura(string zahtjev, string Od)
        {
            izbjeglice = new List<Izbjeglica>();
            this.Zahtjev = zahtjev;
            this.OdobrenjeZahtjeva = Od;
        }
    }
}
