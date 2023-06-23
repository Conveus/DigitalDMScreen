using DigitalDMScreen.Shared.Domain;

namespace DigitalDMScreenApp.Services
{
    public interface INoteDataService
    {
        Task<IEnumerable<Note>> GetAllNotes();
        Task<Note> GetNoteDetails(int Id);
        Task<Note> AddNote(Note note);
        Task UpdateNote(Note note);
        Task DeleteNote(int Id);
    }
}
