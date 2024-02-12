using Application.Dto;
using Application.Services;
using Application.Validators;
using Domain.Entities;
using FluentValidation;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

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

            services.AddScoped<AbstractValidator<ParticipantDto>, ParticipantValidator>();
            services.AddScoped<IValidator<SortieDto>, SortieValidator>();
            services.AddScoped<IValidator<EtatDto>, EtatValidator>();
            services.AddScoped<IValidator<LieuDto>, LieuValidator>();
            services.AddScoped<IValidator<RoleDto>, RoleValidator>();
            services.AddScoped<IValidator<InscriptionDto>, InscriptionValidator>();


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
