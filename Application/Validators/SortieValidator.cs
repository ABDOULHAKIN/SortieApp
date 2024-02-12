using Application.Dto;
using Domain.Entities;
using FluentValidation;
using System;

namespace Application.Validators
{
    public class SortieValidator : AbstractValidator<SortieDto>
    {
        public SortieValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.DateDebut).NotNull();
            RuleFor(x => x.DateFin).NotNull();
            RuleFor(x => x.EtatId).NotNull();
            RuleFor(x => x.LieuId).NotNull();
            RuleFor(x => x.EtatId).NotNull();
        }
    }
}
