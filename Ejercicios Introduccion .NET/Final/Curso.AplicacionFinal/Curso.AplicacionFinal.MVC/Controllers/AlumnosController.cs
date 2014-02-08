using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Curso.AplicacionFinal.MVC.AlumnoService;

namespace Curso.AplicacionFinal.MVC.Controllers
{
    public class AlumnosController : Controller
    {
        //
        // GET: /Alumnos/

        public ActionResult Listar()
        {
            AlumnoServiceClient client = new AlumnoServiceClient();
            
            List<Alumnos> result = client.GetAlumnos();

            return View(result);
        }

        public ActionResult Editar(int id)
        {
            AlumnoServiceClient client = new AlumnoServiceClient();

            Alumnos alumno = client.GetAlumnoById(id);

            return View(alumno);
        }

        [HttpPost]
        public ActionResult Editar(Alumnos alumno)
        {
            AlumnoServiceClient client = new AlumnoServiceClient();

            client.SaveAlumno(alumno);

            return RedirectToAction("Listar");
        }


        public ActionResult Consultar(int id)
        {
            AlumnoServiceClient client = new AlumnoServiceClient();

            Alumnos alumno = client.GetAlumnoById(id);

            return View(alumno);
        }

        public ActionResult Eliminar(int id)
        {
            AlumnoServiceClient client = new AlumnoServiceClient();

            Alumnos alumno = client.GetAlumnoById(id);

            return View(alumno);
        }

        [HttpPost]
        public ActionResult Eliminar(Alumnos alumno)
        {
            AlumnoServiceClient client = new AlumnoServiceClient();

            client.DeleteAlumno(alumno);

            return RedirectToAction("Listar");
        }

        public ActionResult Crear()
        {
            Alumnos alumno = new Alumnos();

            return View(alumno);
        }

        [HttpPost]
        public ActionResult Crear(Alumnos alumno)
        {
            AlumnoServiceClient client = new AlumnoServiceClient();

            client.SaveAlumno(alumno);

            return RedirectToAction("Listar");
        }

       



    }
}
