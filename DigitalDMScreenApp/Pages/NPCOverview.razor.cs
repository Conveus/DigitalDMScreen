using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Models;
using DigitalDMScreenApp.Services;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Pages
{
    public partial class NPCOverview
    {
        [Inject]
        public INPCDataService? NPCDataService { get; set; }

        public List<NonPlayerCharacter>? NPCs { get; set; } = default!;

        private NonPlayerCharacter? _selectedNPC;
        private NonPlayerCharacter? _selectedAddNPC;

        // Gets all notes and saves it to list variable 
        protected override async Task OnInitializedAsync()
        {
            NPCs = (await NPCDataService.GetAllNPCs()).ToList();
        }

        // Function for quick view button, sets _selectedNPC to the non-player character stored in the buttons NPCCard
        // This passes it into the quickviews parameter
        public void ShowNPCQuickView(NonPlayerCharacter selectedNPC)
        {
            _selectedNPC = selectedNPC;
        }

        public void ShowNPCAddToScreen(NonPlayerCharacter selectedNPC)
        {
            _selectedAddNPC = selectedNPC;
        }
    }
}