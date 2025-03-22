using System;
using Convene.Application.Activities.Commands;
using Convene.Application.Activities.DTOs;
using FluentValidation;

namespace Convene.Application.Activities.Validators;

public class EditActivityValidator : BaseActivityValidator<EditActivity.Command, EditActivityDto>
{
    public EditActivityValidator() : base(x => x.ActivityDto)
    {
        RuleFor(x => x.ActivityDto.Id)
            .NotEmpty().WithMessage("Id is required.");
    }
}
