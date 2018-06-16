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
            #region Primera
            var p1 = new Pregunta
            {
                Id = 1,
                Enunciado = "¿Cuál es el país de origen del futbolista Lionel Messi?",
                Categoria = Categoria.Deportes,
                Respuestas = new List<Respuesta>()
            };
            p1.Respuestas.Add(new Respuesta { Id = 1, IdPregunta = 1, Enunciado = "Argentina", Correcta = true });
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

            var p3 = new Pregunta
            {
                Id = 3,
                Enunciado = "¿En qué año tuvo lugar el ataque a Pearl Harbor?",
                Categoria = Categoria.Historia,
                Respuestas = new List<Respuesta>()

            };
            p3.Respuestas.Add(new Respuesta { Id = 7, IdPregunta = 1, Enunciado = "1939", Correcta = false });
            p3.Respuestas.Add(new Respuesta { Id = 8, IdPregunta = 1, Enunciado = "1940", Correcta = false });
            p3.Respuestas.Add(new Respuesta { Id = 9, IdPregunta = 1, Enunciado = "1941", Correcta = true });
            p3.Respuestas.Add(new Respuesta { Id = 10, IdPregunta = 1, Enunciado = "1942", Correcta = false });
            _ListaPreguntas.Add(p3);

            var p4 = new Pregunta
            {
                Id = 4,
                Enunciado = "¿Cuál de los siguientes artistas es una figura clave del dadaísmo y el surrealismo?",
                Categoria = Categoria.Arte,
                Respuestas = new List<Respuesta>()

            };
            p4.Respuestas.Add(new Respuesta { Id = 11, IdPregunta = 1, Enunciado = "Max Ernst", Correcta = true });
            p4.Respuestas.Add(new Respuesta { Id = 12, IdPregunta = 1, Enunciado = "Claude Monet", Correcta = false });
            p4.Respuestas.Add(new Respuesta { Id = 13, IdPregunta = 1, Enunciado = "Vincent Van Gogh", Correcta = false });
            p4.Respuestas.Add(new Respuesta { Id = 14, IdPregunta = 1, Enunciado = "Rafael", Correcta = false });
            _ListaPreguntas.Add(p4);

            var p5 = new Pregunta
            {
                Id = 5,
                Enunciado = "¿Cuántas caras tiene un icosaedro?",
                Categoria = Categoria.Ciencias,
                Respuestas = new List<Respuesta>()

            };
            p5.Respuestas.Add(new Respuesta { Id = 15, IdPregunta = 1, Enunciado = "20", Correcta = true });
            p5.Respuestas.Add(new Respuesta { Id = 16, IdPregunta = 1, Enunciado = "16", Correcta = false });
            p5.Respuestas.Add(new Respuesta { Id = 17, IdPregunta = 1, Enunciado = "8", Correcta = true });
            p5.Respuestas.Add(new Respuesta { Id = 18, IdPregunta = 1, Enunciado = "16", Correcta = false });
            _ListaPreguntas.Add(p5);

            var p6 = new Pregunta
            {
                Id = 6,
                Enunciado = "¿Cómo se llama el protagonista de la saga Indiana Jones?",
                Categoria = Categoria.Entretenimiento,
                Respuestas = new List<Respuesta>()

            };
            p6.Respuestas.Add(new Respuesta { Id = 19, IdPregunta = 1, Enunciado = "Jack Nicholson", Correcta = false });
            p6.Respuestas.Add(new Respuesta { Id = 20, IdPregunta = 1, Enunciado = "Michael Fox", Correcta = false });
            p6.Respuestas.Add(new Respuesta { Id = 21, IdPregunta = 1, Enunciado = "Harrison Ford", Correcta = true });
            p6.Respuestas.Add(new Respuesta { Id = 22, IdPregunta = 1, Enunciado = "Robin Williams", Correcta = false });
            _ListaPreguntas.Add(p6);
            #endregion




            return _ListaPreguntas;
        }
    }
}
