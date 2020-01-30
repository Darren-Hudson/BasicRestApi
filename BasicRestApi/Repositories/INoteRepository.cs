using System;
using System.Collections.Generic;
using BasicRestApi.Database;
using BasicRestApi.Models;

namespace BasicRestApi.Repositories
{
    public interface INoteRepository
    {
        Note FindNoteById(long Id);

        IEnumerable<Note> GetAllNotes();

        void SaveNote(Note note);

        void EditNote(Note note);

        void DeleteNote(Note NoteModel);
    }
}
