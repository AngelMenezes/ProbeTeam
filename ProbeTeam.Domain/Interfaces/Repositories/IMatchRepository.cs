using ProbeTeam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Domain.Interfaces.Repositories
{
    public interface IMatchRepository : IRepository<Guid, Match>
    {
    }
}
