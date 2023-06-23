using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Models;
using DigitalDMScreenApp.Services;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Pages
{
    public partial class NoteOverview
    {
        [Inject]
        public INoteDataService? NoteDataService { get; set; }

        public List<Note>? Notes { get; set; } = default!;

        private Note? _selectedNote;

        // Gets all notes and saves it to list variable 
        protected override async Task OnInitializedAsync()
        {
            Notes = (await NoteDataService.GetAllNotes()).ToList();
        }

        // Function for quick view button, sets _selectedNote to the player character stored in the buttons NoteCard
        // This passes it into the quickviews parameter
        public void ShowNoteQuickView(Note selectedNote)
        {
            _selectedNote = selectedNote;
        }
    }
}