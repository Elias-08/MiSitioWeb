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
            escuela.AñoDeCreación=2019;
            escuela.UniqueId= Guid.NewGuid().ToString();
            escuela.Nombre="Corex VF";
            escuela.Pais="República Dominicana";
            escuela.Ciudad="Barahona";
            escuela.Dirección="C/Panchito Boche #6";
            escuela.TipoEscuela= TiposEscuela.Secundaria;

            
            return View(escuela);
        }
    }
}