using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogPersonal.Controllers
{
    public class AcercaDeController : Controller
    {
        // GET: /<controller>/
        public ActionResult Index()
        {
            ViewBag.Titulo = "Acerca de";
            ViewBag.Descripcion = "Este es mi blog personal";
            ViewBag.Imagen = "/img/about-bg.jpg";

            return View();
        }

    }
}