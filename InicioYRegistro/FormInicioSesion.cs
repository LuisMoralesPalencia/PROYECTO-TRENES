using PROYECTO_TRENES.Códigos;
using PROYECTO_TRENES.Modulo_administrador;
using PROYECTO_TRENES.Modulo_Empleado;
using PROYECTO_TRENES.Modulo_Usuarios;
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
    public partial class FormInicioSesion : Form
    {
        private SistemaAutenticacion sistemaAutenticacion;

        public FormInicioSesion()
        {
            InitializeComponent();
            sistemaAutenticacion = new SistemaAutenticacion(Datos.TablaUsuarios);
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBoxUsuario.Text;
            string contrasenia = textBoxContraseña.Text;

            Usuario usuarioAutenticado = sistemaAutenticacion.IniciarSesion(nombreUsuario, contrasenia);

            if (usuarioAutenticado != null)
            {
                string tipoUsuario = "Tipo de Usuario Desconocido"; 

                if (usuarioAutenticado is Administrador)
                {
                    tipoUsuario = "Administrador";
                    MessageBox.Show($"Inicio de sesión exitoso.\nUsuario: {usuarioAutenticado.NombreUsuario}\nTipo: {tipoUsuario}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormMenuAdministrador formAdmin = new FormMenuAdministrador();
                    formAdmin.Show();
                    this.Hide();

                }
                else if (usuarioAutenticado is Empleado)
                {
                    tipoUsuario = "Empleado";
                    MessageBox.Show($"Inicio de sesión exitoso.\nUsuario: {usuarioAutenticado.NombreUsuario}\nTipo: {tipoUsuario}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MenuPrincipalForm1 formempleado = new MenuPrincipalForm1();
                    formempleado.Show();
                    this.Hide();
                }
                else if (usuarioAutenticado is Pasajero)
                {
                    tipoUsuario = "Pasajero";
                    MessageBox.Show($"Inicio de sesión exitoso.\nUsuario: {usuarioAutenticado.NombreUsuario}\nTipo: {tipoUsuario}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormMenuUsuario formUsuario = new FormMenuUsuario();
                    formUsuario.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Inicio de sesión exitoso.\nUsuario: {usuarioAutenticado.NombreUsuario}\nTipo: {tipoUsuario}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide(); 
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistrarse formRegistrarse = new FormRegistrarse();
            formRegistrarse.Show();
            this.Hide();
        }
    }
}