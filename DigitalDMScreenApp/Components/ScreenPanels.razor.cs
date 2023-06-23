using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Components
{
    public partial class ScreenPanels
    {

        [Inject]
        public ScreenNotes? ScreenNotes { get; set; }

        private NonPlayerCharacter? _selectedNPC;
        private PlayerCharacter? _selectedPC;
        private Monster? _selectedMonster;
        private Location? _selectedLocation;
        private Note? _selectedNote;

        public void ShowNPCQuickView(NonPlayerCharacter selectedNPC)
        {
            _selectedNPC = selectedNPC;
        }

        public void ShowPCQuickView(PlayerCharacter selectedPC)
        {
            _selectedPC = selectedPC;
        }

        public void ShowMonsterQuickView(Monster selectedMonster)
        {
            _selectedMonster = selectedMonster;
        }

        public void ShowLocationQuickView(Location selectedLocation)
        {
            _selectedLocation = selectedLocation;
        }

        public void ShowNoteQuickView(Note selectedNote)
        {
            _selectedNote = selectedNote;
        }

        // Represents which panel is on screen
        private int ActivePanel = 2;

        // Increases active panel number
        private void Increment()
        {
            ActivePanel++;
        }

        // Decreases active panel number
        private void Decrement()
        {
            ActivePanel--;
        }
    }
}
