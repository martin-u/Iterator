using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrabajoDeInvestigacion
    {
        public int nroOrden { get; set; }
        public string palabraClave { get; set; }
        public string resumenes { get; set; }
        public string titulo { get; set; }
        public int edicionSimposio { get; set; }

        public TrabajoDeInvestigacion(int nro, string pal, string res, string tit, int edicion)
        {
            nroOrden = nro;
            palabraClave = pal;
            resumenes = res;
            titulo = tit;
            edicionSimposio = edicion;
        }
    }
}
