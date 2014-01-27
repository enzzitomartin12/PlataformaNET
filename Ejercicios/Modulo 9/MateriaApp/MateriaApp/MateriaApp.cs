using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MateriaApp
{
    public partial class MateriaApp : Form
    {
        public MateriaApp()
        {
            InitializeComponent();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarAlumno fBuscarAlumno = new BuscarAlumno();
            fBuscarAlumno.Visible = true;
        }
    }
}
