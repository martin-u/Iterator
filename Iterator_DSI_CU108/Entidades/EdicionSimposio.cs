using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades

{
    public class EdicionSimposio
    {
        public int cantidadDiasParaCorrecciones { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaLimitePresTrab { get; set; }
        public int nroEdicionCongreso { get; set; }
        public int nroEdicionSimposio {get;set;}
        public string nombreSimposio { get; set; }
        public string areaInvestigacion { get; set; }
        //estado
        //trabajo de investigacion
        //simposio

        public EdicionSimposio(string nombre,string area, int nroCon, int nroESim, DateTime inicio, DateTime fin)
        {
            nombreSimposio = nombre;
            areaInvestigacion = area;
            nroEdicionCongreso = nroCon;
            nroEdicionSimposio = nroESim;
            fechaFin = fin;
            fechaInicio = inicio;
        }
        
    }
}
