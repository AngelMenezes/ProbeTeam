using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Domain.Entities
{
    public class Player : EntityBase<Guid>
    {
        public int ShirtNumber { get; set; }
        public String Nickname { get; set; }
        public String Name { get; set; }
        public String Cpf { get; set; }
        public String IDNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public enum Card
    {
        Yellow,
        Red
    }
}
