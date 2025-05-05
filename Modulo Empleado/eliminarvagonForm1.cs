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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_TRENES.Modulo_Empleado
{
    public partial class eliminarvagonForm1 : Form
    {
        private Vagon vagonEncontradoParaEliminar;
        private Tren trenDelVagonEncontrado;

        public eliminarvagonForm1()
        {
            InitializeComponent();
            this.vagonEncontradoParaEliminar = null;
            this.trenDelVagonEncontrado = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm1 menuPrincipalForm1 = new MenuPrincipalForm1();
            menuPrincipalForm1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idBuscar = textBox2.Text.Trim();

            richTextBox1.Text = "";
            this.vagonEncontradoParaEliminar = null;
            this.trenDelVagonEncontrado = null;

            if (string.IsNullOrWhiteSpace(idBuscar))
            {
                MessageBox.Show("Por favor, ingrese el ID del vagón a buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Vagon vagonEncontrado = null;
            Tren trenDelVagon = null;

            Nodo<Tren> actualTren = Datos.ListaTrenes.GetPrimerNodo();
            if (actualTren != null)
            {
                bool encontrado = false;
                do
                {
                    Nodo<Vagon> actualVagon = actualTren.Valor.PilaVagones.GetCima();
                    while (actualVagon != null)
                    {
                        if (actualVagon.Valor.IdVagon == idBuscar)
                        {
                            vagonEncontrado = actualVagon.Valor;
                            trenDelVagon = actualTren.Valor;
                            encontrado = true;
                            break;
                        }
                        actualVagon = actualVagon.Siguiente;
                    }

                    if (encontrado)
                    {
                        break;
                    }

                    actualTren = actualTren.Siguiente;
                } while (actualTren != Datos.ListaTrenes.GetPrimerNodo());
            }

            if (vagonEncontrado != null)
            {
                this.vagonEncontradoParaEliminar = vagonEncontrado;
                this.trenDelVagonEncontrado = trenDelVagon;

                richTextBox1.Text = "Vagón Encontrado para Eliminar:\r\n" +
                                     "------------------------\r\n" +
                                     $"ID Vagón: {vagonEncontrado.IdVagon}\r\n" +
                                     $"Tipo: {vagonEncontrado.Tipo}\r\n" +
                                     $"Capacidad Máxima: {vagonEncontrado.CapacidadMaxima}\r\n" +
                                     $"Pertenece al Tren (ID): {trenDelVagon?.Id ?? "N/A"}";

            }
            else
            {
                this.vagonEncontradoParaEliminar = null;
                this.trenDelVagonEncontrado = null;
                richTextBox1.Text = $"No se encontró ningún vagón con el ID: {idBuscar}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.vagonEncontradoParaEliminar == null || this.trenDelVagonEncontrado == null)
            {
                MessageBox.Show("Busque un vagón primero usando el botón 'Buscar'.", "Eliminar Vagón", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show($"¿Está seguro de eliminar el vagón con ID {this.vagonEncontradoParaEliminar.IdVagon} del tren {this.trenDelVagonEncontrado.Id}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                Pila<Vagon> pilaOriginal = this.trenDelVagonEncontrado.PilaVagones;
                Pila<Vagon> pilaTemporal = new Pila<Vagon>();
                bool eliminado = false;

                while (!pilaOriginal.EstaVacia)
                {
                    Vagon vagonActual = pilaOriginal.Pop();
                    if (vagonActual.IdVagon == this.vagonEncontradoParaEliminar.IdVagon)
                    {
                        eliminado = true;
                        break;
                    }
                    pilaTemporal.Push(vagonActual);
                }

                if (!pilaOriginal.EstaVacia && !eliminado)
                {
                    Vagon vagonCima = pilaOriginal.Pop();
                    pilaTemporal.Push(vagonCima);
                }


                while (!pilaTemporal.EstaVacia)
                {
                    pilaOriginal.Push(pilaTemporal.Pop());
                }

                if (eliminado)
                {
                    MessageBox.Show($"Vagón con ID {this.vagonEncontradoParaEliminar.IdVagon} eliminado exitosamente del tren {this.trenDelVagonEncontrado.Id}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox2.Text = "";
                    richTextBox1.Text = "";
                    this.vagonEncontradoParaEliminar = null;
                    this.trenDelVagonEncontrado = null;
                }
                else
                {
                    MessageBox.Show($"Error inesperado al intentar eliminar el vagón con ID {this.vagonEncontradoParaEliminar.IdVagon}.", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Text = "";
                    richTextBox1.Text = "";
                    this.vagonEncontradoParaEliminar = null;
                    this.trenDelVagonEncontrado = null;
                }
            }
        }
    }
}