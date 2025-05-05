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
    public partial class agregarvagonForm1 : Form
    {
        public agregarvagonForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm1 menuPrincipalForm1 = new MenuPrincipalForm1();
            menuPrincipalForm1.Show();
            this.Hide();
        }

        private void agregarvagonForm1_Load(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();

            Nodo<Tren> actualTren = Datos.ListaTrenes.GetPrimerNodo();
            if (actualTren != null)
            {
                do
                {
                    comboBox3.Items.Add(actualTren.Valor.Id);
                    actualTren = actualTren.Siguiente;
                } while (actualTren != Datos.ListaTrenes.GetPrimerNodo());
            }

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Vagon de carga");
            comboBox1.Items.Add("Vagon de pasajeros");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idVagon = textBoxVagonId.Text.Trim();
            string tipoVagon = comboBox1.SelectedItem?.ToString();
            string idTrenAsociado = comboBox3.SelectedItem?.ToString();
            string capacidadTexto = textBoxCapacidad.Text.Trim();

            if (string.IsNullOrWhiteSpace(idVagon) ||
                string.IsNullOrWhiteSpace(tipoVagon) ||
                string.IsNullOrWhiteSpace(idTrenAsociado) ||
                string.IsNullOrWhiteSpace(capacidadTexto))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(capacidadTexto, out int capacidadVagon) || capacidadVagon <= 0)
            {
                MessageBox.Show("Por favor, ingrese una capacidad válida para el vagón.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tren trenEncontrado = null;
            Nodo<Tren> actualTren = Datos.ListaTrenes.GetPrimerNodo();
            if (actualTren != null)
            {
                do
                {
                    if (actualTren.Valor.Id == idTrenAsociado)
                    {
                        trenEncontrado = actualTren.Valor;
                        break;
                    }
                    actualTren = actualTren.Siguiente;
                } while (actualTren != Datos.ListaTrenes.GetPrimerNodo());
            }

            if (trenEncontrado == null)
            {
                MessageBox.Show($"No se encontró ningún tren con el ID: {idTrenAsociado}.", "Tren No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool vagonIdYaExisteEnEsteTren = false;
            Nodo<Vagon> actualVagon = trenEncontrado.PilaVagones.GetCima();
            while (actualVagon != null)
            {
                if (actualVagon.Valor.IdVagon == idVagon)
                {
                    vagonIdYaExisteEnEsteTren = true;
                    break;
                }
                actualVagon = actualVagon.Siguiente;
            }

            if (vagonIdYaExisteEnEsteTren)
            {
                MessageBox.Show($"Ya existe un vagón con el ID: {idVagon} en este tren.", "ID de Vagón Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Vagon nuevoVagon = new Vagon(idVagon, tipoVagon, capacidadVagon, idTrenAsociado);

            bool agregadoConExito = trenEncontrado.AgregarVagon(nuevoVagon);

            if (agregadoConExito)
            {
                MessageBox.Show($"Vagón con ID {idVagon} agregado exitosamente al tren {idTrenAsociado}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxVagonId.Text = "";
                comboBox1.SelectedIndex = -1;
                textBoxCapacidad.Text = "";
                comboBox3.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show($"No se pudo agregar el vagón. El tren {idTrenAsociado} ya alcanzó su capacidad máxima de vagones ({trenEncontrado.CapacidadVagones}).", "Fallo al Agregar Vagón", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
