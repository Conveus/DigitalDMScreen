using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Components
{
    public partial class LocationQuickView
    {
        [Parameter]
        public Location Location { get; set; } = default!;

        private Location? _location;

        //Sets _pc to input parameter allowing quickview to be seen
        protected override void OnParametersSet()
        {
            _location = Location;
        }

        // Sets the used player character to null thus closing the popup
        public void Close () { _location = null; }
    }
}
