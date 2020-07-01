using ProbeTeam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Domain.Interfaces.Services
{
    public interface IMatchService
    {
        Match AddMatch(Match match);
        IEnumerable<Match> GetAllMatches();
        void UpdateMatch(Match match);
        void DeleteMatch(Guid matchId);
    }
}
