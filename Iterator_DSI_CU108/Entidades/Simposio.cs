using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Simposio
    {
        public string nombre { get; set; }

        public string concerAreaInvestigacion()
        {
            AreaInvestigacion area = new AreaInvestigacion();
            string resultado;

            return resultado = area.nombre;            
        }
    }
}
