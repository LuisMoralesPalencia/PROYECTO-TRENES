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
    public partial class desembarqueForm1 : Form
    {
        public desembarqueForm1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ControlEquipajeForm1 controlEquipajeForm1 = new ControlEquipajeForm1();
            controlEquipajeForm1.Show();
            this.Hide();
        }
    }
}
