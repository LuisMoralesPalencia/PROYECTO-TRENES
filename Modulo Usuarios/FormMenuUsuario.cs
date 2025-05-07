using PROYECTO_TRENES.InicioYRegistro;
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
    public partial class FormMenuUsuario : Form
    {
        public FormMenuUsuario()
        {
            InitializeComponent();
        }

        private void FormMenuUsuario_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonComprarBoletos_Click(object sender, EventArgs e)
        {
            FormSeleccionarRuta formSeleccionarRuta = new FormSeleccionarRuta();
            formSeleccionarRuta.Show();
            this.Hide();
        }

        private void buttonMirarBoletosComprados_Click(object sender, EventArgs e)
        {

        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            FormInicioSesion formInicioSesion = new FormInicioSesion();
            formInicioSesion.Show();
            this.Hide();
        }
    }
}
