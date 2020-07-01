using ProbeTeam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Domain.Interfaces.Services
{
    public interface ITeamService
    {
        Team AddTeam(Team team);
        IEnumerable<Team> GetAllTeams();
        void UpdateTeam(Team team);
        void DeleteTeam(Guid teamId);
    }
}
