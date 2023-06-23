using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Services;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Pages
{
    public partial class NoteEdit
    {
        [Inject]
        public INoteDataService? NoteDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string? Id { get; set; }
        public Note? Note { get; set; } = new Note();

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        protected override async Task OnInitializedAsync()
        {
            Saved = false;
            Note = await NoteDataService.GetNoteDetails(int.Parse(Id));
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;

            if(Note.Id ==0) // Handling new Note
            {
                var addedNote = await NoteDataService.AddNote(Note);
                if(addedNote != null)
                {
                    StatusClass = "alert-success";
                    Message = "New Note added successfully";
                    Saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something went wrong ading the new Note. Please try again";
                    Saved = false;
                }
            }
            else // Handling existing Note
            {
                await NoteDataService.UpdateNote(Note);
                StatusClass = "alert-success";
                Message = "Note updated successfully";
                Saved = true;
            }
        }

        protected async Task HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again";
        }

        protected async Task DeleteNote()
        {
            await NoteDataService.DeleteNote(Note.Id);

            StatusClass = "alert-success";
            Message = "Deleted successfully";
            Saved = true;
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/noteoverview");
        }
    }
}
