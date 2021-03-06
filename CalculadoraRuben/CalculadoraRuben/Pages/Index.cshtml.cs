﻿using System;
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

        //Constructor
        public IndexModel(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        //Definimos los campos y propiedades que utilizaremos
        public string Valor1 { get; set; }
        public string Valor2 { get; set; }
        public string Oper { get; set; }
        public decimal? Resultado;
        public ArrayList Calculos = new ArrayList();

        public void OnGet(decimal numero1, decimal numero2, string operacion, bool limpiar)
        {
            //Armamos el path donde estaria el archivo que contendra nuestros datos
            var path = ObtenerPath();

            //Si el parametro limpiar es verdadero limpiamos el historial de los calculos
            if (limpiar)
            {
                //Llamamos el metodo d limpiar el historial
                LimpiarHistorial(path);
                return;
            }

            //Preguntamos si esta path no contiene este archivo
            if (!System.IO.File.Exists(path))
            {
                //Si no existe lo creamos y lo liberamos
                System.IO.File.Create(path).Dispose();
            }

            //Preguntamos si alguno de los numeros es distinto de 0 para poder operar
            if (numero1 != 0 || numero2 != 0)
            {
                //Llamamos el metodo para realizar los calculos
                Calcular(numero1, numero2, operacion);
            }
            //Aqui llamamos el metodo para obtener los calculos que quedaron registrados en el historial
            ObtenerHistorialCalculos(path);
        }

        public ActionResult OnPost()
        {
            //Obtenemos los valores de los inputs por medio de sus names
            var n1 = Convert.ToInt32(Request.Form["numero1"]);
            var n2 = Convert.ToInt32(Request.Form["numero2"]);
            var operacion = Request.Form["operacion"];

            //Aqui llamamos el metodo para guardar los calculos para que queden registrados en el historial
            GuardarCalculos(n1, n2, operacion);

            //Armamos la query string donde pasaremos los valores anteriores a los parametros del OnGet()
            var queryString = "Index?numero1=" + n1 + "&numero2=" + n2 + "&operacion=" + operacion;

            //Redireccionamos a la url que armamos anteriormente
            return Redirect(queryString);

        }

        private void Calcular(decimal numero1, decimal numero2, string operacion)
        {
            //Aqui pasamos el parametro operacion para saber que operacion matematica vamos a realizar
            switch (operacion)
            {
                case "suma":
                    //Llamamos el motodo para sumar pasandole los numeros en la sobrecarga
                    Sumar(numero1, numero2);
                    break;
                case "resta":
                    //Llamamos el motodo para restar pasandole los numeros en la sobrecarga
                    Restar(numero1, numero2);
                    break;
                case "multiplicacion":
                    //Llamamos el motodo para multiplicar pasandole los numeros en la sobrecarga
                    Multiplicar(numero1, numero2);
                    break;
                case "division":
                    //Llamamos el motodo para dividir pasandole los numeros en la sobrecarga
                    Dividir(numero1, numero2);
                    break;
            }
        }

        private void Sumar(decimal num1, decimal num2)
        {
            //Realizamos la operacion aritmetica
            Resultado = num1 + num2;
            //Le damos un valor a nuestra propiedad Oper para que recordar el valor de esta cuando se recarga la pagina
            Oper = "suma";
            //Llamamos el metodo para recordar los valores de nuestros numeros cuando se recarga la pagina
            GuardarValores(num1, num2);
        }

        private void Restar(decimal num1, decimal num2)
        {
            //Realizamos la operacion aritmetica
            Resultado = num1 - num2;
            //Le damos un valor a nuestra propiedad Oper para que recordar el valor de esta cuando se recarga la pagina
            Oper = "resta";
            //Llamamos el metodo para recordar los valores de nuestros numeros cuando se recarga la pagina
            GuardarValores(num1, num2);
        }

        private void Multiplicar(decimal num1, decimal num2)
        {
            //Realizamos la operacion aritmetica
            Resultado = num1 * num2;
            //Le damos un valor a nuestra propiedad Oper para que recordar el valor de esta cuando se recarga la pagina
            Oper = "multiplicacion";
            //Llamamos el metodo para recordar los valores de nuestros numeros cuando se recarga la pagina
            GuardarValores(num1, num2);
        }

        private void Dividir(decimal num1, decimal num2)
        {
            //Si el segundo numero es distinto de 0 realizamos la operacion
            if (num2 != 0)
            {
                //Realizamos la operacion aritmetica
                Resultado = num1 / num2;
            }
            else
            {
                //Creamos un ViewData para despues mostrar este mensaje en el front en caso de q se intente dividir por cero
                ViewData["Error"] = "Dividir por 0 (cero) no es posible";
                //Seteamos el resultado en null para que se muestre el mensaje anterior en el front
                Resultado = null;
            }

            //Le damos un valor a nuestra propiedad Oper para que recordar el valor de esta cuando se recarga la pagina
            Oper = "division";
            //Llamamos el metodo para recordar los valores de nuestros numeros cuando se recarga la pagina
            GuardarValores(num1, num2);
        }

        private void GuardarValores(decimal v1, decimal v2 )
        {
            //Recordamos el calor del primer numero
            Valor1 = v1.ToString();
            //Recordamos el calor del segundo numero
            Valor2 = v2.ToString();
        }

        private void GuardarCalculos(decimal numero1, decimal numero2, string operacion)
        {
            //Aqui armamos el path donde se encuentra el archivo a editar
            var path = ObtenerPath();

            //Aqui instanciamos nuestro "escritor" para editar el archivo, pasandole el path
            using (System.IO.StreamWriter esc = new StreamWriter(path, true))
            {
                //Pasamos la operacion para armar la cadena segun corresponda
                switch (operacion)
                {
                    case "suma":
                        //Agregamos una linea al archivo pasandole como sobrecarga la cadena que armamos 
                        esc.WriteLine(numero1  + " + " + numero2 + " = " + (numero1 + numero2));
                        break;
                    case "resta":
                        //Agregamos una linea al archivo pasandole como sobrecarga la cadena que armamos
                        esc.WriteLine(numero1 + " - " + numero2 + " = " + (numero1 - numero2));
                        break;
                    case "multiplicacion":
                        //Agregamos una linea al archivo pasandole como sobrecarga la cadena que armamos
                        esc.WriteLine(numero1 + " x " + numero2 + " = " + (numero1 * numero2));
                        break;
                    case "division":
                        //En el caso de que dividamos por 0 el resultado se setea como null. Por lo tanto editamos el txt solo si tenemos un resultado
                        if (numero2 != 0)
                        {
                            //Agregamos una linea al archivo pasandole como sobrecarga la cadena que armamos
                            esc.WriteLine(numero1 + " / " + numero2 + " = " + (numero1 / numero2));
                        }
                        break;
                }
            }
        }

        private void ObtenerHistorialCalculos(string path)
        {
            var linea = "";
            //Lo obtenemos solo si existe, para saber esto pasamos nuestro path como sobrecarga al siguiente metodo
            if (System.IO.File.Exists(path))
            {
                //Instanciamos nuestro "lector" y le pasamos la path
                using (StreamReader read = new StreamReader(path, false))
                {
                    //Aqui leemos linea por linea del txt
                    while ((linea = read.ReadLine()) != null)
                    {
                        //Agregamos cada linea a nuestro ArrayList de Calculos, el cual usaremos para recorrer en el frontend para mostrar cada calculo
                        Calculos.Add(linea);
                    }
                }

                //Hacemos un reverse al ArrayList de calculos para que los ultimos calculos se posicionesn al principio y los mas antiguos se pierdan de nuestra vista en el front
                Calculos.Reverse();
            }  
        }

        private void LimpiarHistorial(string path)
        {
            //Eliminamos el archivo pasandole el path
            System.IO.File.Delete(path);

        }

        private string ObtenerPath()
        {
            //Aqui armamos el path donde se encuentra o encontraria el archivo donde registrariamos los calculos
            var fileName = "Calculos.txt";
            var reportsFolder = "\\Calculos\\";
            var webRoot = _hostingEnvironment.WebRootPath;
            var path = Path.Combine(webRoot + reportsFolder, fileName);

            return path;
        }

    }

}

