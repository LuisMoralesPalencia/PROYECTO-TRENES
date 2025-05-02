namespace PROYECTO_TRENES.Modulo_Usuarios
{
    partial class FormModificarRuta
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxNuevaEstacionDeDestino = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEstacionActual = new System.Windows.Forms.TextBox();
            this.buttonCambiarRuta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonCambiarRuta);
            this.panel1.Controls.Add(this.textBoxEstacionActual);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.comboBoxNuevaEstacionDeDestino);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Location = new System.Drawing.Point(42, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 520);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 22);
            this.label1.TabIndex = 68;
            this.label1.Text = "Modifique la estación de destino de su ruta";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(16, 13);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelar.TabIndex = 19;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 17);
            this.label7.TabIndex = 128;
            this.label7.Text = "Seleccione una nueva estación de destino:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 129;
            this.label8.Text = "Nueva estación de destino:";
            // 
            // comboBoxNuevaEstacionDeDestino
            // 
            this.comboBoxNuevaEstacionDeDestino.FormattingEnabled = true;
            this.comboBoxNuevaEstacionDeDestino.Location = new System.Drawing.Point(522, 92);
            this.comboBoxNuevaEstacionDeDestino.Name = "comboBoxNuevaEstacionDeDestino";
            this.comboBoxNuevaEstacionDeDestino.Size = new System.Drawing.Size(187, 21);
            this.comboBoxNuevaEstacionDeDestino.TabIndex = 130;
            this.comboBoxNuevaEstacionDeDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxNuevaEstacionDeDestino_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(40, 177);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(669, 270);
            this.richTextBox1.TabIndex = 131;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 17);
            this.label2.TabIndex = 132;
            this.label2.Text = "Rutas disponibles con su estación actual:";
            // 
            // textBoxEstacionActual
            // 
            this.textBoxEstacionActual.Location = new System.Drawing.Point(354, 145);
            this.textBoxEstacionActual.Name = "textBoxEstacionActual";
            this.textBoxEstacionActual.Size = new System.Drawing.Size(188, 20);
            this.textBoxEstacionActual.TabIndex = 133;
            this.textBoxEstacionActual.TextChanged += new System.EventHandler(this.textBoxEstacionActual_TextChanged_1);
            // 
            // buttonCambiarRuta
            // 
            this.buttonCambiarRuta.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonCambiarRuta.Location = new System.Drawing.Point(563, 453);
            this.buttonCambiarRuta.Name = "buttonCambiarRuta";
            this.buttonCambiarRuta.Size = new System.Drawing.Size(146, 54);
            this.buttonCambiarRuta.TabIndex = 134;
            this.buttonCambiarRuta.Text = "Cambiar ruta";
            this.buttonCambiarRuta.UseVisualStyleBackColor = false;
            this.buttonCambiarRuta.Click += new System.EventHandler(this.buttonCambiarRuta_Click);
            // 
            // FormModificarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 544);
            this.Controls.Add(this.panel1);
            this.Name = "FormModificarRuta";
            this.Text = "FormModificarRuta";
            this.Load += new System.EventHandler(this.FormModificarRuta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxNuevaEstacionDeDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxEstacionActual;
        private System.Windows.Forms.Button buttonCambiarRuta;
    }
}