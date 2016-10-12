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
        public int edicionCongreso { get; set; }
        public string estado { get; set; }

        public TrabajoDeInvestigacion(int nro, string pal, string res, string tit, int ediSimp, int ediCon, string est)
        {
            nroOrden = nro;
            palabraClave = pal;
            resumenes = res;
            titulo = tit;
            edicionSimposio = ediSimp;
            edicionCongreso = ediCon;
            estado = est;
        }
    }
}
