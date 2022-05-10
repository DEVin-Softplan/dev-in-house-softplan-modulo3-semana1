using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filme.Entity
{
    public class Filme
    {
        public Filme(string titulo, string diretor, DateTime dataLançamento)
        {
            Titulo = titulo;
            Diretor = diretor;
            DataLançamento = dataLançamento;
        }

        public string Titulo{get; set;}
        public string Diretor{get; set;}
        public DateTime DataLançamento{get; set;}
        
    }
}