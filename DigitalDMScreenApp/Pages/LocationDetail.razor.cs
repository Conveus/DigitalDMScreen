using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Models;
using DigitalDMScreenApp.Services;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Pages
{
    public partial class LocationDetail
    {
        [Inject]
        public ILocationDataService? LocationDataService { get; set; }

        [Parameter]
        public string Id { get; set; }

        public Location? Location { get; set; } = new Location();

        protected async override Task OnInitializedAsync()
        {
            Location = await LocationDataService.GetLocationDetails(int.Parse(Id));
        }
    }
}
