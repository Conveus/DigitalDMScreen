using DigitalDMScreen.Api.Models;
using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DigitalDMScreen.Api.Controllers
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

        [HttpGet]
        public IActionResult GetAllNotes()
        {
            return Ok(_noteRepository.GetAllNotes());
        }

        [HttpGet("{id}")]
        public IActionResult GetNoteById(int id)
        {
            return Ok(_noteRepository.GetNoteById(id));
        }

        [HttpPost]
        public IActionResult CreateNote([FromBody] Note note)
        {
            if (note == null)
                return BadRequest();

            if (note.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdNote = _noteRepository.AddNote(note);

            return Created("note", createdNote);
        }

        [HttpPut]
        public IActionResult UpdateNote([FromBody] Note note)
        {
            if (note == null)
                return BadRequest();

            if (note.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var noteToUpdate = _noteRepository.GetNoteById(note.Id);

            if (noteToUpdate == null)
                return NotFound();

            _noteRepository.UpdateNote(note);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNote(int id)
        {
            if (id == 0)
                return BadRequest();

            var noteToDelete = _noteRepository.GetNoteById(id);
            if (noteToDelete == null)
                return NotFound();

            _noteRepository.DeleteNote(id);

            return NoContent();//success
        }
    }
}
