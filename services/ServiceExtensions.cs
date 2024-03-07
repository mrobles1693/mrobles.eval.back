using repository;
using repository.Interfaces;

namespace services
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IGeneroPeliculaRepository, GeneroPeliculaRepository>();
            services.AddScoped<IGeneroRepository, GeneroRepository>();
            services.AddScoped<IPeliculaRepository, PeliculaRepository>();
            services.AddScoped<IReservaRepository, ReservaRepository>();
            services.AddScoped<ISalaPeliculaRepository, SalaPeliculaRepository>();
            services.AddScoped<ISalaRepository, SalaRepository>();
            services.AddScoped<ITipoDocumentoRepository, TipoDocumentoRepository>();
        }
    }
}
