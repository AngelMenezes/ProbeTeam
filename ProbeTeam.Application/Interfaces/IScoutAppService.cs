using ProbeTeam.Application.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Application.Interfaces
{
    public interface IScoutAppService
    {
        bool AddScout(ScoutViewModel scoutViewModel);
        IEnumerable<ScoutViewModel> GetAllScouts();
        void UpdateScout(ScoutViewModel scoutViewModel);
        void DeleteScout(Guid scoutId);
    }
}
