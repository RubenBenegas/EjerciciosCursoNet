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
        public IActionResult Resultado(bool resultado)
        {
            if (resultado)
            {
                ViewData["Respuesta"] = "Correcto";
                ViewBag.Resultado = true;
            }
            else
            {
                ViewData["Respuesta"] = "Incorrecto";
                ViewBag.Resultado = false;
            }

            return View();
       
        }

        [HttpGet]
        public IActionResult Preguntar(bool respuesta, bool resultado, int idPregunta)
        {
            Random rnd = new Random();
            var n = rnd.Next(1, 12);
            var r = new PreguntasRepository();
            var p = r.GetAllPreguntas();
            var x = p.Where(fa => fa.Id == n).FirstOrDefault();

            if (respuesta)
            {
                respuesta = false;
                return Redirect("/Home/Resultado?resultado=" + resultado);
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

            return Redirect("/Home/Preguntar?respuesta=true&resultado=" + resultado + "&idPregunta=" + idPregunta );
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
