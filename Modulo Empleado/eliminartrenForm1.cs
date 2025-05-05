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
    public partial class eliminartrenForm1 : Form
    {
        private Tren trenEncontradoParaEliminar;

        public eliminartrenForm1()
        {
            InitializeComponent();
            trenEncontradoParaEliminar = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm1 menuPrincipalForm1 = new MenuPrincipalForm1();
            menuPrincipalForm1.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (this.trenEncontradoParaEliminar == null)
            {
                MessageBox.Show("Busque un tren primero usando el botón 'Buscar'.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show($"¿Está seguro de eliminar el tren con ID {this.trenEncontradoParaEliminar.Id}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                bool eliminado = Datos.ListaTrenes.Eliminar(this.trenEncontradoParaEliminar);

                if (eliminado)
                {
                    MessageBox.Show($"Tren con ID {this.trenEncontradoParaEliminar.Id} eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox2.Text = "";
                    textBox1.Text = "";
                    richTextBox1.Text = "";
                    this.trenEncontradoParaEliminar = null;
                }
                else
                {
                    MessageBox.Show($"Error inesperado al intentar eliminar el tren con ID {this.trenEncontradoParaEliminar.Id}.", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Text = "";
                    textBox1.Text = "";
                    richTextBox1.Text = "";
                    this.trenEncontradoParaEliminar = null;
                }
            }
        }

        private void eliminartrenForm1_Load(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string idBuscar = textBox2.Text.Trim(); // Usa Trim() para evitar espacios extra
            string nombreBuscar = textBox1.Text.Trim(); // Usa Trim()

            richTextBox1.Text = "";
            this.trenEncontradoParaEliminar = null; // Reiniciar el tren encontrado al inicio de la búsqueda

            if (string.IsNullOrWhiteSpace(idBuscar) && string.IsNullOrWhiteSpace(nombreBuscar))
            {
                MessageBox.Show("Por favor, ingrese el ID o el Nombre del tren a buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tren trenEncontrado = null;

            if (!string.IsNullOrWhiteSpace(idBuscar))
            {
                Nodo<Tren> actual = Datos.ListaTrenes.GetPrimerNodo();
                if (actual != null)
                {
                    do
                    {
                        if (actual.Valor.Id == idBuscar)
                        {
                            trenEncontrado = actual.Valor;
                            break;
                        }
                        actual = actual.Siguiente;
                    } while (actual != Datos.ListaTrenes.GetPrimerNodo());
                }
            }
            else if (!string.IsNullOrWhiteSpace(nombreBuscar))
            {
                Nodo<Tren> actual = Datos.ListaTrenes.GetPrimerNodo();
                if (actual != null)
                {
                    do
                    {
                        if (actual.Valor.Nombre == nombreBuscar)
                        {
                            trenEncontrado = actual.Valor;
                            break;
                        }
                        actual = actual.Siguiente;
                    } while (actual != Datos.ListaTrenes.GetPrimerNodo());
                }
            }

            if (trenEncontrado != null)
            {
                // *** ESTA LÍNEA ES FUNDAMENTAL PARA QUE FUNCIONE LA ELIMINACIÓN ***
                this.trenEncontradoParaEliminar = trenEncontrado; // ¡Guardar el tren encontrado!
                                                                  // *** ---------------------------------------------------------- ***

                richTextBox1.Text = "Tren Encontrado:\r\n" +
                                   "------------------------\r\n" +
                                   $"Nombre: {trenEncontrado.Nombre}\r\n" +
                                   $"ID: {trenEncontrado.Id}\r\n" +
                                   $"Tipo: {trenEncontrado.Tipo}\r\n" +
                                   $"Capacidad Vagones: {trenEncontrado.CapacidadVagones}\r\n" +
                                   $"Kilometraje: {trenEncontrado.Kilometraje}";

                textBox1.Text = trenEncontrado.Nombre;
                textBox2.Text = trenEncontrado.Id;
            }
            else
            {
                this.trenEncontradoParaEliminar = null; // Asegurarse de que esté a null si no se encontró
                string criterio = "";
                if (!string.IsNullOrWhiteSpace(idBuscar)) criterio += $"ID: {idBuscar}";
                if (!string.IsNullOrWhiteSpace(nombreBuscar))
                {
                    if (!string.IsNullOrWhiteSpace(criterio)) criterio += " y ";
                    criterio += $"Nombre: {nombreBuscar}";
                }
                if (string.IsNullOrWhiteSpace(criterio)) criterio = "criterio no especificado";

                richTextBox1.Text = $"No se encontró ningún tren con el criterio: {criterio}";
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}