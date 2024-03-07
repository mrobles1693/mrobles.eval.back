using repository;
using repository.Interfaces;

namespace services
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IPeliculaRepository, PeliculaRepository>();
            services.AddScoped<ISalaPeliculaRepository, SalaPeliculaRepository>();
        }
    }
}
