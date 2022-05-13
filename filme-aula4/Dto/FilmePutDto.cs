using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filme.Dto
{
    public class FilmePutDto
    {
        public string Titulo {get; set;}
        public string Diretor {get; set;}
        public string Genero {get; set;}
        public int Duracao {get; set;}
    }
}