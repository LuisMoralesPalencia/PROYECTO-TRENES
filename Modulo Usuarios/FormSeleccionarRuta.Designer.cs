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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxRutaSeleccionada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEstacionDestino = new System.Windows.Forms.ComboBox();
            this.comboBoxEstacionOrigen = new System.Windows.Forms.ComboBox();
            this.richTextBoxInformacionRuta = new System.Windows.Forms.RichTextBox();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.buttonSeleccionarRuta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(119, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 628);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(435, 559);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 44);
            this.button1.TabIndex = 34;
            this.button1.Text = "Ir a comprar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxRutaSeleccionada
            // 
            this.textBoxRutaSeleccionada.Enabled = false;
            this.textBoxRutaSeleccionada.Location = new System.Drawing.Point(497, 105);
            this.textBoxRutaSeleccionada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRutaSeleccionada.Name = "textBoxRutaSeleccionada";
            this.textBoxRutaSeleccionada.Size = new System.Drawing.Size(132, 22);
            this.textBoxRutaSeleccionada.TabIndex = 33;
            this.textBoxRutaSeleccionada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Rutas disponibles";
            // 
            // comboBoxEstacionDestino
            // 
            this.comboBoxEstacionDestino.FormattingEnabled = true;
            this.comboBoxEstacionDestino.Location = new System.Drawing.Point(57, 167);
            this.comboBoxEstacionDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEstacionDestino.Name = "comboBoxEstacionDestino";
            this.comboBoxEstacionDestino.Size = new System.Drawing.Size(160, 24);
            this.comboBoxEstacionDestino.TabIndex = 30;
            this.comboBoxEstacionDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstacionDestino_SelectedIndexChanged);
            // 
            // comboBoxEstacionOrigen
            // 
            this.comboBoxEstacionOrigen.FormattingEnabled = true;
            this.comboBoxEstacionOrigen.Location = new System.Drawing.Point(57, 103);
            this.comboBoxEstacionOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEstacionOrigen.Name = "comboBoxEstacionOrigen";
            this.comboBoxEstacionOrigen.Size = new System.Drawing.Size(160, 24);
            this.comboBoxEstacionOrigen.TabIndex = 29;
            this.comboBoxEstacionOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstacionOrigen_SelectedIndexChanged);
            // 
            // richTextBoxInformacionRuta
            // 
            this.richTextBoxInformacionRuta.Location = new System.Drawing.Point(57, 229);
            this.richTextBoxInformacionRuta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxInformacionRuta.Name = "richTextBoxInformacionRuta";
            this.richTextBoxInformacionRuta.Size = new System.Drawing.Size(732, 271);
            this.richTextBoxInformacionRuta.TabIndex = 28;
            this.richTextBoxInformacionRuta.Text = "";
            this.richTextBoxInformacionRuta.TextChanged += new System.EventHandler(this.richTextBoxInformacionRuta_TextChanged);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(21, 16);
            this.buttonRegresar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(133, 34);
            this.buttonRegresar.TabIndex = 27;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // buttonSeleccionarRuta
            // 
            this.buttonSeleccionarRuta.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonSeleccionarRuta.Location = new System.Drawing.Point(57, 559);
            this.buttonSeleccionarRuta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonSeleccionarRuta.Name = "buttonSeleccionarRuta";
            this.buttonSeleccionarRuta.Size = new System.Drawing.Size(356, 44);
            this.buttonSeleccionarRuta.TabIndex = 24;
            this.buttonSeleccionarRuta.Text = "Buscar ruta";
            this.buttonSeleccionarRuta.UseVisualStyleBackColor = false;
            this.buttonSeleccionarRuta.Click += new System.EventHandler(this.buttonSeleccionarRuta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F);
            this.label2.Location = new System.Drawing.Point(295, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Seleccione una ruta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Estación de Origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Estación de Destino";
            // 
            // FormSeleccionarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1112, 684);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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