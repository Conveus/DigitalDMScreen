using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Services;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Pages
{
    public partial class PCEdit
    {
        [Inject]
        public IPCDataService? PCDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string? Id { get; set; }
        public PlayerCharacter PC { get; set; } = new PlayerCharacter();

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        protected override async Task OnInitializedAsync()
        {
            Saved = false;
            PC = await PCDataService.GetPCDetails(int.Parse(Id));
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;

            if(PC.Id ==0) // Handling new PC
            {
                var addedPC = await PCDataService.AddPC(PC);
                if(addedPC != null)
                {
                    StatusClass = "alert-success";
                    Message = "New PC added successfully";
                    Saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something went wrong ading the new PC. Please try again";
                    Saved = false;
                }
            }
            else // Handling existing PC
            {
                await PCDataService.UpdatePC(PC);
                StatusClass = "alert-success";
                Message = "PC updated successfully";
                Saved = true;
            }
        }

        protected async Task HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again";
        }

        protected async Task DeletePC()
        {
            await PCDataService.DeletePC(PC.Id);

            StatusClass = "alert-success";
            Message = "Deleted successfully";
            Saved = true;
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/pcoverview");
        }
    }
}
