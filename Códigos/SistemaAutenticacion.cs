using PROYECTO_TRENES.Estructuras_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_TRENES.Códigos
{
    public class SistemaAutenticacion
    {
        private TablaHash<string, UserInfo> tablaUsuarios;

        public SistemaAutenticacion(TablaHash<string, UserInfo> existingTable)
        {
            if (existingTable == null)
            {
                throw new ArgumentNullException(nameof(existingTable), "La tabla hash de usuarios proporcionada no puede ser nula.");
            }
            tablaUsuarios = existingTable;
        }

        public bool RegistrarUsuario(string nombreUsuario, string contrasenia, string rol)
        {
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasenia) || string.IsNullOrEmpty(rol))
            {
                return false;
            }

            if (tablaUsuarios.BuscarValores(nombreUsuario) != null)
            {
                return false;
            }

            UserInfo nuevoUsuario = new UserInfo
            {
                ContraseniaAlmacenada = contrasenia,
                Rol = rol
            };

            tablaUsuarios.InsertarValores(nombreUsuario, nuevoUsuario);

            return true;
        }

        public string IniciarSesion(string nombreUsuario, string contrasenia)
        {
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasenia))
            {
                return null;
            }

            UserInfo storedUserInfo = tablaUsuarios.BuscarValores(nombreUsuario);

            if (storedUserInfo != null && storedUserInfo.ContraseniaAlmacenada == contrasenia)
            {
                return storedUserInfo.Rol;
            }

            return null;
        }

        public void CerrarSesion()
        {
            Console.WriteLine("Sesión cerrada.");
        }
    }
}
