using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Models;
using DigitalDMScreenApp.Services;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Pages
{
    public partial class NPCDetail
    {
        [Inject]
        public INPCDataService? NPCDataService { get; set; }

        [Parameter]
        public string Id { get; set; }

        public NonPlayerCharacter? NPC { get; set; } = new NonPlayerCharacter();

        protected async override Task OnInitializedAsync()
        {
            NPC = await NPCDataService.GetNPCDetails(int.Parse(Id));
        }
    }
}
