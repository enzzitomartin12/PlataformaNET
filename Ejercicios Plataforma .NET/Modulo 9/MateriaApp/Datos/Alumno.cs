using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public partial class Alumno
    {
        public Alumno BuscarporLegajo(string Legajo)
        {
            var miMateria = new DataClasesDataContext();
            Alumno a = new Alumno();


            var unAlumno = from alumno in miMateria.Alumno
                           where (alumno.Legajo == Legajo)
                           select alumno;

            a = unAlumno.First();
            return a;
            
       }

        public void BuscarporNombre()
        {}

    }
}
