using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BlogPersonal.Data;
using BlogPersonal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogPersonal.Controllers
{
    public class AdministradorController : Controller
    {
        private readonly BlogPersonalDbContext _context;

        public AdministradorController(BlogPersonalDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var l = _context.Publicacion.ToList();
            ViewBag.Titulo = "Administrador";
            ViewBag.Descripcion = "Agrega, edita y elimina las entradas de tu blog";
            ViewBag.Imagen = "/img/home-bg.jpg";
            return View(l);
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            Publicacion publicacion = new Publicacion();
            ViewBag.Disabled = "";
            ViewBag.Titulo = "Agregar";
            ViewBag.Descripcion = "Agrega una nueva entrada a tu blog";
            ViewBag.Imagen = "/img/home-bg.jpg";
            ViewBag.Accion = "Agregar";
            return View("Formulario", publicacion);
        }

        [HttpPost]
        public IActionResult Agregar(Publicacion publicacion)
        {
            publicacion.Titulo = Request.Form["Titulo"];
            publicacion.Subtitulo = Request.Form["Subtitulo"];
            publicacion.Autor = Request.Form["Autor"];
            publicacion.Fecha = Convert.ToDateTime(Request.Form["Fecha"]);
            publicacion.Cuerpo = Request.Form["Cuerpo"];

            _context.Publicacion.Add(publicacion);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            Publicacion publicacion = _context.Publicacion.Find(id);
            if (publicacion == null)
            {
                return HttpNotFound();
            }
            ViewBag.Disabled = "";
            ViewBag.Titulo = "Editar";
            ViewBag.Descripcion = "Edita una entrada existente en tu blog";
            ViewBag.Imagen = "/img/home-bg.jpg";
            ViewBag.Accion = "Editar";
            return View("Formulario", publicacion);
        }

        [HttpPost]
        public ActionResult Editar(int id, Publicacion publicacion)
        {
            if (ModelState.IsValid)
            {
                publicacion.Titulo = Request.Form["Titulo"];
                publicacion.Subtitulo = Request.Form["Subtitulo"];
                publicacion.Autor = Request.Form["Autor"];
                publicacion.Fecha = Convert.ToDateTime(Request.Form["Fecha"]);
                publicacion.Cuerpo = Request.Form["Cuerpo"];
                _context.Entry(publicacion).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Disabled = "";
            ViewBag.Titulo = "Editar";
            ViewBag.Descripcion = "Edita una entrada existente en tu blog";
            ViewBag.Imagen = "/img/home-bg.jpg";
            ViewBag.Accion = "Editar";
            return View("Formulario",publicacion);
        }

        public ActionResult Eliminar(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult(); 
            }
            Publicacion publicacion = _context.Publicacion.Find(id);
            if (publicacion == null)
            {
                return HttpNotFound();
            }
            ViewBag.Disabled = "disabled";
            ViewBag.Titulo = "Eliminar";
            ViewBag.Descripcion = "Elimina una entrada existente en tu blog";
            ViewBag.Imagen = "/img/home-bg.jpg";
            ViewBag.Accion = "Eliminar";
            return View("Formulario",publicacion);
        }

        [HttpPost]
        public ActionResult Eliminar(int id, Publicacion publicacion)
        {
            publicacion = _context.Publicacion.Find(id);
            _context.Publicacion.Remove(publicacion);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

    }
}

