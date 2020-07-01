using ProbeTeam.Domain.Entities;
using ProbeTeam.Domain.Interfaces.Repositories;
using ProbeTeam.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Domain.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository repository;

        public TeamService(ITeamRepository repository)
        {
            this.repository = repository;
        }

        public Team AddTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public void DeleteTeam(Guid teamId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Team> GetAllTeams()
        {
            throw new NotImplementedException();
        }

        public void UpdateTeam(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
