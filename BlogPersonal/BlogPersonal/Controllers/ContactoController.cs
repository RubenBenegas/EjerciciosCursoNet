using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogPersonal.Controllers
{
    public class ContactoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Titulo = "Contacto";
            ViewBag.Descripcion = "Deje sus datos y lo contactaré";
            ViewBag.Imagen = "/img/contact-bg.jpg";

            return View();
        }
    }
}