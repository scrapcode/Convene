using System;
using AutoMapper;
using Convene.Domain;

namespace Convene.Application.Core;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Activity, Activity>();
    }
}
