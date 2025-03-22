using System;
using AutoMapper;
using Convene.Application.Activities.DTOs;
using Convene.Application.Core;
using Convene.Domain;
using Convene.Persistence;
using MediatR;

namespace Convene.Application.Activities.Commands;

public class CreateActivity
{
    public class Command : IRequest<Result<string>>
    {
        public required CreateActivityDto ActivityDto { get; set; }
    }

    public class Handler(AppDbContext context, IMapper mapper) : IRequestHandler<Command, Result<string>>
    {
        public async Task<Result<string>> Handle(Command request, CancellationToken cancellationToken)
        {
            var activity = mapper.Map<Activity>(request.ActivityDto);

            context.Activities.Add(activity);

            var result = await context.SaveChangesAsync(cancellationToken) > 0;

            if (!result) return Result<string>.Failure("Failed to create activity", 400);

            return Result<string>.Success(activity.Id);
        }
    }
}
