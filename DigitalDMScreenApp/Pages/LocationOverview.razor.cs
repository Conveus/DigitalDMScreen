using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Models;
using DigitalDMScreenApp.Services;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Pages
{
    public partial class LocationOverview
    {
        [Inject]
        public ILocationDataService? LocationDataService { get; set; }

        public List<Location>? Locations { get; set; } = default!;

        private Location? _selectedLocation;
		private Location? _selectedAddLocation;

        // Gets all notes and saves it to list variable 
        protected override async Task OnInitializedAsync()
        {
            Locations = (await LocationDataService.GetAllLocations()).ToList();
        }

        // Function for quick view button, sets _selectedLocation to the player character stored in the buttons LocationCard
        // This passes it into the quickviews parameter
        public void ShowLocationQuickView(Location selectedLocation)
        {
            _selectedLocation = selectedLocation;
        }
		
		public void ShowLocationAddToScreen(Location selectedAddLocation)
        {
            _selectedAddLocation = selectedAddLocation;
        }
    }
}