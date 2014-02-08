using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Curso.AplicacionFinal.WCF.Modelo;

namespace Curso.AplicacionFinal.WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAlumnoService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAlumnoService
    {
        [OperationContract]
        List<Alumnos> GetAlumnos();

        [OperationContract]
        Alumnos GetAlumnoById(int id);

        [OperationContract]
        void SaveAlumno(Alumnos alumno);

        [OperationContract]
        void DeleteAlumno(Alumnos alumno);
    }
}
