using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using filme.Dto;
using filme.Entity;

namespace filme.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile(){
            CreateMap<Filme,FilmeGetDto>();
            CreateMap<List<Filme>,List<FilmeGetDto>>();
            CreateMap<Filme,FilmePutRespostaDto>();
            CreateMap<FilmePutDto,Filme>();
            CreateMap<FilmePostDto, Filme>();
        }
    }
}