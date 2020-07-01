using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Domain.Entities
{
    public class Scout : EntityBase<Guid>
    {
        public String TypeOfScout { get; set; }
        public String Locality { get; set; }
        public int QuantityInField { get; set; }
        public DateTime ScoutRegistrationDate { get; set; }
    }
}
