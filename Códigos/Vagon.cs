using PROYECTO_TRENES.Estructuras_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_TRENES.Códigos
{
    public class Vagon
    {
        private string idVagon;
        private string tipo;
        private int capacidadMaxima;
        private string idTren;

        public string IdVagon { get => idVagon; set => idVagon = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public string IdTren { get => idTren; set => idTren = value; }

        public Vagon(string idVagon, string tipo, int capacidadMaxima, string idTren)
        {
            this.IdVagon = idVagon;
            this.Tipo = tipo;
            this.CapacidadMaxima = capacidadMaxima;
            this.IdTren = idTren;
        }

    }
}
