using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_TRENES.Códigos;

namespace PROYECTO_TRENES.Estructuras_de_datos
{
    public class ResultadoDijkstra
    {
        public double DistanciaTotal { get; set; }
        public List<Ruta> RutasDelCamino { get; set; }
        public bool Alcanzado { get; set; }
    }

    public class Grafo
    {
        private Dictionary<string, Estacion> estaciones;
        private Dictionary<string, List<Ruta>> listaAdyacencia;
        private Dictionary<string, Ruta> rutasPorId;

        public Grafo()
        {
            estaciones = new Dictionary<string, Estacion>();
            listaAdyacencia = new Dictionary<string, List<Ruta>>();
            rutasPorId = new Dictionary<string, Ruta>();
        }

        public void AgregarEstacion(Estacion estacion)
        {
            if (!estaciones.ContainsKey(estacion.NombreEstacion))
            {
                estaciones[estacion.NombreEstacion] = estacion;
                listaAdyacencia[estacion.NombreEstacion] = new List<Ruta>();
            }
            else
            {
                Console.WriteLine($"Advertencia: La estación '{estacion.NombreEstacion}' ya existe en el grafo.");
            }
        }

        public void AgregarRuta(Ruta ruta)
        {
            if (estaciones.ContainsKey(ruta.Origen) && estaciones.ContainsKey(ruta.Destino))
            {
                if (!rutasPorId.ContainsKey(ruta.IdRuta))
                {
                    listaAdyacencia[ruta.Origen].Add(ruta);
                    rutasPorId[ruta.IdRuta] = ruta;
                }
                else
                {
                    Console.WriteLine($"Advertencia: La ruta con ID '{ruta.IdRuta}' ya existe en el grafo.");
                }
            }
            else
            {
                if (!estaciones.ContainsKey(ruta.Origen))
                {
                    Console.WriteLine($"Error al agregar ruta '{ruta.IdRuta}': Estación de origen '{ruta.Origen}' no encontrada en el grafo.");
                }
                if (!estaciones.ContainsKey(ruta.Destino))
                {
                    Console.WriteLine($"Error al agregar ruta '{ruta.IdRuta}': Estación de destino '{ruta.Destino}' no encontrada en el grafo.");
                }
            }
        }

        public Estacion BuscarEstacion(string nombreEstacion)
        {
            if (estaciones.ContainsKey(nombreEstacion))
            {
                return estaciones[nombreEstacion];
            }
            return null;
        }

        public Ruta BuscarRuta(string idRuta)
        {
            if (rutasPorId.ContainsKey(idRuta))
            {
                return rutasPorId[idRuta];
            }
            return null;
        }

        public bool EliminarRuta(string idRuta)
        {
            if (rutasPorId.ContainsKey(idRuta))
            {
                Ruta rutaAEliminar = rutasPorId[idRuta];
                rutasPorId.Remove(idRuta);
                if (listaAdyacencia.ContainsKey(rutaAEliminar.Origen))
                {
                    listaAdyacencia[rutaAEliminar.Origen].Remove(rutaAEliminar);
                }

                Console.WriteLine($"Ruta con ID '{idRuta}' eliminada del grafo.");
                return true; 
            }
            else
            {
                Console.WriteLine($"Advertencia: Ruta con ID '{idRuta}' no encontrada en el grafo para eliminar.");
                return false; 
            }
        }

        public bool ModificarRuta(string idRuta, string nuevoOrigen, string nuevoDestino, string nuevaFechaSalida, string nuevaFechaLlegada, Tren nuevoTren, double nuevaDistancia)
        {
            if (rutasPorId.ContainsKey(idRuta))
            {
                Ruta rutaAModificar = rutasPorId[idRuta];

                if (!estaciones.ContainsKey(nuevoOrigen) || !estaciones.ContainsKey(nuevoDestino))
                {
                    Console.WriteLine($"Error al modificar ruta '{idRuta}': La nueva estación de origen '{nuevoOrigen}' o de destino '{nuevoDestino}' no existe.");
                    return false;
                }

                string oldOrigen = rutaAModificar.Origen;

                rutaAModificar.Origen = nuevoOrigen;
                rutaAModificar.Destino = nuevoDestino;
                rutaAModificar.FechaSalida = nuevaFechaSalida;
                rutaAModificar.FechaLlegada = nuevaFechaLlegada;
                rutaAModificar.Tren = nuevoTren;
                rutaAModificar.Distancia = nuevaDistancia;
                
                if (oldOrigen != nuevoOrigen)
                {
                    if (listaAdyacencia.ContainsKey(oldOrigen))
                    {
                        listaAdyacencia[oldOrigen].Remove(rutaAModificar);
                    }

                    if (listaAdyacencia.ContainsKey(nuevoOrigen))
                    {
                        listaAdyacencia[nuevoOrigen].Add(rutaAModificar);
                    }
                    else
                    {
                        listaAdyacencia[nuevoOrigen] = new List<Ruta> { rutaAModificar };
                    }
                }

                Console.WriteLine($"Ruta con ID '{idRuta}' modificada exitosamente.");
                return true;
            }
            else
            {
                Console.WriteLine($"Advertencia: Ruta con ID '{idRuta}' no encontrada en el grafo para modificar.");
                return false;
            }
        }

        public bool ModificarRutaConCambioId(string oldIdRuta, Ruta rutaConNuevosDatos)
        {
            if (!rutasPorId.ContainsKey(oldIdRuta))
            {
                Console.WriteLine($"Advertencia: Ruta con ID antiguo '{oldIdRuta}' no encontrada para modificar.");
                return false;
            }

            Ruta rutaExistente = rutasPorId[oldIdRuta];
            string oldOrigen = rutaExistente.Origen;
            string nuevoIdRuta = rutaConNuevosDatos.IdRuta;
            string nuevoOrigen = rutaConNuevosDatos.Origen;
            string nuevoDestino = rutaConNuevosDatos.Destino;


            if (oldIdRuta != nuevoIdRuta)
            {
                if (rutasPorId.ContainsKey(nuevoIdRuta))
                {
                    Console.WriteLine($"Advertencia: El nuevo ID de ruta '{nuevoIdRuta}' ya existe para otra ruta.");
                    return false;
                }
            }


            if (oldIdRuta != nuevoIdRuta)
            {
                if (listaAdyacencia.ContainsKey(oldOrigen))
                {
                    listaAdyacencia[oldOrigen].Remove(rutaExistente);
                }

                rutasPorId.Remove(oldIdRuta);


                rutaExistente.IdRuta = rutaConNuevosDatos.IdRuta;
                rutaExistente.Origen = rutaConNuevosDatos.Origen;
                rutaExistente.Destino = rutaConNuevosDatos.Destino;
                rutaExistente.FechaSalida = rutaConNuevosDatos.FechaSalida;
                rutaExistente.FechaLlegada = rutaConNuevosDatos.FechaLlegada;
                rutaExistente.Tren = rutaConNuevosDatos.Tren;
                rutaExistente.Distancia = rutaConNuevosDatos.Distancia;


                rutasPorId[nuevoIdRuta] = rutaExistente;

                if (listaAdyacencia.ContainsKey(nuevoOrigen))
                {
                    listaAdyacencia[nuevoOrigen].Add(rutaExistente);
                }
                else
                {
                    listaAdyacencia[nuevoOrigen] = new List<Ruta> { rutaExistente };
                }

                Console.WriteLine($"Ruta con ID '{oldIdRuta}' modificada a '{nuevoIdRuta}' exitosamente.");
                return true;

            }
            else
            {
                string oldOrigenCuandoIdNoCambia = rutaExistente.Origen;

                rutaExistente.Origen = rutaConNuevosDatos.Origen;
                rutaExistente.Destino = rutaConNuevosDatos.Destino;
                rutaExistente.FechaSalida = rutaConNuevosDatos.FechaSalida;
                rutaExistente.FechaLlegada = rutaConNuevosDatos.FechaLlegada;
                rutaExistente.Tren = rutaConNuevosDatos.Tren;
                rutaExistente.Distancia = rutaConNuevosDatos.Distancia;


                if (oldOrigenCuandoIdNoCambia != rutaConNuevosDatos.Origen)
                {
                    if (listaAdyacencia.ContainsKey(oldOrigenCuandoIdNoCambia))
                    {
                        listaAdyacencia[oldOrigenCuandoIdNoCambia].Remove(rutaExistente);
                    }

                    if (listaAdyacencia.ContainsKey(rutaConNuevosDatos.Origen))
                    {
                        listaAdyacencia[rutaConNuevosDatos.Origen].Add(rutaExistente);
                    }
                    else
                    {
                        listaAdyacencia[rutaConNuevosDatos.Origen] = new List<Ruta> { rutaExistente };
                    }
                }

                Console.WriteLine($"Ruta con ID '{oldIdRuta}' modificada (ID no cambió) exitosamente.");
                return true;
            }
        }

        public List<Ruta> MostrarRutas()
        {
            return rutasPorId.Values.ToList();
        }

        public Ruta BuscarRutaEntreEstaciones(string origen, string destino)
        {
            if (listaAdyacencia.ContainsKey(origen))
            {
                foreach (Ruta ruta in listaAdyacencia[origen])
                {
                    if (ruta.Destino == destino)
                    {
                        return ruta;
                    }
                }
            }
            return null;
        }

        public double CalcularDistancia(List<Ruta> path)
        {
            double totalDistancia = 0;
            if (path != null)
            {
                foreach (Ruta ruta in path)
                {
                    totalDistancia += ruta.Distancia;
                }
            }
            return totalDistancia;
        }

        public void PublicarRuta(string idRuta, bool esPublicada)
        {
            if (rutasPorId.ContainsKey(idRuta))
            {
                rutasPorId[idRuta].EsPublicada = esPublicada;
                Console.WriteLine($"Estado de publicación de la ruta '{idRuta}' actualizado a {esPublicada}.");
            }
            else
            {
                Console.WriteLine($"Error: Ruta con ID '{idRuta}' no encontrada para publicar.");
            }
        }

        public ResultadoDijkstra RecomendarRutaMasCorta(string origen, string destino)
        {
            if (!estaciones.ContainsKey(origen) || !estaciones.ContainsKey(destino))
            {
                return new ResultadoDijkstra { Alcanzado = false, DistanciaTotal = double.PositiveInfinity, RutasDelCamino = new List<Ruta>() };
            }

            Dictionary<string, double> distancias = new Dictionary<string, double>();
            Dictionary<string, string> estacionesPrevias = new Dictionary<string, string>();
            Dictionary<string, Ruta> rutasPrevias = new Dictionary<string, Ruta>();
            HashSet<string> noVisitados = new HashSet<string>();


            foreach (var stationName in estaciones.Keys)
            {
                distancias[stationName] = double.PositiveInfinity;
                estacionesPrevias[stationName] = null;
                rutasPrevias[stationName] = null;
                noVisitados.Add(stationName);
            }
            distancias[origen] = 0;

            while (noVisitados.Count > 0)
            {
                string estacionActualNombre = null;
                double distanciaMinima = double.PositiveInfinity;

                foreach (var stationName in noVisitados)
                {
                    if (distancias.ContainsKey(stationName) && distancias[stationName] < distanciaMinima)
                    {
                        distanciaMinima = distancias[stationName];
                        estacionActualNombre = stationName;
                    }
                }

                if (estacionActualNombre == null || distancias[estacionActualNombre] == double.PositiveInfinity)
                {
                    break;
                }

                if (estacionActualNombre == destino)
                {
                    break;
                }

                noVisitados.Remove(estacionActualNombre);

                if (listaAdyacencia.ContainsKey(estacionActualNombre))
                {
                    foreach (Ruta rutaSaliente in listaAdyacencia[estacionActualNombre])
                    {
                        string estacionVecinaNombre = rutaSaliente.Destino;

                        if (estaciones.ContainsKey(estacionVecinaNombre))
                        {
                            if (noVisitados.Contains(estacionVecinaNombre))
                            {
                                double nuevaDistancia = distancias[estacionActualNombre] + rutaSaliente.Distancia;

                                if (nuevaDistancia < distancias[estacionVecinaNombre])
                                {
                                    distancias[estacionVecinaNombre] = nuevaDistancia;
                                    estacionesPrevias[estacionVecinaNombre] = estacionActualNombre;
                                    rutasPrevias[estacionVecinaNombre] = rutaSaliente;
                                }
                            }
                        }
                    }
                }
            }

            ResultadoDijkstra resultado = new ResultadoDijkstra();
            resultado.DistanciaTotal = distancias.ContainsKey(destino) ? distancias[destino] : double.PositiveInfinity;
            resultado.RutasDelCamino = new List<Ruta>();
            resultado.Alcanzado = (resultado.DistanciaTotal != double.PositiveInfinity);

            if (resultado.Alcanzado)
            {
                List<Ruta> pathRoutesReversed = new List<Ruta>();
                string step = destino;
                while (rutasPrevias.ContainsKey(step) && rutasPrevias[step] != null)
                {
                    pathRoutesReversed.Add(rutasPrevias[step]);
                    step = estacionesPrevias[step];
                }
                pathRoutesReversed.Reverse();
                resultado.RutasDelCamino = pathRoutesReversed;
            }

            return resultado;
        }

        public List<Ruta> ObtenerRutasDesdeEstacion(string origen)
        {
            if (listaAdyacencia.ContainsKey(origen))
            {
                return listaAdyacencia[origen].ToList();
            }
            return new List<Ruta>(); 
        }

        public List<string> ObtenerNombresEstaciones()
        {
            return estaciones.Keys.ToList();
        }
    }
}