using AutoMapper;
using ProbeTeam.Application.Interfaces;
using ProbeTeam.Application.Models.ViewModels;
using ProbeTeam.Domain.Entities;
using ProbeTeam.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ProbeTeam.Application.Services
{
    public class ScoutAppService : IScoutAppService
    {
        public ObservableCollection<ScoutViewModel> Scouts { get; set; }
        private IScoutService scoutService;
        private Mapper mapper;

        public ScoutAppService(IScoutService scoutService)
        {
            this.scoutService = scoutService;
            Scouts = new ObservableCollection<ScoutViewModel>();
            mapper = new Mapper(AutoMapper.AutoMapperConfig.RegisterMappings());
        }

        public bool AddScout(ScoutViewModel scoutViewModel)
        {
            //ViewModel -> Model
            var scout = mapper.Map<Scout>(scoutViewModel);
            scout = scoutService.AddScout(scout);
            if (scout == null)
                return false;

            //Model -> ViewModel
            scoutViewModel = mapper.Map<ScoutViewModel>(scout);
            Scouts.Add(scoutViewModel);

            return true;
        }

        public void DeleteScout(Guid scoutId)
        {
            scoutService.DeleteScout(scoutId);
        }

        public IEnumerable<ScoutViewModel> GetAllScouts()
        {
            var scouts = scoutService.GetAllScouts();

            //Domain -> ViewModel
            return scouts.Select(s => mapper.Map<ScoutViewModel>(s));
        }

        public void UpdateScout(ScoutViewModel scoutViewModel)
        {
            var scout = mapper.Map<Scout>(scoutViewModel);
            scoutService.UpdateScout(scout);
        }
    }
}
