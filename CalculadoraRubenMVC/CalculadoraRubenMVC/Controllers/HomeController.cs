using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculadoraRubenMVC.Models;
using CalculadoraRubenMVC.Repository;
using Microsoft.AspNetCore.Hosting;

namespace CalculadoraRubenMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public IActionResult Calculadora(decimal numero1, decimal numero2, string operacion, bool limpiar)
        {
            var repository = new CalculadoraRepository();

            var model = repository.ProcesarOperacion(numero1, numero2, operacion, limpiar, _hostingEnvironment);
            return View(model);
        }

        [HttpPost]
        public IActionResult Calculadora()
        {
            var repository = new CalculadoraRepository();

            //Obtenemos los valores de los inputs por medio de sus names
            var n1 = Convert.ToInt32(Request.Form["numero1"]);
            var n2 = Convert.ToInt32(Request.Form["numero2"]);
            var operacion = Request.Form["operacion"];

            //Aqui llamamos el metodo para guardar los calculos para que queden registrados en el historial
            repository.GuardarCalculos(n1, n2, operacion, _hostingEnvironment);

            //Armamos la query string donde pasaremos los valores anteriores a los parametros del OnGet()
            var queryString = "/Home/Calculadora?numero1=" + n1 + "&numero2=" + n2 + "&operacion=" + operacion;

            //Redireccionamos a la url que armamos anteriormente
            return Redirect(queryString);
        }


        
    }
}
