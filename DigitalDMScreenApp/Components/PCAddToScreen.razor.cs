using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Components
{
    public partial class PCAddToScreen
    {
        [Inject]
        public ScreenNotes? ScreenNotes { get; set; }

        [Parameter]
        public PlayerCharacter PC { get; set; } = default!;

        private PlayerCharacter? _pcAdd;

        public int panel = 2;

        //Sets _pc to input parameter allowing quickview to be seen
        protected override void OnParametersSet()
        {
            _pcAdd = PC;
        }

        public void AddtoScreen()
        {
            if (panel == 1)
            {
                ScreenNotes.P1UsedPCs.Add(_pcAdd);
            }
            else if (panel == 2)
            {
                ScreenNotes.P2UsedPCs.Add(_pcAdd);
            }
            else
            {
                ScreenNotes.P3UsedPCs.Add(_pcAdd);
            }
        }

        // Sets the used player character to null thus closing the popup
        public void Close () { _pcAdd = null; }
    }
}
