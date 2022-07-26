using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VideogamesStore.Controllers.Base;
using VideogamesStore.Data.Repositories;
using VideogamesStore.Models.Dtos;
using VideogamesStore.Models.Entities;

namespace VideogamesStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideogameController : CustomControllerBase<Videogame>
    {
        private const string getVideogameRouteName = "getStudent";

        public VideogameController(IVideogameRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }

        [HttpGet]
        public async Task<ActionResult<List<VideogameDto>>> Get()
        {
            return await Get<VideogameDto>();
        }

        [HttpGet("{id:int}", Name = getVideogameRouteName)]
        public async Task<ActionResult<VideogameDto>> Get (int id)
        {
            return await Get<VideogameDto>(id);
        }

        [HttpPost]
        public async Task<ActionResult<VideogameDto>> Post([FromBody] CreateVideogameDto createStudentDto)
        {
            return await Post<CreateVideogameDto, VideogameDto>(createStudentDto, getVideogameRouteName);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateVideogameDto updateVideogameDto)
        {
            return await Put<UpdateVideogameDto>(updateVideogameDto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await base.Delete(id);
        }
    }
}
