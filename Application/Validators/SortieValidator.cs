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
            RuleFor(x => x.RoleId).NotNull();
            RuleFor(x => x.Mail).Matches("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$").NotNull().NotEmpty();
            RuleFor(x => x.Nom).NotNull().NotEmpty();
            RuleFor(x => x.Prenom).NotNull().NotEmpty();
        }
    }
}
