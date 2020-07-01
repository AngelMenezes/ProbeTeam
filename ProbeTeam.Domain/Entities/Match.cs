using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Domain.Entities
{
    public class Match : EntityBase<Guid>
    {
        public String BossTeam { get; set; }
        public String VisitingTeam { get; set; }
    }
}
