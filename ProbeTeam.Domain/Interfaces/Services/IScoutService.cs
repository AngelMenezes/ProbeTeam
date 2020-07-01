using ProbeTeam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Domain.Interfaces.Services
{
    public interface IScoutService
    {
        Scout AddScout(Scout scout);
        IEnumerable<Scout> GetAllScouts();
        void UpdateScout(Scout scout);
        void DeleteScout(Guid scoutId);
    }
}
