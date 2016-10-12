using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Windows;

namespace Negocio
{
    public class EdicionSimposioNeg
    {
        public static List<EdicionSimposio> obtenerEdicionSimposio()
        {
            List<EdicionSimposio> listaEdicionSimposio = new List<EdicionSimposio>();
                                       //string nombre,string area, int nroCon, int nroESim, DateTime inicio, DateTime fin
            listaEdicionSimposio.Add(new EdicionSimposio("UNO","UNA",1, 1, DateTime.Parse("10-10-2015"), DateTime.Parse("21-10-2015")));
            listaEdicionSimposio.Add(new EdicionSimposio("DOS","DAS",1, 2, DateTime.Parse("10-10-2015"), DateTime.Parse("21-10-2015")));
            listaEdicionSimposio.Add(new EdicionSimposio("TRES","TRAS",2, 2, DateTime.Parse("13-10-2016"), DateTime.Parse("25-10-2016")));

            return listaEdicionSimposio;
        }

        public static List<EdicionSimposio> ediSimpFiltrada(List<int> ediCon)
        {
            List<EdicionSimposio> listaFiltrada = new List<EdicionSimposio>();
            foreach (EdicionSimposio es in obtenerEdicionSimposio())
            {
                foreach (int num in ediCon)
                {
                    if (es.nroEdicionCongreso == num)
                    {
                        listaFiltrada.Add(es);
                    }
                }
            }
            return listaFiltrada;
        }

        public List<TrabajoDeInvestigacion> ListarTrabajosInvestigacion()
        {
            List<TrabajoDeInvestigacion> lista = new List<TrabajoDeInvestigacion>();            
            lista = TrabajoDeInvestigacionNeg.obtenerTodos();
            //creo el iterador
            IteratorTrabajoInvestigacion iter = new IteratorTrabajoInvestigacion();
            // seteo el elemento actual en 1
            iter.primero();
            // creo el loop
            while (iter.haTerminado(lista) == false)
            {                
                iter.obtenerActual();
                iter.aplicarFiltros(lista);
                iter.siguiente();
            }
            return listaFiltrada;
        }
 
    }
}
