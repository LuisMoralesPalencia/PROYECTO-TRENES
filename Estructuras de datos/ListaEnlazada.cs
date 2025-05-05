using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_TRENES.Estructuras_de_datos
{
    public class ListaEnlazada<T>
    {
        private Nodo<T> cabeza;
        private int contador;

        public int Cantidad { get { return contador; } }

        public ListaEnlazada()
        {
            this.cabeza = null;
            this.contador = 0;
        }

        public void Agregar(T valor)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(valor);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo<T> actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
            contador++;
        }

        public void AgregarAlInicio(T valor)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(valor);
            nuevoNodo.Siguiente = cabeza;
            cabeza = nuevoNodo;
            contador++;
        }

        public T Buscar(T valor)
        {
            Nodo<T> actual = cabeza;
            while (actual != null)
            {
                if (EqualityComparer<T>.Default.Equals(actual.Valor, valor))
                {
                    return actual.Valor;
                }
                actual = actual.Siguiente;
            }
            return default(T);
        }

        public bool Eliminar(T valor)
        {
            if (cabeza == null)
            {
                return false;
            }

            if (EqualityComparer<T>.Default.Equals(cabeza.Valor, valor))
            {
                cabeza = cabeza.Siguiente;
                contador--;
                return true;
            }

            Nodo<T> actual = cabeza;
            Nodo<T> anterior = null;

            while (actual != null && !EqualityComparer<T>.Default.Equals(actual.Valor, valor))
            {
                anterior = actual;
                actual = actual.Siguiente;
            }

            if (actual != null)
            {
                anterior.Siguiente = actual.Siguiente;
                contador--;
                return true;
            }

            return false;
        }

        public bool Modificar(T valorActual, T nuevoValor)
        {
            Nodo<T> actual = cabeza;
            while (actual != null)
            {
                if (EqualityComparer<T>.Default.Equals(actual.Valor, valorActual))
                {
                    actual.Valor = nuevoValor;
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }

        public Nodo<T> GetCabeza()
        {
            return cabeza;
        }
    }
}
