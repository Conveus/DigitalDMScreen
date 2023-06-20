using DigitalDMScreen.Shared.Domain;

namespace DigitalDMScreen.Api.Models
{
    public class NoteRepository
    {
        private readonly AppDbContext _appDbContext;
        private Random random = new Random();

        public NoteRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Note> GetAllNotes()
        {
            return _appDbContext.Notes;
        }

        public Note GetNoteById(int Id)
        {
            return _appDbContext.Notes.FirstOrDefault(c => c.Id == Id);
        }

        public Note AddNote(Note note)
        {
            var addedEntity = _appDbContext.Notes.Add(note);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public Note UpdateNote(Note note)
        {
            var foundNote = _appDbContext.Notes.FirstOrDefault(e => e.Id == note.Id);

            if (foundNote != null)
            {
                foundNote.Name = note.Name;
                foundNote.Notes = note.Notes;

                _appDbContext.SaveChanges();

                return foundNote;
            }

            return null;
        }

        public void DeleteNote(int Id)
        {
            var foundNote = _appDbContext.Notes.FirstOrDefault(e => e.Id == Id);
            if (foundNote == null) return;

            _appDbContext.Notes.Remove(foundNote);
            _appDbContext.SaveChanges();
        }
    }
}
