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
    public partial class modificartrenForm1 : Form
    {
        private Tren trenEncontradoParaModificar;

        public modificartrenForm1()
        {
            InitializeComponent();
            this.trenEncontradoParaModificar = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm1 menuPrincipalForm1 = new MenuPrincipalForm1();
            menuPrincipalForm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idBuscar = textBox2.Text.Trim();
            string nombreBuscar = textBox1.Text.Trim();

            richTextBox1.Text = "";
            this.trenEncontradoParaModificar = null;

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
                this.trenEncontradoParaModificar = trenEncontrado;

                richTextBox1.Text = "Tren Encontrado para Modificar:\r\n" +
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
                this.trenEncontradoParaModificar = null;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.trenEncontradoParaModificar != null)
            {
                confirmarmodificaciontrenForm1 confirmarmodificaciontren = new confirmarmodificaciontrenForm1();
                confirmarmodificaciontren.TrenAModificar = this.trenEncontradoParaModificar;
                confirmarmodificaciontren.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, busque y encuentre un tren antes de ir a modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void modificartrenForm1_Load(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void modificartrenForm1_Load_1(object sender, EventArgs e) { }
    }
}