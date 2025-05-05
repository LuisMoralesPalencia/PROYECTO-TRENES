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

namespace PROYECTO_TRENES.Modulo_Empleado
{
    public partial class confirmarmodificaciontrenForm1 : Form
    {
        public Tren TrenAModificar { get; set; }

        public confirmarmodificaciontrenForm1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modificartrenForm1 modificartrenForm1 = new modificartrenForm1();
            modificartrenForm1.Show();
            this.Hide();
        }

        private void confirmarmodificaciontrenForm1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TrenAModificar == null)
            {
                MessageBox.Show("Error: No hay ningún tren seleccionado para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione el tipo de tren.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox3.Text.Trim(), out int nuevaCapacidad) || nuevaCapacidad < 0)
            {
                MessageBox.Show("Por favor, ingrese un número entero válido para la Capacidad de Vagones.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox4.Text.Trim(), out int nuevoKilometraje) || nuevoKilometraje < 0)
            {
                MessageBox.Show("Por favor, ingrese un número entero válido no negativo para el Kilometraje.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nuevoTipo = comboBox1.SelectedItem.ToString();
            bool capacidadValidaParaTipo = true;
            int maxCapacidad = 0;

            if (nuevoTipo == "Arnold")
            {
                maxCapacidad = 32;
                if (nuevaCapacidad > maxCapacidad) capacidadValidaParaTipo = false;
            }
            else if (nuevoTipo == "MercedesBenz")
            {
                maxCapacidad = 28;
                if (nuevaCapacidad > maxCapacidad) capacidadValidaParaTipo = false;
            }

            if (!capacidadValidaParaTipo)
            {
                MessageBox.Show($"La capacidad de vagones ({nuevaCapacidad}) excede el máximo permitido para un Tren {nuevoTipo} ({maxCapacidad}).", "Validación de Capacidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nuevoNombre = textBox1.Text.Trim();
            string nuevoId = textBox2.Text.Trim();

            Nodo<Tren> actualCheckId = Datos.ListaTrenes.GetPrimerNodo();
            bool idYaExisteEnOtroTren = false;
            if (actualCheckId != null)
            {
                do
                {
                    if (actualCheckId.Valor.Id == nuevoId && actualCheckId.Valor != TrenAModificar)
                    {
                        idYaExisteEnOtroTren = true;
                        break;
                    }
                    actualCheckId = actualCheckId.Siguiente;
                } while (actualCheckId != Datos.ListaTrenes.GetPrimerNodo());
            }

            if (idYaExisteEnOtroTren)
            {
                MessageBox.Show($"Ya existe otro tren con el ID: {nuevoId}.", "Validación de ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tren trenConDatosModificados = new Tren(nuevoNombre, nuevoId, nuevoTipo, nuevaCapacidad, nuevoKilometraje);

            bool modificacionExitosa = Datos.ListaTrenes.Modificar(this.TrenAModificar, trenConDatosModificados);

            if (modificacionExitosa)
            {
                MessageBox.Show($"El tren con ID {trenConDatosModificados.Id} se modificó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.SelectedIndex = -1;
                this.TrenAModificar = null;

                modificartrenForm1 formBusqueda = new modificartrenForm1();
                formBusqueda.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("No se pudo encontrar el tren original en la lista para modificar.", "Error de Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}