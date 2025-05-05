using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_TRENES.Estructuras_de_datos
{
    public class ListaCircular<T>
    {
        private Nodo<T> primer;
        private Nodo<T> ultimo;
        private int contador;

        public int Cantidad { get { return contador; } }

        public ListaCircular()
        {
            this.primer = null;
            this.ultimo = null;
            this.contador = 0;
        }

        public Nodo<T> GetPrimerNodo()
        {
            return primer;
        }

        public void Agregar(T nuevo)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(nuevo);

            if (primer == null)
            {
                primer = nuevoNodo;
                ultimo = nuevoNodo;
                nuevoNodo.Siguiente = primer;
            }
            else
            {
                ultimo.Siguiente = nuevoNodo;
                nuevoNodo.Siguiente = primer;
                ultimo = nuevoNodo;
            }
            contador++;
        }

        public T Buscar(T valor)
        {
            if (primer == null)
            {
                return default(T);
            }

            Nodo<T> actual = primer;

            do
            {
                if (EqualityComparer<T>.Default.Equals(actual.Valor, valor))
                {
                    return actual.Valor;
                }
                actual = actual.Siguiente;
            } while (actual != primer);

            return default(T);
        }

        public bool Eliminar(T valor)
        {
            if (primer == null)
            {
                return false;
            }

            Nodo<T> actual = primer;
            Nodo<T> anterior = ultimo;

            do
            {
                if (EqualityComparer<T>.Default.Equals(actual.Valor, valor))
                {
                    break;
                }

                anterior = actual;
                actual = actual.Siguiente;

            } while (actual != primer);

            if (!EqualityComparer<T>.Default.Equals(actual.Valor, valor))
            {
                return false;
            }

            if (contador == 1)
            {
                primer = null;
                ultimo = null;
            }
            else if (actual == primer)
            {
                ultimo.Siguiente = primer.Siguiente;
                primer = primer.Siguiente;
            }
            else
            {
                anterior.Siguiente = actual.Siguiente;

                if (actual == ultimo)
                {
                    ultimo = anterior;
                }
            }

            contador--;
            return true;
        }

        public bool Modificar(T valorActual, T nuevoValor)
        {
            if (primer == null)
            {
                return false; 
            }

            Nodo<T> actual = primer;
            bool encontrado = false;

            do
            {
                if (EqualityComparer<T>.Default.Equals(actual.Valor, valorActual))
                {
                    actual.Valor = nuevoValor;
                    encontrado = true;
                    break;
                }
                actual = actual.Siguiente;
            } while (actual != primer);

            return encontrado;
        }
    }
}
