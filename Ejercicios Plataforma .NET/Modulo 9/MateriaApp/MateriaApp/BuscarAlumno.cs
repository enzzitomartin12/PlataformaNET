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
    public partial class BuscarAlumno : Form
    {
        
        private Datos.Alumno alumno = new Datos.Alumno();

        public BuscarAlumno()
        {
            InitializeComponent();
            MostrarDatos(alumno);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
			DialogResult r;
			r = MessageBox.Show("Quiere Salir?", "Cerrar Ventana", MessageBoxButtons.YesNo);
			if (r == DialogResult.Yes)
			{
				this.Visible = false;
			}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alumno.Legajo = textBox1.Text;
            alumno.Nombre = textBox2.Text;
            alumno.Apellido = textBox3.Text;

            Gestores.GestorAlumno gAlumno = new Gestores.GestorAlumno();
            alumno = gAlumno.BuscarAlumno(alumno);
            MostrarDatos(alumno);
        }

        public void MostrarDatos(Datos.Alumno alumno)
        {
            textBox1.Text = alumno.Legajo;
            textBox2.Text = alumno.Nombre;
            textBox3.Text = alumno.Apellido;
        }
    }
}
