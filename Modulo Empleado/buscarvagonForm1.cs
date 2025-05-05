using PROYECTO_TRENES.Códigos;
using PROYECTO_TRENES.Estructuras_de_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_TRENES.Modulo_Empleado
{
    public partial class buscarvagonForm1 : Form
    {
        public buscarvagonForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm1 menuPrincipalForm1 = new MenuPrincipalForm1();
            menuPrincipalForm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idBuscar = textBox2.Text.Trim();

            richTextBox1.Text = "";

            if (string.IsNullOrWhiteSpace(idBuscar))
            {
                MessageBox.Show("Por favor, ingrese el ID del vagón a buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Vagon vagonEncontrado = null;
            Tren trenDelVagon = null;

            Nodo<Tren> actualTren = Datos.ListaTrenes.GetPrimerNodo();
            if (actualTren != null)
            {
                bool encontrado = false;
                do
                {
                    Nodo<Vagon> actualVagon = actualTren.Valor.PilaVagones.GetCima();
                    while (actualVagon != null)
                    {
                        if (actualVagon.Valor.IdVagon == idBuscar)
                        {
                            vagonEncontrado = actualVagon.Valor;
                            trenDelVagon = actualTren.Valor;
                            encontrado = true;
                            break; 
                        }
                        actualVagon = actualVagon.Siguiente;
                    }

                    if (encontrado)
                    {
                        break; 
                    }

                    actualTren = actualTren.Siguiente;
                } while (actualTren != Datos.ListaTrenes.GetPrimerNodo()); 
            }

            if (vagonEncontrado != null)
            {
                richTextBox1.Text = "Vagón Encontrado:\r\n" +
                                     "------------------------\r\n" +
                                     $"ID Vagón: {vagonEncontrado.IdVagon}\r\n" +
                                     $"Tipo: {vagonEncontrado.Tipo}\r\n" +
                                     $"Capacidad Máxima: {vagonEncontrado.CapacidadMaxima}\r\n" +
                                     $"Pertenece al Tren (ID): {trenDelVagon?.Id ?? "N/A"}";

            }
            else
            {
                richTextBox1.Text = $"No se encontró ningún vagón con el ID: {idBuscar}";
            }
        
        }
    }
}
