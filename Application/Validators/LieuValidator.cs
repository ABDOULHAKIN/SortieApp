using Application.Dto;
using FluentValidation;
using System;

namespace Application.Validators
{
    public class LieuValidator : AbstractValidator<LieuDto>
    {
        public LieuValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Etablissement).NotNull().NotEmpty();
            RuleFor(x => x.Adresse).NotNull().NotEmpty();
            RuleFor(x => x.CodePostale).NotNull().NotEmpty();
            RuleFor(x => x.CoordonneesGps).NotNull().NotEmpty();

        }
    }
}
