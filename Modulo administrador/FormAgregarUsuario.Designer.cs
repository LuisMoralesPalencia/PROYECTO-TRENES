namespace PROYECTO_TRENES.Modulo_administrador
{
    partial class FormAgregarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDEmpleado = new System.Windows.Forms.TextBox();
            this.buttonAgregarEmpleado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTipoIdentificacionEmpleado = new System.Windows.Forms.ComboBox();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.textBoxNumeroTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroIdentificacionEmpleado = new System.Windows.Forms.TextBox();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxIDEmpleado);
            this.panel1.Controls.Add(this.buttonAgregarEmpleado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxTipoIdentificacionEmpleado);
            this.panel1.Controls.Add(this.buttonRegresar);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBoxApellidoEmpleado);
            this.panel1.Controls.Add(this.textBoxNumeroTelefonoEmpleado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNumeroIdentificacionEmpleado);
            this.panel1.Controls.Add(this.textBoxNombreUsuario);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(71, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 443);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 30);
            this.label1.TabIndex = 91;
            this.label1.Text = "Este es el ID que identificara al empleado, no le asigne un ID\r\nque ya este vincu" +
    "lado a otro empleado.";
            // 
            // textBoxIDEmpleado
            // 
            this.textBoxIDEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDEmpleado.Location = new System.Drawing.Point(48, 262);
            this.textBoxIDEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIDEmpleado.Name = "textBoxIDEmpleado";
            this.textBoxIDEmpleado.Size = new System.Drawing.Size(161, 21);
            this.textBoxIDEmpleado.TabIndex = 90;
            this.textBoxIDEmpleado.TextChanged += new System.EventHandler(this.textBoxIDEmpleado_TextChanged);
            // 
            // buttonAgregarEmpleado
            // 
            this.buttonAgregarEmpleado.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonAgregarEmpleado.Location = new System.Drawing.Point(48, 312);
            this.buttonAgregarEmpleado.Name = "buttonAgregarEmpleado";
            this.buttonAgregarEmpleado.Size = new System.Drawing.Size(111, 59);
            this.buttonAgregarEmpleado.TabIndex = 89;
            this.buttonAgregarEmpleado.Text = "Agregar al sistema";
            this.buttonAgregarEmpleado.UseVisualStyleBackColor = false;
            this.buttonAgregarEmpleado.Click += new System.EventHandler(this.buttonAgregarEmpleado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "Diligenciar datos del empleado que quiere agregar al sistema";
            // 
            // comboBoxTipoIdentificacionEmpleado
            // 
            this.comboBoxTipoIdentificacionEmpleado.FormattingEnabled = true;
            this.comboBoxTipoIdentificacionEmpleado.Location = new System.Drawing.Point(474, 116);
            this.comboBoxTipoIdentificacionEmpleado.Name = "comboBoxTipoIdentificacionEmpleado";
            this.comboBoxTipoIdentificacionEmpleado.Size = new System.Drawing.Size(161, 21);
            this.comboBoxTipoIdentificacionEmpleado.TabIndex = 87;
            this.comboBoxTipoIdentificacionEmpleado.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoIdentificacionEmpleado_SelectedIndexChanged);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.Location = new System.Drawing.Point(12, 11);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(105, 32);
            this.buttonRegresar.TabIndex = 20;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 154);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 86;
            this.label11.Text = "Número de teléfono";
            // 
            // textBoxApellidoEmpleado
            // 
            this.textBoxApellidoEmpleado.Location = new System.Drawing.Point(270, 117);
            this.textBoxApellidoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApellidoEmpleado.Name = "textBoxApellidoEmpleado";
            this.textBoxApellidoEmpleado.Size = new System.Drawing.Size(161, 20);
            this.textBoxApellidoEmpleado.TabIndex = 81;
            this.textBoxApellidoEmpleado.TextChanged += new System.EventHandler(this.textBoxApellidoEmpleado_TextChanged);
            // 
            // textBoxNumeroTelefonoEmpleado
            // 
            this.textBoxNumeroTelefonoEmpleado.Location = new System.Drawing.Point(270, 174);
            this.textBoxNumeroTelefonoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumeroTelefonoEmpleado.Name = "textBoxNumeroTelefonoEmpleado";
            this.textBoxNumeroTelefonoEmpleado.Size = new System.Drawing.Size(161, 20);
            this.textBoxNumeroTelefonoEmpleado.TabIndex = 85;
            this.textBoxNumeroTelefonoEmpleado.TextChanged += new System.EventHandler(this.textBoxNumeroTelefonoEmpleado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Nombre";
            // 
            // txtNumeroIdentificacionEmpleado
            // 
            this.txtNumeroIdentificacionEmpleado.Location = new System.Drawing.Point(48, 174);
            this.txtNumeroIdentificacionEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroIdentificacionEmpleado.Name = "txtNumeroIdentificacionEmpleado";
            this.txtNumeroIdentificacionEmpleado.Size = new System.Drawing.Size(161, 20);
            this.txtNumeroIdentificacionEmpleado.TabIndex = 84;
            this.txtNumeroIdentificacionEmpleado.TextChanged += new System.EventHandler(this.txtNumeroIdentificacionEmpleado_TextChanged);
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(48, 117);
            this.textBoxNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(161, 20);
            this.textBoxNombreUsuario.TabIndex = 79;
            this.textBoxNombreUsuario.TextChanged += new System.EventHandler(this.textBoxNombreUsuario_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "Número de Identificación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Tipo identificación";
            // 
            // FormAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 518);
            this.Controls.Add(this.panel1);
            this.Name = "FormAgregarUsuario";
            this.Text = "FormAgregarUsuario";
            this.Load += new System.EventHandler(this.FormAgregarUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDEmpleado;
        private System.Windows.Forms.Button buttonAgregarEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTipoIdentificacionEmpleado;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxApellidoEmpleado;
        private System.Windows.Forms.TextBox textBoxNumeroTelefonoEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroIdentificacionEmpleado;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}