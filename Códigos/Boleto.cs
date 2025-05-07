using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_TRENES.Códigos
{
    public class Boleto
    {

        private string idRegistro;
        private string fechaHoraCompra;
        private string fechaHoraSalida;
        private string fechaHoraLlegada;
        private string nombres;
        private string apellidos;
        private string tipoIdentificacion;
        private string identificacion;
        private string direccion;
        private string telefono;
        private string idTren;
        private string lugar;
        private string categoriaPasajero;
        private double valorPasaje;
        private string contactoNombres;
        private string contactoApellidos;
        private string contactoTelefono;
        private string idVagonCarga;
        private List<Equipaje> equipaje;
        private Boolean estado;

        public Boleto(
            string idRegistro, string fechaHoraCompra, string fechaHoraSalida, string fechaHoraLlegada, string nombres,
            string apellidos, string tipoIdentificacion, string identificacion, string direccion, string telefono,
            string idTren, string lugar, string categoriaPasajero, double valorPasaje, string contactoNombres,
            string contactoApellidos, string contactoTelefono, string idVagonCarga, List<Equipaje> equipaje, bool estado)
        {
            this.idRegistro = idRegistro;
            this.fechaHoraCompra = fechaHoraCompra;
            this.fechaHoraSalida = fechaHoraSalida;
            this.fechaHoraLlegada = fechaHoraLlegada;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.tipoIdentificacion = tipoIdentificacion;
            this.identificacion = identificacion;
            this.direccion = direccion;
            this.telefono = telefono;
            this.idTren = idTren;
            this.lugar = lugar;
            this.categoriaPasajero = categoriaPasajero;
            this.valorPasaje = valorPasaje;
            this.contactoNombres = contactoNombres;
            this.contactoApellidos = contactoApellidos;
            this.contactoTelefono = contactoTelefono;
            this.idVagonCarga = idVagonCarga;
            this.equipaje = equipaje;
            this.estado = estado;
        }

        public void Cancelar()
        {
            if (Estado == true)
            {
                Estado = false;
                Console.WriteLine($"Boleto {IdRegistro} ha sido marcado como Cancelado.");
            }
            else
            {
                Console.WriteLine($"Boleto {IdRegistro} ya tiene estado '{Estado}' y no puede ser cancelado.");
            }
        }
        public string IdRegistro { get => idRegistro; set => idRegistro = value; }
        public string FechaHoraCompra { get => fechaHoraCompra; set => fechaHoraCompra = value; }
        public string FechaHoraSalida { get => fechaHoraSalida; set => fechaHoraSalida = value; }
        public string FechaHoraLlegada { get => fechaHoraLlegada; set => fechaHoraLlegada = value; }
        public string IdPasajero { get => identificacion; set => identificacion = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string TipoIdentificacion { get => tipoIdentificacion; set => tipoIdentificacion = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string IdTren { get => idTren; set => idTren = value; }
        public string Lugar { get => lugar; set => lugar = value; }
        public string CategoriaPasajero { get => categoriaPasajero; set => categoriaPasajero = value; }
        public double ValorPasaje { get => valorPasaje; set => valorPasaje = value; }
        public string ContactoNombres { get => contactoNombres; set => contactoNombres = value; }
        public string ContactoApellidos { get => contactoApellidos; set => contactoApellidos = value; }
        public string ContactoTelefono { get => contactoTelefono; set => contactoTelefono = value; }
        public string IdVagonCarga { get => idVagonCarga; set => idVagonCarga = value; }
        public List<Equipaje> Equipaje { get => equipaje; set => equipaje = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
