using filme.Entity;

namespace filme.Service
{
    public interface IFilmeService 
    {
        public List<Filme> listarFilmes();
        Filme encontrarFilme(long id);
    }
}