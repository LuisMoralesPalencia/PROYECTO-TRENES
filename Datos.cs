using PROYECTO_TRENES.Estructuras_de_datos;
using PROYECTO_TRENES.Códigos;
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
        public static Grafo RedFerroviaria;
        public static ListaDoblementeEnlazada<Boleto> ListaBoletos;
        static Datos()
        {
            ListaTrenes = new ListaCircular<Tren>();
            TablaUsuarios = new TablaHash<string, Usuario>(200);
            RedFerroviaria = new Grafo();
            ListaBoletos = new ListaDoblementeEnlazada<Boleto>();

            TablaUsuarios.InsertarValores(
                "admin",
                new Administrador("admin", "NombreAdmin", "ApellidoAdmin", "CC", "123456789", "3001112233", "admin123") 
            );

            TablaUsuarios.InsertarValores(
                "empleado1", 
                new Empleado("empleado1", "NombreEmpleado", "ApellidoEmpleado", "TI", "987654321", "3104445566", "emp456") 
            );

            TablaUsuarios.InsertarValores(
                "pasajero1", 
                new Pasajero("pasajero1", "NombrePasajero", "ApellidoPasajero", "CC", "101010101", "3207778899", "pass789") 
            );



        }
    }
}