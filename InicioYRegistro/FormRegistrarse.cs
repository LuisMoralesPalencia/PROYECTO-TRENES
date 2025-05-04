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
        public FormRegistrarse()
        {
            InitializeComponent();
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

        }

        private void LinkLabelSiTengoCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormInicioSesion formInicioSesion = new FormInicioSesion();
            formInicioSesion.Show();
            this.Hide();
        }
    }
}
