using ProyectoValidacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoValidacion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Usuarios usuario = new Usuarios();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Index(Usuarios user)
        {
            if (ModelState.IsValid)
            {
                //Insercion de base datos 
                return RedirectToAction("MensajeOK");
            }
            return View();
        }

        public ActionResult MensajeOK()
        {
            return View();
        }
    }
}