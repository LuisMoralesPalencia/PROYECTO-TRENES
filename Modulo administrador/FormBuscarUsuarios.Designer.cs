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
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxInformacionUsuario = new System.Windows.Forms.RichTextBox();
            this.buttonBuscarUsuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonModificarUsuario = new System.Windows.Forms.Button();
            this.buttonEliminarUsuario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTipoDeUsuario = new System.Windows.Forms.TextBox();
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
            this.panel1.Location = new System.Drawing.Point(52, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 550);
            this.panel1.TabIndex = 0;
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.Location = new System.Drawing.Point(16, 13);
            this.buttonRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(140, 39);
            this.buttonRegresar.TabIndex = 21;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID del usuario";
            // 
            // textBoxIDUsuario
            // 
            this.textBoxIDUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDUsuario.Location = new System.Drawing.Point(63, 151);
            this.textBoxIDUsuario.Name = "textBoxIDUsuario";
            this.textBoxIDUsuario.Size = new System.Drawing.Size(130, 26);
            this.textBoxIDUsuario.TabIndex = 23;
            this.textBoxIDUsuario.TextChanged += new System.EventHandler(this.textBoxIDUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(662, 36);
            this.label2.TabIndex = 92;
            this.label2.Text = "En esta ventana podra consultar la información de cualquier usuario en el sistema" +
    ", sea\r\nun pasajero o empleado.";
            // 
            // richTextBoxInformacionUsuario
            // 
            this.richTextBoxInformacionUsuario.Location = new System.Drawing.Point(63, 203);
            this.richTextBoxInformacionUsuario.Name = "richTextBoxInformacionUsuario";
            this.richTextBoxInformacionUsuario.Size = new System.Drawing.Size(553, 295);
            this.richTextBoxInformacionUsuario.TabIndex = 93;
            this.richTextBoxInformacionUsuario.Text = "";
            this.richTextBoxInformacionUsuario.TextChanged += new System.EventHandler(this.richTextBoxInformacionUsuario_TextChanged);
            // 
            // buttonBuscarUsuario
            // 
            this.buttonBuscarUsuario.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonBuscarUsuario.Location = new System.Drawing.Point(237, 147);
            this.buttonBuscarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscarUsuario.Name = "buttonBuscarUsuario";
            this.buttonBuscarUsuario.Size = new System.Drawing.Size(106, 36);
            this.buttonBuscarUsuario.TabIndex = 173;
            this.buttonBuscarUsuario.Text = "Buscar";
            this.buttonBuscarUsuario.UseVisualStyleBackColor = false;
            this.buttonBuscarUsuario.Click += new System.EventHandler(this.buttonBuscarUsuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(701, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 18);
            this.label3.TabIndex = 174;
            this.label3.Text = "Opciones de gestión de usuario";
            // 
            // buttonModificarUsuario
            // 
            this.buttonModificarUsuario.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonModificarUsuario.Location = new System.Drawing.Point(755, 256);
            this.buttonModificarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModificarUsuario.Name = "buttonModificarUsuario";
            this.buttonModificarUsuario.Size = new System.Drawing.Size(132, 60);
            this.buttonModificarUsuario.TabIndex = 175;
            this.buttonModificarUsuario.Text = "Modificar";
            this.buttonModificarUsuario.UseVisualStyleBackColor = false;
            this.buttonModificarUsuario.Click += new System.EventHandler(this.buttonModificarUsuario_Click);
            // 
            // buttonEliminarUsuario
            // 
            this.buttonEliminarUsuario.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonEliminarUsuario.Location = new System.Drawing.Point(755, 405);
            this.buttonEliminarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminarUsuario.Name = "buttonEliminarUsuario";
            this.buttonEliminarUsuario.Size = new System.Drawing.Size(132, 60);
            this.buttonEliminarUsuario.TabIndex = 176;
            this.buttonEliminarUsuario.Text = "Eliminar";
            this.buttonEliminarUsuario.UseVisualStyleBackColor = false;
            this.buttonEliminarUsuario.Click += new System.EventHandler(this.buttonEliminarUsuario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 18);
            this.label4.TabIndex = 177;
            this.label4.Text = "El usuario que usted ha buscado es un:";
            // 
            // textBoxTipoDeUsuario
            // 
            this.textBoxTipoDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTipoDeUsuario.Location = new System.Drawing.Point(681, 151);
            this.textBoxTipoDeUsuario.Name = "textBoxTipoDeUsuario";
            this.textBoxTipoDeUsuario.Size = new System.Drawing.Size(174, 26);
            this.textBoxTipoDeUsuario.TabIndex = 178;
            this.textBoxTipoDeUsuario.TextChanged += new System.EventHandler(this.textBoxTipoDeUsuario_TextChanged);
            // 
            // FormBuscarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1112, 635);
            this.Controls.Add(this.panel1);
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