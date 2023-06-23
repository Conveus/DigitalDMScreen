using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Components
{
    public partial class LocationScreenCard
    {
        [Parameter]
        public Location Location { get; set; } = default!;

        [Parameter]
        public EventCallback<Location> LocationQuickViewClicked { get; set; }

        //[Inject]
        //public NavigationManager NavigationManager { get; set; } = default!;

        //public void NavigateToDetails(Location selectedLocation)
        //{
        //    NavigationManager.NavigateTo($"/locationdetail/{selectedLocation.Id}");
        //}
    }
}
