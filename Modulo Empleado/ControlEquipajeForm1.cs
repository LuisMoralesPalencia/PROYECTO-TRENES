﻿using System;
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
    public partial class ControlEquipajeForm1 : Form
    {
        public ControlEquipajeForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            embarqueForm1 embarqueForm1 = new embarqueForm1();
            embarqueForm1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm1 menuPrincipalForm1 = new MenuPrincipalForm1();
            menuPrincipalForm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            desembarqueForm1 desembarqueForm1 = new desembarqueForm1();
            desembarqueForm1.Show();
            this.Hide();
        }
    }
}
