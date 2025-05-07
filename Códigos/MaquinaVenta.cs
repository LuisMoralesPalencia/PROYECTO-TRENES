using PROYECTO_TRENES.Estructuras_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PROYECTO_TRENES.Códigos
{
    public class MaquinaVenta
    {
        private ListaCircular<Tren> trenes;
        private Pila<Vagon> vagones;
        private ListaDoblementeEnlazada<Boleto> boletos;


        public ListaCircular<Tren> Trenes { get => trenes; set => trenes = value; }
        public Pila<Vagon> Vagones { get => vagones; set => vagones = value; }
        public ListaDoblementeEnlazada<Boleto> Boletos { get => boletos; set => boletos = value; }


        public MaquinaVenta()
        {
            boletos = new ListaDoblementeEnlazada<Boleto>();
        }

        public List<string> ObtenerTodasLasEstaciones()
        {
            if (Datos.RedFerroviaria != null)
            {
                return Datos.RedFerroviaria.ObtenerNombresEstaciones();
            }
            return new List<string>();
        }

        public List<Ruta> BuscarRutasDesdeOrigen(string origen)
        {
            if (Datos.RedFerroviaria != null)
            {
                return Datos.RedFerroviaria.ObtenerRutasDesdeEstacion(origen);
            }
            return new List<Ruta>();
        }

        public Ruta BuscarRutaPorId(string idRuta)
        {
            if (Datos.RedFerroviaria != null)
            {
                return Datos.RedFerroviaria.BuscarRuta(idRuta);
            }
            return null;
        }

        public string ObtenerInfoRuta(string idRuta)
        {
            if (Datos.RedFerroviaria != null)
            {
                Ruta ruta = Datos.RedFerroviaria.BuscarRuta(idRuta);
                if (ruta != null)
                {
                    return $"ID: {ruta.IdRuta}\n" +
                           $"Origen: {ruta.Origen}\n" +
                           $"Destino: {ruta.Destino}\n" +
                           $"Fecha Salida: {ruta.FechaSalida}\n" +
                           $"Fecha Llegada: {ruta.FechaLlegada}\n" +
                           $"Distancia: {ruta.Distancia} km\n" +
                           $"Tren: {ruta.Tren?.Id ?? "N/A"}\n" +
                           $"Publicada: {(ruta.EsPublicada ? "Sí" : "No")}";

                }
            }
            return "Ruta no encontrada.";
        }

        public ResultadoDijkstra BuscarCaminoMasCorto(string origen, string destino)
        {
            if (Datos.RedFerroviaria != null)
            {
                return Datos.RedFerroviaria.RecomendarRutaMasCorta(origen, destino);
            }
            return new ResultadoDijkstra { Alcanzado = false, DistanciaTotal = double.PositiveInfinity, RutasDelCamino = new List<Ruta>() };
        }

        public bool RealizarCompra(string idRuta, string idPasajero, string nombresPasajero, string apellidosPasajero, string tipoIdentificacionPasajero, string direccionPasajero, string telefonoPasajero, string lugarAsiento, string categoriaPasajero, double valorPasaje, string contactoNombres, string contactoApellidos, string contactoTelefono, string idVagonCarga = null, List<Equipaje> listaEquipaje = null)
        {
            Ruta rutaAComprar = BuscarRutaPorId(idRuta);

            if (rutaAComprar != null)
            {
                string idRegistroBoleto = $"REG_{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";

                string fechaSalidaRuta = rutaAComprar.FechaSalida;
                string fechaLlegadaRuta = rutaAComprar.FechaLlegada;
                string idTrenRuta = rutaAComprar.Tren?.Id;

                string fechaHoraActualCompra = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");


                Boleto nuevoBoleto = new Boleto(
                    idRegistroBoleto,
                    fechaHoraActualCompra,
                    fechaSalidaRuta,
                    fechaLlegadaRuta,
                    idPasajero,
                    nombresPasajero,
                    apellidosPasajero,
                    tipoIdentificacionPasajero,
                    direccionPasajero,
                    telefonoPasajero,
                    idTrenRuta,
                    lugarAsiento,
                    categoriaPasajero,
                    valorPasaje,
                    contactoNombres,
                    contactoApellidos,
                    contactoTelefono,
                    idVagonCarga
                );

                


                if (Boletos != null)
                {
                    Boletos.Agregar(nuevoBoleto);
                }
                else
                {
                    Console.WriteLine("Error: La lista de boletos en MaquinaVenta no está inicializada.");
                    MessageBox.Show("Error interno al procesar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                Console.WriteLine($"Simulacion: Compra exitosa para Ruta ID: {idRuta}, Registro Boleto ID: {idRegistroBoleto}");
                MessageBox.Show($"Compra exitosa para la ruta {rutaAComprar.Origen} a {rutaAComprar.Destino}.\nID de Registro de Boleto: {idRegistroBoleto}", "Compra Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show($"No se pudo realizar la compra. La ruta {idRuta} no existe.", "Error de Compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine($"Simulacion: Error al comprar. Ruta {idRuta} no encontrada.");
                return false;
            }
        }

        public bool CancelarCompra(string idRegistroBoleto)
        {
            Boleto boletoACancelar = null;

            if (Boletos != null)
            {
                Nodo<Boleto> actual = Boletos.GetCabeza();
                if (actual != null)
                {
                    do
                    {
                        if (actual.Valor.IdRegistro == idRegistroBoleto)
                        {
                            boletoACancelar = actual.Valor;
                            break;
                        }
                        actual = actual.Siguiente;
                    } while (actual != Boletos.GetCabeza() && actual != null);
                }

            }
            else
            {
                Console.WriteLine("Error: La lista de boletos en MaquinaVenta no está inicializada.");
                MessageBox.Show("Error interno al procesar la cancelación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (boletoACancelar != null)
            {
                if (boletoACancelar.Estado == "Válido")
                {
                    boletoACancelar.Cancelar();

                    Console.WriteLine($"Simulacion: Boleto con Registro ID {idRegistroBoleto} cancelado exitosamente.");
                    MessageBox.Show($"Cancelación exitosa para el boleto con Registro ID {idRegistroBoleto}.", "Cancelación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show($"El boleto con Registro ID {idRegistroBoleto} ya está cancelado o no es válido para cancelar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Console.WriteLine($"Simulacion: Intento de cancelar boleto con Registro ID {idRegistroBoleto} que no estaba Válido.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show($"No se encontró ningún boleto con el Registro ID {idRegistroBoleto}.", "Error de Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine($"Simulacion: No se encontró boleto con Registro ID {idRegistroBoleto} para cancelar.");
                return false;
            }
        }

        public ListaDoblementeEnlazada<Boleto> ObtenerTodosLosBoletos()
        {
            return Boletos;
        }
    }
}
