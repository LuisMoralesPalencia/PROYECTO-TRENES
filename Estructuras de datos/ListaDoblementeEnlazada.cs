using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_TRENES.Estructuras_de_datos
{
    public class ListaDoblementeEnlazada<T>
    {
        private Nodo<T> cabeza;
        private Nodo<T> cola;
        private int contador;

        public int Cantidad { get { return contador; } }

        public ListaDoblementeEnlazada()
        {
            this.cabeza = null;
            this.cola = null;
            this.contador = 0;
        }

        public void Agregar(T valor)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(valor);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
            }
            else
            {
                cola.Siguiente = nuevoNodo;
                nuevoNodo.Anterior = cola;
                cola = nuevoNodo;
            }
            contador++;
        }

        public void AgregarAlInicio(T valor)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(valor);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
            }
            else
            {
                nuevoNodo.Siguiente = cabeza;
                cabeza.Anterior = nuevoNodo;
                cabeza = nuevoNodo;
            }
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
                if (cabeza != null)
                {
                    cabeza.Anterior = null;
                }
                else
                {
                    cola = null;
                }
                contador--;
                return true;
            }

            Nodo<T> actual = cabeza;
            while (actual != null && !EqualityComparer<T>.Default.Equals(actual.Valor, valor))
            {
                actual = actual.Siguiente;
            }

            if (actual != null)
            {
                if (actual.Anterior != null)
                {
                    actual.Anterior.Siguiente = actual.Siguiente;
                }

                if (actual.Siguiente != null)
                {
                    actual.Siguiente.Anterior = actual.Anterior;
                }
                else
                {
                    cola = actual.Anterior;
                }

                actual.Siguiente = null;
                actual.Anterior = null;

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

        public Nodo<T> GetCola()
        {
            return cola;
        }
    }
}