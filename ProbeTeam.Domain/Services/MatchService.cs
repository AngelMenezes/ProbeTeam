using ProbeTeam.Domain.Entities;
using ProbeTeam.Domain.Interfaces.Repositories;
using ProbeTeam.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Domain.Services
{
    public class MatchService : IMatchService
    {
        private readonly IMatchRepository repository;

        public MatchService(IMatchRepository repository)
        {
            this.repository = repository;
        }

        public Match AddMatch(Match match)
        {
            throw new NotImplementedException();
        }

        public void DeleteMatch(Guid matchId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Match> GetAllMatches()
        {
            throw new NotImplementedException();
        }

        public void UpdateMatch(Match match)
        {
            throw new NotImplementedException();
        }
    }
}
