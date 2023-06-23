using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Components
{
    public partial class LocationAddToScreen
    {
        [Inject]
        public ScreenNotes? ScreenNotes { get; set; }

        [Parameter]
        public Location Location { get; set; } = default!;

        private Location? _locationAdd;

        public int panel = 2;

        //Sets _pc to input parameter allowing quickview to be seen
        protected override void OnParametersSet()
        {
            _locationAdd = Location;
        }

        public void AddtoScreen()
        {
            if (panel == 1)
            {
                ScreenNotes.P1UsedLocations.Add(_locationAdd);
            }
            else if (panel == 2)
            {
                ScreenNotes.P2UsedLocations.Add(_locationAdd);
            }
            else
            {
                ScreenNotes.P3UsedLocations.Add(_locationAdd);
            }
        }

        // Sets the used player character to null thus closing the popup
        public void Close () { _locationAdd = null; }
    }
}
