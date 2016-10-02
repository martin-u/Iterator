using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public class TrabajoDeInvestigacionNeg
    {
        public static List<TrabajoDeInvestigacion> obtenerTodos()
        {
            List<TrabajoDeInvestigacion> lista = new List<TrabajoDeInvestigacion>();

            lista.Add(new TrabajoDeInvestigacion(1, "Uno", "resumen de Uno", "Pruebas Uno", 1));
            lista.Add(new TrabajoDeInvestigacion(2, "Dos", "resumen de Dos", "Pruebas Dos", 1));
            lista.Add(new TrabajoDeInvestigacion(3, "Tres", "resumen de Tres", "Pruebas Tres", 1));
            lista.Add(new TrabajoDeInvestigacion(4, "Cuatro", "resumen de Cuatro", "Pruebas Cuatro", 1));
            lista.Add(new TrabajoDeInvestigacion(5, "Cinco", "resumen de Cinco", "Pruebas Cinco", 2));
            lista.Add(new TrabajoDeInvestigacion(6, "Seis", "resumen de Seis", "Pruebas Seis", 2));
            lista.Add(new TrabajoDeInvestigacion(7, "Siete", "resumen de Siete", "Pruebas Siete", 2));

            return lista;
        }
    }
}
