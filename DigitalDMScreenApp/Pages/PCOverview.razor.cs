using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Models;

namespace DigitalDMScreenApp.Pages
{
    public partial class PCOverview
    {
        public List<PlayerCharacter> PCs { get; set; } = default!;

        private PlayerCharacter? _selectedPC;

        // Gets all notes and saves it to list variable 
        protected override void OnInitialized()
        {
            PCs = MockDataService.PCs;
        }

        // Function for quick view button, sets _selectedPC to the player character stored in the buttons PCCard
        // This passes it into the quickviews parameter
        public void ShowPCQuickView(PlayerCharacter selectedPC)
        {
            _selectedPC = selectedPC;
        }
    }
}
