using PROYECTO_TRENES.Códigos;
using PROYECTO_TRENES.Estructuras_de_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_TRENES.Modulo_Usuarios
{
    public partial class FormSeleccionarRuta : Form
    {
        private MaquinaVenta maquinaVenta;
        private Ruta rutaSeleccionada;

        public FormSeleccionarRuta()
        {
            InitializeComponent();
            maquinaVenta = new MaquinaVenta();
            //rutaSeleccionada = null;
            
        }

        private void FormSeleccionarRuta1_Load(object sender, EventArgs e)
        {
            CargarEstaciones();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            FormMenuUsuario formMenuUsuario = new FormMenuUsuario();
            formMenuUsuario.Show();
            this.Hide();
        }

        private void comboBoxEstacionOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxRutaSeleccionada != null) textBoxRutaSeleccionada.Clear();
            richTextBoxInformacionRuta.Clear();
            //rutaSeleccionada = null;
        }

        private void richTextBoxInformacionRuta_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEstacionDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxRutaSeleccionada != null) textBoxRutaSeleccionada.Clear();
            richTextBoxInformacionRuta.Clear();
            //rutaSeleccionada = null;
        }

        private void buttonSeleccionarRuta_Click(object sender, EventArgs e)
        {
            string origenSeleccionado = comboBoxEstacionOrigen.SelectedItem?.ToString();
            string destinoSeleccionado = comboBoxEstacionDestino.SelectedItem?.ToString();

            Console.WriteLine($"Origen seleccionado: {origenSeleccionado}");
            Console.WriteLine($"Destino seleccionado: {destinoSeleccionado}");


            if (string.IsNullOrWhiteSpace(origenSeleccionado) || string.IsNullOrWhiteSpace(destinoSeleccionado))
            {
                MessageBox.Show("Por favor, seleccione una estación de origen y una de destino.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxRutaSeleccionada != null) textBoxRutaSeleccionada.Clear();
            richTextBoxInformacionRuta.Clear();
            rutaSeleccionada = null;

            List<Ruta> rutasDirectas = maquinaVenta.BuscarRutasDesdeOrigen(origenSeleccionado);

            Console.WriteLine($"Rutas obtenidas desde {origenSeleccionado}: {rutasDirectas?.Count ?? 0}");
            if (rutasDirectas != null)
            {
                foreach (var ruta in rutasDirectas)
                {
                    Console.WriteLine($"- ID: {ruta.IdRuta}, Origen: {ruta.Origen}, Destino: {ruta.Destino}");
                }
            }


            List<Ruta> rutasDisponibles = rutasDirectas.Where(r => r.Destino == destinoSeleccionado).ToList();

            Console.WriteLine($"Rutas encontradas para destino {destinoSeleccionado}: {rutasDisponibles.Count}");
            if (rutasDisponibles.Count > 0)
            {
                foreach (var ruta in rutasDisponibles)
                {
                    Console.WriteLine($"- Ruta disponible ID: {ruta.IdRuta}");
                }
            }


            if (rutasDisponibles.Count > 0)
            {
                rutaSeleccionada = rutasDisponibles.First();
                if (textBoxRutaSeleccionada != null)
                {
                    textBoxRutaSeleccionada.Text = rutaSeleccionada.IdRuta;
                }

                richTextBoxInformacionRuta.AppendText("Información de la Ruta Directa Seleccionada:\n");
                richTextBoxInformacionRuta.AppendText("-------------------------------------------\n");
                richTextBoxInformacionRuta.AppendText(maquinaVenta.ObtenerInfoRuta(rutaSeleccionada.IdRuta));

            }
            else
            {
                ResultadoDijkstra resultadoCaminoMasCorto = maquinaVenta.BuscarCaminoMasCorto(origenSeleccionado, destinoSeleccionado);

                if (resultadoCaminoMasCorto.Alcanzado)
                {
                    richTextBoxInformacionRuta.AppendText("No hay rutas directas disponibles, pero se encontró un camino:\n");
                    foreach (Ruta rutaPaso in resultadoCaminoMasCorto.RutasDelCamino)
                    {
                        richTextBoxInformacionRuta.AppendText($"- {rutaPaso.Origen} -> {rutaPaso.Destino} (ID: {rutaPaso.IdRuta}, Distancia: {rutaPaso.Distancia} km)\n");
                    }
                    richTextBoxInformacionRuta.AppendText($"Distancia Total: {resultadoCaminoMasCorto.DistanciaTotal} km\n");

                }
                else
                {
                    richTextBoxInformacionRuta.Text = "No hay rutas directas ni camino disponible entre las estaciones seleccionadas.";
                }
            }
        }

        private void CargarEstaciones()
        {
            List<string> nombresEstaciones = maquinaVenta.ObtenerTodasLasEstaciones();

            comboBoxEstacionOrigen.Items.Clear();
            comboBoxEstacionDestino.Items.Clear();

            if (nombresEstaciones != null && nombresEstaciones.Count > 0)
            {
                foreach (string nombreEstacion in nombresEstaciones)
                {
                    comboBoxEstacionOrigen.Items.Add(nombreEstacion);
                    comboBoxEstacionDestino.Items.Add(nombreEstacion);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron estaciones en el sistema. Por favor, registre estaciones primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRellenarDatosBoleto formRellenarDatosBoleto = new FormRellenarDatosBoleto();
            formRellenarDatosBoleto.Show();
            this.Hide();
        }
    }
}
