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

namespace PROYECTO_TRENES.Modulo_Empleado
{
    public partial class mostrarvagonesForm1 : Form
    {
        public mostrarvagonesForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm1 menuPrincipalForm1 = new MenuPrincipalForm1();
            menuPrincipalForm1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StringBuilder sb = new StringBuilder();

            if (Datos.ListaTrenes.Cantidad == 0)
            {
                sb.AppendLine("No hay trenes registrados en el sistema.");
            }
            else
            {
                sb.AppendLine("--- Listado de Vagones por Tren ---");
                sb.AppendLine();

                Nodo<Tren> actualTren = Datos.ListaTrenes.GetPrimerNodo();
                if (actualTren != null)
                {
                    do
                    {
                        sb.AppendLine($"Tren ID: {actualTren.Valor.Id}, Nombre: {actualTren.Valor.Nombre}");
                        Pila<Vagon> pilaVagonesDelTren = actualTren.Valor.PilaVagones;

                        if (pilaVagonesDelTren.EstaVacia)
                        {
                            sb.AppendLine("  Este tren no tiene vagones asignados.");
                        }
                        else
                        {
                            Nodo<Vagon> actualVagon = pilaVagonesDelTren.GetCima();
                            while (actualVagon != null)
                            {
                                sb.AppendLine($"  Vagón ID: {actualVagon.Valor.IdVagon}, Tipo: {actualVagon.Valor.Tipo}, Capacidad: {actualVagon.Valor.CapacidadMaxima}");
                                actualVagon = actualVagon.Siguiente;
                            }
                        }
                        sb.AppendLine();

                        actualTren = actualTren.Siguiente;
                    } while (actualTren != Datos.ListaTrenes.GetPrimerNodo());
                }
            }

            richTextBox1.Text = sb.ToString();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
    }
}