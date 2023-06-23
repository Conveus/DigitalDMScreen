using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Services;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Pages
{
    public partial class LocationEdit
    {
        [Inject]
        public ILocationDataService? LocationDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string? Id { get; set; }
        public Location? Location { get; set; } = new Location();

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        protected override async Task OnInitializedAsync()
        {
            Saved = false;
            Location = await LocationDataService.GetLocationDetails(int.Parse(Id));
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;

            if(Location.Id ==0) // Handling new Location
            {
                var addedLocation = await LocationDataService.AddLocation(Location);
                if(addedLocation != null)
                {
                    StatusClass = "alert-success";
                    Message = "New Location added successfully";
                    Saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something went wrong ading the new Location. Please try again";
                    Saved = false;
                }
            }
            else // Handling existing Location
            {
                await LocationDataService.UpdateLocation(Location);
                StatusClass = "alert-success";
                Message = "Location updated successfully";
                Saved = true;
            }
        }

        protected async Task HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again";
        }

        protected async Task DeleteLocation()
        {
            await LocationDataService.DeleteLocation(Location.Id);

            StatusClass = "alert-success";
            Message = "Deleted successfully";
            Saved = true;
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/locationoverview");
        }
    }
}
