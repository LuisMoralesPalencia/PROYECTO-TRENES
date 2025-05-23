﻿using PROYECTO_TRENES.Códigos;
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
    public partial class FormEliminarUsuario : Form
    {
        public FormEliminarUsuario()
        {
            InitializeComponent();
        }

        private void FormEliminarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUsuariosEnComboBox();

                if (this.Controls.Find("textBoxTipoDeUsuario", true).FirstOrDefault() is TextBox txtTipo)
                {
                    txtTipo.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Advertencia: No se encontró el control textBoxTipoDeUsuario para hacerlo de solo lectura.", "Control No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (this.Controls.Find("textBox1", true).FirstOrDefault() is TextBox txtIdentificacion)
                {
                    txtIdentificacion.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Advertencia: No se encontró el control textBox1 para hacerlo de solo lectura.", "Control No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void textBoxTipoDeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FormMenuAdministrador formMenuAdministrador = new FormMenuAdministrador();
            formMenuAdministrador.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Controls.Find("comboBox1", true).FirstOrDefault() is ComboBox cbUsuarios)
                {
                    if (this.Controls.Find("textBoxTipoDeUsuario", true).FirstOrDefault() is TextBox txtTipo)
                    {
                        if (this.Controls.Find("textBox1", true).FirstOrDefault() is TextBox txtIdentificacion)
                        {
                            if (cbUsuarios.SelectedItem is Usuario selectedUser)
                            {
                                txtTipo.Text = selectedUser.GetType().Name;
                                txtIdentificacion.Text = selectedUser.NumeroIdentificacion;
                            }
                            else
                            {
                                txtTipo.Text = "";
                                txtIdentificacion.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error interno: No se encontró el control textBox1 al seleccionar usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error interno: No se encontró el control textBoxTipoDeUsuario al seleccionar usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar la información del usuario seleccionado: " + ex.Message, "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfirmarEliminacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Controls.Find("comboBox1", true).FirstOrDefault() is ComboBox cbUsuarios)
                {
                    if (cbUsuarios.SelectedItem is Usuario usuarioAEliminar)
                    {
                        string nombreUsuarioClave = usuarioAEliminar.NombreUsuario;

                        Datos.TablaUsuarios.EliminarValores(nombreUsuarioClave);

                        MessageBox.Show($"Usuario '{nombreUsuarioClave}' eliminado exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarUsuariosEnComboBox();
                        if (this.Controls.Find("textBoxTipoDeUsuario", true).FirstOrDefault() is TextBox txtTipo) txtTipo.Text = "";
                        if (this.Controls.Find("textBox1", true).FirstOrDefault() is TextBox txtIdentificacion) txtIdentificacion.Text = "";

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
    }
}