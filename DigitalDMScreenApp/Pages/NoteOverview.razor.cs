using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Models;

namespace DigitalDMScreenApp.Pages
{
    public partial class NoteOverview
    {
        public List<Note> Notes { get; set; } = default!;

        // Gets all notes and saves it to list variable 
        protected override void OnInitialized()
        {
            Notes = MockDataService.Notes;
        }
    }
}
