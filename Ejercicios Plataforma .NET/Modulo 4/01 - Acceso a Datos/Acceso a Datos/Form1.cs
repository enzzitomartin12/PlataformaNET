using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccesoADatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Se establece la cadena de conexión con la base de datos (Capa Conectada)
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Proyectos;Integrated Security=SSPI";
            conn.Open();

            //Se define el adaptador con el fuente de datos (Capa conectada)
            SqlDataAdapter MiAdaptador = new SqlDataAdapter("SELECT * FROM Clientes", conn);

            //Se define el objeto que mantendrá los datos extraidos para su manipulación (Capa desconectada)
            DataSet MiDataSet = new DataSet();
            //Se llena el el objeto con los datos extraidos
            MiAdaptador.Fill(MiDataSet);

            //Se muestran los objetos recuperados
            textBox1.Text = "";
            foreach (DataTable tabla in MiDataSet.Tables)
            {
                textBox1.Text = textBox1.Text + "Tabla: " + tabla.TableName + "\n";
                foreach (DataColumn columna in tabla.Columns)
                {
                    textBox1.Text = textBox1.Text + "Columna: " + columna.ColumnName + "\t" +
                                    "Tipo: " + columna.DataType.Name + "\n";
                }
            }
            
           conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
