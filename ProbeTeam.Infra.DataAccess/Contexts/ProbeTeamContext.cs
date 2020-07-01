using Microsoft.EntityFrameworkCore;
using ProbeTeam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Infra.DataAccess.Contexts
{
    public class ProbeTeamContext : DbContext
    {
        private readonly string dbConnectionString;

        public DbSet<Match> Matches { get; set; }
        public DbSet<Notepad> Notepads { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Scout> Scouts { get; set; }
        public DbSet<Team> Teams { get; set; }

        public ProbeTeamContext(string dbConnectionString)
        {
            this.dbConnectionString = dbConnectionString;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer(dbConnectionString);
            optionsBuilder.UseSqlite(dbConnectionString);
        }
    }
}
