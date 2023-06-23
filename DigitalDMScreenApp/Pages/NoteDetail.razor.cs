using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Models;
using DigitalDMScreenApp.Services;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Pages
{
    public partial class NoteDetail
    {
        [Inject]
        public INoteDataService? NoteDataService { get; set; }

        [Parameter]
        public string Id { get; set; }

        public Note? Note { get; set; } = new Note();

        protected async override Task OnInitializedAsync()
        {
            Note = await NoteDataService.GetNoteDetails(int.Parse(Id));
        }
    }
}
