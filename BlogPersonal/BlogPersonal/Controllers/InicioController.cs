using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogPersonal.Data;
using BlogPersonal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogPersonal.Controllers
{
    public class InicioController : Controller
    {
        private readonly BlogPersonalDbContext _context;

        public InicioController(BlogPersonalDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Titulo = "Bienvenidos";
            ViewBag.Descripcion = "El sitio para encontrar lo mejor de la web";
            ViewBag.Imagen = "/img/home-bg.jpg";

            var l =_context.Publicacion.ToList();

            return View(l);
        }
    }
}