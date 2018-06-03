using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraRuben.Pages
{
    public class IndexModel : PageModel
    {

        private readonly IHostingEnvironment _hostingEnvironment;

        public IndexModel(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }


        public string linea;
        public ArrayList Calculos = new ArrayList();
        public decimal? resultado;
        public string valor1 { get; set; }
        public string valor2 { get; set; }
        public string Oper { get; set; }

        public void OnGet(decimal numero1, decimal numero2, string operacion)
        {

            
            var a = Calculos;
            if (numero1 != 0 || numero2 != 0)
            {
                switch (operacion)
                {
                    case "suma":
                        Sumar(numero1, numero2);
                        break;
                    case "resta":
                        Restar(numero1, numero2);
                        break;
                    case "multiplicacion":
                        Multiplicar(numero1, numero2);
                        break;
                    case "division":
                        Dividir(numero1, numero2);
                        break;
                }
                
                GuardarCalculos(numero1, numero2, operacion);
            }
            ObtenerHistorialCalculos();

            var x = Calculos;

        }

        public ActionResult OnPost()
        {
            var n1 = Convert.ToInt32(Request.Form["numero1"]);
            var n2 = Convert.ToInt32(Request.Form["numero2"]);
            var operacion = Request.Form["operacion"];

            return Redirect("Index?numero1=" + n1 + "&numero2=" + n2 + "&operacion=" + operacion);

        }

        private void Sumar(decimal num1, decimal num2)
        {
            resultado = num1 + num2;
            Oper = "suma";
            GuardarValores(num1, num2);
        }

        private void Restar(decimal num1, decimal num2)
        {
            resultado = num1 - num2;
            Oper = "resta";
            GuardarValores(num1, num2);
        }

        private void Multiplicar(decimal num1, decimal num2)
        {
            resultado = num1 * num2;
            Oper = "multiplicacion";
            GuardarValores(num1, num2);
        }

        private void Dividir(decimal num1, decimal num2)
        {
            if (num2 != 0)
            {
                resultado = num1 / num2;
            }
            else
            {
                ViewData["Error"] = "Dividir por 0 (cero) no es posible";
                resultado = null;
            }
            
            Oper = "division";
            GuardarValores(num1, num2);
        }

        private void GuardarValores(decimal v1, decimal v2 )
        {
            valor1 = v1.ToString();
            valor2 = v2.ToString();
        }

        private void GuardarCalculos(decimal numero1, decimal numero2, string operacion)
        {
            var fileName = "Calculos.txt";
            var reportsFolder = "\\Calculos\\";
            var webRoot = _hostingEnvironment.WebRootPath;
            var path = Path.Combine(webRoot + reportsFolder, fileName);

            using (System.IO.StreamWriter esc = new StreamWriter(path, true))
            {
                switch (operacion)
                {
                    case "suma":
                        esc.WriteLine(numero1  + " + " + numero2 + " = " + (numero1 + numero2));
                        break;
                    case "resta":
                        esc.WriteLine(numero1 + " - " + numero2 + " = " + (numero1 - numero2));
                        break;
                    case "multiplicacion":
                        esc.WriteLine(numero1 + " x " + numero2 + " = " + (numero1 * numero2));
                        break;
                    case "division":
                        if (resultado != null)
                        {
                            
                        esc.WriteLine(numero1 + " / " + numero2 + " = " + (numero1 / numero2));
                        }
                        break;
                }
                

            }
        }

        private void ObtenerHistorialCalculos()
        {
            var fileName = "Calculos.txt";
            var reportsFolder = "\\Calculos\\";
            var webRoot = _hostingEnvironment.WebRootPath;
            var path = Path.Combine(webRoot + reportsFolder, fileName);


            if (System.IO.File.Exists(path))
            {
                using (StreamReader read = new StreamReader(path, false))
                {
                    while ((linea = read.ReadLine()) != null)
                    {
                        Calculos.Add(linea);
                    }
                }

                Calculos.Reverse();
            }
            
           
        }
    }

}

