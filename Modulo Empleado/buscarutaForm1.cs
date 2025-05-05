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
    public partial class buscarutaForm1 : Form
    {
        public buscarutaForm1()
        {
            InitializeComponent();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idBuscar = textBox2.Text.Trim();

            richTextBox1.Text = "";

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
                richTextBox1.Text = "Ruta Encontrada:\r\n" +
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
                richTextBox1.Text = $"No se encontró ninguna ruta con el ID: {idBuscar}";
            }
        }
    }
}
