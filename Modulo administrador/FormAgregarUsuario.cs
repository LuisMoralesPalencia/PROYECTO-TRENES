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
    public partial class FormAgregarUsuario : Form
    {
        public FormAgregarUsuario()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAgregarUsuario_Load(object sender, EventArgs e)
        {
            if (this.Controls.Find("comboBoxTipoIdentificacionEmpleado", true).FirstOrDefault() is ComboBox cbTipoIdentificacion)
            {
                cbTipoIdentificacion.Items.Clear();
                cbTipoIdentificacion.Items.Add("Cédula de Ciudadanía");
                cbTipoIdentificacion.Items.Add("Tarjeta de Identidad");
                cbTipoIdentificacion.Items.Add("Cédula de Extranjería");
                cbTipoIdentificacion.Items.Add("Pasaporte");
                cbTipoIdentificacion.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Error interno: No se encontró el control comboBoxTipoIdentificacionEmpleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (this.Controls.Find("textBoxIDEmpleado", true).FirstOrDefault() is TextBox txtIdEmpleado)
            {
                txtIdEmpleado.ReadOnly = true;
                txtIdEmpleado.Text = "ID se generará automáticamente";
            }
            else if (this.Controls.Find("labelIDEmpleado", true).FirstOrDefault() is Label lblIdEmpleado)
            {
                lblIdEmpleado.Text = "ID se generará automáticamente";
            }
        }

        private void textBoxNombreUsuario_TextChanged(object sender, EventArgs e) { }
        private void textBoxApellidoEmpleado_TextChanged(object sender, EventArgs e) { }
        private void comboBoxTipoIdentificacionEmpleado_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtNumeroIdentificacionEmpleado_TextChanged(object sender, EventArgs e) { }
        private void textBoxNumeroTelefonoEmpleado_TextChanged(object sender, EventArgs e) { }
        private void textBoxIDEmpleado_TextChanged(object sender, EventArgs e) { }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            FormMenuAdministrador formMenuAdministrador = new FormMenuAdministrador();
            formMenuAdministrador.Show();
            this.Hide();
        }

        private void buttonAgregarEmpleado_Click(object sender, EventArgs e)
        {
            string nombre = "";
            string apellido = "";
            string tipoIdentificacion = "";
            string numeroIdentificacion = "";
            string numeroTelefono = "";

            try
            {
                TextBox txtNombre = this.Controls.Find("textBoxNombreUsuario", true).FirstOrDefault() as TextBox;
                if (txtNombre != null) nombre = txtNombre.Text.Trim(); else { MessageBox.Show("Error interno: No se encontró el control textBoxNombreUsuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                TextBox txtApellido = this.Controls.Find("textBoxApellidoEmpleado", true).FirstOrDefault() as TextBox;
                if (txtApellido != null) apellido = txtApellido.Text.Trim(); else { MessageBox.Show("Error interno: No se encontró el control textBoxApellidoEmpleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                ComboBox cbTipoIdentificacion = this.Controls.Find("comboBoxTipoIdentificacionEmpleado", true).FirstOrDefault() as ComboBox;
                if (cbTipoIdentificacion != null) tipoIdentificacion = cbTipoIdentificacion.SelectedItem?.ToString() ?? ""; else { MessageBox.Show("Error interno: No se encontró el control comboBoxTipoIdentificacionEmpleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                TextBox txtNumeroIdentificacion = this.Controls.Find("txtNumeroIdentificacionEmpleado", true).FirstOrDefault() as TextBox;
                if (txtNumeroIdentificacion != null) numeroIdentificacion = txtNumeroIdentificacion.Text.Trim(); else { MessageBox.Show("Error interno: No se encontró el control txtNumeroIdentificacionEmpleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                TextBox txtNumeroTelefono = this.Controls.Find("textBoxNumeroTelefonoEmpleado", true).FirstOrDefault() as TextBox;
                if (txtNumeroTelefono != null) numeroTelefono = txtNumeroTelefono.Text.Trim(); else { MessageBox.Show("Error interno: No se encontró el control textBoxNumeroTelefonoEmpleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos de los campos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(tipoIdentificacion) ||
                string.IsNullOrWhiteSpace(numeroIdentificacion) ||
                string.IsNullOrWhiteSpace(numeroTelefono))
            {
                MessageBox.Show("Por favor, complete todos los campos del empleado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idEmpleadoGenerado = Guid.NewGuid().ToString();
            string nombreUsuarioGenerado = "emp_" + idEmpleadoGenerado.Substring(0, 8);
            string contraseniaPorDefecto = "empleado123";

            if (Datos.TablaUsuarios.ContieneClave(nombreUsuarioGenerado))
            {
                MessageBox.Show("Error interno: El nombre de usuario generado ya existe. Intente de nuevo.", "Error de Generación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Empleado nuevoEmpleado = new Empleado(
                nombreUsuarioGenerado,
                nombre,
                apellido,
                tipoIdentificacion,
                numeroIdentificacion,
                numeroTelefono,
                contraseniaPorDefecto
            );
            nuevoEmpleado.IdUsuario = idEmpleadoGenerado;

            Datos.TablaUsuarios.InsertarValores(nombreUsuarioGenerado, nuevoEmpleado);

            MessageBox.Show($"Empleado agregado exitosamente.\nID Empleado: {idEmpleadoGenerado}\nUsuario para login: {nombreUsuarioGenerado}\nContraseña por defecto: {contraseniaPorDefecto}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (this.Controls.Find("textBoxIDEmpleado", true).FirstOrDefault() is TextBox txtIdEmpleadoOutput)
            {
                txtIdEmpleadoOutput.Text = idEmpleadoGenerado;
            }
            else if (this.Controls.Find("labelIDEmpleado", true).FirstOrDefault() is Label lblIdEmpleadoOutput)
            {
                lblIdEmpleadoOutput.Text = idEmpleadoGenerado;
            }

            try
            {
                if (this.Controls.Find("textBoxNombreUsuario", true).FirstOrDefault() is TextBox txtNombreLimpiar) txtNombreLimpiar.Text = "";
                if (this.Controls.Find("textBoxApellidoEmpleado", true).FirstOrDefault() is TextBox txtApellidoLimpiar) txtApellidoLimpiar.Text = "";
                if (this.Controls.Find("comboBoxTipoIdentificacionEmpleado", true).FirstOrDefault() is ComboBox cbTipoIdentificacionLimpiar) cbTipoIdentificacionLimpiar.SelectedIndex = -1;
                if (this.Controls.Find("txtNumeroIdentificacionEmpleado", true).FirstOrDefault() is TextBox txtNumeroIdentificacionLimpiar) txtNumeroIdentificacionLimpiar.Text = "";
                if (this.Controls.Find("textBoxNumeroTelefonoEmpleado", true).FirstOrDefault() is TextBox txtNumeroTelefonoLimpiar) txtNumeroTelefonoLimpiar.Text = "";
            }
            catch { }
        }
    }
}