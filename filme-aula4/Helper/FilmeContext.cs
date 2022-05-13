using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using filme.Entity;
using Microsoft.EntityFrameworkCore;

namespace filme.Helper
{
    public class FilmeContext: DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opt) : base(opt){
            
        }
        public DbSet<Filme> Filmes {get; set;}
        public DbSet<Diretor> Diretores {get; set;}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            var filme = modelBuilder.Entity<Filme>()
                .HasOne(filme => filme.Diretor)
                .WithOne(diretor => diretor.Filme)
                .HasForeignKey<Diretor>(diretor => diretor.FilmeId);
           

            var diretor = modelBuilder.Entity<Diretor>()
                .HasOne(diretor => diretor.Filme)
                .WithOne(filme => filme.Diretor)
                .HasForeignKey<Filme>(filme => filme.DiretorId);;
            
        }
    }
}