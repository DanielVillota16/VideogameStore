using AutoMapper;
using VideogamesStore.Models.Entities;

namespace VideogamesStore.Models.Dtos.AutoMapper
{
    public class VideogameProfile : Profile
    {
        public VideogameProfile()
        {
            CreateMap<CreateVideogameDto, Videogame>();
            CreateMap<UpdateVideogameDto, Videogame>();
            CreateMap<Videogame, VideogameDto>();
        }
    }
}
