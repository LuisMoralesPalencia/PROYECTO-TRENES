using PROYECTO_TRENES.Códigos;
using PROYECTO_TRENES.Estructuras_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_TRENES
{
    public static class Datos
    {
        public static TablaHash<string, UserInfo> TablaUsuarios;


        static Datos()
        {
            TablaUsuarios = new TablaHash<string, UserInfo>(10);
            TablaUsuarios.InsertarValores(
                "admin",
                new UserInfo { ContraseniaAlmacenada = "admin123", Rol = "Administrador" }
            );

            TablaUsuarios.InsertarValores(
                "empleado1",
                new UserInfo { ContraseniaAlmacenada = "emp456", Rol = "Empleado" }
            );

            TablaUsuarios.InsertarValores(
                "pasajero1",
                new UserInfo { ContraseniaAlmacenada = "pass789", Rol = "Pasajero" }
            );
        }
    }
}
