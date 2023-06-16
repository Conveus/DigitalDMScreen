using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Models;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Pages
{
    public partial class PCDetail
    {
        [Parameter]
        public string Id { get; set; }

        public PlayerCharacter? PC { get; set; } = new PlayerCharacter();

        protected override Task OnInitializedAsync()
        {
            PC = MockDataService.PCs.FirstOrDefault(e => e.Id == 
            int.Parse(Id));

            return base.OnInitializedAsync();
        }
    }
}
