using Application.Dto;
using Domain.Entities;
using FluentValidation;
using System;

namespace Application.Validators
{
    public class InscriptionValidator : AbstractValidator<InscriptionDto>
    {
        public InscriptionValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.SortieId).NotEmpty().NotNull();
            RuleFor(x => x.ParticipantId).NotEmpty().NotNull();

        }
    }
}
