using Application.Dto;
using Application.Services;
using Application.Validators;
using Domain.Entities;
using FluentValidation;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace SortieApp.Application
{
    public static class ApplicationService
    {
        public static IServiceCollection ConfigureApplicationService(this IServiceCollection services)
        {
            services.AddScoped<ISortieService, SortieService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IParticipantService, ParticipantService>();
            services.AddScoped<ILieuService, LieuService>();
            services.AddScoped<IEtatService, EtatService>();
            services.AddScoped<IInscriptionService, InscriptionService>();

            services.AddAutoMapper(configurations => configurations.CreateMap<EtatDto, Etat>());
            services.AddAutoMapper(configurations => configurations.CreateMap<LieuDto, Lieu>());
            services.AddAutoMapper(configurations => configurations.CreateMap<InscriptionDto, Inscription>());
            services.AddAutoMapper(configurations => configurations.CreateMap<ParticipantDto, Participant>());
            services.AddAutoMapper(configurations => configurations.CreateMap<RoleDto, Role>());
            services.AddAutoMapper(configurations => configurations.CreateMap<SortieDto, Sortie>());

            services.AddAutoMapper(configurations => configurations.CreateMap<Lieu, LieuSortie>())
                .AddAutoMapper(configurations => configurations.CreateMap<Etat, EtatSortie>())
                .AddAutoMapper(configurations => configurations.CreateMap<Inscription, InscriptionSortie>())
                .AddAutoMapper(configurations => configurations.CreateMap<Participant, ParticipantSortie>())
                .AddAutoMapper(configurations => configurations.CreateMap<Role, RoleSortie>())
                .AddAutoMapper(configurations => configurations.CreateMap<Sortie, SortieSortie>())
                .AddAutoMapper(configurations => configurations.CreateMap<SortieSortie, Sortie>());


            services.AddScoped<IValidator<EtatDto>, EtatValidator>();
            services.AddScoped<IValidator<ParticipantDto>, ParticipantValidator>();
            services.AddScoped<IValidator<LieuDto>, LieuValidator>();
            services.AddScoped<IValidator<RoleDto>, RoleValidator>()
                .AddScoped<IValidator<SortieDto>, SortieValidator>()
                .AddScoped<IValidator<InscriptionDto>, InscriptionValidator>();


            return services;
        }

    }
}
