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
    public partial class FormEliminar : Form
    {
        public FormEliminar()
        {
            InitializeComponent();
        }

        private void FormEliminar_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUsuariosEnComboBox();

                if (this.Controls.Find("textBox1", true).FirstOrDefault() is TextBox txtIdentificacion)
                {
                    txtIdentificacion.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Advertencia: No se encontró el control textBox1 para hacerlo de solo lectura.", "Control No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // *** LÍNEA A CORREGIR #1 ***
                if (this.Controls.Find("textBoxTipoDeUsuario", true).FirstOrDefault() is TextBox txtTipo) // <-- Cambiar "textBoxTipoDeUsuario" a "textBox2"
                {
                    txtTipo.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Advertencia: No se encontró el control textBox2 para hacerlo de solo lectura.", "Control No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado durante la carga del formulario: " + ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarUsuariosEnComboBox()
        {
            try
            {
                if (this.Controls.Find("comboBox1", true).FirstOrDefault() is ComboBox cbUsuarios)
                {
                    cbUsuarios.Items.Clear();

                    List<Usuario> listaUsuarios = Datos.TablaUsuarios.ObtenerValores();

                    foreach (Usuario user in listaUsuarios)
                    {
                        cbUsuarios.Items.Add(user);
                    }

                    cbUsuarios.DisplayMember = "NombreUsuario";

                    cbUsuarios.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Error interno CRÍTICO: No se encontró el control comboBox1 en el formulario. No se pueden cargar los usuarios.", "Control No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los usuarios en la lista: " + ex.Message, "Error de Carga de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenuAdministrador formMenuAdministrador = new FormMenuAdministrador();
            formMenuAdministrador.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Controls.Find("comboBox1", true).FirstOrDefault() is ComboBox cbUsuarios)
                {
                    if (this.Controls.Find("textBox1", true).FirstOrDefault() is TextBox txtIdentificacion)
                    {
                        // *** LÍNEA A CORREGIR #2 ***
                        if (this.Controls.Find("textBoxTipoDeUsuario", true).FirstOrDefault() is TextBox txtTipo) // <-- Cambiar "textBoxTipoDeUsuario" a "textBox2"
                        {
                            if (cbUsuarios.SelectedItem is Usuario selectedUser)
                            {
                                txtIdentificacion.Text = selectedUser.NumeroIdentificacion;
                                txtTipo.Text = selectedUser.GetType().Name;
                            }
                            else
                            {
                                txtIdentificacion.Text = "";
                                txtTipo.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error interno: No se encontró el control textBox2 al seleccionar usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error interno: No se encontró el control textBox1 al seleccionar usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar la información del usuario seleccionado: " + ex.Message, "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Este es el boton Confirmar Eliminacion
        {
            try
            {
                if (this.Controls.Find("comboBox1", true).FirstOrDefault() is ComboBox cbUsuarios)
                {
                    if (cbUsuarios.SelectedItem is Usuario usuarioAEliminar)
                    {
                        string nombreUsuarioClave = usuarioAEliminar.NombreUsuario;

                        DialogResult result = MessageBox.Show($"¿Está seguro de que desea eliminar al usuario '{nombreUsuarioClave}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Datos.TablaUsuarios.EliminarValores(nombreUsuarioClave);

                            MessageBox.Show($"Usuario '{nombreUsuarioClave}' eliminado exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CargarUsuariosEnComboBox();
                            if (this.Controls.Find("textBox1", true).FirstOrDefault() is TextBox txtIdentificacion) txtIdentificacion.Text = "";
                            // CORREGIDO: Limpiar "textBox2" en lugar de "textBoxTipoDeUsuario"
                            if (this.Controls.Find("textBox2", true).FirstOrDefault() is TextBox txtTipo) txtTipo.Text = ""; // <-- Cambiar "textBoxTipoDeUsuario" a "textBox2"
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione un usuario para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar al usuario: " + ex.Message, "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}