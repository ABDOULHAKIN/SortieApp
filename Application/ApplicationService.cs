using Application.Dto;
using Application.Services;
using Domain.Entities;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace SortieApp.Application
{
    public static class ApplicationService
    {
        public static IServiceCollection ConfigureApplicationService(this IServiceCollection services)
        {
            services.AddScoped<ISortieService, SortieService>();
            services.AddScoped<IEtatService, EtatService>();
            services.AddScoped<IParticipantService, ParticipantService>();
            services.AddScoped<ILieuService, LieuService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IInscriptionService, InscriptionService>();

            services.AddAutoMapper(Configuration => Configuration.CreateMap<SortieDto, Sortie>());
            services.AddAutoMapper(Configuration => Configuration.CreateMap<EtatDto, Etat>());
            services.AddAutoMapper(Configuration => Configuration.CreateMap<ParticipantDto, Participant>());
            services.AddAutoMapper(Configuration => Configuration.CreateMap<LieuDto, Lieu>());
            services.AddAutoMapper(Configuration => Configuration.CreateMap<RoleDto, Role>());
            services.AddAutoMapper(Configuration => Configuration.CreateMap<InscriptionDto, Inscription>());

            return services;
        }

    }
}
