using System;
using AutoMapper;
using Convene.Application.Activities.DTOs;
using Convene.Domain;

namespace Convene.Application.Core;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Activity, Activity>();
        CreateMap<CreateActivityDto, Activity>();
    }
}
