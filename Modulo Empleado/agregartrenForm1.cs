using PROYECTO_TRENES.Códigos;
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
    public partial class agregartrenForm1 : Form
    {
        public agregartrenForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm1 menuPrincipalForm1 = new MenuPrincipalForm1();
            menuPrincipalForm1.Show();
            this.Hide();
        }

        private void agregartrenForm1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Arnold");
            comboBox1.Items.Add("MercedesBenz");
            comboBox1.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string id = textBox2.Text;
            string capacidadStr = textBox3.Text;
            string kilometrajeStr = textBox4.Text;
            string tipoTren = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(capacidadStr) || string.IsNullOrWhiteSpace(kilometrajeStr) ||
                string.IsNullOrWhiteSpace(tipoTren))
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione el tipo de tren.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(capacidadStr, out int capacidad) || capacidad < 1)
            {
                MessageBox.Show("Capacidad de vagones debe ser un número entero positivo (al menos 1).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(kilometrajeStr, out int kilometraje) || kilometraje < 0)
            {
                MessageBox.Show("Kilometraje debe ser un número entero no negativo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool capacidadValidaParaTipo = true;
            int maxCapacidad = 0;

            if (tipoTren == "Arnold")
            {
                maxCapacidad = 32;
                if (capacidad > maxCapacidad) capacidadValidaParaTipo = false;
            }
            else if (tipoTren == "MercedesBenz")
            {
                maxCapacidad = 28;
                if (capacidad > maxCapacidad) capacidadValidaParaTipo = false;
            }

            if (!capacidadValidaParaTipo)
            {
                MessageBox.Show($"La capacidad de vagones ({capacidad}) excede el máximo permitido para un Tren {tipoTren} ({maxCapacidad}).", "Validación de Capacidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tren trenExistente = Datos.ListaTrenes.Buscar(new Tren(nombre, id, tipoTren, capacidad, kilometraje));

            if (trenExistente != default(Tren))
            {
                MessageBox.Show($"Ya existe un tren con el ID: {id}.", "Validación de ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tren nuevoTren = new Tren(nombre, id, tipoTren, capacidad, kilometraje);

            Datos.ListaTrenes.Agregar(nuevoTren);

            MessageBox.Show("Tren agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
