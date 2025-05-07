using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_TRENES.Códigos
{
    public class Estacion
    {
        private string nombreEstacion;
        private List<Ruta> rutas;

        public string NombreEstacion { get => nombreEstacion; set => nombreEstacion = value; }
        public List<Ruta> Rutas { get => rutas; set => rutas = value; }

        public Estacion(string nombreEstacion)
        {
            rutas = new List<Ruta>();
            this.nombreEstacion = nombreEstacion;
        }

        public void AgregarRuta(Ruta ruta)
        {
            if (ruta != null) 
            {
                rutas.Add(ruta);
            }
        }
    }
}
