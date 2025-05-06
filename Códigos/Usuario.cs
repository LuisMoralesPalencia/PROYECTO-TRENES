using System;

namespace PROYECTO_TRENES.Códigos
{
    public class Usuario
    {
        public string IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string NumeroTelefono { get; set; }

        public Usuario(string nombreUsuario, string nombre, string apellido, string tipoIdentificacion, string numeroIdentificacion, string numeroTelefono, string contrasenia)
        {
            this.NombreUsuario = nombreUsuario;
            this.IdUsuario = nombreUsuario;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.TipoIdentificacion = tipoIdentificacion;
            this.NumeroIdentificacion = numeroIdentificacion;
            this.NumeroTelefono = numeroTelefono;
            this.Contrasenia = contrasenia;
        }

        public Usuario(string nombreUsuario, string contrasenia)
        {
            this.NombreUsuario = nombreUsuario;
            this.IdUsuario = nombreUsuario;
            this.Contrasenia = contrasenia;
        }

        public override string ToString()
        {
            return $"Usuario: {NombreUsuario}, Nombre: {Nombre} {Apellido}";
        }
    }
}