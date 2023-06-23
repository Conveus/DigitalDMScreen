using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Models;
using DigitalDMScreenApp.Services;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Pages
{
    public partial class PCOverview
    {
        [Inject]
        public IPCDataService? PCDataService { get; set; }

        public List<PlayerCharacter>? PCs { get; set; } = default!;

        private PlayerCharacter? _selectedPC;
		private PlayerCharacter? _selectedAddPC;

        // Gets all notes and saves it to list variable 
        protected override async Task OnInitializedAsync()
        {
            PCs = (await PCDataService.GetAllPCs()).ToList();
        }

        // Function for quick view button, sets _selectedPC to the player character stored in the buttons PCCard
        // This passes it into the quickviews parameter
        public void ShowPCQuickView(PlayerCharacter selectedPC)
        {
            _selectedPC = selectedPC;
        }
		
		public void ShowPCAddToScreen(PlayerCharacter selectedPC)
        {
            _selectedAddPC = selectedPC;
        }
    }
}
