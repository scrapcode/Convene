using System;
using Convene.Application.Activities.Commands;
using FluentValidation;

namespace Convene.Application.Activities.Validators;

public class CreateActivityValidator : AbstractValidator<CreateActivity.Command>
{
    public CreateActivityValidator()
    {
        RuleFor(x => x.ActivityDto.Title).NotEmpty().WithMessage("Title is required.");
        RuleFor(x => x.ActivityDto.Description).NotEmpty().WithMessage("Description is required.");
    }
}
