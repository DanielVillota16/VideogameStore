using VideogamesStore.Data.Repositories;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class RepositoriesServiceCollection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) =>
            services.AddScoped<IVideogameRepository, VideogameRepository>();
    }
}
