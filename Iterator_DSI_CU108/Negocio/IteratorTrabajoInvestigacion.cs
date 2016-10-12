using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
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

        public Object elementoActual()
        {
            //ojo aca tengo q devolver el elemento en el que estoy en la lista, no un numero
            return actual;
        }

        public bool haTerminado(List<Object> lista)
        {
            //aca tengo q decir si el nro del actual es mayor o igual al numero de la posicion del elemento en la lista
            return actual >= lista.Count();
        }

        public List<Object> aplicarFiltros(List<Object> lista)
        { 
            //aca tengo que filtrar la lista que me pasen por parametro
            return null;
        }

    }
}
