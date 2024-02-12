using Application.Dto;
using FluentValidation;
using System;

namespace Application.Validators
{
    public class RoleValidator : AbstractValidator<RoleDto>
    {
        public RoleValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Libelle).NotNull().NotEmpty();
        }
    }
}
