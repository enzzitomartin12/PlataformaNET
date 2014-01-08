using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class ClienteRepositorio
    {

        private ProyectoDataClassesDataContext m_ctx = new ProyectoDataClassesDataContext();
        public int InsertarCliente(Clientes Cli)
        {
            m_ctx.Clientes.InsertOnSubmit(Cli);
            m_ctx.SubmitChanges();
            return Cli.IDCliente;
        }

        public void ActualizarCliente(Clientes Cli)
        {
            var ClienteActual =
            (from CliActual in m_ctx.Clientes
             where CliActual.IDCliente == Cli.IDCliente
             select CliActual)
            .SingleOrDefault();
            if (ClienteActual != null)
                {
                    ClienteActual.Nombre = Cli.Nombre;
                    ClienteActual.IDContacto = Cli.IDContacto;
                    ClienteActual.Calle = Cli.Calle;
                    ClienteActual.Numero = Cli.Numero;
                    ClienteActual.Piso = Cli.Piso;
                    ClienteActual.Departamento = Cli.Departamento;
                    ClienteActual.Cuidad = Cli.Cuidad;
                    ClienteActual.Provincia = Cli.Provincia;
                    ClienteActual.Pais = Cli.Pais;
                    ClienteActual.Telefono = Cli.Telefono;
                    ClienteActual.Web = Cli.Web;
                    
                }
            m_ctx.SubmitChanges();
        }

        public Clientes ObtenerCliente(int IDCli)
        {
            return
            (from Cli in m_ctx.Clientes
             where Cli.IDCliente == IDCli
             select Cli)
            .SingleOrDefault();
        }

        public List<Clientes> ObtenerClientes()
        {
            return
            (from Cli in m_ctx.Clientes
             select Cli)
            .ToList();
        }

        public void EliminarCliente(int IDCli)
        {
            var cliente =
            (from Cli in m_ctx.Clientes
             where Cli.IDCliente == IDCli
             select Cli)
            .SingleOrDefault();
            m_ctx.Clientes.DeleteOnSubmit(cliente);
            m_ctx.SubmitChanges();
        }
    }
}