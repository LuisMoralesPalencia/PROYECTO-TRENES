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
    public partial class agregarrutaForm1 : Form
    {
        public agregarrutaForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm1 menuPrincipalForm1 = new MenuPrincipalForm1();
            menuPrincipalForm1.Show();
            this.Hide();
        }

        private void agregarrutaForm1_Load(object sender, EventArgs e)
        {
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
        }

        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            string idRuta = textBox2.Text.Trim();
            string origen = textBox1.Text.Trim();
            string destino = textBox3.Text.Trim();
            string fechaSalida = textBox4.Text.Trim();
            string fechaLlegada = textBox5.Text.Trim();

            if (string.IsNullOrWhiteSpace(idRuta) ||
                string.IsNullOrWhiteSpace(origen) ||
                string.IsNullOrWhiteSpace(destino) ||
                string.IsNullOrWhiteSpace(fechaSalida) ||
                string.IsNullOrWhiteSpace(fechaLlegada) ||
                comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un tren.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string formatoFecha = "dd/MM/yyyy";
            if (!DateTime.TryParseExact(fechaSalida, formatoFecha, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime salida) || !DateTime.TryParseExact(fechaLlegada, formatoFecha, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime llegada))
            {
                MessageBox.Show($"Por favor, ingrese las fechas en el formato {formatoFecha}.", "Validación de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (salida >= llegada)
            {
                MessageBox.Show("La fecha de llegada debe ser posterior a la fecha de salida.", "Validación de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tren trenAsociado = comboBox1.SelectedItem as Tren; 

            if (trenAsociado == null)
            {
                MessageBox.Show("Error interno: No se pudo obtener el objeto Tren seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Ruta rutaExistente = null;
            Nodo<Ruta> actualRuta = Datos.ListaRutas.GetCabeza();
            while (actualRuta != null)
            {
                if (actualRuta.Valor.IdRuta == idRuta)
                {
                    rutaExistente = actualRuta.Valor;
                    break;
                }
                actualRuta = actualRuta.Siguiente;
            }

            if (rutaExistente != null)
            {
                MessageBox.Show($"Ya existe una ruta con el ID: {idRuta}. Por favor, use un ID de ruta único.", "ID de Ruta Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Ruta nuevaRuta = new Ruta(idRuta, origen, destino, fechaSalida, fechaLlegada, trenAsociado);

            Datos.ListaRutas.Agregar(nuevaRuta);

            MessageBox.Show("Ruta agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.SelectedIndex = -1;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}