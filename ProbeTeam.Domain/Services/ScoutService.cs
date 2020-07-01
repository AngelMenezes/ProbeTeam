using ProbeTeam.Domain.Entities;
using ProbeTeam.Domain.Interfaces.Repositories;
using ProbeTeam.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Domain.Services
{
    public class ScoutService : IScoutService
    {
        private readonly IScoutRepository repository;

        public ScoutService(IScoutRepository repository)
        {
            this.repository = repository;
        }

        public Scout AddScout(Scout scout)
        {
            scout.Id = Guid.NewGuid();
            repository.Create(scout);
            repository.SaveChanges();
            return scout;
        }

        public IEnumerable<Scout> GetAllScouts()
        {
            return repository.ReadAll();
        }

        public void UpdateScout(Scout scout)
        {
            repository.Update(scout);
            repository.SaveChanges();
        }
        public void DeleteScout(Guid scoutId)
        {
            repository.Delete(scoutId);
            repository.SaveChanges();
        }
    }
}
