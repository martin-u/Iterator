using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public class EdicionCongresoNeg
    {
        public static List<EdicionCongreso> obtenerEdicionesCongreso()
        {
            List<EdicionCongreso> listaEdicionCongreso = new List<EdicionCongreso>();

            listaEdicionCongreso.Add(new EdicionCongreso(1)); 
            listaEdicionCongreso.Add(new EdicionCongreso(2));

            return listaEdicionCongreso;
        }

    }
}
