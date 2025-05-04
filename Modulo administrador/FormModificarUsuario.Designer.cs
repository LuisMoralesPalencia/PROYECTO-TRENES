namespace PROYECTO_TRENES.Modulo_administrador
{
    partial class FormModificarUsuario
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxApellidoUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTipoDeUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonConfirmarCambio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(12, 11);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(105, 32);
            this.buttonCancelar.TabIndex = 22;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Nombre de usuario";
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Enabled = false;
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(62, 112);
            this.textBoxNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(161, 20);
            this.textBoxNombreUsuario.TabIndex = 79;
            this.textBoxNombreUsuario.TextChanged += new System.EventHandler(this.textBoxNombreUsuario_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Contraseña";
            // 
            // textBoxApellidoUsuario
            // 
            this.textBoxApellidoUsuario.Enabled = false;
            this.textBoxApellidoUsuario.Location = new System.Drawing.Point(285, 112);
            this.textBoxApellidoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApellidoUsuario.Name = "textBoxApellidoUsuario";
            this.textBoxApellidoUsuario.Size = new System.Drawing.Size(161, 20);
            this.textBoxApellidoUsuario.TabIndex = 81;
            this.textBoxApellidoUsuario.TextChanged += new System.EventHandler(this.textBoxApellidoUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 15);
            this.label2.TabIndex = 94;
            this.label2.Text = "Usted esta modificando un usuario de tipo:";
            // 
            // textBoxTipoDeUsuario
            // 
            this.textBoxTipoDeUsuario.Enabled = false;
            this.textBoxTipoDeUsuario.Location = new System.Drawing.Point(341, 47);
            this.textBoxTipoDeUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTipoDeUsuario.Name = "textBoxTipoDeUsuario";
            this.textBoxTipoDeUsuario.Size = new System.Drawing.Size(161, 20);
            this.textBoxTipoDeUsuario.TabIndex = 95;
            this.textBoxTipoDeUsuario.TextChanged += new System.EventHandler(this.textBoxTipoDeUsuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 96;
            this.label1.Text = "Información actual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 15);
            this.label5.TabIndex = 97;
            this.label5.Text = "Información nueva";
            // 
            // buttonConfirmarCambio
            // 
            this.buttonConfirmarCambio.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonConfirmarCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarCambio.Location = new System.Drawing.Point(207, 267);
            this.buttonConfirmarCambio.Name = "buttonConfirmarCambio";
            this.buttonConfirmarCambio.Size = new System.Drawing.Size(111, 59);
            this.buttonConfirmarCambio.TabIndex = 115;
            this.buttonConfirmarCambio.Text = "Confirmar cambio";
            this.buttonConfirmarCambio.UseVisualStyleBackColor = false;
            this.buttonConfirmarCambio.Click += new System.EventHandler(this.buttonConfirmarCambio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buttonConfirmarCambio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxTipoDeUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxApellidoUsuario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxNombreUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Location = new System.Drawing.Point(149, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 347);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 205);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 119;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 118;
            this.label6.Text = "Contraseña";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 205);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 117;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 116;
            this.label7.Text = "Nombre de usuario";
            // 
            // FormModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 459);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormModificarUsuario";
            this.Text = "Modificar Usuario";
            this.Load += new System.EventHandler(this.FormModificarUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxApellidoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTipoDeUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonConfirmarCambio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
    }
}