using System;

namespace PROYECTO_TRENES.Códigos
{
    public class Empleado : Usuario
    {
        public Empleado(string nombreUsuario, string nombre, string apellido, string tipoIdentificacion, string numeroIdentificacion, string numeroTelefono, string contrasenia)
            : base(nombreUsuario, nombre, apellido, tipoIdentificacion, numeroIdentificacion, numeroTelefono, contrasenia)
        {
        }

        public Empleado(string nombreUsuario, string contrasenia)
            : base(nombreUsuario, contrasenia)
        {
        }
    }
}