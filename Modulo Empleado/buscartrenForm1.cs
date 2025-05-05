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
    public partial class buscartrenForm1 : Form
    {
        public buscartrenForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm1 menuPrincipalForm1 = new MenuPrincipalForm1();
            menuPrincipalForm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idBuscar = textBox2.Text;
            string nombreBuscar = textBox1.Text;

            richTextBox1.Text = "";

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
                string criterio = "";
                if (!string.IsNullOrWhiteSpace(idBuscar)) criterio += $"ID: {idBuscar}";
                if (!string.IsNullOrWhiteSpace(nombreBuscar))
                {
                    if (!string.IsNullOrWhiteSpace(criterio)) criterio += " y ";
                    criterio += $"Nombre: {nombreBuscar}";
                }
                if (string.IsNullOrWhiteSpace(criterio)) criterio = "criterio no especificado"; // Manejar caso ambos vacios, aunque validacion ya lo hace

                richTextBox1.Text = $"No se encontró ningún tren con el criterio: {criterio}";
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
