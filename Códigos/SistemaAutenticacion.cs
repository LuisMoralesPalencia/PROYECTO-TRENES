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
        private TablaHash<string, Usuario> tablaUsuarios;

        public SistemaAutenticacion(TablaHash<string, Usuario> existingTable)
        {
            tablaUsuarios = existingTable;
        }

        public bool RegistrarUsuario(string nombreUsuario, string contrasenia, string rol)
        {
            if (tablaUsuarios.BuscarValores(nombreUsuario) != null)
            {
                return false; 
            }

            Usuario nuevoUsuario = null;

            switch (rol.ToLower())
            {
                case "administrador":
                    nuevoUsuario = new Administrador(nombreUsuario, contrasenia);
                    break;
                case "empleado":
                    nuevoUsuario = new Empleado(nombreUsuario, contrasenia);
                    break;
                case "pasajero":
                    nuevoUsuario = new Pasajero(nombreUsuario, contrasenia);
                    break;
                default:
                    return false; 
            }

            if (nuevoUsuario != null)
            {
                tablaUsuarios.InsertarValores(nombreUsuario, nuevoUsuario);
                return true;
            }

            return false; 
        }


        public Usuario IniciarSesion(string nombreUsuario, string contrasenia)
        {
            Usuario storedUsuario = tablaUsuarios.BuscarValores(nombreUsuario);

            if (storedUsuario != null && storedUsuario.Contrasenia == contrasenia)
            {
                return storedUsuario;
            }

            return null;
        }

        public void CerrarSesion()
        {
            Console.WriteLine("Sesión cerrada.");
        }
    }
}