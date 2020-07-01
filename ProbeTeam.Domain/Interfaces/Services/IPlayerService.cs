using ProbeTeam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Domain.Interfaces.Services
{
    public interface IPlayerService
    {
        Player AddPlayer(Player player);
        IEnumerable<Player> GetAllPlayers();
        void UpdatePlayer(Player player);
        void DeletePlayer(Guid playerId);
    }
}
