namespace PROYECTO_TRENES.Modulo_Usuarios
{
    partial class FormMenuUsuario
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
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.buttonMirarBoletosComprados = new System.Windows.Forms.Button();
            this.buttonComprarBoletos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonCerrarSesion);
            this.panel1.Controls.Add(this.buttonMirarBoletosComprados);
            this.panel1.Controls.Add(this.buttonComprarBoletos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(59, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 455);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.Location = new System.Drawing.Point(21, 16);
            this.buttonCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(140, 39);
            this.buttonCerrarSesion.TabIndex = 19;
            this.buttonCerrarSesion.Text = "Cerrar sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // buttonMirarBoletosComprados
            // 
            this.buttonMirarBoletosComprados.Location = new System.Drawing.Point(557, 148);
            this.buttonMirarBoletosComprados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMirarBoletosComprados.Name = "buttonMirarBoletosComprados";
            this.buttonMirarBoletosComprados.Size = new System.Drawing.Size(151, 80);
            this.buttonMirarBoletosComprados.TabIndex = 18;
            this.buttonMirarBoletosComprados.Text = "Mirar boletos comprados";
            this.buttonMirarBoletosComprados.UseVisualStyleBackColor = true;
            this.buttonMirarBoletosComprados.Click += new System.EventHandler(this.buttonMirarBoletosComprados_Click);
            // 
            // buttonComprarBoletos
            // 
            this.buttonComprarBoletos.Location = new System.Drawing.Point(229, 148);
            this.buttonComprarBoletos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonComprarBoletos.Name = "buttonComprarBoletos";
            this.buttonComprarBoletos.Size = new System.Drawing.Size(151, 80);
            this.buttonComprarBoletos.TabIndex = 17;
            this.buttonComprarBoletos.Text = "Comprar boletos";
            this.buttonComprarBoletos.UseVisualStyleBackColor = true;
            this.buttonComprarBoletos.Click += new System.EventHandler(this.buttonComprarBoletos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Menú usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormMenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1112, 567);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMenuUsuario";
            this.Text = "Menu usuario";
            this.Load += new System.EventHandler(this.FormMenuUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonComprarBoletos;
        private System.Windows.Forms.Button buttonMirarBoletosComprados;
        private System.Windows.Forms.Button buttonCerrarSesion;
    }
}