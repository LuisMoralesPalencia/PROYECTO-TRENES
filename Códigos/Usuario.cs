using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_TRENES.Códigos
{
    public class Usuario
    {
        private string nombreUsuario;
        private string contrasenia;

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }

        public Usuario(string nombreUsuario, string contrasenia)
        {
            this.NombreUsuario = nombreUsuario;
            this.Contrasenia = contrasenia;
        }
    }
}
