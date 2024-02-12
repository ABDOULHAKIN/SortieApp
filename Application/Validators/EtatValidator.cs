using Application.Dto;
using FluentValidation;
using System;

namespace Application.Validators
{
    public class EtatValidator : AbstractValidator<EtatDto>
    {
        public EtatValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Libelle).NotNull().NotEmpty();
        }
    }
}
