using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Components
{
    public partial class NPCAddToScreen
    {
        [Inject]
        public ScreenNotes? ScreenNotes { get; set; }

        [Parameter]
        public NonPlayerCharacter NPC { get; set; } = default!;

        private NonPlayerCharacter? _npcAdd;

        public int panel = 2;

        //Sets _pc to input parameter allowing quickview to be seen
        protected override void OnParametersSet()
        {
            _npcAdd = NPC;
        }

        public void AddtoScreen()
        {
            if (panel == 1)
            {
                ScreenNotes.P1UsedNPCs.Add(_npcAdd);
            }
            else if (panel == 2)
            {
                ScreenNotes.P2UsedNPCs.Add(_npcAdd);
            }
            else
            {
                ScreenNotes.P3UsedNPCs.Add(_npcAdd);
            }
        }

        // Sets the used player character to null thus closing the popup
        public void Close () { _npcAdd = null; }
    }
}
