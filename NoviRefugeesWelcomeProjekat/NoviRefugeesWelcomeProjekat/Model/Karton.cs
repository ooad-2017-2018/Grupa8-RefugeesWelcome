using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoviRefugeesWelcomeProjekat.Model
{
    public class Karton
    {
        public List<Izbjeglica> Izbjeglice { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public string Dijagnoza { get; set; }

        public Karton(string dijag, DateTime di)
        {
            this.DatumIzdavanja = di;
            this.Dijagnoza = dijag;
            Izbjeglice = new List<Izbjeglica>();
        }
    }
}
