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

namespace PROYECTO_TRENES.Modulo_administrador
{
    public partial class FormMenuAdministrador : Form
    {
        public FormMenuAdministrador()
        {
            InitializeComponent();
        }

        private void FormMenuAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            FormInicioSesion formInicioSesion = new FormInicioSesion();
            formInicioSesion.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAgregarEmpleado_Click(object sender, EventArgs e)
        {
            FormAgregarEmpleado formAgregarEmpleado = new FormAgregarEmpleado();
            formAgregarEmpleado.Show();
            this.Hide();
        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            FormBuscarUsuarios formBuscarUsuarios = new FormBuscarUsuarios();
            formBuscarUsuarios.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEliminarUsuario formEliminarUsuario = new FormEliminarUsuario();
            formEliminarUsuario.Show();
            this.Hide();
        }
    }
}
