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
    public partial class confirmarmodificaciontrenForm1 : Form
    {
        public confirmarmodificaciontrenForm1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modificartrenForm1 modificartrenForm1 = new modificartrenForm1();
            modificartrenForm1.Show();
            this.Hide();
        }
    }
}
