using ProbeTeam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Domain.Interfaces.Services
{
    public interface INotepadService
    {
        Notepad AddNotepad(Notepad notepad);
        IEnumerable<Notepad> GetAllNotepads();
        void UpdateNotepad(Notepad notepad);
        void DeleteNotepad(Guid notepadId);
    }
}
