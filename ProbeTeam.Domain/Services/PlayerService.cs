using ProbeTeam.Domain.Entities;
using ProbeTeam.Domain.Interfaces.Repositories;
using ProbeTeam.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Domain.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository repository;
        public PlayerService(IPlayerRepository repository)
        {
            this.repository = repository;
        }

        public Player AddPlayer(Player player)
        {
            throw new NotImplementedException();
        }

        public void DeletePlayer(Guid playerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Player> GetAllPlayers()
        {
            throw new NotImplementedException();
        }

        public void UpdatePlayer(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
