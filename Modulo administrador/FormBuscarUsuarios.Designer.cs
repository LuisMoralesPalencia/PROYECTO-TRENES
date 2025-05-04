namespace PROYECTO_TRENES.Modulo_administrador
{
    partial class FormBuscarUsuarios
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
            this.textBoxTipoDeUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEliminarUsuario = new System.Windows.Forms.Button();
            this.buttonModificarUsuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBuscarUsuario = new System.Windows.Forms.Button();
            this.richTextBoxInformacionUsuario = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxTipoDeUsuario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonEliminarUsuario);
            this.panel1.Controls.Add(this.buttonModificarUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonBuscarUsuario);
            this.panel1.Controls.Add(this.richTextBoxInformacionUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxIDUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonRegresar);
            this.panel1.Location = new System.Drawing.Point(39, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 447);
            this.panel1.TabIndex = 0;
            // 
            // textBoxTipoDeUsuario
            // 
            this.textBoxTipoDeUsuario.Enabled = false;
            this.textBoxTipoDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTipoDeUsuario.Location = new System.Drawing.Point(511, 123);
            this.textBoxTipoDeUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTipoDeUsuario.Name = "textBoxTipoDeUsuario";
            this.textBoxTipoDeUsuario.Size = new System.Drawing.Size(132, 23);
            this.textBoxTipoDeUsuario.TabIndex = 178;
            this.textBoxTipoDeUsuario.TextChanged += new System.EventHandler(this.textBoxTipoDeUsuario_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 15);
            this.label4.TabIndex = 177;
            this.label4.Text = "El usuario que usted ha buscado es un:";
            // 
            // buttonEliminarUsuario
            // 
            this.buttonEliminarUsuario.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonEliminarUsuario.Location = new System.Drawing.Point(566, 329);
            this.buttonEliminarUsuario.Name = "buttonEliminarUsuario";
            this.buttonEliminarUsuario.Size = new System.Drawing.Size(99, 49);
            this.buttonEliminarUsuario.TabIndex = 176;
            this.buttonEliminarUsuario.Text = "Eliminar";
            this.buttonEliminarUsuario.UseVisualStyleBackColor = false;
            this.buttonEliminarUsuario.Click += new System.EventHandler(this.buttonEliminarUsuario_Click);
            // 
            // buttonModificarUsuario
            // 
            this.buttonModificarUsuario.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonModificarUsuario.Location = new System.Drawing.Point(566, 208);
            this.buttonModificarUsuario.Name = "buttonModificarUsuario";
            this.buttonModificarUsuario.Size = new System.Drawing.Size(99, 49);
            this.buttonModificarUsuario.TabIndex = 175;
            this.buttonModificarUsuario.Text = "Modificar";
            this.buttonModificarUsuario.UseVisualStyleBackColor = false;
            this.buttonModificarUsuario.Click += new System.EventHandler(this.buttonModificarUsuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 15);
            this.label3.TabIndex = 174;
            this.label3.Text = "Opciones de gestión de usuario";
            // 
            // buttonBuscarUsuario
            // 
            this.buttonBuscarUsuario.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonBuscarUsuario.Location = new System.Drawing.Point(178, 119);
            this.buttonBuscarUsuario.Name = "buttonBuscarUsuario";
            this.buttonBuscarUsuario.Size = new System.Drawing.Size(80, 29);
            this.buttonBuscarUsuario.TabIndex = 173;
            this.buttonBuscarUsuario.Text = "Buscar";
            this.buttonBuscarUsuario.UseVisualStyleBackColor = false;
            this.buttonBuscarUsuario.Click += new System.EventHandler(this.buttonBuscarUsuario_Click);
            // 
            // richTextBoxInformacionUsuario
            // 
            this.richTextBoxInformacionUsuario.Location = new System.Drawing.Point(47, 165);
            this.richTextBoxInformacionUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxInformacionUsuario.Name = "richTextBoxInformacionUsuario";
            this.richTextBoxInformacionUsuario.Size = new System.Drawing.Size(416, 240);
            this.richTextBoxInformacionUsuario.TabIndex = 93;
            this.richTextBoxInformacionUsuario.Text = "";
            this.richTextBoxInformacionUsuario.TextChanged += new System.EventHandler(this.richTextBoxInformacionUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(566, 30);
            this.label2.TabIndex = 92;
            this.label2.Text = "En esta ventana podra consultar la información de cualquier usuario en el sistema" +
    ", sea\r\nun pasajero o empleado.";
            // 
            // textBoxIDUsuario
            // 
            this.textBoxIDUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDUsuario.Location = new System.Drawing.Point(47, 123);
            this.textBoxIDUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIDUsuario.Name = "textBoxIDUsuario";
            this.textBoxIDUsuario.Size = new System.Drawing.Size(98, 23);
            this.textBoxIDUsuario.TabIndex = 23;
            this.textBoxIDUsuario.TextChanged += new System.EventHandler(this.textBoxIDUsuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID del usuario";
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.Location = new System.Drawing.Point(12, 11);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(105, 32);
            this.buttonRegresar.TabIndex = 21;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // FormBuscarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 516);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormBuscarUsuarios";
            this.Text = "Buscar Usuarios";
            this.Load += new System.EventHandler(this.FormBuscarUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.TextBox textBoxIDUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxInformacionUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBuscarUsuario;
        private System.Windows.Forms.Button buttonEliminarUsuario;
        private System.Windows.Forms.Button buttonModificarUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTipoDeUsuario;
    }
}