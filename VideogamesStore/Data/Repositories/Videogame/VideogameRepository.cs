using Microsoft.EntityFrameworkCore;
using VideogamesStore.Data.Base;
using VideogamesStore.Models.Entities;

namespace VideogamesStore.Data.Repositories
{
    public class VideogameRepository : RepositoryBase<Videogame, ApplicationDbContext>, IVideogameRepository
    {
        public VideogameRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
