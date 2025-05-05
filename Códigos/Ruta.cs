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

        public string IdRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string FechaSalida { get; set; }
        public string FechaLlegada { get; set; }
        public Tren Tren { get => tren; set => tren = value; }

        public Ruta(string idRuta, string origen, string destino, string fechaSalida, string fechaLlegada, Tren tren)
        {
            IdRuta = idRuta;
            Origen = origen;
            Destino = destino;
            FechaSalida = fechaSalida;
            FechaLlegada = fechaLlegada;
            Tren = tren;
        }
    }
}
