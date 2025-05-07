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
using System.Globalization;

namespace PROYECTO_TRENES.Modulo_Empleado
{
    public partial class confirmarmodificarrutaForm1 : Form
    {
        public Ruta RutaAModificar { get; set; }

        public confirmarmodificarrutaForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modificarrutaForm1 modificarrutaForm1 = new modificarrutaForm1();
            modificarrutaForm1.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void confirmarmodificarrutaForm1_Load(object sender, EventArgs e)
        {
            if (RutaAModificar != null)
            {
                textBox2.Text = RutaAModificar.IdRuta;
                textBox1.Text = RutaAModificar.Origen;
                textBox3.Text = RutaAModificar.Destino;
                textBox4.Text = RutaAModificar.FechaSalida;
                textBox5.Text = RutaAModificar.FechaLlegada;
                textBox6.Text = RutaAModificar.Distancia.ToString();

                // Removida logica relacionada con CheckBox de publicacion


                comboBox1.Items.Clear();
                Nodo<Tren> actualTren = Datos.ListaTrenes.GetPrimerNodo();
                if (actualTren != null)
                {
                    do
                    {
                        comboBox1.Items.Add(actualTren.Valor);
                        actualTren = actualTren.Siguiente;
                    } while (actualTren != Datos.ListaTrenes.GetPrimerNodo());
                }
                comboBox1.DisplayMember = "IdTren";


                if (RutaAModificar.Tren != null)
                {
                    foreach (Tren item in comboBox1.Items)
                    {
                        if (item.Id == RutaAModificar.Tren.Id)
                        {
                            comboBox1.SelectedItem = item;
                            break;
                        }
                    }
                }
                else
                {
                    comboBox1.SelectedIndex = -1;
                }

            }
            else
            {
                MessageBox.Show("No se recibió ninguna ruta para modificar. Volviendo al formulario anterior.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                modificarrutaForm1 formBusqueda = new modificarrutaForm1();
                formBusqueda.Show();
                this.Hide();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (RutaAModificar == null)
            {
                MessageBox.Show("Error: No hay ninguna ruta seleccionada para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idRutaOriginal = textBox2.Text.Trim();
            string nuevoOrigen = textBox1.Text.Trim();
            string nuevoDestino = textBox3.Text.Trim();
            string nuevaFechaSalida = textBox4.Text.Trim();
            string nuevaFechaLlegada = textBox5.Text.Trim();
            string nuevaDistanciaText = textBox6.Text.Trim();
            Tren nuevoTrenAsociado = comboBox1.SelectedItem as Tren;

            // Removida logica relacionada con el estado de publicacion


            if (string.IsNullOrWhiteSpace(nuevoOrigen) ||
                string.IsNullOrWhiteSpace(nuevoDestino) ||
                string.IsNullOrWhiteSpace(nuevaFechaSalida) ||
                string.IsNullOrWhiteSpace(nuevaFechaLlegada) ||
                string.IsNullOrWhiteSpace(nuevaDistanciaText) ||
                nuevoTrenAsociado == null)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un tren válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string formatoFecha = "dd/MM/yyyy";
            if (!DateTime.TryParseExact(nuevaFechaSalida, formatoFecha, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime salida) ||
                !DateTime.TryParseExact(nuevaFechaLlegada, formatoFecha, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime llegada))
            {
                MessageBox.Show($"Por favor, ingrese las fechas en el formato {formatoFecha}.", "Validación de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (salida >= llegada)
            {
                MessageBox.Show("La fecha de llegada debe ser posterior a la fecha de salida.", "Validación de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(nuevaDistanciaText, out double nuevaDistancia) || nuevaDistancia <= 0)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido y positivo para la distancia.", "Validación de Distancia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // *** Verificar si las nuevas estaciones de origen y destino existen. Si no, crearlas. ***
            Estacion origenEstacion = Datos.RedFerroviaria.BuscarEstacion(nuevoOrigen);
            if (origenEstacion == null)
            {
                Estacion nuevaEstacionOrigen = new Estacion(nuevoOrigen);
                Datos.RedFerroviaria.AgregarEstacion(nuevaEstacionOrigen);
                // Opcional: Puedes mostrar un mensaje al usuario informandole que la estacion fue creada.
                // MessageBox.Show($"La nueva estación de origen '{nuevoOrigen}' no existia y ha sido creada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Estacion destinoEstacion = Datos.RedFerroviaria.BuscarEstacion(nuevoDestino);
            if (destinoEstacion == null)
            {
                Estacion nuevaEstacionDestino = new Estacion(nuevoDestino);
                Datos.RedFerroviaria.AgregarEstacion(nuevaEstacionDestino);
                // Opcional: Puedes mostrar un mensaje al usuario informandole que la estacion fue creada.
                // MessageBox.Show($"La nueva estación de destino '{nuevoDestino}' no existia y ha sido creada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // *** ------------------------------------------------------------------------------- ***


            // Llamar al metodo ModificarRuta del Grafo con los datos actualizados
            bool modificado = Datos.RedFerroviaria.ModificarRuta(
                idRutaOriginal,
                nuevoOrigen,
                nuevoDestino,
                nuevaFechaSalida,
                nuevaFechaLlegada,
                nuevoTrenAsociado,
                nuevaDistancia
            );

            // Removida la llamada a PublicarRuta


            if (modificado)
            {
                MessageBox.Show($"La ruta con ID {idRutaOriginal} se modificó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox1.SelectedIndex = -1;
                this.RutaAModificar = null;

            }
            else
            {
                MessageBox.Show($"Error al intentar modificar la ruta con ID {idRutaOriginal}. Verifique los datos.", "Error de Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged_1(object sender, EventArgs e) { }
        private void textBox5_TextChanged_1(object sender, EventArgs EventArgs ) { }
        private void comboBoxTrenes_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}