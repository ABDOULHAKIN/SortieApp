using Infrastructure.Contexts;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SortieApp.Infrastructure
{
    public static class InfrastructureService
    {
        public static IServiceCollection ConfigureInfrastructureService(this IServiceCollection services)
        {
            services.AddScoped<ISortieRepository, SortieRepository>();

            services.AddDbContext<SortieContext> (options => options.UseSqlServer("Data Source=48SE46-3M5HHZ3;Initial Catalog=sortie;User ID=SA;Password=Pa$$w0rd;Trust Server Certificate=True"));
            // services.AddSingleton<SortieContext>();
            return services;
        }

    }
}