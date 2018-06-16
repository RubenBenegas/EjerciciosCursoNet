using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Preguntados.Models
{
    public enum Categoria
    {
        Deportes,
        Historia,
        Geografia,
        Arte,
        Ciencias,
        Entretenimiento
    }
    public class Pregunta
    {
        public int Id { get; set; }
        public string Enunciado { get; set; }
        public Categoria Categoria { get; set; }
        public List<Respuesta> Respuestas { get; set; }
    }
}
