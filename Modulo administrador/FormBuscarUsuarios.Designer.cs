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
            this.buttonModificarUsuario = new System.Windows.Forms.Button();
            this.richTextBoxInformacionUsuario = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonModificarUsuario);
            this.panel1.Controls.Add(this.richTextBoxInformacionUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonRegresar);
            this.panel1.Location = new System.Drawing.Point(127, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 447);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonModificarUsuario
            // 
            this.buttonModificarUsuario.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonModificarUsuario.Location = new System.Drawing.Point(239, 99);
            this.buttonModificarUsuario.Name = "buttonModificarUsuario";
            this.buttonModificarUsuario.Size = new System.Drawing.Size(99, 49);
            this.buttonModificarUsuario.TabIndex = 175;
            this.buttonModificarUsuario.Text = "Mostrar usuarios";
            this.buttonModificarUsuario.UseVisualStyleBackColor = false;
            this.buttonModificarUsuario.Click += new System.EventHandler(this.buttonModificarUsuario_Click);
            // 
            // richTextBoxInformacionUsuario
            // 
            this.richTextBoxInformacionUsuario.Location = new System.Drawing.Point(47, 165);
            this.richTextBoxInformacionUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxInformacionUsuario.Name = "richTextBoxInformacionUsuario";
            this.richTextBoxInformacionUsuario.Size = new System.Drawing.Size(499, 240);
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
            this.label2.Size = new System.Drawing.Size(501, 15);
            this.label2.TabIndex = 92;
            this.label2.Text = "En esta ventana podra consultar la información de los usuarios en el sistema";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 38);
            this.label4.TabIndex = 176;
            this.label4.Text = "TransRail";
            // 
            // FormBuscarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 516);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBuscarUsuarios";
            this.Text = "Buscar Usuarios";
            this.Load += new System.EventHandler(this.FormBuscarUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxInformacionUsuario;
        private System.Windows.Forms.Button buttonModificarUsuario;
        private System.Windows.Forms.Label label4;
    }
}