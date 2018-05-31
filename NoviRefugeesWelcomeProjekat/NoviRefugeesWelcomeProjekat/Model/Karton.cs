using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NoviRefugeesWelcomeProjekat.Model
{
    public class Karton
    {
       
        public DateTime DatumIzdavanja { get; set; }
        public string Dijagnoza { get; set; }

        public Karton(string dijag, DateTime di)
        {
            this.DatumIzdavanja = di;
            this.Dijagnoza = dijag;
            Izbjeglice = new List<Izbjeglica>(); 
           
        }
        public ICollection<Izbjeglica>Izbjeglice
        {
            get;
            set;
        }
       
       
    }
}
