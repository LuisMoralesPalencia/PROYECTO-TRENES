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
    public partial class eliminarrutaForm1 : Form
    {
        private Ruta rutaEncontradaParaEliminar;

        public eliminarrutaForm1()
        {
            InitializeComponent();
            this.rutaEncontradaParaEliminar = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm1 menuPrincipalForm1 = new MenuPrincipalForm1();
            menuPrincipalForm1.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) 
        {
            string idBuscar = textBox2.Text.Trim();

            richTextBox1.Text = "";
            this.rutaEncontradaParaEliminar = null;

            if (string.IsNullOrWhiteSpace(idBuscar))
            {
                MessageBox.Show("Por favor, ingrese el ID de la ruta a buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Ruta rutaEncontrada = Datos.RedFerroviaria.BuscarRuta(idBuscar);
            if (rutaEncontrada != null)
            {
                this.rutaEncontradaParaEliminar = rutaEncontrada;

                richTextBox1.Text = "Ruta Encontrada:\r\n" +
                                   "------------------------\r\n" +
                                   $"ID Ruta: {rutaEncontrada.IdRuta}\r\n" +
                                   $"Origen: {rutaEncontrada.Origen}\r\n" +
                                   $"Destino: {rutaEncontrada.Destino}\r\n" +
                                   $"Fecha Salida: {rutaEncontrada.FechaSalida}\r\n" +
                                   $"Fecha Llegada: {rutaEncontrada.FechaLlegada}\r\n" +
                                   $"Distancia: {rutaEncontrada.Distancia} km\r\n" +
                                   $"Tren Asociado (ID): {rutaEncontrada.Tren?.Id ?? "N/A"}\r\n";

            }
            else
            {
                this.rutaEncontradaParaEliminar = null;
                richTextBox1.Text = $"No se encontró ninguna ruta con el ID: {idBuscar}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.rutaEncontradaParaEliminar == null)
            {
                MessageBox.Show("Busque una ruta primero usando el botón 'Buscar'.", "Eliminar Ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show($"¿Está seguro de eliminar la ruta con ID {this.rutaEncontradaParaEliminar.IdRuta}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
               
                bool eliminado = Datos.RedFerroviaria.EliminarRuta(this.rutaEncontradaParaEliminar.IdRuta);
                
                if (eliminado)
                {
                    MessageBox.Show($"Ruta con ID {this.rutaEncontradaParaEliminar.IdRuta} eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Text = "";
                    richTextBox1.Text = "";
                    this.rutaEncontradaParaEliminar = null;
                }
                else
                {
                    MessageBox.Show($"Error inesperado al intentar eliminar la ruta con ID {this.rutaEncontradaParaEliminar.IdRuta}.", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Text = "";
                    richTextBox1.Text = "";
                    this.rutaEncontradaParaEliminar = null;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}