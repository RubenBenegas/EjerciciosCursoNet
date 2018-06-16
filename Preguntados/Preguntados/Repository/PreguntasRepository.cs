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
            p2.Respuestas.Add(new Respuesta { Id = 5, IdPregunta = 2, Enunciado = "Tres", Correcta = false });
            p2.Respuestas.Add(new Respuesta { Id = 6, IdPregunta = 2, Enunciado = "Cuatro", Correcta = false });
            p2.Respuestas.Add(new Respuesta { Id = 7, IdPregunta = 2, Enunciado = "Cinco", Correcta = true });
            p2.Respuestas.Add(new Respuesta { Id = 8, IdPregunta = 2, Enunciado = "Seis", Correcta = false });
            _ListaPreguntas.Add(p2);

            var p3 = new Pregunta
            {
                Id = 3,
                Enunciado = "¿En qué año tuvo lugar el ataque a Pearl Harbor?",
                Categoria = Categoria.Historia,
                Respuestas = new List<Respuesta>()

            };
            p3.Respuestas.Add(new Respuesta { Id = 7, IdPregunta = 3, Enunciado = "1939", Correcta = false });
            p3.Respuestas.Add(new Respuesta { Id = 8, IdPregunta = 3, Enunciado = "1940", Correcta = false });
            p3.Respuestas.Add(new Respuesta { Id = 9, IdPregunta = 3, Enunciado = "1941", Correcta = true });
            p3.Respuestas.Add(new Respuesta { Id = 10, IdPregunta = 3, Enunciado = "1942", Correcta = false });
            _ListaPreguntas.Add(p3);

            var p4 = new Pregunta
            {
                Id = 4,
                Enunciado = "¿Cuál de los siguientes artistas es una figura clave del dadaísmo y el surrealismo?",
                Categoria = Categoria.Arte,
                Respuestas = new List<Respuesta>()

            };
            p4.Respuestas.Add(new Respuesta { Id = 11, IdPregunta = 4, Enunciado = "Max Ernst", Correcta = true });
            p4.Respuestas.Add(new Respuesta { Id = 12, IdPregunta = 4, Enunciado = "Claude Monet", Correcta = false });
            p4.Respuestas.Add(new Respuesta { Id = 13, IdPregunta = 4, Enunciado = "Vincent Van Gogh", Correcta = false });
            p4.Respuestas.Add(new Respuesta { Id = 14, IdPregunta = 4, Enunciado = "Rafael", Correcta = false });
            _ListaPreguntas.Add(p4);

            var p5 = new Pregunta
            {
                Id = 5,
                Enunciado = "¿Cuántas caras tiene un icosaedro?",
                Categoria = Categoria.Ciencias,
                Respuestas = new List<Respuesta>()

            };
            p5.Respuestas.Add(new Respuesta { Id = 15, IdPregunta = 5, Enunciado = "20", Correcta = true });
            p5.Respuestas.Add(new Respuesta { Id = 16, IdPregunta = 5, Enunciado = "16", Correcta = false });
            p5.Respuestas.Add(new Respuesta { Id = 17, IdPregunta = 5, Enunciado = "8", Correcta = false });
            p5.Respuestas.Add(new Respuesta { Id = 18, IdPregunta = 5, Enunciado = "16", Correcta = false });
            _ListaPreguntas.Add(p5);

            var p6 = new Pregunta
            {
                Id = 6,
                Enunciado = "¿Cómo se llama el protagonista de la saga Indiana Jones?",
                Categoria = Categoria.Entretenimiento,
                Respuestas = new List<Respuesta>()

            };
            p6.Respuestas.Add(new Respuesta { Id = 19, IdPregunta = 6, Enunciado = "Jack Nicholson", Correcta = false });
            p6.Respuestas.Add(new Respuesta { Id = 20, IdPregunta = 6, Enunciado = "Michael Fox", Correcta = false });
            p6.Respuestas.Add(new Respuesta { Id = 21, IdPregunta = 6, Enunciado = "Harrison Ford", Correcta = true });
            p6.Respuestas.Add(new Respuesta { Id = 22, IdPregunta = 6, Enunciado = "Robin Williams", Correcta = false });
            _ListaPreguntas.Add(p6);
            #endregion


            var p7 = new Pregunta
            {
                Id = 7,
                Enunciado = "¿Cuál fué el Mundial de fútbol que consagró a Diego Armando Maradona?",
                Categoria = Categoria.Deportes,
                Respuestas = new List<Respuesta>()
            };
            p7.Respuestas.Add(new Respuesta { Id = 23, IdPregunta = 7, Enunciado = "Argentina\'76", Correcta = false });
            p7.Respuestas.Add(new Respuesta { Id = 24, IdPregunta = 7, Enunciado = "España\'82", Correcta = false });
            p7.Respuestas.Add(new Respuesta { Id = 25, IdPregunta = 7, Enunciado = "Italia\'90", Correcta = false });
            p7.Respuestas.Add(new Respuesta { Id = 26, IdPregunta = 7, Enunciado = "México\'86", Correcta = true });

            _ListaPreguntas.Add(p7);

            var p8 = new Pregunta
            {
                Id = 8,
                Enunciado = "¿En qué país de África es el español el idioma oficial? ",
                Categoria = Categoria.Geografia,
                Respuestas = new List<Respuesta>()

            };
            p8.Respuestas.Add(new Respuesta { Id = 27, IdPregunta = 8, Enunciado = "Camerún", Correcta = false });
            p8.Respuestas.Add(new Respuesta { Id = 28, IdPregunta = 8, Enunciado = "Gabón", Correcta = false });
            p8.Respuestas.Add(new Respuesta { Id = 29, IdPregunta = 8, Enunciado = "Ghana", Correcta = true });
            p8.Respuestas.Add(new Respuesta { Id = 30, IdPregunta = 8, Enunciado = "Guinea Ecuatorial", Correcta = false });
            _ListaPreguntas.Add(p8);

            var p9 = new Pregunta
            {
                Id = 9,
                Enunciado = " ¿Cómo se llamaba el hermano de Napoleón Bonaparte ?",
                Categoria = Categoria.Historia,
                Respuestas = new List<Respuesta>()

            };
            p9.Respuestas.Add(new Respuesta { Id = 31, IdPregunta = 9, Enunciado = "Jose Bonaparte", Correcta = true });
            p9.Respuestas.Add(new Respuesta { Id = 32, IdPregunta = 9, Enunciado = "Pierre Bonaparte", Correcta = false });
            p9.Respuestas.Add(new Respuesta { Id = 33, IdPregunta = 9, Enunciado = "Pita Bonaparte", Correcta = false });
            p9.Respuestas.Add(new Respuesta { Id = 34, IdPregunta = 9, Enunciado = "Ernesto Bonaparte", Correcta = false });
            _ListaPreguntas.Add(p9);

            var p10 = new Pregunta
            {
                Id = 10,
                Enunciado = "¿Qué animal quería ser domesticado por El Principito?",
                Categoria = Categoria.Arte,
                Respuestas = new List<Respuesta>()

            };
            p10.Respuestas.Add(new Respuesta { Id = 35, IdPregunta = 10, Enunciado = "Un perro", Correcta = false });
            p10.Respuestas.Add(new Respuesta { Id = 36, IdPregunta = 10, Enunciado = "Un zorro", Correcta = true });
            p10.Respuestas.Add(new Respuesta { Id = 37, IdPregunta = 10, Enunciado = "Un gato", Correcta = false });
            p10.Respuestas.Add(new Respuesta { Id = 38, IdPregunta = 10, Enunciado = "Un lobo", Correcta = false });
            _ListaPreguntas.Add(p10);

            var p11 = new Pregunta
            {
                Id = 11,
                Enunciado = "¿Cómo se mide la fuerza del viento en el mar?",
                Categoria = Categoria.Ciencias,
                Respuestas = new List<Respuesta>()

            };
            p11.Respuestas.Add(new Respuesta { Id = 39, IdPregunta = 11, Enunciado = "Pies", Correcta = false });
            p11.Respuestas.Add(new Respuesta { Id = 40, IdPregunta = 11, Enunciado = "Nudos", Correcta = true });
            p11.Respuestas.Add(new Respuesta { Id = 41, IdPregunta = 11, Enunciado = "Zancadas", Correcta = false });
            p11.Respuestas.Add(new Respuesta { Id = 42, IdPregunta = 11, Enunciado = "Kilómetros por hora", Correcta = false });
            _ListaPreguntas.Add(p11);

            var p12 = new Pregunta
            {
                Id = 12,
                Enunciado = "¿Qué grupo interpretaba la canción \" Smells like teen spirit \"?",
                Categoria = Categoria.Entretenimiento,
                Respuestas = new List<Respuesta>()

            };
            p12.Respuestas.Add(new Respuesta { Id = 43, IdPregunta = 12, Enunciado = "Los Beatles ", Correcta = false });
            p12.Respuestas.Add(new Respuesta { Id = 44, IdPregunta = 12, Enunciado = "Led Zeppelin ", Correcta = false });
            p12.Respuestas.Add(new Respuesta { Id = 45, IdPregunta = 12, Enunciado = "Nirvana", Correcta = true });
            p12.Respuestas.Add(new Respuesta { Id = 46, IdPregunta = 12, Enunciado = "Los Rolling Stones", Correcta = false });
            _ListaPreguntas.Add(p12);

            return _ListaPreguntas;
        }
    }
}
