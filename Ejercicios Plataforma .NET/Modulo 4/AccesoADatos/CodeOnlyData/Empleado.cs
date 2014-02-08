using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeOnlyData
{
    public class Empleado
    {
        public Empleado() { }
        public int IDEmpleado { get; set; }
        public string Legajo { get; set; }
        public string LoginID { get; set; }
        public Nullable<int> ManagerID { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string Genero { get; set; }
        public DateTime FechaIngreo { get; set; }
        public bool FlagSalario { get; set; }
        public short HorasVacacioens { get; set; }
        public short SickLeaveHours { get; set; }
        public bool CurrentFlag { get; set; }
        public Guid rowguid { get; set; }   
        public DateTime FechaModificacion { get; set; }
        public Contacto Contacto { get; set; }
        //public int ContactID { get; set; }
    }
}
