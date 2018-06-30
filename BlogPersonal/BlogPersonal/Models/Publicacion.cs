using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPersonal.Models
{
    public class Publicacion
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Subtitulo { get; set; }

        public string Cuerpo { get; set; }

        public string Foto { get; set; }

        public string Autor { get; set; }

        public DateTime Fecha { get; set; }
    }
}
