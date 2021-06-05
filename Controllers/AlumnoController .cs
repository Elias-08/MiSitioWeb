using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using MiSitioWeb.Models;

namespace MiSitioWeb.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index ()
        {       
                ViewBag.Fecha = DateTime.Now;    

                return View(new Alumno{Nombre="Lucas", 
                UniqueId= Guid.NewGuid().ToString()});
        }
        public IActionResult MultiAlumno ()
        {
            var ListaAlumnos = new List<Alumno>()
            {
                new Alumno{Nombre="Pedro", 
                UniqueId= Guid.NewGuid().ToString()},

                new Alumno{Nombre="Maria", 
                UniqueId= Guid.NewGuid().ToString()},

                new Alumno{Nombre="Juan", 
                UniqueId= Guid.NewGuid().ToString()},

                new Alumno{Nombre="Papotico", 
                UniqueId= Guid.NewGuid().ToString()},

                new Alumno{Nombre="Pinocho", 
                UniqueId= Guid.NewGuid().ToString()}
            };

            ViewBag.Fecha = DateTime.Now;
        
            return View("MultiAlumno",ListaAlumnos);
        }
    }
}