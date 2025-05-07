using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_TRENES.Modulo_Usuarios;

namespace PROYECTO_TRENES
{
    public partial class FormResumenBoleto : Form
    {
        private string nombrePasajero;
        private string apellidoPasajero;
        private string tipoIdentificacion;
        private string numeroIdentificacion;
        private string telefonoPasajero;
        private string tipoBoleto;
        private string cantidadMaletas;
        private string pesoEquipaje;
        private string nombreContacto;
        private string apellidoContacto;
        private string telefonoContacto;

        public FormResumenBoleto(
            string nombrePasajero,
            string apellidoPasajero,
            string tipoIdentificacion,
            string numeroIdentificacion,
            string telefonoPasajero,
            string tipoBoleto,
            string cantidadMaletas,
            string pesoEquipaje,
            string nombreContacto,
            string apellidoContacto,
            string telefonoContacto)
        {
            InitializeComponent();
            this.nombrePasajero = nombrePasajero;
            this.apellidoPasajero = apellidoPasajero;
            this.tipoIdentificacion = tipoIdentificacion;
            this.numeroIdentificacion = numeroIdentificacion;
            this.telefonoPasajero = telefonoPasajero;
            this.tipoBoleto = tipoBoleto;
            this.cantidadMaletas = cantidadMaletas;
            this.pesoEquipaje = pesoEquipaje;
            this.nombreContacto = nombreContacto;
            this.apellidoContacto = apellidoContacto;
            this.telefonoContacto = telefonoContacto;
            textBoxNombre.Text = nombrePasajero;
            textBoxApellido.Text = apellidoPasajero;
            textBoxTipoIdentificacion.Text = tipoIdentificacion;
            textBoxIdentificación.Text = numeroIdentificacion;
            textBoxNumeroTelefono.Text = telefonoPasajero;
            textBoxNombreContacto.Text = nombreContacto;
            textBoxApellidoContacto.Text = apellidoContacto;
            textBoxNumeroContacto.Text = telefonoContacto;
        }

        private void FormResumenBoleto_Load(object sender, EventArgs e)
        {
            // Display the data in the appropriate controls
            textBoxNombre.Text = nombrePasajero;
            textBoxApellido.Text = apellidoPasajero;
            textBoxTipoIdentificacion.Text = tipoIdentificacion;
            textBoxIdentificación.Text = numeroIdentificacion;
            textBoxNumeroTelefono.Text = telefonoPasajero;
            textBoxTipoBoleto.Text = tipoBoleto;
            textBoxCantidadMaletas.Text = cantidadMaletas;
            textBoxPesoTotalEquipaje.Text = pesoEquipaje;
            textBoxNombreContacto.Text = nombreContacto;
            textBoxApellidoContacto.Text = apellidoContacto;
            textBoxNumeroContacto.Text = telefonoContacto;
        }

        public FormResumenBoleto()
        {
            InitializeComponent();
        }

        private void buttonCambiarDatos_Click(object sender, EventArgs e)
        {
            FormRellenarDatosBoleto formRellenarDatosBoleto = new FormRellenarDatosBoleto();
            formRellenarDatosBoleto.Show();
            this.Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTipoIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdentificación_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumeroTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApellidoContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumeroContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIDTren_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrecioBoleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIDTipoBoleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEstacionOrigen_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void textBoxEstacionDestino_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void textBoxFechaHoraSalida_TextChanged(object sender, EventArgs e)
        {
            //
        }
        private void textBoxFechaHoraLlegada_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void textBoxCantidadMaletas_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPesoTotalEquipaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIDEquipaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIDVagonDeCarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFechaHoraCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIDBoleto_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
