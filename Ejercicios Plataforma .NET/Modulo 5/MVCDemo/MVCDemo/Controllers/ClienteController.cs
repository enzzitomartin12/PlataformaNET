using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/

        public ActionResult Index()
        {
            var clientes = new ClienteRepositorio().ObtenerClientes();
            return View(clientes);
        }

        //
        // GET: /Cliente/Details/5

        public ActionResult Details(int id)
        {
            var cliente = new ClienteRepositorio().ObtenerCliente(id);
            return View(cliente);
        }

        //
        // GET: /Cliente/Create

        public ActionResult Create()
        {

            Clientes cli = new Clientes()
            {
                IDCliente = 100
            };
            return View(cli);
        } 

        //
        // POST: /Cliente/Create

        [HttpPost]
        public ActionResult Create(Clientes Cli)
        {
            try
            {
                // TODO: Add insert logic here
                if (string.IsNullOrEmpty(Cli.Nombre))
                {
                    ModelState.AddModelError("Nombre", "El nombre es requerido");
                    return View();
                }
                new ClienteRepositorio().InsertarCliente(Cli);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Cliente/Edit/5
 
        public ActionResult Edit(int id)
        {

            Clientes cli = new ClienteRepositorio().ObtenerCliente(id);
            return View(cli);
        }

        //
        // POST: /Cliente/Edit/5

        [HttpPost]
        public ActionResult Edit(Clientes cli)
        {
            try
            {
                // TODO: Add update logic here
                new ClienteRepositorio().ActualizarCliente(cli);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Cliente/Delete/5
 
        public ActionResult Delete(int id)
        {
            Clientes cli = new ClienteRepositorio().ObtenerCliente(id);
            new ClienteRepositorio().EliminarCliente(id);
          
            TempData["Resultado"] = "Cliente Eliminado: " + cli.Nombre;
            return RedirectToAction("Index");
        }

        //
        // POST: /Cliente/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
