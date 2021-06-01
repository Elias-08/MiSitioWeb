using System;
using Microsoft.AspNetCore.Mvc;
using MiSitioWeb.Models;

namespace MiSitioWeb.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index ()
        {
            var escuela= new Escuela();
            escuela.AFundacion=2019;
            escuela.EscuelaId= Guid.NewGuid().ToString();
            escuela.Nombre="Corex VF";
            
            return View(escuela);
        }
    }
}