using System;
using Microsoft.EntityFrameworkCore;
using Convene.Domain;

namespace Convene.Persistence;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Activity> Activities { get; set; }
}
