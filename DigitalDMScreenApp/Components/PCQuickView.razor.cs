using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Components
{
    public partial class PCQuickView
    {
        [Parameter]
        public PlayerCharacter PC { get; set; } = default!;

        private PlayerCharacter? _pc;

        //Sets _pc to input parameter allowing quickview to be seen
        protected override void OnParametersSet()
        {
            _pc = PC;
        }

        // Sets the used player character to null thus closing the popup
        public void Close () { _pc = null; }
    }
}
