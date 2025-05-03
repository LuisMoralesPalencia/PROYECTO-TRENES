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
    public partial class confirmarmodificarrutaForm1 : Form
    {
        public confirmarmodificarrutaForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modificarrutaForm1 modificarrutaForm1 = new modificarrutaForm1();
            modificarrutaForm1.Show();
            this.Hide();
        }
    }
}
