using DigitalDMScreen.Shared.Domain;

namespace DigitalDMScreen.Api.Models
{
    public interface INoteRepository
    {
        IEnumerable<Note> GetAllNotes();
        Note GetNoteById(int Id);
        Note AddNote(Note note);
        Note UpdateNote(Note note);
        void DeleteNote(int Id);
    }
}
