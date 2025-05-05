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
        public static TablaHash<string, Usuario> TablaUsuarios;
        public static ListaCircular<Tren> ListaTrenes;
        public static ListaEnlazada<Ruta> ListaRutas;

        static Datos()
        {
            ListaRutas = new ListaEnlazada<Ruta>();
            TablaUsuarios = new TablaHash<string, Usuario>(10);
            ListaTrenes = new ListaCircular<Tren>();

            TablaUsuarios.InsertarValores(
                "Camacho",
                new Administrador("admin", "admin123")
            );

            TablaUsuarios.InsertarValores(
                "Miguel",
                new Empleado("empleado1", "emp456")
            );

            TablaUsuarios.InsertarValores(
                "Ren",
                new Pasajero("pasajero1", "pass789")
            );
        }
    }
}
