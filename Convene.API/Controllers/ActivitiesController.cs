using System;
using Convene.Domain;
using Convene.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Convene.API.Controllers;

public class ActivitiesController(AppDbContext context) : BaseApiController
{
    /// <summary>
    /// Retrieves a list of all activities.
    /// </summary>
    /// <remarks>
    /// This endpoint returns all activities stored in the database without any filtering.
    /// The activities are returned in their default order.
    /// </remarks>
    /// <response code="200">Returns the list of activities</response>
    /// <response code="500">If there was an internal server error</response>
    /// <returns>A list of all activities</returns>
    [HttpGet]
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        return await context.Activities.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetActivityDetail(string id)
    {
        var activity = await context.Activities.FindAsync(id);

        if (activity == null) return NotFound();

        return activity;
    }
}
