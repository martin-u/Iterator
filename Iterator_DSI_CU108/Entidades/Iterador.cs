﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        Object obtenerActual();
        bool haTerminado(List<Object> lista);
        List<Object> aplicarFiltros(List<Object> lista);

    }
}
