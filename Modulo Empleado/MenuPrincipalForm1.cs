using PROYECTO_TRENES.InicioYRegistro;
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
    public partial class MenuPrincipalForm1 : Form
    {
        public MenuPrincipalForm1()
        {
            InitializeComponent();
        }

        private void MenuPrincipalForm1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormInicioSesion formInicioSesion = new FormInicioSesion();
            formInicioSesion.Show();
            this.Hide();
        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            validarBoletoForm1 validarBoletoForm1 = new validarBoletoForm1();
            validarBoletoForm1.Show();
            this.Hide();
        }

        private void GestiónTren_Click(object sender, EventArgs e)
        {
            desembarqueForm1 desembarqueForm1 = new desembarqueForm1();
            desembarqueForm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            embarqueForm1 embarqueForm1 = new embarqueForm1();
            embarqueForm1.Show();
            this.Hide();
        }

        private void Protocolo_Click(object sender, EventArgs e)
        {
            protocoloAbordajeForm1 protocoloAbordajeForm1 = new protocoloAbordajeForm1();
            protocoloAbordajeForm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agregartrenForm1 agregartrenForm1 = new agregartrenForm1();
            agregartrenForm1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buscartrenForm1 buscartrenForm1 = new buscartrenForm1();
            buscartrenForm1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            eliminartrenForm1 eliminartrenForm1 = new eliminartrenForm1();
            eliminartrenForm1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            modificartrenForm1 modificartrenForm1 = new modificartrenForm1();
            modificartrenForm1.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            agregarrutaForm1 agregarrutaForm1 = new agregarrutaForm1();
            agregarrutaForm1.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buscarutaForm1 buscarutaForm1 = new buscarutaForm1();
            buscarutaForm1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            eliminarrutaForm1 eliminarrutaForm1 = new eliminarrutaForm1();
            eliminarrutaForm1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            modificarrutaForm1 modificarrutaForm1 = new modificarrutaForm1();
            modificarrutaForm1.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            agregarvagonForm1 agregarvagonForm1 = new agregarvagonForm1();
            agregarvagonForm1.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            buscarvagonForm1 buscarvagonForm1 = new buscarvagonForm1();
            buscarvagonForm1.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            eliminarvagonForm1 eliminarvagonForm1 = new eliminarvagonForm1();
            eliminarvagonForm1.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mostrarvagonesForm1 mostrarvagonesForm1 = new mostrarvagonesForm1();
            mostrarvagonesForm1.Show();
            this.Hide();
        }
    }
}
