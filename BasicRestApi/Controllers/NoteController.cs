using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicRestApi.Models;
using BasicRestApi.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class NoteController : Controller
    {
        private readonly INoteRepository _noteRepository;

        public NoteController(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<Note> GetNote(int id)
        {
            var note = _noteRepository.FindNoteById(id);
            return note;
        }

        // GET: api/values
        [HttpGet]
        public ActionResult <IEnumerable<Note>> GetNotes()
        {
            var AllNotes = _noteRepository.GetAllNotes().ToList();
            return AllNotes;
        }

        // GET api/values/5
        

        // POST api/values
        [HttpPost]
        public ActionResult<Note>PostNote(Note note)
        {
            var currentDate = DateTime.Now;
            note.CreatedDate = currentDate;
            note.LastModified = currentDate;
            _noteRepository.SaveNote(note);
            return note;
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult<Note> PutNote(Note note)
        {
            note.LastModified = DateTime.Now;
            _noteRepository.EditNote(note);
            return note;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<Note> Delete(long id)
        {
            var note = _noteRepository.FindNoteById(id);
            _noteRepository.DeleteNote(note);
            return note;
        }
    }
}
