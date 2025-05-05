using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_TRENES.Estructuras_de_datos
{
    public class Pila<T>
    {
        private Nodo<T> cima;
        private int contador;

        public int Cantidad { get { return contador; } }
        public bool EstaVacia { get { return contador == 0; } }

        public Pila()
        {
            cima = null;
            contador = 0;
        }

        public void Push(T valor)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(valor);
            nuevoNodo.Siguiente = cima;
            cima = nuevoNodo;
            contador++;
        }

        public T Pop()
        {
            if (EstaVacia)
            {
                throw new InvalidOperationException("La pila está vacía.");
            }

            T valorCima = cima.Valor;
            cima = cima.Siguiente;
            contador--;

            return valorCima;
        }

        public T Peek()
        {
            if (EstaVacia)
            {
                throw new InvalidOperationException("La pila está vacía.");
            }

            return cima.Valor;
        }

        public Nodo<T> GetCima()
        {
            return cima;
        }
    }
}
