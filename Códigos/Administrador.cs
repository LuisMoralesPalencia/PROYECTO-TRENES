using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_TRENES.Códigos
{
    public class Administrador : Usuario
    {
        public Administrador(string nombreUsuario, string contrasenia) : base(nombreUsuario, contrasenia)
        {
        }
    }
}
