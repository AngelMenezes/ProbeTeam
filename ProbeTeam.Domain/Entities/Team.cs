using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Domain.Entities
{
    public class Team : EntityBase<Guid>
    {
        public String Name { get; set; }
        public String Manager { get; set; }
        public String Coach { get; set; }
        public String Contact { get; set; }
        public String Shield { get; set; }
    }
}
