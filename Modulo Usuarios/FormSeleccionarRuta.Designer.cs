namespace PROYECTO_TRENES.Modulo_Usuarios
{
    partial class FormSeleccionarRuta
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
            this.comboBoxEstacionDestino = new System.Windows.Forms.ComboBox();
            this.comboBoxEstacionOrigen = new System.Windows.Forms.ComboBox();
            this.richTextBoxInformacionRuta = new System.Windows.Forms.RichTextBox();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.buttonSeleccionarRuta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRutaSeleccionada = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxRutaSeleccionada);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxEstacionDestino);
            this.panel1.Controls.Add(this.comboBoxEstacionOrigen);
            this.panel1.Controls.Add(this.richTextBoxInformacionRuta);
            this.panel1.Controls.Add(this.buttonRegresar);
            this.panel1.Controls.Add(this.buttonSeleccionarRuta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(89, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 510);
            this.panel1.TabIndex = 19;
            // 
            // comboBoxEstacionDestino
            // 
            this.comboBoxEstacionDestino.FormattingEnabled = true;
            this.comboBoxEstacionDestino.Location = new System.Drawing.Point(43, 136);
            this.comboBoxEstacionDestino.Name = "comboBoxEstacionDestino";
            this.comboBoxEstacionDestino.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstacionDestino.TabIndex = 30;
            this.comboBoxEstacionDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstacionDestino_SelectedIndexChanged);
            // 
            // comboBoxEstacionOrigen
            // 
            this.comboBoxEstacionOrigen.FormattingEnabled = true;
            this.comboBoxEstacionOrigen.Location = new System.Drawing.Point(43, 84);
            this.comboBoxEstacionOrigen.Name = "comboBoxEstacionOrigen";
            this.comboBoxEstacionOrigen.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstacionOrigen.TabIndex = 29;
            this.comboBoxEstacionOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstacionOrigen_SelectedIndexChanged);
            // 
            // richTextBoxInformacionRuta
            // 
            this.richTextBoxInformacionRuta.Location = new System.Drawing.Point(43, 186);
            this.richTextBoxInformacionRuta.Name = "richTextBoxInformacionRuta";
            this.richTextBoxInformacionRuta.Size = new System.Drawing.Size(550, 221);
            this.richTextBoxInformacionRuta.TabIndex = 28;
            this.richTextBoxInformacionRuta.Text = "";
            this.richTextBoxInformacionRuta.TextChanged += new System.EventHandler(this.richTextBoxInformacionRuta_TextChanged);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(16, 13);
            this.buttonRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(100, 28);
            this.buttonRegresar.TabIndex = 27;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // buttonSeleccionarRuta
            // 
            this.buttonSeleccionarRuta.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonSeleccionarRuta.Location = new System.Drawing.Point(43, 454);
            this.buttonSeleccionarRuta.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSeleccionarRuta.Name = "buttonSeleccionarRuta";
            this.buttonSeleccionarRuta.Size = new System.Drawing.Size(267, 36);
            this.buttonSeleccionarRuta.TabIndex = 24;
            this.buttonSeleccionarRuta.Text = "Buscar ruta";
            this.buttonSeleccionarRuta.UseVisualStyleBackColor = false;
            this.buttonSeleccionarRuta.Click += new System.EventHandler(this.buttonSeleccionarRuta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F);
            this.label2.Location = new System.Drawing.Point(221, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Seleccione una ruta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Estación de Origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Estación de Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Rutas disponibles";
            // 
            // textBoxRutaSeleccionada
            // 
            this.textBoxRutaSeleccionada.Enabled = false;
            this.textBoxRutaSeleccionada.Location = new System.Drawing.Point(373, 85);
            this.textBoxRutaSeleccionada.Name = "textBoxRutaSeleccionada";
            this.textBoxRutaSeleccionada.Size = new System.Drawing.Size(100, 20);
            this.textBoxRutaSeleccionada.TabIndex = 33;
            this.textBoxRutaSeleccionada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(326, 454);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 36);
            this.button1.TabIndex = 34;
            this.button1.Text = "Ir a comprar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSeleccionarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 556);
            this.Controls.Add(this.panel1);
            this.Name = "FormSeleccionarRuta";
            this.Text = "Seleccionar ruta";
            this.Load += new System.EventHandler(this.FormSeleccionarRuta1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Button buttonSeleccionarRuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxEstacionOrigen;
        private System.Windows.Forms.RichTextBox richTextBoxInformacionRuta;
        private System.Windows.Forms.ComboBox comboBoxEstacionDestino;
        private System.Windows.Forms.TextBox textBoxRutaSeleccionada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}