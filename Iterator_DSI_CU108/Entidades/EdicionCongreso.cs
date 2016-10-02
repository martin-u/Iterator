using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades

{
    public class EdicionCongreso
    {
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaLimiteInscripcion { get; set; }
        //public string isbn { get; set; }
        public int numeroEdicion { get; set; }

        public EdicionCongreso(int nro)
        {
            numeroEdicion = nro;
        }
    }
}
