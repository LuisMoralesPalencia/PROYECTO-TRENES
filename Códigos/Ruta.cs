using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_TRENES.Códigos
{
    public class Ruta
    {
        private string idRuta;
        private string origen;
        private string destino;
        private string fechaSalida;
        private string fechaLlegada;
        private Tren tren;
        private double distancia;
        private bool esPublicada;

        public string IdRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string FechaSalida { get; set; }
        public string FechaLlegada { get; set; }
        public Tren Tren { get => tren; set => tren = value; }
        public double Distancia { get => distancia; set => distancia = value; }
        public bool EsPublicada { get => esPublicada; set => esPublicada = value; }

        public Ruta(string idRuta, string origen, string destino, string fechaSalida, string fechaLlegada, Tren tren, double distancia)
        {
            IdRuta = idRuta;
            Origen = origen;
            Destino = destino;
            FechaSalida = fechaSalida;
            FechaLlegada = fechaLlegada;
            Tren = tren;
            Distancia = distancia;
            esPublicada = false;
        }

        public override string ToString()
        {
            return $"Ruta {IdRuta}: {Origen} -> {Destino} ({Distancia} km)";
        }
    }
}
