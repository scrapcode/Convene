using System;
using Convene.Application.Activities.Commands;
using Convene.Application.Activities.DTOs;
using FluentValidation;

namespace Convene.Application.Activities.Validators;

public class CreateActivityValidator : BaseActivityValidator<CreateActivity.Command, CreateActivityDto>
{
    public CreateActivityValidator() : base(x => x.ActivityDto)
    {
    }
}
