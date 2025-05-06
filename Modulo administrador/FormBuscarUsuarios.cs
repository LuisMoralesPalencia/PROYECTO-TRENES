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

namespace PROYECTO_TRENES.Modulo_administrador
{
    public partial class FormBuscarUsuarios : Form
    {
        public FormBuscarUsuarios()
        {
            InitializeComponent();
        }

        private void FormBuscarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void MostrarTodosLosUsuarios()
        {
            richTextBoxInformacionUsuario.Clear();

            List<Usuario> listaUsuarios = Datos.TablaUsuarios.ObtenerValores();

            if (listaUsuarios != null && listaUsuarios.Count > 0)
            {
                richTextBoxInformacionUsuario.AppendText("Usuarios registrados en el sistema:\n");
                richTextBoxInformacionUsuario.AppendText("-------------------------------------\n");
                foreach (Usuario user in listaUsuarios)
                {
                    richTextBoxInformacionUsuario.AppendText($"{user.ToString()} (Rol: {user.GetType().Name})\n");
                }
            }
            else
            {
                richTextBoxInformacionUsuario.AppendText("No hay usuarios registrados en el sistema en este momento.");
            }
        }


        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            FormMenuAdministrador formMenuAdministrador = new FormMenuAdministrador();
            formMenuAdministrador.Show();
            this.Hide();
        }

        private void textBoxIDUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxInformacionUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonModificarUsuario_Click(object sender, EventArgs e)
        {
            MostrarTodosLosUsuarios();
        }

        private void textBoxTipoDeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}