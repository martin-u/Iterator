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
            //int nro, string pal, string res, string tit, int edicionSimposio
            lista.Add(new TrabajoDeInvestigacion(1, "Uno", "resumen de Uno", "Pruebas Uno", 1, 1));
            lista.Add(new TrabajoDeInvestigacion(2, "Dos", "resumen de Dos", "Pruebas Dos", 1, 1));
            lista.Add(new TrabajoDeInvestigacion(3, "Tres", "resumen de Tres", "Pruebas Tres", 1, 2));
            lista.Add(new TrabajoDeInvestigacion(4, "Cuatro", "resumen de Cuatro", "Pruebas Cuatro", 1, 2));
            lista.Add(new TrabajoDeInvestigacion(5, "Cinco", "resumen de Cinco", "Pruebas Cinco", 2, 2));
            lista.Add(new TrabajoDeInvestigacion(6, "Seis", "resumen de Seis", "Pruebas Seis", 2, 1));
            lista.Add(new TrabajoDeInvestigacion(7, "Siete", "resumen de Siete", "Pruebas Siete", 2, 1));

            return lista;
        }

        public static List<TrabajoDeInvestigacion> tpsFiltrados(List<int> ediSimp, List<int> ediCon)
        {
            List<TrabajoDeInvestigacion> listaFiltrada = new List<TrabajoDeInvestigacion>();
            List<TrabajoDeInvestigacion> listaInter = new List<TrabajoDeInvestigacion>();

            foreach (TrabajoDeInvestigacion tp in obtenerTodos())
            {
                foreach (int con in ediCon)
                {
                    if (tp.edicionCongreso == con)
                    {
                        foreach (int num in ediSimp)
                        {
                            if (tp.edicionSimposio == num)
                            {
                                listaFiltrada.Add(tp);
                            }
                        }
                    }
                }
            }
            return listaFiltrada.Distinct().ToList();
        }
    }
}
