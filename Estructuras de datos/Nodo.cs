﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_TRENES.Estructuras_de_datos
{
    public class Nodo<T>
    {
        public T Valor { get; set; }
        public Nodo<T> Siguiente { get; set; }
        public Nodo<T> Anterior { get; set; }

        public Nodo(T valor)
        {
            Valor = valor;
            Siguiente = null;
            Anterior = null;
        }
    }
}
