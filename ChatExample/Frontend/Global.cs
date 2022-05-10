using Frontend.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend
{
    // Esto es provisorio para simplificar el cambio de pantallas!
    // En general, no es buena práctica usar variables globales por las dependencias que genera.
    internal class Global
    {
        public static IRouter router;
    }
}
