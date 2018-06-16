using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Preguntados.Models;

namespace Preguntados.Repository
{
    public class PreguntasRepository
    {
        private List<Pregunta> _ListaPreguntas;
        public PreguntasRepository()
        {
            _ListaPreguntas = new List<Pregunta>();
        }

        public List<Pregunta> GetAllPreguntas()
        {
            var p1 = new Pregunta
            {
                Id = 1,
                Enunciado = "¿Cuál es el país de origen del futbolista Lionel Messi?",
                Categoria = Categoria.Deportes,
                Respuestas = new List<Respuesta>()
            };
            p1.Respuestas.Add(new Respuesta { Id = 1, IdPregunta= 1, Enunciado = "Argentina", Correcta = true});
            p1.Respuestas.Add(new Respuesta { Id = 2, IdPregunta = 1, Enunciado = "Brasil", Correcta = false });
            p1.Respuestas.Add(new Respuesta { Id = 3, IdPregunta = 1, Enunciado = "España", Correcta = false });
            p1.Respuestas.Add(new Respuesta { Id = 4, IdPregunta = 1, Enunciado = "Chile", Correcta = false });

            _ListaPreguntas.Add(p1);

            var p2 = new Pregunta
            {
                Id = 2,
                Enunciado = "¿Con cuántos países limita Argentina ?",
                Categoria = Categoria.Geografia,
                Respuestas = new List<Respuesta>()
  
            };
            p2.Respuestas.Add(new Respuesta { Id = 5, IdPregunta = 1, Enunciado = "Tres", Correcta = false });
            p2.Respuestas.Add(new Respuesta { Id = 6, IdPregunta = 1, Enunciado = "Cuatro", Correcta = false });
            p2.Respuestas.Add(new Respuesta { Id = 7, IdPregunta = 1, Enunciado = "Cinco", Correcta = true });
            p2.Respuestas.Add(new Respuesta { Id = 8, IdPregunta = 1, Enunciado = "Seis", Correcta = false });

            _ListaPreguntas.Add(p2);

            return _ListaPreguntas;
        }
    }
}
