using DigitalDMScreen.Shared.Domain;
using DigitalDMScreenApp.Models;
using DigitalDMScreenApp.Services;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Pages
{
    public partial class MonsterOverview
    {
        [Inject]
        public IMonsterDataService? MonsterDataService { get; set; }

        public List<Monster>? Monsters { get; set; } = default!;

        private Monster? _selectedMonster;

        // Gets all notes and saves it to list variable 
        protected override async Task OnInitializedAsync()
        {
            Monsters = (await MonsterDataService.GetAllMonsters()).ToList();
        }

        // Function for quick view button, sets _selectedMonster to the player character stored in the buttons MonsterCard
        // This passes it into the quickviews parameter
        public void ShowMonsterQuickView(Monster selectedMonster)
        {
            _selectedMonster = selectedMonster;
        }
    }
}