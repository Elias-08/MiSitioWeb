using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using MiSitioWeb.Models;

namespace MiSitioWeb.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index ()
        {       
                ViewBag.Fecha = DateTime.Now;    

                return View(new Asignatura{Nombre="Moral y Civica", 
                UniqueId= Guid.NewGuid().ToString()});
        }
        public IActionResult MultiAsignatura ()
        {
            var ListaAsignaturas = new List<Asignatura>()
            {
                new Asignatura{Nombre="Programación", 
                UniqueId= Guid.NewGuid().ToString()},

                new Asignatura{Nombre="Matemáticas", 
                UniqueId= Guid.NewGuid().ToString()},

                new Asignatura{Nombre="Ciencias Naturales", 
                UniqueId= Guid.NewGuid().ToString()},

                new Asignatura{Nombre="Ciencias Sociales", 
                UniqueId= Guid.NewGuid().ToString()},

                new Asignatura{Nombre="Moral y Civica", 
                UniqueId= Guid.NewGuid().ToString()}
            };

            ViewBag.Fecha = DateTime.Now;
        
            return View("MultiAsignatura",ListaAsignaturas);
        }
    }
}