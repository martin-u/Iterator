using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ;

namespace Entidades
{
    public class IteratorTrabajoInvestigacion: Iterador
    {
        public int actual { get; set; }
        public object elemento { get; set; }
        //metodos
        public void primero()
        {
            actual = 0;
        }

        public void siguiente()
        {
            actual++;
        }

        public Object obtenerActual()
        {
            //ojo aca tengo q devolver el elemento en el que estoy en la lista, no un numero
            return actual;
        }

        public bool haTerminado(List<TrabajoDeInvestigacion> lista)
        {
            //aca tengo q decir si el nro del actual es mayor o igual al numero de la posicion del elemento en la lista
            return actual >= lista.Count();
        }

        public int[] aplicarFiltros(List<TrabajoDeInvestigacion> listaTP)
        { 
            //aca tengo que filtrar la lista que me pasen por parametro
            int[] totales = new int[3];
           
            foreach(TrabajoDeInvestigacion tp in listaTP)
            {
            if(tp.estado == "Rechazado")
            {
                totales[0]++;
            }
                if(tp.estado == "Anulado")
            {
                totales[0]++;
            }
                if(tp.estado == "Retirado")
            {
                totales[0]++;
            }
                if(tp.estado == "Publicado")
            {
                totales[0]++;
            }
               
            }
            return totales;
        }

    }
}
