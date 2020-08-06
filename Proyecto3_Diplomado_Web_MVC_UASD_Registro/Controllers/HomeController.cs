using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto3_Diplomado_Web_MVC_UASD_Registro.Models;

namespace Proyecto3_Diplomado_Web_MVC_UASD_Registro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var coches = new List<Coche>
            {
                new Coche{Tipo ="Jepp",Marca="BMW",Modelo="X6",Color="Azul"},
                new Coche{Tipo ="Auto",Marca="Mercedes",Modelo="A200",Color="Blanco"},
                new Coche{Tipo ="Jepp",Marca="Porsche",Modelo="Cayenne",Color="Negro"},
                new Coche{Tipo ="Auto",Marca="Ford",Modelo="Mustang",Color="Rojo"},
            };

            return View(coches);
        }
        public ActionResult Persona()
        {
            var personas = new List<Persona>
            {
                new Persona{Nombre ="Carlos",Apellido="Medina"},
                new Persona{Nombre ="Miguel",Apellido="Hernandez"},
                new Persona{Nombre ="Nelson",Apellido="Lama"},
                new Persona{Nombre ="Ohalmi",Apellido="de la Rosa"},
                new Persona{Nombre ="Doris",Apellido="Gonzalez"},
                new Persona{Nombre ="Samuel",Apellido="Ferreira"},
                new Persona{Nombre ="Anthony",Apellido="Fulgencio"},
                new Persona{Nombre ="Paloma",Apellido="Moncion"},
                new Persona{Nombre ="Ohalmi",Apellido="de la Rosa"}
            };

            return View(personas);
        }
    }
}