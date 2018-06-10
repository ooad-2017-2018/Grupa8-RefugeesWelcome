using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoviRefugeesWelcomeProjekat.ViewModel
{
    class RegistratorSingletonPatern
    {
        private RegistratorSingletonPatern() { }
        private static RegistratorSingletonPatern zaposlenikRegistracija= new RegistratorSingletonPatern();
        public static RegistratorSingletonPatern GetRegistrator()
        {
            return zaposlenikRegistracija; 
        }
 


    }
}
