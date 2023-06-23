using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Components
{
    public partial class NoteCard
    {
        [Parameter]
        public Note Note { get; set; } = default!;

        [Parameter]
        public EventCallback<Note> NoteQuickViewClicked { get; set; }
		
		[Parameter]
        public EventCallback<Note> NoteAddToScreenClicked { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        public void NavigateToDetails(Note selectedNote)
        {
            NavigationManager.NavigateTo($"/notedetail/{selectedNote.Id}");
        }
    }
}
