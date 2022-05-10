using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using filme.Entity;

namespace filme.Service
{
    public class FilmeService : IFilmeService
    {
        private static List<Filme> filmes = new List<Filme>();

        public FilmeService()
        {
            filmes.Add(new Filme("Interstelar","Nolan",DateTime.Now));
            filmes.Add(new Filme("Star Wars VI","George Lucas",DateTime.Now));
            filmes.Add(new Filme("Yu You Hakusho o filme","Yoshiriro Togashi",DateTime.Now));
            filmes.Add(new Filme("Naruto","Top",DateTime.Now));
            filmes.Add(new Filme("Akira","Top2",DateTime.Now));
            filmes.Add(new Filme("Jujutsu kaisen","Top3",DateTime.Now));
        }

        public List<Filme> listarFilmes(){
            return filmes;
        }
    }
}