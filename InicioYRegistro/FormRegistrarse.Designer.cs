﻿namespace PROYECTO_TRENES.InicioYRegistro
{
    partial class FormRegistrarse
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelSiTengoCuenta = new System.Windows.Forms.LinkLabel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.textBoxContraseñaRegistro = new System.Windows.Forms.TextBox();
            this.textBoxCorreoRegistro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 38);
            this.label4.TabIndex = 17;
            this.label4.Text = "TransRail";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.linkLabelSiTengoCuenta);
            this.panel1.Controls.Add(this.buttonSalir);
            this.panel1.Controls.Add(this.buttonRegistrarse);
            this.panel1.Controls.Add(this.textBoxContraseñaRegistro);
            this.panel1.Controls.Add(this.textBoxCorreoRegistro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(213, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 369);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabelSiTengoCuenta
            // 
            this.linkLabelSiTengoCuenta.AutoSize = true;
            this.linkLabelSiTengoCuenta.Location = new System.Drawing.Point(159, 231);
            this.linkLabelSiTengoCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelSiTengoCuenta.Name = "linkLabelSiTengoCuenta";
            this.linkLabelSiTengoCuenta.Size = new System.Drawing.Size(107, 13);
            this.linkLabelSiTengoCuenta.TabIndex = 15;
            this.linkLabelSiTengoCuenta.TabStop = true;
            this.linkLabelSiTengoCuenta.Text = "Ya tengo una cuenta";
            this.linkLabelSiTengoCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSiTengoCuenta_LinkClicked);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(12, 11);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 14;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarse.Location = new System.Drawing.Point(63, 267);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(290, 33);
            this.buttonRegistrarse.TabIndex = 13;
            this.buttonRegistrarse.Text = "Registrarse";
            this.buttonRegistrarse.UseVisualStyleBackColor = false;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // textBoxContraseñaRegistro
            // 
            this.textBoxContraseñaRegistro.Location = new System.Drawing.Point(65, 197);
            this.textBoxContraseñaRegistro.Name = "textBoxContraseñaRegistro";
            this.textBoxContraseñaRegistro.Size = new System.Drawing.Size(289, 20);
            this.textBoxContraseñaRegistro.TabIndex = 12;
            this.textBoxContraseñaRegistro.TextChanged += new System.EventHandler(this.textBoxContraseñaRegistro_TextChanged);
            // 
            // textBoxCorreoRegistro
            // 
            this.textBoxCorreoRegistro.Location = new System.Drawing.Point(65, 120);
            this.textBoxCorreoRegistro.Name = "textBoxCorreoRegistro";
            this.textBoxCorreoRegistro.Size = new System.Drawing.Size(289, 20);
            this.textBoxCorreoRegistro.TabIndex = 11;
            this.textBoxCorreoRegistro.TextChanged += new System.EventHandler(this.textBoxCorreoRegistro_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(63, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(63, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Registrarse";
            // 
            // FormRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 545);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRegistrarse";
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.FormRegistrarse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.TextBox textBoxContraseñaRegistro;
        private System.Windows.Forms.TextBox textBoxCorreoRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelSiTengoCuenta;
    }
}