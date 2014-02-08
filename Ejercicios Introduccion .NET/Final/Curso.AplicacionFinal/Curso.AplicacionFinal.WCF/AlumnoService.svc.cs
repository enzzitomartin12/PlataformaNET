using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Curso.AplicacionFinal.WCF.Modelo;

namespace Curso.AplicacionFinal.WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AlumnoService" en el código, en svc y en el archivo de configuración a la vez.
    public class AlumnoService : IAlumnoService
    {
        masterEntities context = new masterEntities();

        public List<Alumnos> GetAlumnos()
        {
            return context.Alumnos.ToList();
        }

        public Alumnos GetAlumnoById(int id)
        {
            return context.Alumnos.FirstOrDefault(a => a.NroLegajo == id);
        }

        public void SaveAlumno(Alumnos alumno)
        {
            Alumnos alumnoSaved = new Alumnos();
            if (alumno.NroLegajo > 0)
                alumnoSaved = GetAlumnoById(alumno.NroLegajo);

            alumnoSaved.Nombre = alumno.Nombre;
            alumnoSaved.Apellido = alumno.Apellido;
            alumnoSaved.FechaNac = alumno.FechaNac;

            if (alumnoSaved.NroLegajo == 0)
                context.AddToAlumnos(alumnoSaved);

            context.SaveChanges(true);
        }

        public void DeleteAlumno(Alumnos alumno)
        {
            context.DeleteObject(alumno);

            context.SaveChanges(true);
        }
    }
}
