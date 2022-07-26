using VideogamesStore.Models.Base;

namespace VideogamesStore.Models.Dtos
{
    public class UpdateVideogameDto : CreateVideogameDto, IHasId
    {
       public int Id { get; set; }
    }
}
