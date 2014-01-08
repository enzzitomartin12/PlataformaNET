using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrabajoConLINQ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext contexto = new DataClasses1DataContext();

            var datosCliente = from tProyecto in contexto.Proyectos
                               from tClientes in contexto.Clientes
                               where tClientes.IDCliente == tProyecto.IDCliente
                               group tClientes by tClientes.Nombre into Cli
                               select new
                                {
                                    nombre = Cli.Key,
                                    Cantidad = Cli.Count()
                                };

            this.dataGridView1.DataSource = datosCliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Proy = new Proyectos
            {
                IDCliente = 1,
                Nombre = "Proyecto Z",
                Descripcion = "jjjjjjjj",
                IDProyecto = 44
            };

            var miContexto = new DataClasses1DataContext();
            miContexto.Proyectos.InsertOnSubmit(Proy);
            miContexto.SubmitChanges();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Form1_Load(this, e);
        }
    }
}
