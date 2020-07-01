using ProbeTeam.Domain.Entities;
using ProbeTeam.Domain.Interfaces.Repositories;
using ProbeTeam.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProbeTeam.Domain.Services
{
    public class NotepadService : INotepadService
    {
        private readonly INotepadRepository repository;

        public NotepadService(INotepadRepository repository)
        {
            this.repository = repository;
        }

        public Notepad AddNotepad(Notepad notepad)
        {
            throw new NotImplementedException();
        }

        public void DeleteNotepad(Guid notepadId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Notepad> GetAllNotepads()
        {
            throw new NotImplementedException();
        }

        public void UpdateNotepad(Notepad notepad)
        {
            throw new NotImplementedException();
        }
    }
}
