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

            services.AddDbContext<SortieContext> (options => options.UseSqlServer("Data Source=48SE46-4M5HHZ3;Initial Catalog=SORTIRDB;User ID=SA;Password=Pa$$w0rd;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"));

            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddDbContext<RoleContext>(options => options.UseSqlServer("Data Source=48SE46-4M5HHZ3;Initial Catalog=SORTIRDB;User ID=SA;Password=Pa$$w0rd;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"));

            services.AddScoped<IParticipantRepository, ParticipantRepository>();
            services.AddDbContext<ParticipantContext>(options => options.UseSqlServer("Data Source=48SE46-4M5HHZ3;Initial Catalog=SORTIRDB;User ID=SA;Password=Pa$$w0rd;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"));

            services.AddScoped<ILieuRepository, LieuRepository>();
            services.AddDbContext<LieuContext>(options => options.UseSqlServer("Data Source=48SE46-4M5HHZ3;Initial Catalog=SORTIRDB;User ID=SA;Password=Pa$$w0rd;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"));

            services.AddScoped<IEtatRepository, EtatRepository>();
            services.AddDbContext<EtatContext>(options => options.UseSqlServer("Data Source=48SE46-4M5HHZ3;Initial Catalog=SORTIRDB;User ID=SA;Password=Pa$$w0rd;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"));

            services.AddScoped<IInscriptionRepository, InscriptionRepository>();
            services.AddDbContext<InscriptionContext>(options => options.UseSqlServer("Data Source=48SE46-4M5HHZ3;Initial Catalog=SORTIRDB;User ID=SA;Password=Pa$$w0rd;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"));

            // services.AddSingleton<SortieContext>();
            return services;
        }

    }
}