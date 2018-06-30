using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogPersonal.Data;
using BlogPersonal.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogPersonal.Controllers
{
    public class PublicacionController : Controller
    {
        private readonly BlogPersonalDbContext _context;

        public PublicacionController(BlogPersonalDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index(int id)
        {
            Publicacion publicacion = _context.Publicacion.Find(id);
            ViewBag.Titulo = publicacion.Titulo;
            ViewBag.Subtitulo = publicacion.Subtitulo;
            ViewBag.Autor = publicacion.Autor;
            ViewBag.Fecha = publicacion.Fecha.ToLongDateString();
            ViewBag.Foto = publicacion.Foto;
            return View(publicacion);
        }
    }
}
