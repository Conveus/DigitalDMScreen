using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Models;
using DigitalDMScreenApp.Services;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Pages
{
    public partial class PCDetail
    {
        [Inject]
        public IPCDataService? PCDataService { get; set; }

        [Parameter]
        public string Id { get; set; }

        public PlayerCharacter? PC { get; set; } = new PlayerCharacter();

        protected async override Task OnInitializedAsync()
        {
            PC = await PCDataService.GetPCDetails(int.Parse(Id));
        }
    }
}
