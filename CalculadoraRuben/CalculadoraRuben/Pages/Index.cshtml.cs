using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraRuben.Pages
{
    public class IndexModel : PageModel
    {
        public decimal? resultado;
        public bool MostrarResultado { get; set; }
        public string valor1 { get; set; }
        public string valor2 { get; set; }
        public string Oper { get; set; }

        public void OnGet(decimal numero1, decimal numero2, string operacion)
        {
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
                
                
            }

        }

        public ActionResult OnPost()
        {
            MostrarResultado = false;
            //Obtiene los valores del formulario, segun name
            var n1 = Convert.ToInt32(Request.Form["numero1"]);
            var n2 = Convert.ToInt32(Request.Form["numero2"]);
            var operacion = Request.Form["operacion"];
            //Redirecciona Al GET con los parametros que enviamos
            return Redirect("Index?numero1=" + n1 + "&numero2=" + n2 + "&operacion=" + operacion);

        }

        private void Sumar(decimal num1, decimal num2)
        {
            resultado = num1 + num2;
            MostrarResultado = true;
            Oper = "suma";
            GuardarValores(num1, num2);
        }

        private void Restar(decimal num1, decimal num2)
        {
            resultado = num1 - num2;
            MostrarResultado = true;
            Oper = "resta";
            GuardarValores(num1, num2);
        }

        private void Multiplicar(decimal num1, decimal num2)
        {
            resultado = num1 * num2;
            MostrarResultado = true;
            Oper = "multiplicacion";
            GuardarValores(num1, num2);
        }

        private void Dividir(decimal num1, decimal num2)
        {
            resultado = num1 / num2;
            MostrarResultado = true;
            Oper = "division";
            GuardarValores(num1, num2);
        }

        private void GuardarValores(decimal v1, decimal v2 )
        {
            valor1 = v1.ToString();
            valor2 = v2.ToString();
        }
    }
}