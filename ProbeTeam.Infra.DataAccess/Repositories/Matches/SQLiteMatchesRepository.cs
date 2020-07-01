using ProbeTeam.Domain.Entities;
using ProbeTeam.Domain.Interfaces.Repositories;
using ProbeTeam.Infra.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProbeTeam.Infra.DataAccess.Repositories.Matches
{
    public class SQLiteMatchesRepository : EntityFrameworkRepositoryBase<Guid, Match>, IMatchRepository
    {
        public SQLiteMatchesRepository(string devicePlatform)
        {
            string dbPath = "FIlename=";
            const string dbFileName = "probeteam.sqlite";

            switch (devicePlatform)
            {
                case "UWP":
                    dbPath += Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbFileName);
                    break;
                case "iOS":
                    dbPath += Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", "data", dbFileName);
                    break;
                case "Android":
                    dbPath += Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), dbFileName);
                    break;
            }

            db = new ProbeTeamContext(dbPath);
        }
    }
}
