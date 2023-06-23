using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace DigitalDMScreenApp.Components
{
    public partial class MonsterQuickView
    {
        [Parameter]
        public Monster Monster { get; set; } = default!;

        private Monster? _monster;

        //Sets _pc to input parameter allowing quickview to be seen
        protected override void OnParametersSet()
        {
            _monster = Monster;
        }

        // Sets the used player character to null thus closing the popup
        public void Close () { _monster = null; }
    }
}
