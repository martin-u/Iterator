using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public class EdicionSimposioNeg
    {
        public static List<EdicionSimposio> obtenerEdicionSimposio()
        {
            List<EdicionSimposio> listaEdicionSimposio = new List<EdicionSimposio>();

            listaEdicionSimposio.Add(new EdicionSimposio(1, 1, DateTime.Parse("10-10-2015"), DateTime.Parse("21-10-2015")));
            listaEdicionSimposio.Add(new EdicionSimposio(1, 2, DateTime.Parse("10-10-2015"), DateTime.Parse("21-10-2015")));
            listaEdicionSimposio.Add(new EdicionSimposio(2, 2, DateTime.Parse("13-10-2016"), DateTime.Parse("25-10-2016")));

            return listaEdicionSimposio;
        }
    }
}
