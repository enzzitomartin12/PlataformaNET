using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeOnlyData
{
    public class Contacto
    {
        public Contacto() { }
        public int IDContacto { get; set; }
        public bool EstiloNombre { get; set; }
        public string Titulo { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido { get; set; }
        public string Sufijo { get; set; }
        public string Emails { get; set; }
        public int EmailPromocion { get; set; }
        public string Telefono { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public Guid rowguid { get; set; }
        public DateTime FechaModificacion { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
}
