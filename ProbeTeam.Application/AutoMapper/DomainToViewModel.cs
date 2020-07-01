using AutoMapper;
using ProbeTeam.Application.Models.ViewModels;
using ProbeTeam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Application.AutoMapper
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Scout, ScoutViewModel>();
        }
    }
}
