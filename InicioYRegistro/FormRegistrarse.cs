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

namespace PROYECTO_TRENES.InicioYRegistro
{
    public partial class FormRegistrarse : Form
    {
        private SistemaAutenticacion sistemaAutenticacion;

        public FormRegistrarse()
        {
            InitializeComponent();
            sistemaAutenticacion = new SistemaAutenticacion(Datos.TablaUsuarios);
        }

        private void FormRegistrarse_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxCorreoRegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContraseñaRegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBoxCorreoRegistro.Text; 
            string contrasenia = textBoxContraseñaRegistro.Text;
            string rol = "Pasajero";

            bool registroExitoso = sistemaAutenticacion.RegistrarUsuario(nombreUsuario, contrasenia, rol);

            if (registroExitoso)
            {
                MessageBox.Show("Usuario registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxCorreoRegistro.Text = "";
                textBoxContraseñaRegistro.Text = "";

                FormInicioSesion formInicioSesion = new FormInicioSesion();
                formInicioSesion.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al registrar usuario. El nombre de usuario ya existe o los datos son inválidos.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LinkLabelSiTengoCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormInicioSesion formInicioSesion = new FormInicioSesion();
            formInicioSesion.Show();
            this.Hide();
        }
    }
}
