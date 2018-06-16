using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Preguntados.Models;
using Preguntados.Repository;

namespace Preguntados.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Resultado()
        {
            var r = new PreguntasRepository();
            var p = r.GetAllPreguntas();
            var x = p.Where(fa => fa.Id == 1).FirstOrDefault();
            return View();
        }

        [HttpGet]
        public IActionResult Preguntar(bool respuesta, bool resultado)
        {

            var r = new PreguntasRepository();
            var p = r.GetAllPreguntas();
            var x = p.Where(fa => fa.Id == 2).FirstOrDefault();

            if (respuesta)
            {
                if (resultado)
                {
                    ViewData["Respuesta"] = "Correcto";
                }

                else
                {
                    ViewData["Respuesta"] = "Incorrecto";
                }

                ViewData["Mostrar"] = "true";
            }
            else
            {
                ViewData["Mostrar"] = "false";
            }
            

            return View(x);
        }

        [HttpPost]
        public IActionResult Preguntar()
        {
            var idPregunta = Convert.ToInt32(Request.Form["id"]);
            var idRespuesta = Convert.ToInt32(Request.Form["respuesta"]);

            var r = new PreguntasRepository();
            var p = r.GetAllPreguntas();
            var x = p.Where(fa => fa.Id == idPregunta).FirstOrDefault().Respuestas;
            var y = x.Where(t => t.Id == idRespuesta).FirstOrDefault();

            bool resultado = false;
            if (y.Correcta)
            {
                resultado = true;
            }

            return Redirect("/Home/Preguntar?respuesta=true&resultado=" + resultado);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
