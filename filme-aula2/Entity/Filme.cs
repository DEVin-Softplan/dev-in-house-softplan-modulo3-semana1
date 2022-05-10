using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filme.Entity
{
    public class Filme
    {
        public Filme(long id,string titulo, string diretor, DateTime dataLançamento)
        {
            Id = id;
            Titulo = titulo;
            Diretor = diretor;
            DataLançamento = dataLançamento;
        }

        public long Id{get; set;}
        public string Titulo{get; set;}
        public string Diretor{get; set;}
        public DateTime DataLançamento{get; set;}
        
    }
}