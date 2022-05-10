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
            filmes.Add(new Filme(1,"Interstelar","Nolan",DateTime.Now));
            filmes.Add(new Filme(2,"Star Wars VI","George Lucas",DateTime.Now));
            filmes.Add(new Filme(3,"Yu You Hakusho o filme","Yoshiriro Togashi",DateTime.Now));
            filmes.Add(new Filme(4,"Naruto","Top",DateTime.Now));
            filmes.Add(new Filme(5,"Akira","Top2",DateTime.Now));
            filmes.Add(new Filme(6,"Jujutsu kaisen","Top3",DateTime.Now));
        }

        public List<Filme> listarFilmes(){
            return filmes;
        }

        public Filme encontrarFilme(long id){
            return filmes.Find(filme => filme.Id == id);
        }
    }
}