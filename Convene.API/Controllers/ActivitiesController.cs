using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Convene.Application.Activities.Queries;
using Convene.Domain;
using Convene.Application.Activities.Commands;
using Convene.Application.Activities.DTOs;

namespace Convene.API.Controllers;

public class ActivitiesController : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        return await Mediator.Send(new GetActivityList.Query());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetActivityDetail(string id)
    {
        return HandleResult(await Mediator.Send(new GetActivityDetails.Query { Id = id }));
    }

    [HttpPost]
    public async Task<ActionResult<string>> CreateActivity(CreateActivityDto activityDto)
    {
        return HandleResult(await Mediator.Send( new CreateActivity.Command { ActivityDto = activityDto }));
    }

    [HttpPut]
    public async Task<ActionResult> EditActivity(EditActivityDto activityDto)
    {
        return HandleResult(await Mediator.Send(new EditActivity.Command { ActivityDto = activityDto }));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteActivity(string id)
    {
        return HandleResult(await Mediator.Send(new DeleteActivity.Command { Id = id }));
    }
}
