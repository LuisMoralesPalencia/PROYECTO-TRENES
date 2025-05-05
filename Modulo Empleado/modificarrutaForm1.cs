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
    public partial class modificarrutaForm1 : Form
    {
        private Ruta rutaEncontradaParaModificar;

        public modificarrutaForm1()
        {
            InitializeComponent();
            this.rutaEncontradaParaModificar = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm1 menuPrincipalForm1 = new MenuPrincipalForm1();
            menuPrincipalForm1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idBuscar = textBox2.Text.Trim();

            richTextBox1.Text = "";
            this.rutaEncontradaParaModificar = null;

            if (string.IsNullOrWhiteSpace(idBuscar))
            {
                MessageBox.Show("Por favor, ingrese el ID de la ruta a buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Ruta rutaEncontrada = null;
            Nodo<Ruta> actualRuta = Datos.ListaRutas.GetCabeza();

            while (actualRuta != null)
            {
                if (actualRuta.Valor.IdRuta == idBuscar)
                {
                    rutaEncontrada = actualRuta.Valor;
                    break;
                }
                actualRuta = actualRuta.Siguiente;
            }

            if (rutaEncontrada != null)
            {
                this.rutaEncontradaParaModificar = rutaEncontrada;

                richTextBox1.Text = "Ruta Encontrada para Modificar:\r\n" +
                                   "------------------------\r\n" +
                                   $"ID Ruta: {rutaEncontrada.IdRuta}\r\n" +
                                   $"Origen: {rutaEncontrada.Origen}\r\n" +
                                   $"Destino: {rutaEncontrada.Destino}\r\n" +
                                   $"Fecha Salida: {rutaEncontrada.FechaSalida}\r\n" +
                                   $"Fecha Llegada: {rutaEncontrada.FechaLlegada}\r\n" +
                                   $"Tren Asociado (ID): {rutaEncontrada.Tren?.Id ?? "N/A"}";

            }
            else
            {
                this.rutaEncontradaParaModificar = null;
                richTextBox1.Text = $"No se encontró ninguna ruta con el ID: {idBuscar}";
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.rutaEncontradaParaModificar != null)
            {
                confirmarmodificarrutaForm1 confirmarmodificarrutaForm1 = new confirmarmodificarrutaForm1();

                confirmarmodificarrutaForm1.RutaAModificar = this.rutaEncontradaParaModificar;

                confirmarmodificarrutaForm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, busque y encuentre una ruta antes de ir a modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}