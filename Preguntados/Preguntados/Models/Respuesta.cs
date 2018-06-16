using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Preguntados.Models
{
    public class Respuesta
    {
        public int Id { get; set; }
        public int IdPregunta { get; set; }
        public string Enunciado { get; set; }
        public bool Correcta { get; set; }
    }
}
