using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Domain.Entities
{
    public class Notepad : TEntity<Guid>
    {
        public String Guidelines { get; set; }
    }
}
