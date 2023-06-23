using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Components
{
    public partial class NPCQuickView
    {
        [Parameter]
        public NonPlayerCharacter NPC { get; set; } = default!;

        private NonPlayerCharacter? _npc;

        //Sets _pc to input parameter allowing quickview to be seen
        protected override void OnParametersSet()
        {
            _npc = NPC;
        }

        // Sets the used player character to null thus closing the popup
        public void Close () { _npc = null; }
    }
}
