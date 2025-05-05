using PROYECTO_TRENES.Estructuras_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_TRENES.Códigos
{
    public class Tren
    {
        private string nombre;
        private string id;
        private string tipo;
        private int capacidadVagones;
        private int kilometraje;
        private Pila<Vagon> pilaVagones;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Kilometraje { get => kilometraje; set => kilometraje = value; }
        public int CapacidadVagones { get => capacidadVagones; set => capacidadVagones = value; }
        public Pila<Vagon> PilaVagones { get => pilaVagones; set => pilaVagones = value; }

        public Tren(string nombre, string id, string tipo, int maximoVagones, int kilometraje)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.id = id;
            this.capacidadVagones = maximoVagones;
            this.kilometraje = kilometraje;
            this.pilaVagones = new Pila<Vagon>();
        }

        public bool AgregarVagon(Vagon vagon)
        {
            if (this.pilaVagones.Cantidad >= this.capacidadVagones)
            {
                return false;
            }

            this.pilaVagones.Push(vagon);
            return true;
        }

        public bool EliminarVagon(string idVagon)
        {
            if (this.pilaVagones.EstaVacia)
            {
                return false;
            }

            Nodo<Vagon> actual = this.pilaVagones.GetCima();
            Nodo<Vagon> anterior = null;

            while (actual != null)
            {
                if (actual.Valor.IdVagon == idVagon)
                {
                    if (anterior == null)
                    {
                        this.pilaVagones.Pop();
                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }
                    return true;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }

            return false;
        }

        public Vagon BuscarVagon(string idVagon)
        {
            Nodo<Vagon> actual = this.pilaVagones.GetCima();

            while (actual != null)
            {
                if (actual.Valor.IdVagon == idVagon)
                {
                    return actual.Valor;
                }
                actual = actual.Siguiente;
            }

            return null;
        }
        public override string ToString()
        {
            return $"{Id} - {Nombre} ({Tipo}, Capacidad: {CapacidadVagones})";
        }
    }
}
