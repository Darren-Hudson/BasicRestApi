using System;
using System.Collections.Generic;
using BasicRestApi.Database;
using BasicRestApi.Models;

namespace BasicRestApi.Repositories.Implementations
{
    public class NoteRepository : INoteRepository
    {
        private BasicDbContext _Context;

        public NoteRepository(BasicDbContext context)
        {
            _Context = context;
        }

        public Note FindNoteById(long Id)
        {
            var note = _Context.Notes.Find(Id);
            return note;
        }

        public IEnumerable<Note> GetAllNotes()
        {
            var notes = _Context.Notes;
            return notes;
        }
        public void SaveNote(Note note)
        {
            _Context.Notes.Add(note);
            _Context.SaveChanges();
        }
        public void EditNote(Note note)
        {
            _Context.Notes.Update(note);
            _Context.SaveChanges();
        }
        public void DeleteNote(Note NoteModel)
        {
            _Context.Notes.Remove(NoteModel);
            _Context.SaveChanges();
        }
        
    }
}
