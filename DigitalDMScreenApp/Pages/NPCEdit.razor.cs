using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Services;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Pages
{
    public partial class NPCEdit
    {
        [Inject]
        public INPCDataService? NPCDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string? Id { get; set; }
        public NonPlayerCharacter? NPC { get; set; } = new NonPlayerCharacter();

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        protected override async Task OnInitializedAsync()
        {
            Saved = false;
            NPC = await NPCDataService.GetNPCDetails(int.Parse(Id));
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;

            if(NPC.Id ==0) // Handling new NPC
            {
                var addedNPC = await NPCDataService.AddNPC(NPC);
                if(addedNPC != null)
                {
                    StatusClass = "alert-success";
                    Message = "New NPC added successfully";
                    Saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something went wrong ading the new NPC. Please try again";
                    Saved = false;
                }
            }
            else // Handling existing NPC
            {
                await NPCDataService.UpdateNPC(NPC);
                StatusClass = "alert-success";
                Message = "NPC updated successfully";
                Saved = true;
            }
        }

        protected async Task HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again";
        }

        protected async Task DeleteNPC()
        {
            await NPCDataService.DeleteNPC(NPC.Id);

            StatusClass = "alert-success";
            Message = "Deleted successfully";
            Saved = true;
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/npcoverview");
        }
    }
}
