using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_TRENES.Objetos.Usuarios
{
    internal class ClassUsuario
    {
        

        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }



        public ClassUsuario(string identificacion, string nombre, string apellido,
            string tipoIdentificacion, string direccion, string telefono)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            TipoIdentificacion = tipoIdentificacion;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
