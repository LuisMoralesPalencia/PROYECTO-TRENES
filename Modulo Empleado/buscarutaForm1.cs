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
    public partial class buscarutaForm1 : Form
    {
        
        public buscarutaForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            MenuPrincipalForm1 menuPrincipalForm1 = new MenuPrincipalForm1();
            menuPrincipalForm1.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e) 
        {
            int rutasPublicadasCount = 0;

            List<Ruta> todasLasRutas = Datos.RedFerroviaria.MostrarRutas();

            if (todasLasRutas == null || todasLasRutas.Count == 0)
            {
                MessageBox.Show("No hay rutas para publicar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (Ruta ruta in todasLasRutas)
            {
                
                if (!ruta.EsPublicada)
                {
                    Datos.RedFerroviaria.PublicarRuta(ruta.IdRuta, true);
                    rutasPublicadasCount++;
                }
            }

            if (rutasPublicadasCount > 0)
            {
                MessageBox.Show($"{rutasPublicadasCount} ruta(s) han sido publicadas exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Todas las rutas ya estaban publicadas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            List<Ruta> LasRutas = Datos.RedFerroviaria.MostrarRutas();

            if (todasLasRutas == null || todasLasRutas.Count == 0)
            {
                richTextBox1.Text = "No hay rutas registradas en el sistema.";
            }
            else
            {
                richTextBox1.AppendText("Listado de Rutas:\n");
                
                foreach (Ruta ruta in todasLasRutas)
                {
                    richTextBox1.AppendText($"ID: {ruta.IdRuta}, Origen: {ruta.Origen}, Destino: {ruta.Destino}, Publicada: {(ruta.EsPublicada ? "Sí" : "No")}\n");
                }
                
            }

            
        }
    }
}
