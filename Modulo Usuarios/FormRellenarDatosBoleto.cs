using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_TRENES.Modulo_Usuarios
{
    public partial class FormRellenarDatosBoleto : Form
    {
        // Variables para almacenar los datos del boleto
        private string nombrePasajero;
        private string apellidoPasajero;
        private string tipoIdentificacion;
        private string numeroIdentificacion;
        private string telefonoPasajero;
        private string direccionPasajero;
        private string tipoBoleto;
        private string cantidadMaletas;
        private string pesoEquipaje;
        private string nombreContacto;
        private string apellidoContacto;
        private string telefonoContacto;

        public FormRellenarDatosBoleto()
        {
            InitializeComponent();
        }

        private void FormRellenarDatosBoleto_Load(object sender, EventArgs e)
        {
            // Configuración de comboBoxTipoIdentificacion
            comboBoxTipoIdentificacion.DropDownStyle = ComboBoxStyle.DropDownList; // Bloquea la edición del texto
            comboBoxTipoIdentificacion.Items.Add("Tarjeta de identidad");
            comboBoxTipoIdentificacion.Items.Add("Cedula de ciudadanía");
            comboBoxTipoIdentificacion.SelectedIndex = -1; // Ningún elemento seleccionado por defecto

            // Configuración de comboBoxCantidadMaletas
            comboBoxCantidadMaletas.DropDownStyle = ComboBoxStyle.DropDownList; // Bloquea la edición del texto
            comboBoxCantidadMaletas.Items.Add("0 maletas");
            comboBoxCantidadMaletas.Items.Add("1 maleta");
            comboBoxCantidadMaletas.Items.Add("2 maletas");
            comboBoxCantidadMaletas.SelectedIndex = -1; // Ningún elemento seleccionado por defecto

            // Configuración de comboBoxTipoBoleto
            comboBoxTipoBoleto.DropDownStyle = ComboBoxStyle.DropDownList; // Bloquea la edición del texto
            comboBoxTipoBoleto.Items.Add("Estandar");
            comboBoxTipoBoleto.Items.Add("Ejecutivo");
            comboBoxTipoBoleto.Items.Add("Premium");
            comboBoxTipoBoleto.SelectedIndex = -1; // Ningún elemento seleccionado por defecto
        }

        private void textTelefonoContacto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textApellidoPasajero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombrePasajero_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumeroTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textNumeroIdentificacionPasajero_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombreContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textApellidoContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCantidadMaletas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCantidadMaletas.SelectedItem?.ToString() == "0 maletas")
            {
                textBoxPesoEquipaje.Enabled = false;
                textBoxPesoEquipaje.Text = "";
            }
            else
            {
                textBoxPesoEquipaje.Enabled = true;
            }
        }

        private void comboBoxTipoBoleto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumeroPersonaContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void buttonSiguente_Click(object sender, EventArgs e)
        {
            nombrePasajero = textBoxNombrePasajero.Text;
            apellidoPasajero = textBoxApellidoPasajero.Text;
            tipoIdentificacion = comboBoxTipoIdentificacion.SelectedItem?.ToString();
            numeroIdentificacion = textNumeroIdentificacionPasajero.Text;
            telefonoPasajero = textBoxNumeroTelefono.Text;
            tipoBoleto = comboBoxTipoBoleto.SelectedItem?.ToString();
            cantidadMaletas = comboBoxCantidadMaletas.SelectedItem?.ToString();
            pesoEquipaje = textBoxPesoEquipaje.Text;
            nombreContacto = textNombreContacto.Text;
            apellidoContacto = textApellidoContacto.Text;
            telefonoContacto = textBoxNumeroPersonaContacto.Text;

            MessageBox.Show("Datos almacenados correctamente. Procediendo al siguiente paso.",
                            "Confirmación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            FormResumenBoleto formResumenBoleto = new FormResumenBoleto(
                nombrePasajero,
                apellidoPasajero,
                tipoIdentificacion,
                numeroIdentificacion,
                telefonoPasajero,
                tipoBoleto,
                cantidadMaletas,
                pesoEquipaje,
                nombreContacto,
                apellidoContacto,
                telefonoContacto);
            formResumenBoleto.Show();
            this.Hide();
        }

        private void textBoxPesoEquipaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            FormSeleccionarRuta formSeleccionarRuta = new FormSeleccionarRuta();
            formSeleccionarRuta.Show();
            this.Close();
        }
    }
}
