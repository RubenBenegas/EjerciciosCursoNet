using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraRubenMVC.Models
{
    public class CalculadoraModel
    {
        //Definimos los campos y propiedades que utilizaremos
        public string Valor1 { get; set; }
        public string Valor2 { get; set; }
        public string Oper { get; set; }
        public decimal? Resultado;
        public ArrayList Calculos = new ArrayList();
        public string Error;
    }
}
